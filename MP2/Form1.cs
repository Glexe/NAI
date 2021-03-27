using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace MP2
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private enum AppStates
        {
            None,
            Menu,
            Settings
        }

        private Color _bttnPressedColor;
        private Color _bttnDefaultColor;

        public Form1()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            _bttnPressedColor = ColorsConfig.ButtonPressed;
            _bttnDefaultColor = ColorsConfig.ButtonDefault;
            SwitchPage(AppStates.Menu);
        }


        

        private void SelectTrainSetPath_Click(object sender, EventArgs e)
        {
            TrainSetPathText.Text = PickFolder();
        }

        private void SelectTestSetPath_Click(object sender, EventArgs e)
        {
            TestSetPathText.Text = PickFolder();
        }

        private void SwitchPage(AppStates state)
        {
            switch (state)
            {
                case AppStates.None:
                    MenuBtn.BackColor = _bttnDefaultColor;
                    SettingsBtn.BackColor = _bttnDefaultColor;
                    MenuPanel.Visible = false;
                    SettingsPanel.Visible = false;
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
                    MenuPanel.Visible = false;
                    SettingsPanel.Visible = true;
                    break;
            }
        }

        private string PickFolder()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }
            return null;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SwitchPage(AppStates.Menu);
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SwitchPage(AppStates.Settings);
        }
    }
}
