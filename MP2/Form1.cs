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

        struct TrainSpecs
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

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            _bttnPressedColor = ColorsConfig.ButtonPressed;
            _bttnDefaultColor = ColorsConfig.ButtonDefault;
            SwitchPage(AppStates.Menu);

            //events
            EpochTrackBar.ValueChanged += EpochTrackBar_ValueChanged;
            LearningRateTrackBar.ValueChanged += LearningRateTrackBar_ValueChanged;
            ThresholdTrackBar.ValueChanged += ThresholdTrackBar_ValueChanged;
            MaxErrorTrackBar.ValueChanged += MaxErrorTrackBar_ValueChanged;

            TrainSetPathText.TextChanged += TrainSetPathText_TextChanged;
            TestSetPathText.TextChanged += TestSetPathText_TextChanged;
            OutputSetPathText.TextChanged += OutputSetPathText_TextChanged;
            ConditionTextBox.TextChanged += ConditionTextBox_TextChanged;

            AttributesListBox.ItemCheck += AttributesListBox_ItemCheck;

            OutputAttributeComboBox.SelectedValueChanged += OutputAttributeComboBox_SelectedValueChanged;
            OperatorChooserComboBox.SelectedValueChanged += OperatorChooserComboBox_SelectedValueChanged;

            InitializeFields();  
        }

        private void OperatorChooserComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ValidateCondition();
        }

        private void ConditionTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateCondition();
        }

        #region Events

        private void AttributesListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
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
        }

        private void OutputAttributeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = ((ComboBox)sender).SelectedItem;
            var status = item != null;
            if (status) ValidateCondition();
            ConditionPanel.Visible = status;
            if(_headers_string != null && _headers_double != null)
            {
                if (_headers_double.Contains(item.ToString()))
                {
                    SetOperatorsList(InputManager.DataType.DOUBLE);
                }
                else if (_headers_string.Contains(item.ToString()))
                {
                    SetOperatorsList(InputManager.DataType.STRING);
                }
            }
        }

        #region TextBox_TextChanged

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

        #region TrackBar_ValueChanged

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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //TestDataTextBox.Text = "";
            PushSession();
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
            var filter = new CommonFileDialogFilter("CSV", "*.csv");
            dialog.Filters.Add(filter);
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }
        #endregion

        private void InitializeFields()
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

        private void SetAttributes(params string[] @params)
        {
            AttributesListBox.Items.Clear();
            foreach (var field in @params)
            {
                AttributesListBox.Items.Add(field, false);
            }
        }

        private void InitComboBox(params string[] @params)
        {
            OutputAttributeComboBox.Items.Clear();
            foreach(var item in @params)
            {
                OutputAttributeComboBox.Items.Add(item);
            }
        }

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

        private void SetOperatorsList(InputManager.DataType dataType)
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

        private void ValidateCondition()
        {
            var doubleRegex = @"^\d*\.{0,1}\d+$";
            var stringRegex = @"^.+$";
            Regex regex;
            
            if (_headers_double.Contains(OutputAttributeComboBox.SelectedItem.ToString()))
            {
                regex = new Regex(doubleRegex);
            }
            else if (_headers_string.Contains(OutputAttributeComboBox.SelectedItem.ToString()))
            {
                regex = new Regex(stringRegex);
            }
            else
            {
                throw new Exception("Reload data");
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

        

        private bool test()
        {
            double d1 = 2.0;
            Predicate<dynamic> predicate = o1 => o1 == 2;
            return predicate.Invoke(d1);
        }

        private void LoadMenuPage()
        {
            if (_trainSetPath != null || _testSetPath != null)
            {
                ResultTextBox.Text = test().ToString();
                ConditionPanel.Visible = false;
                RefreshDatabase();

                var trainHeaders_double = InputManager.GetHeaders(InputManager.DataSet.TRAIN, InputManager.DataType.DOUBLE);
                var testHeaders = InputManager.GetHeaders(InputManager.DataSet.TEST, InputManager.DataType.DOUBLE);

                if (!trainHeaders_double.SequenceEqual(testHeaders)) throw new ArgumentException("Train & test sets correspond to different objects");

                SetData(TrainDataTextBox, _trainSetPath);
                
                SetData(TestDataTextBox, _testSetPath);
                SetAttributes(trainHeaders_double);
                
                var trainHeaders_string = InputManager.GetHeaders(InputManager.DataSet.TRAIN, InputManager.DataType.STRING);
                
                _headers_double = trainHeaders_double;
                _headers_string = trainHeaders_string;

                InitComboBox(trainHeaders_string.Concat(trainHeaders_double).ToArray());
            }
        }

        private void RefreshDatabase()
        {
            if (_outputSetPath != null) MainController.LoadDataToDatabase(_outputSetPath, InputManager.DataSet.OUTPUT);
            if (_testSetPath != null) MainController.LoadDataToDatabase(_testSetPath, InputManager.DataSet.TEST);
            if (_trainSetPath != null) MainController.LoadDataToDatabase(_trainSetPath, InputManager.DataSet.TRAIN);
        }

        private void SetData(TextBox textBox, string filePath)
        {
            textBox.Text = MainController.ReadData(filePath);
        }

        private void ReadTrainSpecs(out TrainSpecs trainSpecs)
        {
            trainSpecs = new TrainSpecs
            {
                inputAttributes = GetInputAttributes(),
                outputAttribute = OutputAttributeComboBox.Text,
                learningRate = float.Parse(LearningRateBox.Text),
                epoch = uint.Parse(EpochCountBox.Text),
                threshold = float.Parse(ThresholdBox.Text),
                maxError = float.Parse(MaxErrorBox.Text)
            };
        }

        private string[] GetInputAttributes()
        {
            List<string> checkedItemsList = new List<string>();
            for(int i=0; i<AttributesListBox.CheckedItems.Count; i++)
            {
                checkedItemsList.Add(AttributesListBox.CheckedItems[i].ToString());
            }

            return checkedItemsList.ToArray();
        }

        private Predicate<object> GetPredicate()
        {
            return new Predicate<object>(k => (bool) k);
        }

        private void PushSession(bool useNewPerceptron = true)
        {
            ReadTrainSpecs(out TrainSpecs specs);
            if(useNewPerceptron || _perceptron is null)
            {
                _perceptron = new Perceptron();
            }
            _perceptron.Threshold = specs.threshold;

            //InputManager.DataSet dataSet = InputManager.DataSet.TRAIN;
            DataType dataType = DataType.DOUBLE;
            //Predicate<object> predicate = new Predicate<object>(k => (bool)k);
            var pred = MainController.CreateCondition(OperatorChooserComboBox.SelectedItem.ToString(), ConditionTextBox.Text);
            TrainData trainData = new TrainData
            {
                OutputAttribute = specs.outputAttribute,
                InputAttributes = specs.inputAttributes,
                LearningRate = specs.learningRate,
                Epoch = specs.epoch,
                @Perceptron = _perceptron,
                @Predicate = pred,
                @DataSet = InputManager.DataSet.TRAIN,
                @DataType = dataType
            };

            

            MainController.TrainSession(trainData);
            trainData.DataSet = InputManager.DataSet.TEST;
            ResultTextBox.Text += "\r\n" + MainController.TestSession(trainData);
        }
    }
}
