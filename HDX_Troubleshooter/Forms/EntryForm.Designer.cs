namespace HDX_ServiceTools.Forms
{
    partial class EntryForm
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
            supportLabel = new Label();
            Logo = new PictureBox();
            welcomeLabel = new Label();
            installButton = new Button();
            troubleshootButton = new Button();
            qualityAssuranceButton = new Button();
            troubleshootWorkstationButton = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // supportLabel
            // 
            supportLabel.Anchor = AnchorStyles.Bottom;
            supportLabel.AutoSize = true;
            supportLabel.BackColor = Color.Transparent;
            supportLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supportLabel.Location = new Point(198, 446);
            supportLabel.Margin = new Padding(2, 10, 2, 0);
            supportLabel.Name = "supportLabel";
            supportLabel.Size = new Size(335, 30);
            supportLabel.TabIndex = 6;
            supportLabel.Text = "For any questions or concerns, please contact HDX support:\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            supportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(11, 13);
            Logo.Margin = new Padding(2, 3, 2, 22);
            Logo.Name = "Logo";
            Logo.Size = new Size(274, 54);
            Logo.TabIndex = 7;
            Logo.TabStop = false;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.Location = new Point(173, 99);
            welcomeLabel.Margin = new Padding(2, 10, 2, 10);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(361, 42);
            welcomeLabel.TabIndex = 8;
            welcomeLabel.Text = "Welcome to the HDX WILL Self Service Application.\nPlease select one of the options below:";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installButton
            // 
            installButton.AutoSize = true;
            installButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            installButton.Location = new Point(190, 164);
            installButton.Margin = new Padding(9, 10, 2, 22);
            installButton.Name = "installButton";
            installButton.Size = new Size(162, 55);
            installButton.TabIndex = 9;
            installButton.Text = "Software Installation\n(Workstations)";
            installButton.UseVisualStyleBackColor = true;
            installButton.Click += InstallButton_Click;
            // 
            // troubleshootButton
            // 
            troubleshootButton.AutoSize = true;
            troubleshootButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            troubleshootButton.Location = new Point(372, 164);
            troubleshootButton.Margin = new Padding(2, 3, 2, 3);
            troubleshootButton.Name = "troubleshootButton";
            troubleshootButton.Size = new Size(162, 55);
            troubleshootButton.TabIndex = 10;
            troubleshootButton.Text = "Troubleshoot\n(Server)";
            troubleshootButton.UseVisualStyleBackColor = true;
            troubleshootButton.Click += TroubleshootButton_Click;
            // 
            // qualityAssuranceButton
            // 
            qualityAssuranceButton.AutoSize = true;
            qualityAssuranceButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            qualityAssuranceButton.Location = new Point(190, 244);
            qualityAssuranceButton.Margin = new Padding(2, 3, 2, 3);
            qualityAssuranceButton.Name = "qualityAssuranceButton";
            qualityAssuranceButton.Size = new Size(162, 55);
            qualityAssuranceButton.TabIndex = 11;
            qualityAssuranceButton.Text = "QA/QC";
            qualityAssuranceButton.UseVisualStyleBackColor = true;
            qualityAssuranceButton.Click += QualityAssuranceButton_Click;
            // 
            // troubleshootWorkstationButton
            // 
            troubleshootWorkstationButton.AutoSize = true;
            troubleshootWorkstationButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            troubleshootWorkstationButton.Location = new Point(372, 244);
            troubleshootWorkstationButton.Margin = new Padding(2, 3, 2, 3);
            troubleshootWorkstationButton.Name = "troubleshootWorkstationButton";
            troubleshootWorkstationButton.Size = new Size(162, 55);
            troubleshootWorkstationButton.TabIndex = 12;
            troubleshootWorkstationButton.Text = "Troubleshoot\n(Workstations)";
            troubleshootWorkstationButton.UseVisualStyleBackColor = true;
            troubleshootWorkstationButton.Click += TroubleshootWorkstationButton_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(633, 442);
            btnHelp.Margin = new Padding(2, 3, 2, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(69, 33);
            btnHelp.TabIndex = 29;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            ClientSize = new Size(713, 487);
            Controls.Add(btnHelp);
            Controls.Add(troubleshootWorkstationButton);
            Controls.Add(qualityAssuranceButton);
            Controls.Add(troubleshootButton);
            Controls.Add(installButton);
            Controls.Add(welcomeLabel);
            Controls.Add(Logo);
            Controls.Add(supportLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "EntryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HDX WILL - Self Service";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label supportLabel;
        private PictureBox Logo;
        private Label welcomeLabel;
        private Button installButton;
        private Button troubleshootButton;
        private Button qualityAssuranceButton;
        private Button troubleshootWorkstationButton;
        private Button btnHelp;
    }
}