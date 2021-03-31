using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using MP2.Models;
using System.Text.RegularExpressions;
using Attribute = MP2.Models.Attribute;
using static MP2.Models.InputManager;

namespace MP2
{
    public partial class Form1 : Form
    {
        private const string TRAIN_SET_DEFAULT_PATH = @"D:\Soft\VisualStudio\Projects\NAI\MP2\Data\irisTrain.csv";
        private const string TEST_SET_DEFAULT_PATH = @"D:\Soft\VisualStudio\Projects\NAI\MP2\Data\irisTest.csv";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private enum AppStates
        {
            None,
            Menu,
            Settings
        }

        struct TrainingSpecifications
        {
            public string[] inputAttributes;
            public string outputAttribute;
            public float learningRate;
            public uint epoch;
            public float threshold;
            public float maxError;
        }

        private readonly Color _bttnPressedColor;
        private readonly Color _bttnDefaultColor;

        private string[] _headers_double;
        private string[] _headers_string;

        private string _trainSetPath;
        private string _testSetPath;
        private string _outputSetPath;

        private Perceptron _perceptron;
        private List<string> _checkedInputAttributes = new List<string>(); //coz listBox.checkedItems is bugged 


        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            _bttnPressedColor = ColorsConfig.ButtonPressed;
            _bttnDefaultColor = ColorsConfig.ButtonDefault;
            SwitchPage(AppStates.Menu);

            #region BindingToEvents

            EpochTrackBar.ValueChanged += EpochTrackBar_ValueChanged;
            LearningRateTrackBar.ValueChanged += LearningRateTrackBar_ValueChanged;
            ThresholdTrackBar.ValueChanged += ThresholdTrackBar_ValueChanged;
            MaxErrorTrackBar.ValueChanged += MaxErrorTrackBar_ValueChanged;

            TrainSetPathText.TextChanged += TrainSetPathText_TextChanged;
            TestSetPathText.TextChanged += TestSetPathText_TextChanged;
            OutputSetPathText.TextChanged += OutputSetPathText_TextChanged;
            ConditionTextBox.TextChanged += ConditionTextBox_TextChanged;
            TrainDataTextBox.TextChanged += TrainDataTextBox_TextChanged;
            TestDataTextBox.TextChanged += TestDataTextBox_TextChanged;

            AttributesListBox.ItemCheck += AttributesListBox_ItemCheck;

            OutputAttributeComboBox.SelectedValueChanged += OutputAttributeComboBox_SelectedValueChanged;
            OperatorChooserComboBox.SelectedValueChanged += OperatorChooserComboBox_SelectedValueChanged;

            #endregion

            InitializeDefaultValues();  
        }


        #region Events

        #region ItemChecked

        private void AttributesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var attributeName = AttributesListBox.Items[e.Index].ToString();
            var ifExists = _checkedInputAttributes.Exists(a => a == attributeName);

            if(e.NewValue == CheckState.Checked && !ifExists) _checkedInputAttributes.Add(attributeName);
            else if(e.NewValue == CheckState.Unchecked && ifExists) _checkedInputAttributes.Remove(attributeName);

            _checkedInputAttributes = _checkedInputAttributes.Distinct().ToList();
            
            var item = ((CheckedListBox)sender).Items[e.Index].ToString();
            if (e.NewValue == CheckState.Checked)
            {
                OutputAttributeComboBox.Items.Remove(item);
            }
            else
            {
                if (!OutputAttributeComboBox.Items.Contains(item))
                    OutputAttributeComboBox.Items.Add(item);
            }

            var status = OutputAttributeComboBox.SelectedItem != null;
            ConditionPanel.Visible = status;
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        #endregion

        #region TextChanged

