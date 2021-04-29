using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media;

namespace MP3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string _projectFolderPath = Environment.CurrentDirectory.Replace(@"bin\Debug", "");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Classify_button_Click(object sender, RoutedEventArgs e)
        {
            GetLaunchAtttributes(out int langCode, out string trainPath, out string testPath, out string textToClassify);

            if(!File.Exists(trainPath))
            {
                RegError("Such trainSet file does not exist");
                return;
            }
            if (!File.Exists(testPath))
            {
                RegError("Such testSet file does not exist");
                return;
            }

            string args = $"{trainPath} {testPath} {langCode} {textToClassify}";
            string scriptPath = $"{_projectFolderPath}{@"Python\main.py "}";
            string pythonPath = $"{_projectFolderPath}{@"Python\venv\Scripts\python.exe"}";
            scriptPath += args;
            ProcessStartInfo start = new ProcessStartInfo(pythonPath, scriptPath)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            };

            var proc = new Process
            {
                StartInfo = start
            };
            proc.Start();
            var output = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit();

            if (output.StartsWith("-1"))
            {
                RegError(output.Split(',')[1]);
                return;
            }
            if (output.Length == 0)
            {
                output = "Given text cannot be classified";
            }

            RegResult(output);
        }

        private void RegError(string msg)
        {
            ResultType_label.Foreground = Brushes.Red;
            ResultType_label.Content = "Error:";
            Result_textBlock.Text = msg;
        }

        private void RegResult(string msg)
        {
            ResultType_label.Foreground = Brushes.LightBlue;
            ResultType_label.Content = "Result:";
            Result_textBlock.Text = msg;
        }

        private void GetLaunchAtttributes(out int languageCode, out string trainFilepath, out string testFilePath, out string textToClassify)
        {
            if ((bool)Romance_Radio_button.IsChecked) languageCode = 1;
            else languageCode = 2;
            trainFilepath = trainSetFilepath_textBox.Text;
            testFilePath = testSetFilepath_textBox.Text;
            textToClassify = textBox.Text.Replace(" ","");
        }

        private void OpenTrainSetFilePicker_button_Click(object sender, RoutedEventArgs e)
        {
            string path;
            if((path = OpenFilePicker()) != null)
                trainSetFilepath_textBox.Text = path;
        }

        private void OpenTestSetFilePicker_button_Click(object sender, RoutedEventArgs e)
        {
            string path;
            if ((path = OpenFilePicker()) != null)
                testSetFilepath_textBox.Text = path;
        }

        private string OpenFilePicker()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Text files (*.csv,*.txt)|*.csv; *.txt"
            };

            if (dialog.ShowDialog() == true)
            {
                return dialog.FileName;
            }

            return null;
        }
    }
}
