
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoImageBox = new System.Windows.Forms.PictureBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTestSetPath = new System.Windows.Forms.Button();
            this.TestSetPathText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTrainSetPath = new System.Windows.Forms.Button();
            this.TrainSetPathText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImageBox)).BeginInit();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.MenuBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 554);
            this.panel1.TabIndex = 0;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(85)))), ((int)(((byte)(65)))));
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
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
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
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
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.MenuPanel.Controls.Add(this.SettingsPanel);
            this.MenuPanel.Controls.Add(this.label2);
            this.MenuPanel.Controls.Add(this.SelectTestSetPath);
            this.MenuPanel.Controls.Add(this.TestSetPathText);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.SelectTrainSetPath);
            this.MenuPanel.Controls.Add(this.TrainSetPathText);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(141, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(763, 554);
            this.MenuPanel.TabIndex = 1;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(763, 554);
            this.SettingsPanel.TabIndex = 4;
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
            this.SelectTestSetPath.Size = new System.Drawing.Size(41, 20);
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
            this.TestSetPathText.Size = new System.Drawing.Size(285, 22);
            this.TestSetPathText.TabIndex = 5;
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
            this.SelectTrainSetPath.Size = new System.Drawing.Size(41, 20);
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
            this.TrainSetPathText.Size = new System.Drawing.Size(285, 22);
            this.TrainSetPathText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(904, 554);
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
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MenuPanel;
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
        private System.Windows.Forms.Panel SettingsPanel;
    }
}