        private void TestDataTextBox_TextChanged(object sender, EventArgs e)
        {
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        private void TrainDataTextBox_TextChanged(object sender, EventArgs e)
        {
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        private void ConditionTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateCondition();
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        private void TestSetPathText_TextChanged(object sender, EventArgs e)
        {
            _testSetPath = ((TextBox)sender).Text;
        }

        private void TrainSetPathText_TextChanged(object sender, EventArgs e)
        {
            _trainSetPath = ((TextBox)sender).Text;
        }

        private void OutputSetPathText_TextChanged(object sender, EventArgs e)
        {
            _outputSetPath = ((TextBox)sender).Text;
        }
        #endregion

        #region ValueChanged

        private void OperatorChooserComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateCondition();
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        private void OutputAttributeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = ((ComboBox)sender).SelectedItem;
            var status = item != null;
            if (status) ValidateCondition();
            ConditionPanel.Visible = status;

            LoadOperators(GetAttributeDataType(item.ToString()));
            TrainingButtonsPanel.Enabled = ValidateInput();
        }

        private void MaxErrorTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MaxErrorBox.Text = (((TrackBar)sender).Value * 0.05).ToString();
        }

        private void ThresholdTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ThresholdBox.Text = (((TrackBar)sender).Value * 0.05).ToString();
        }

        private void LearningRateTrackBar_ValueChanged(object sender, EventArgs e)
        {
            LearningRateBox.Text = (((TrackBar)sender).Value * 0.05).ToString();
        }

        private void EpochTrackBar_ValueChanged(object sender, EventArgs e)
        {
            EpochCountBox.Text = (((TrackBar)sender).Value * 5).ToString();
        }
        #endregion

        #endregion

        #region Button Clicks
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if(TrainSetPathText!=null && TestSetPathText != null)
            {
                LoadMenuPage();
            }
            SwitchPage(AppStates.Menu);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SwitchPage(AppStates.Settings);
        }

        private void BeginNewTrainingBtn_Click(object sender, EventArgs e)
        {
            StartTraining(useNewPerceptron:true);
        }

        private void ContinueTrainingBtn_Click(object sender, EventArgs e)
        {
            StartTraining(useNewPerceptron: false);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Select File Pathes

        private void SelectTrainSetPath_Click(object sender, EventArgs e)
        {
            TrainSetPathText.Text = PickFile();
        }

        private void SelectTestSetPath_Click(object sender, EventArgs e)
        {
            TestSetPathText.Text = PickFile();
        }

        private void SelectOutputSetPath_Click(object sender, EventArgs e)
        {
            OutputSetPathText.Text = PickFile();
        }

        private string PickFile()
        {
            var dialog = new CommonOpenFileDialog();
            var filterCSV = new CommonFileDialogFilter("CSV", "*.csv");
            var filterTXT = new CommonFileDialogFilter("TXT", "*.txt");
            dialog.Filters.Add(filterCSV);
            dialog.Filters.Add(filterTXT);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }

        #endregion

        #region Load Boxes

        private void LoadInputAttributes(params string[] @params)
        {
            AttributesListBox.Items.Clear();
            foreach (var field in @params)
            {
                AttributesListBox.Items.Add(field, false);
            }
        }
        private void LoadOutputAttribute(params string[] @params)
        {
            OutputAttributeComboBox.Items.Clear();
            foreach(var item in @params)
            {
                OutputAttributeComboBox.Items.Add(item);
            }
        }
        private void LoadOperators(InputManager.DataType dataType)
        {
            ConditionTextBox.Text = "";
            OperatorChooserComboBox.Items.Clear();
            OperatorChooserComboBox.Items.Add("==");
            OperatorChooserComboBox.Items.Add("!=");

            if(dataType == InputManager.DataType.DOUBLE)
            {
                OperatorChooserComboBox.Items.Add(">");
                OperatorChooserComboBox.Items.Add("<");
            }
        }

        #endregion

        #region Validation

        private bool ValidateInput()
        {
            if (OperatorChooserComboBox.SelectedItem is null) return false;
            if (OutputAttributeComboBox.SelectedItem is null) return false;
            if (ConditionTextBox.Text == string.Empty) return false;
            if (TrainDataTextBox.Text == string.Empty) return false;
            if (TestDataTextBox.Text == string.Empty) return false;
            if (_checkedInputAttributes.Count == 0) return false;
            if (InvalidConditionLabel.Visible == true) return false;
            return true;
        }

        private void ValidateCondition()
        {
            var doubleRegex = @"^\d*\.{0,1}\d+$";
            var stringRegex = @"^.+$";
            Regex regex = new Regex(doubleRegex);

            if (GetAttributeDataType(OutputAttributeComboBox.SelectedItem.ToString()) == DataType.STRING)
            {
                if (regex.IsMatch(ConditionTextBox.Text))
                {
                    InvalidConditionLabel.Visible = true;
                    return;
                }
                else regex = new Regex(stringRegex);
            }
            
            if(!regex.IsMatch(ConditionTextBox.Text) || OperatorChooserComboBox.SelectedItem is null)
            {
                InvalidConditionLabel.Visible = true;
            }
            else
            {
                InvalidConditionLabel.Visible = false;
            }
        }

        #endregion

        #region Utility

        private void InitializeDefaultValues()
        {
            EpochCountBox.Text = (EpochTrackBar.Value * 5).ToString();
            LearningRateBox.Text = (LearningRateTrackBar.Value * 0.05).ToString();
            ThresholdBox.Text = (ThresholdTrackBar.Value * 0.05).ToString();
            MaxErrorBox.Text = (MaxErrorTrackBar.Value * 0.05).ToString();

            TrainSetPathText.Text = TRAIN_SET_DEFAULT_PATH;
            TestSetPathText.Text = TEST_SET_DEFAULT_PATH;

            _trainSetPath = TrainSetPathText.Text;
            _testSetPath = TestSetPathText.Text;
        }
        private void SetData(TextBox textBox, string filePath)
        {
            textBox.Text = MainController.ReadData(filePath);
        }
        private void SetTrainingResults(int correctCount, int incorrectCount, float accuracy, string summary)
        {
            correctCountLabel.Text = $"Correct: {correctCount}";
            IncorrectCountLabel.Text = $"Incorrect: {incorrectCount}";
            AccuracyLabel.Text = $"Accuracy: {accuracy}%";
            ChangeAccuracyColor(accuracy);
            ResultTextBox.Text = summary;
            ContinueTrainingBtn.Visible = true;
        }
        private void ChangeAccuracyColor(float? value)
        {
            Color labelColor = Color.Black;
            if (value is null) labelColor = Color.Black;
            else if (value < 35) labelColor = Color.Red;
            else if (value >= 35 && value < 65) labelColor = Color.Yellow;
            else if (value >= 65) labelColor = Color.Green;

            AccuracyLabel.ForeColor = labelColor;
        }
        private void DefaultPage()
        {
            correctCountLabel.Text = "Correct: ";
            IncorrectCountLabel.Text = "Incorrect: ";
            AccuracyLabel.Text = "Accuracy: ";
            ChangeAccuracyColor(null);
            ContinueTrainingBtn.Visible = false;
            ConditionPanel.Visible = false;
            ResultTextBox.Text = "";
        }

        #endregion

        private void SwitchPage(AppStates state)
        {
            switch (state)
            {
                case AppStates.None:
                    MenuBtn.BackColor = _bttnDefaultColor;
                    SettingsBtn.BackColor = _bttnDefaultColor;
                    SettingsPanel.Visible = false;
                    MenuPanel.Visible = false;
                    break;
                case AppStates.Menu:
                    MenuBtn.BackColor = _bttnPressedColor;
                    SettingsBtn.BackColor = _bttnDefaultColor;
                    MenuPanel.Visible = true;
                    SettingsPanel.Visible = false;
                    break;
                case AppStates.Settings:
                    MenuBtn.BackColor = _bttnDefaultColor;
                    SettingsBtn.BackColor = _bttnPressedColor;
                    SettingsPanel.Visible = true;
                    MenuPanel.Visible = false;
                    break;
            }
        }
        private DataType GetAttributeDataType(string attribute)
        {
            if(_headers_double is null || _headers_string is null)
            {
                _headers_double = InputManager.GetHeaders(InputManager.DataSet.TRAIN, DataType.DOUBLE);
                _headers_string = InputManager.GetHeaders(InputManager.DataSet.TRAIN, DataType.STRING);
            }

            if (_headers_double.Contains(attribute)) return DataType.DOUBLE;
            else if (_headers_string.Contains(attribute)) return DataType.STRING;
            throw new ArgumentException("Invalid attribute");
        }
        private void LoadMenuPage()
        {
            TrainingButtonsPanel.Enabled = false;
            if (_trainSetPath is null || _testSetPath is null) throw new NullReferenceException("Provide valid file pathes");

                DefaultPage();
                LoadDatabaseFromFile();

                var trainHeaders_double = InputManager.GetHeaders(InputManager.DataSet.TRAIN, InputManager.DataType.DOUBLE);
                var testHeaders = InputManager.GetHeaders(InputManager.DataSet.TEST, InputManager.DataType.DOUBLE);

                if (!trainHeaders_double.SequenceEqual(testHeaders)) throw new ArgumentException("Train & test sets correspond to different objects");

                SetData(TrainDataTextBox, _trainSetPath);
                
                SetData(TestDataTextBox, _testSetPath);
                LoadInputAttributes(trainHeaders_double);
                
                var trainHeaders_string = InputManager.GetHeaders(InputManager.DataSet.TRAIN, InputManager.DataType.STRING);
                
                _headers_double = trainHeaders_double;
                _headers_string = trainHeaders_string;

                LoadOutputAttribute(trainHeaders_string.Concat(trainHeaders_double).ToArray());
        }
        private void ReadTrainingSpecs(out TrainingSpecifications trainSpecs)
        {
            trainSpecs = new TrainingSpecifications
            {
                inputAttributes = _checkedInputAttributes.ToArray(),
                outputAttribute = OutputAttributeComboBox.Text,
                learningRate = float.Parse(LearningRateBox.Text),
                epoch = uint.Parse(EpochCountBox.Text),
                threshold = float.Parse(ThresholdBox.Text),
                maxError = float.Parse(MaxErrorBox.Text)
            };
        }
        private TrainingParameters GetTrainingParameters(TrainingSpecifications specs, Perceptron perceptron)
        {
            var predicate = MainController.CreatePredicate(OperatorChooserComboBox.SelectedItem.ToString(), ConditionTextBox.Text);
            var dataType = GetAttributeDataType(specs.outputAttribute);

            return new TrainingParameters
            {
                OutputAttribute = specs.outputAttribute,
                InputAttributes = specs.inputAttributes,
                LearningRate = specs.learningRate,
                Epoch = specs.epoch,
                @Perceptron = perceptron,
                @Predicate = predicate,
                @DataSet = InputManager.DataSet.TRAIN,
                OutputDataType = dataType
            };
        }
        private void LoadDatabaseFromFile()
        {
            if (_outputSetPath != null) MainController.ReadDataFromFile(_outputSetPath, InputManager.DataSet.OUTPUT);
            if (_testSetPath != null) MainController.ReadDataFromFile(_testSetPath, InputManager.DataSet.TEST);
            if (_trainSetPath != null) MainController.ReadDataFromFile(_trainSetPath, InputManager.DataSet.TRAIN);
        }

        private void LoadDatabaseFromTextBox()
        {
            if (_testSetPath != null) MainController.ReadDataFromTextBox(TestDataTextBox.Text, _testSetPath, InputManager.DataSet.TEST);
            if (_trainSetPath != null) MainController.ReadDataFromTextBox(TrainDataTextBox.Text, _trainSetPath, InputManager.DataSet.TRAIN);
        }


        private void StartTraining(bool useNewPerceptron = true)
        {
            LoadDatabaseFromTextBox();
            ReadTrainingSpecs(out TrainingSpecifications specs);
            if (useNewPerceptron || _perceptron is null)
            {
                _perceptron = new Perceptron();
            }
            _perceptron.Threshold = specs.threshold;

            var trainParams = GetTrainingParameters(specs, _perceptron);

            
            MainController.TrainSession(trainParams);
            trainParams.DataSet = InputManager.DataSet.TEST;

            MainController.TestSession(trainParams, out int correctCount, out int incorrectCount, out float accuracy, out string summary);

            SetTrainingResults(correctCount, incorrectCount, accuracy, summary);
        }
    }
}
