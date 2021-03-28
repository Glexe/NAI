
namespace MP2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoImageBox = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTestSetPath = new System.Windows.Forms.Button();
            this.TestSetPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTrainSetPath = new System.Windows.Forms.Button();
            this.TrainSetPathText = new System.Windows.Forms.TextBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MaxErrorBox = new System.Windows.Forms.TextBox();
            this.ThresholdBox = new System.Windows.Forms.TextBox();
            this.LearningRateBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TestDataTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EpochCountBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaxErrorTrackBar = new System.Windows.Forms.TrackBar();
            this.ThresholdTrackBar = new System.Windows.Forms.TrackBar();
            this.LearningRateTrackBar = new System.Windows.Forms.TrackBar();
            this.EpochTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.AttributesListBox = new System.Windows.Forms.CheckedListBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.TrainDataTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.SelectOutputSetPath = new System.Windows.Forms.Button();
            this.OutputSetPathText = new System.Windows.Forms.TextBox();
            this.OutputAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImageBox)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxErrorTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.MenuBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 554);
            this.panel1.TabIndex = 0;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ExitBtn.Image = global::MP2.Properties.Resources.Exit;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(0, 506);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(7, 7, 0, 7);
            this.ExitBtn.Size = new System.Drawing.Size(141, 48);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.SettingsBtn.Image = global::MP2.Properties.Resources.Settings;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 192);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(141, 48);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.SettingsBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.MenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MenuBtn.Image = global::MP2.Properties.Resources.Home;
            this.MenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBtn.Location = new System.Drawing.Point(0, 144);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(141, 48);
            this.MenuBtn.TabIndex = 2;
            this.MenuBtn.Text = "Menu";
            this.MenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuBtn.UseVisualStyleBackColor = true;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LogoImageBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 144);
            this.panel3.TabIndex = 1;
            // 
            // LogoImageBox
            // 
            this.LogoImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(130)))), ((int)(((byte)(105)))));
            this.LogoImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoImageBox.Image = global::MP2.Properties.Resources.Logo;
            this.LogoImageBox.InitialImage = null;
            this.LogoImageBox.Location = new System.Drawing.Point(0, 0);
            this.LogoImageBox.Name = "LogoImageBox";
            this.LogoImageBox.Size = new System.Drawing.Size(141, 144);
            this.LogoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoImageBox.TabIndex = 0;
            this.LogoImageBox.TabStop = false;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.SettingsPanel.Controls.Add(this.label11);
            this.SettingsPanel.Controls.Add(this.SelectOutputSetPath);
            this.SettingsPanel.Controls.Add(this.OutputSetPathText);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.SelectTestSetPath);
            this.SettingsPanel.Controls.Add(this.TestSetPathText);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.SelectTrainSetPath);
            this.SettingsPanel.Controls.Add(this.TrainSetPathText);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsPanel.Location = new System.Drawing.Point(141, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(763, 554);
            this.SettingsPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(31, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose test-set";
            // 
            // SelectTestSetPath
            // 
            this.SelectTestSetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTestSetPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.SelectTestSetPath.Location = new System.Drawing.Point(328, 253);
            this.SelectTestSetPath.Name = "SelectTestSetPath";
            this.SelectTestSetPath.Size = new System.Drawing.Size(41, 22);
            this.SelectTestSetPath.TabIndex = 6;
            this.SelectTestSetPath.Text = "●●●";
            this.SelectTestSetPath.UseVisualStyleBackColor = true;
            this.SelectTestSetPath.Click += new System.EventHandler(this.SelectTestSetPath_Click);
            // 
            // TestSetPathText
            // 
            this.TestSetPathText.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestSetPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.TestSetPathText.Location = new System.Drawing.Point(37, 253);
            this.TestSetPathText.Name = "TestSetPathText";
            this.TestSetPathText.ReadOnly = true;
            this.TestSetPathText.Size = new System.Drawing.Size(285, 22);
            this.TestSetPathText.TabIndex = 5;
            this.TestSetPathText.Text = "D:\\Soft\\VisualStudio\\Projects\\NAI\\MP2\\Data\\irisTest.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(31, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose train-set";
            // 
            // SelectTrainSetPath
            // 
            this.SelectTrainSetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTrainSetPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.SelectTrainSetPath.Location = new System.Drawing.Point(328, 136);
            this.SelectTrainSetPath.Name = "SelectTrainSetPath";
            this.SelectTrainSetPath.Size = new System.Drawing.Size(41, 22);
            this.SelectTrainSetPath.TabIndex = 2;
            this.SelectTrainSetPath.Text = "●●●";
            this.SelectTrainSetPath.UseVisualStyleBackColor = true;
            this.SelectTrainSetPath.Click += new System.EventHandler(this.SelectTrainSetPath_Click);
            // 
            // TrainSetPathText
            // 
            this.TrainSetPathText.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainSetPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.TrainSetPathText.Location = new System.Drawing.Point(37, 136);
            this.TrainSetPathText.Name = "TrainSetPathText";
            this.TrainSetPathText.ReadOnly = true;
            this.TrainSetPathText.Size = new System.Drawing.Size(285, 22);
            this.TrainSetPathText.TabIndex = 0;
            this.TrainSetPathText.Text = "D:\\Soft\\VisualStudio\\Projects\\NAI\\MP2\\Data\\irisTrain.csv";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.MenuPanel.Controls.Add(this.OutputAttributeComboBox);
            this.MenuPanel.Controls.Add(this.MaxErrorBox);
            this.MenuPanel.Controls.Add(this.ThresholdBox);
            this.MenuPanel.Controls.Add(this.LearningRateBox);
            this.MenuPanel.Controls.Add(this.label10);
            this.MenuPanel.Controls.Add(this.ResultTextBox);
            this.MenuPanel.Controls.Add(this.label9);
            this.MenuPanel.Controls.Add(this.TestDataTextBox);
            this.MenuPanel.Controls.Add(this.label8);
            this.MenuPanel.Controls.Add(this.EpochCountBox);
            this.MenuPanel.Controls.Add(this.label7);
            this.MenuPanel.Controls.Add(this.label6);
            this.MenuPanel.Controls.Add(this.label5);
            this.MenuPanel.Controls.Add(this.label4);
            this.MenuPanel.Controls.Add(this.MaxErrorTrackBar);
            this.MenuPanel.Controls.Add(this.ThresholdTrackBar);
            this.MenuPanel.Controls.Add(this.LearningRateTrackBar);
            this.MenuPanel.Controls.Add(this.EpochTrackBar);
            this.MenuPanel.Controls.Add(this.label3);
            this.MenuPanel.Controls.Add(this.AttributesListBox);
            this.MenuPanel.Controls.Add(this.StartBtn);
            this.MenuPanel.Controls.Add(this.TrainDataTextBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(141, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(763, 554);
            this.MenuPanel.TabIndex = 4;
            // 
            // MaxErrorBox
            // 
            this.MaxErrorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.MaxErrorBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxErrorBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.MaxErrorBox.Location = new System.Drawing.Point(626, 167);
            this.MaxErrorBox.MaxLength = 4;
            this.MaxErrorBox.Name = "MaxErrorBox";
            this.MaxErrorBox.ReadOnly = true;
            this.MaxErrorBox.Size = new System.Drawing.Size(81, 25);
            this.MaxErrorBox.TabIndex = 28;
            this.MaxErrorBox.Text = "0.5";
            this.MaxErrorBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ThresholdBox
            // 
            this.ThresholdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.ThresholdBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresholdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ThresholdBox.Location = new System.Drawing.Point(480, 167);
            this.ThresholdBox.MaxLength = 4;
            this.ThresholdBox.Name = "ThresholdBox";
            this.ThresholdBox.ReadOnly = true;
            this.ThresholdBox.Size = new System.Drawing.Size(81, 25);
            this.ThresholdBox.TabIndex = 27;
            this.ThresholdBox.Text = "0.5";
            this.ThresholdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LearningRateBox
            // 
            this.LearningRateBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.LearningRateBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningRateBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.LearningRateBox.Location = new System.Drawing.Point(341, 167);
            this.LearningRateBox.MaxLength = 4;
            this.LearningRateBox.Name = "LearningRateBox";
            this.LearningRateBox.ReadOnly = true;
            this.LearningRateBox.Size = new System.Drawing.Size(81, 25);
            this.LearningRateBox.TabIndex = 26;
            this.LearningRateBox.Text = "0.5";
            this.LearningRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(576, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 25;
            this.label10.Text = "Result";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResultTextBox.Location = new System.Drawing.Point(580, 318);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(161, 140);
            this.ResultTextBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(14, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Given test data";
            // 
            // TestDataTextBox
            // 
            this.TestDataTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TestDataTextBox.Location = new System.Drawing.Point(18, 445);
            this.TestDataTextBox.Multiline = true;
            this.TestDataTextBox.Name = "TestDataTextBox";
            this.TestDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TestDataTextBox.Size = new System.Drawing.Size(278, 97);
            this.TestDataTextBox.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(14, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Given train data";
            // 
            // EpochCountBox
            // 
            this.EpochCountBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.EpochCountBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EpochCountBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.EpochCountBox.Location = new System.Drawing.Point(202, 167);
            this.EpochCountBox.MaxLength = 2;
            this.EpochCountBox.Name = "EpochCountBox";
            this.EpochCountBox.ReadOnly = true;
            this.EpochCountBox.Size = new System.Drawing.Size(81, 25);
            this.EpochCountBox.TabIndex = 20;
            this.EpochCountBox.Text = "5";
            this.EpochCountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label7.Location = new System.Drawing.Point(623, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max error";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label6.Location = new System.Drawing.Point(477, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Threshold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(338, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Learning rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(199, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Epoch count";
            // 
            // MaxErrorTrackBar
            // 
            this.MaxErrorTrackBar.LargeChange = 1;
            this.MaxErrorTrackBar.Location = new System.Drawing.Point(614, 136);
            this.MaxErrorTrackBar.Maximum = 20;
            this.MaxErrorTrackBar.Minimum = 1;
            this.MaxErrorTrackBar.Name = "MaxErrorTrackBar";
            this.MaxErrorTrackBar.Size = new System.Drawing.Size(104, 45);
            this.MaxErrorTrackBar.TabIndex = 13;
            this.MaxErrorTrackBar.Value = 1;
            // 
            // ThresholdTrackBar
            // 
            this.ThresholdTrackBar.LargeChange = 1;
            this.ThresholdTrackBar.Location = new System.Drawing.Point(468, 136);
            this.ThresholdTrackBar.Maximum = 20;
            this.ThresholdTrackBar.Minimum = 1;
            this.ThresholdTrackBar.Name = "ThresholdTrackBar";
            this.ThresholdTrackBar.Size = new System.Drawing.Size(104, 45);
            this.ThresholdTrackBar.TabIndex = 12;
            this.ThresholdTrackBar.Value = 1;
            // 
            // LearningRateTrackBar
            // 
            this.LearningRateTrackBar.LargeChange = 1;
            this.LearningRateTrackBar.Location = new System.Drawing.Point(328, 136);
            this.LearningRateTrackBar.Maximum = 20;
            this.LearningRateTrackBar.Minimum = 1;
            this.LearningRateTrackBar.Name = "LearningRateTrackBar";
            this.LearningRateTrackBar.Size = new System.Drawing.Size(104, 45);
            this.LearningRateTrackBar.TabIndex = 11;
            this.LearningRateTrackBar.Value = 1;
            // 
            // EpochTrackBar
            // 
            this.EpochTrackBar.LargeChange = 1;
            this.EpochTrackBar.Location = new System.Drawing.Point(192, 136);
            this.EpochTrackBar.Maximum = 20;
            this.EpochTrackBar.Minimum = 1;
            this.EpochTrackBar.Name = "EpochTrackBar";
            this.EpochTrackBar.Size = new System.Drawing.Size(104, 45);
            this.EpochTrackBar.TabIndex = 10;
            this.EpochTrackBar.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(15, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select attributes";
            // 
            // AttributesListBox
            // 
            this.AttributesListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AttributesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttributesListBox.CausesValidation = false;
            this.AttributesListBox.CheckOnClick = true;
            this.AttributesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.AttributesListBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttributesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.AttributesListBox.FormattingEnabled = true;
            this.AttributesListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AttributesListBox.Location = new System.Drawing.Point(18, 70);
            this.AttributesListBox.Name = "AttributesListBox";
            this.AttributesListBox.Size = new System.Drawing.Size(159, 122);
            this.AttributesListBox.TabIndex = 8;
            this.AttributesListBox.ThreeDCheckBoxes = true;
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.StartBtn.Location = new System.Drawing.Point(341, 374);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(139, 45);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // TrainDataTextBox
            // 
            this.TrainDataTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TrainDataTextBox.Location = new System.Drawing.Point(18, 302);
            this.TrainDataTextBox.Multiline = true;
            this.TrainDataTextBox.Name = "TrainDataTextBox";
            this.TrainDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TrainDataTextBox.Size = new System.Drawing.Size(278, 97);
            this.TrainDataTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label11.Location = new System.Drawing.Point(31, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Choose output-set (optional)";
            // 
            // SelectOutputSetPath
            // 
            this.SelectOutputSetPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectOutputSetPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.SelectOutputSetPath.Location = new System.Drawing.Point(328, 379);
            this.SelectOutputSetPath.Name = "SelectOutputSetPath";
            this.SelectOutputSetPath.Size = new System.Drawing.Size(41, 22);
            this.SelectOutputSetPath.TabIndex = 9;
            this.SelectOutputSetPath.Text = "●●●";
            this.SelectOutputSetPath.UseVisualStyleBackColor = true;
            this.SelectOutputSetPath.Click += new System.EventHandler(this.SelectOutputSetPath_Click);
            // 
            // OutputSetPathText
            // 
            this.OutputSetPathText.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputSetPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.OutputSetPathText.Location = new System.Drawing.Point(37, 379);
            this.OutputSetPathText.Name = "OutputSetPathText";
            this.OutputSetPathText.ReadOnly = true;
            this.OutputSetPathText.Size = new System.Drawing.Size(285, 22);
            this.OutputSetPathText.TabIndex = 8;
            // 
            // OutputAttributeComboBox
            // 
            this.OutputAttributeComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OutputAttributeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputAttributeComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OutputAttributeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.OutputAttributeComboBox.FormattingEnabled = true;
            this.OutputAttributeComboBox.Location = new System.Drawing.Point(18, 198);
            this.OutputAttributeComboBox.MaxDropDownItems = 65;
            this.OutputAttributeComboBox.Name = "OutputAttributeComboBox";
            this.OutputAttributeComboBox.Size = new System.Drawing.Size(159, 25);
            this.OutputAttributeComboBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(904, 554);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoImageBox)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxErrorTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectTrainSetPath;
        private System.Windows.Forms.TextBox TrainSetPathText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectTestSetPath;
        private System.Windows.Forms.TextBox TestSetPathText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox LogoImageBox;
        private System.Windows.Forms.Button MenuBtn;
        private System.Windows.Forms.Button SettingsBtn;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.TextBox TrainDataTextBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.CheckedListBox AttributesListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar MaxErrorTrackBar;
        private System.Windows.Forms.TrackBar ThresholdTrackBar;
        private System.Windows.Forms.TrackBar LearningRateTrackBar;
        private System.Windows.Forms.TrackBar EpochTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EpochCountBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TestDataTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox MaxErrorBox;
        private System.Windows.Forms.TextBox ThresholdBox;
        private System.Windows.Forms.TextBox LearningRateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SelectOutputSetPath;
        private System.Windows.Forms.TextBox OutputSetPathText;
        private System.Windows.Forms.ComboBox OutputAttributeComboBox;
    }
}

