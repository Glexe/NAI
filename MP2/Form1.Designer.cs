
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartsBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoImageBox = new System.Windows.Forms.PictureBox();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.ChartsPanel = new System.Windows.Forms.Panel();
            this.DrawChartsBtn = new System.Windows.Forms.Button();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectOutputSetPath = new System.Windows.Forms.Button();
            this.OutputSetPathText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTestSetPath = new System.Windows.Forms.Button();
            this.TestSetPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTrainSetPath = new System.Windows.Forms.Button();
            this.TrainSetPathText = new System.Windows.Forms.TextBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.TrainingButtonsPanel = new System.Windows.Forms.Panel();
            this.BeginNewTrainingBtn = new System.Windows.Forms.Button();
            this.ContinueTrainingBtn = new System.Windows.Forms.Button();
            this.TestResultPanel = new System.Windows.Forms.Panel();
            this.IncorrectCountLabel = new System.Windows.Forms.Label();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.correctCountLabel = new System.Windows.Forms.Label();
            this.ConditionPanel = new System.Windows.Forms.Panel();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.OperatorChooserComboBox = new System.Windows.Forms.ComboBox();
            this.InvalidConditionLabel = new System.Windows.Forms.Label();
            this.OutputAttributeComboBox = new System.Windows.Forms.ComboBox();
            this.MaxErrorBox = new System.Windows.Forms.TextBox();
            this.ThresholdBox = new System.Windows.Forms.TextBox();
            this.LearningRateBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
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
            this.TrainDataTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoadDataBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImageBox)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            this.ChartsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.TrainingButtonsPanel.SuspendLayout();
            this.TestResultPanel.SuspendLayout();
            this.ConditionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxErrorTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LearningRateTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpochTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.ChartsBtn);
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
            // ChartsBtn
            // 
            this.ChartsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(115)))));
            this.ChartsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChartsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChartsBtn.FlatAppearance.BorderSize = 0;
            this.ChartsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.ChartsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(75)))), ((int)(((byte)(55)))));
            this.ChartsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartsBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ChartsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChartsBtn.Location = new System.Drawing.Point(0, 240);
            this.ChartsBtn.Name = "ChartsBtn";
            this.ChartsBtn.Size = new System.Drawing.Size(141, 48);
            this.ChartsBtn.TabIndex = 5;
            this.ChartsBtn.Text = "Charts";
            this.ChartsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChartsBtn.UseVisualStyleBackColor = false;
            this.ChartsBtn.Click += new System.EventHandler(this.ChartsBtn_Click);
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
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(141, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(763, 554);
            this.SettingsPanel.TabIndex = 1;
            // 
            // ChartsPanel
            // 
            this.ChartsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.ChartsPanel.Controls.Add(this.DrawChartsBtn);
            this.ChartsPanel.Controls.Add(this.MainChart);
            this.ChartsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartsPanel.Location = new System.Drawing.Point(141, 0);
            this.ChartsPanel.Name = "ChartsPanel";
            this.ChartsPanel.Size = new System.Drawing.Size(763, 554);
            this.ChartsPanel.TabIndex = 12;
            // 
            // DrawChartsBtn
            // 
            this.DrawChartsBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawChartsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.DrawChartsBtn.Location = new System.Drawing.Point(18, 410);
            this.DrawChartsBtn.Name = "DrawChartsBtn";
            this.DrawChartsBtn.Size = new System.Drawing.Size(139, 45);
            this.DrawChartsBtn.TabIndex = 12;
            this.DrawChartsBtn.Text = "Draw";
            this.DrawChartsBtn.UseVisualStyleBackColor = true;
            this.DrawChartsBtn.Click += new System.EventHandler(this.DrawChartsBtn_Click);
            // 
            // MainChart
            // 
            chartArea6.AxisX.Interval = 0.1D;
            chartArea6.AxisX.Maximum = 1D;
            chartArea6.AxisX.Minimum = 0D;
            chartArea6.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisX2.Maximum = 10D;
            chartArea6.AxisX2.Minimum = 0D;
            chartArea6.AxisY.Interval = 10D;
            chartArea6.AxisY.Maximum = 100D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.MainChart.Legends.Add(legend6);
            this.MainChart.Location = new System.Drawing.Point(18, 37);
            this.MainChart.Name = "MainChart";
            this.MainChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Learning Rate";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series12.BorderWidth = 3;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series12.Legend = "Legend1";
            series12.Name = "Threshold";
            this.MainChart.Series.Add(series11);
            this.MainChart.Series.Add(series12);
            this.MainChart.Size = new System.Drawing.Size(736, 346);
            this.MainChart.TabIndex = 11;
            this.MainChart.Text = "chart2";
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
            this.MenuPanel.Controls.Add(this.LoadDataBtn);
            this.MenuPanel.Controls.Add(this.TrainingButtonsPanel);
            this.MenuPanel.Controls.Add(this.TestResultPanel);
            this.MenuPanel.Controls.Add(this.ConditionPanel);
            this.MenuPanel.Controls.Add(this.OutputAttributeComboBox);
            this.MenuPanel.Controls.Add(this.MaxErrorBox);
            this.MenuPanel.Controls.Add(this.ThresholdBox);
            this.MenuPanel.Controls.Add(this.LearningRateBox);
            this.MenuPanel.Controls.Add(this.ResultLabel);
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
            this.MenuPanel.Controls.Add(this.TrainDataTextBox);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(141, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(763, 554);
            this.MenuPanel.TabIndex = 4;
            // 
            // TrainingButtonsPanel
            // 
            this.TrainingButtonsPanel.Controls.Add(this.BeginNewTrainingBtn);
            this.TrainingButtonsPanel.Controls.Add(this.ContinueTrainingBtn);
            this.TrainingButtonsPanel.Enabled = false;
            this.TrainingButtonsPanel.Location = new System.Drawing.Point(416, 399);
            this.TrainingButtonsPanel.Name = "TrainingButtonsPanel";
            this.TrainingButtonsPanel.Size = new System.Drawing.Size(153, 118);
            this.TrainingButtonsPanel.TabIndex = 39;
            // 
            // BeginNewTrainingBtn
            // 
            this.BeginNewTrainingBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeginNewTrainingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.BeginNewTrainingBtn.Location = new System.Drawing.Point(6, 9);
            this.BeginNewTrainingBtn.Name = "BeginNewTrainingBtn";
            this.BeginNewTrainingBtn.Size = new System.Drawing.Size(139, 45);
            this.BeginNewTrainingBtn.TabIndex = 3;
            this.BeginNewTrainingBtn.Text = "Begin new training";
            this.BeginNewTrainingBtn.UseVisualStyleBackColor = true;
            this.BeginNewTrainingBtn.Click += new System.EventHandler(this.BeginNewTrainingBtn_Click);
            // 
            // ContinueTrainingBtn
            // 
            this.ContinueTrainingBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueTrainingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ContinueTrainingBtn.Location = new System.Drawing.Point(6, 60);
            this.ContinueTrainingBtn.Name = "ContinueTrainingBtn";
            this.ContinueTrainingBtn.Size = new System.Drawing.Size(139, 45);
            this.ContinueTrainingBtn.TabIndex = 38;
            this.ContinueTrainingBtn.Text = "Continue training";
            this.ContinueTrainingBtn.UseVisualStyleBackColor = true;
            this.ContinueTrainingBtn.Visible = false;
            this.ContinueTrainingBtn.Click += new System.EventHandler(this.ContinueTrainingBtn_Click);
            // 
            // TestResultPanel
            // 
            this.TestResultPanel.Controls.Add(this.IncorrectCountLabel);
            this.TestResultPanel.Controls.Add(this.AccuracyLabel);
            this.TestResultPanel.Controls.Add(this.correctCountLabel);
            this.TestResultPanel.Location = new System.Drawing.Point(578, 278);
            this.TestResultPanel.Name = "TestResultPanel";
            this.TestResultPanel.Size = new System.Drawing.Size(161, 84);
            this.TestResultPanel.TabIndex = 37;
            // 
            // IncorrectCountLabel
            // 
            this.IncorrectCountLabel.AutoSize = true;
            this.IncorrectCountLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.IncorrectCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.IncorrectCountLabel.Location = new System.Drawing.Point(3, 33);
            this.IncorrectCountLabel.Name = "IncorrectCountLabel";
            this.IncorrectCountLabel.Size = new System.Drawing.Size(82, 21);
            this.IncorrectCountLabel.TabIndex = 35;
            this.IncorrectCountLabel.Text = "Incorrect:";
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.AccuracyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.AccuracyLabel.Location = new System.Drawing.Point(3, 54);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(83, 21);
            this.AccuracyLabel.TabIndex = 36;
            this.AccuracyLabel.Text = "Accuracy:";
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.AutoSize = true;
            this.correctCountLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.correctCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.correctCountLabel.Location = new System.Drawing.Point(3, 12);
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(69, 21);
            this.correctCountLabel.TabIndex = 34;
            this.correctCountLabel.Text = "Correct:";
            // 
            // ConditionPanel
            // 
            this.ConditionPanel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionPanel.Controls.Add(this.ConditionTextBox);
            this.ConditionPanel.Controls.Add(this.OperatorChooserComboBox);
            this.ConditionPanel.Controls.Add(this.InvalidConditionLabel);
            this.ConditionPanel.Location = new System.Drawing.Point(183, 198);
            this.ConditionPanel.Name = "ConditionPanel";
            this.ConditionPanel.Size = new System.Drawing.Size(389, 25);
            this.ConditionPanel.TabIndex = 33;
            this.ConditionPanel.Visible = false;
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ConditionTextBox.Location = new System.Drawing.Point(49, 0);
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(125, 25);
            this.ConditionTextBox.TabIndex = 31;
            this.ConditionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OperatorChooserComboBox
            // 
            this.OperatorChooserComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OperatorChooserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperatorChooserComboBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OperatorChooserComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.OperatorChooserComboBox.FormattingEnabled = true;
            this.OperatorChooserComboBox.Location = new System.Drawing.Point(0, 0);
            this.OperatorChooserComboBox.MaxDropDownItems = 65;
            this.OperatorChooserComboBox.Name = "OperatorChooserComboBox";
            this.OperatorChooserComboBox.Size = new System.Drawing.Size(43, 25);
            this.OperatorChooserComboBox.TabIndex = 32;
            // 
            // InvalidConditionLabel
            // 
            this.InvalidConditionLabel.AutoSize = true;
            this.InvalidConditionLabel.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.InvalidConditionLabel.ForeColor = System.Drawing.Color.Maroon;
            this.InvalidConditionLabel.Location = new System.Drawing.Point(180, 3);
            this.InvalidConditionLabel.Name = "InvalidConditionLabel";
            this.InvalidConditionLabel.Size = new System.Drawing.Size(206, 17);
            this.InvalidConditionLabel.TabIndex = 34;
            this.InvalidConditionLabel.Text = "Please provide a valid condition";
            this.InvalidConditionLabel.Visible = false;
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
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ResultLabel.Location = new System.Drawing.Point(574, 365);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(57, 21);
            this.ResultLabel.TabIndex = 25;
            this.ResultLabel.Text = "Result";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResultTextBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ResultTextBox.Location = new System.Drawing.Point(578, 389);
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
            // LoadDataBtn
            // 
            this.LoadDataBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.LoadDataBtn.Location = new System.Drawing.Point(18, 229);
            this.LoadDataBtn.Name = "LoadDataBtn";
            this.LoadDataBtn.Size = new System.Drawing.Size(139, 45);
            this.LoadDataBtn.TabIndex = 39;
            this.LoadDataBtn.Text = "Load data";
            this.LoadDataBtn.UseVisualStyleBackColor = true;
            this.LoadDataBtn.Click += new System.EventHandler(this.LoadDataBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(904, 554);
            this.Controls.Add(this.ChartsPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.SettingsPanel);
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
            this.ChartsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.TrainingButtonsPanel.ResumeLayout(false);
            this.TestResultPanel.ResumeLayout(false);
            this.TestResultPanel.PerformLayout();
            this.ConditionPanel.ResumeLayout(false);
            this.ConditionPanel.PerformLayout();
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
        private System.Windows.Forms.Button BeginNewTrainingBtn;
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
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox MaxErrorBox;
        private System.Windows.Forms.TextBox ThresholdBox;
        private System.Windows.Forms.TextBox LearningRateBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SelectOutputSetPath;
        private System.Windows.Forms.TextBox OutputSetPathText;
        private System.Windows.Forms.ComboBox OutputAttributeComboBox;
        private System.Windows.Forms.ComboBox OperatorChooserComboBox;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.Panel ConditionPanel;
        private System.Windows.Forms.Label InvalidConditionLabel;
        private System.Windows.Forms.Label correctCountLabel;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.Label IncorrectCountLabel;
        private System.Windows.Forms.Panel TestResultPanel;
        private System.Windows.Forms.Button ContinueTrainingBtn;
        private System.Windows.Forms.Panel TrainingButtonsPanel;
        private System.Windows.Forms.Button ChartsBtn;
        private System.Windows.Forms.Panel ChartsPanel;
        private System.Windows.Forms.Button DrawChartsBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.Button LoadDataBtn;
    }
}

