namespace HDX_ServiceTools.Forms
{
    partial class InstallerForm
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
            homeButton = new Button();
            supportLabel = new Label();
            Logo = new PictureBox();
            optionsLabel = new Label();
            standardInstallButton = new Button();
            descriptionLabel = new Label();
            progressBar = new ProgressBar();
            statusText = new TextBox();
            backButton = new Button();
            continueButton = new Button();
            wmInstallButton = new Button();
            odInstallButton = new Button();
            willcephInstallButton = new Button();
            finishButton = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // homeButton
            // 
            homeButton.AutoSize = true;
            homeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeButton.Location = new Point(634, 13);
            homeButton.Margin = new Padding(2, 3, 2, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(69, 33);
            homeButton.TabIndex = 14;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += HomeButton_Click;
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
            supportLabel.TabIndex = 15;
            supportLabel.Text = "For any questions or concerns, please contact HDX support:\r\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            supportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(11, 13);
            Logo.Margin = new Padding(2, 3, 2, 22);
            Logo.Name = "Logo";
            Logo.Size = new Size(274, 54);
            Logo.TabIndex = 16;
            Logo.TabStop = false;
            // 
            // optionsLabel
            // 
            optionsLabel.AutoSize = true;
            optionsLabel.BackColor = Color.Transparent;
            optionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optionsLabel.Location = new Point(190, 98);
            optionsLabel.Margin = new Padding(2, 10, 2, 10);
            optionsLabel.Name = "optionsLabel";
            optionsLabel.Size = new Size(394, 21);
            optionsLabel.TabIndex = 17;
            optionsLabel.Text = "Please select from one of the installation options below:";
            optionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // standardInstallButton
            // 
            standardInstallButton.AutoSize = true;
            standardInstallButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            standardInstallButton.Location = new Point(190, 142);
            standardInstallButton.Margin = new Padding(9, 10, 2, 3);
            standardInstallButton.Name = "standardInstallButton";
            standardInstallButton.Size = new Size(148, 55);
            standardInstallButton.TabIndex = 18;
            standardInstallButton.Text = "Will-Master +\n OnDemand3D";
            standardInstallButton.UseVisualStyleBackColor = true;
            standardInstallButton.Click += StandardInstallButton_Click;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(198, 98);
            descriptionLabel.Margin = new Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(362, 21);
            descriptionLabel.TabIndex = 19;
            descriptionLabel.Text = "The application will attempt to install the following:";
            descriptionLabel.Visible = false;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.Control;
            progressBar.Location = new Point(126, 365);
            progressBar.Margin = new Padding(2, 3, 2, 3);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(474, 25);
            progressBar.TabIndex = 20;
            progressBar.Visible = false;
            // 
            // statusText
            // 
            statusText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(126, 134);
            statusText.Margin = new Padding(2, 3, 2, 3);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.ScrollBars = ScrollBars.Vertical;
            statusText.Size = new Size(474, 224);
            statusText.TabIndex = 21;
            statusText.Visible = false;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(243, 401);
            backButton.Margin = new Padding(2, 3, 2, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(69, 31);
            backButton.TabIndex = 22;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Visible = false;
            backButton.Click += BackButton_Click;
            // 
            // continueButton
            // 
            continueButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueButton.Location = new Point(369, 401);
            continueButton.Margin = new Padding(2, 3, 2, 3);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(102, 31);
            continueButton.TabIndex = 23;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Visible = false;
            continueButton.Click += ContinueButton_Click;
            // 
            // wmInstallButton
            // 
            wmInstallButton.AutoSize = true;
            wmInstallButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wmInstallButton.Location = new Point(402, 142);
            wmInstallButton.Margin = new Padding(9, 10, 2, 10);
            wmInstallButton.Name = "wmInstallButton";
            wmInstallButton.Size = new Size(148, 55);
            wmInstallButton.TabIndex = 24;
            wmInstallButton.Text = "Will-Master";
            wmInstallButton.UseVisualStyleBackColor = true;
            wmInstallButton.Click += WmInstallButton_Click;
            // 
            // odInstallButton
            // 
            odInstallButton.AutoSize = true;
            odInstallButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            odInstallButton.Location = new Point(402, 218);
            odInstallButton.Margin = new Padding(9, 10, 2, 3);
            odInstallButton.Name = "odInstallButton";
            odInstallButton.Size = new Size(148, 55);
            odInstallButton.TabIndex = 25;
            odInstallButton.Text = "OnDemand3D";
            odInstallButton.UseVisualStyleBackColor = true;
            odInstallButton.Click += OdInstallButton_Click;
            // 
            // willcephInstallButton
            // 
            willcephInstallButton.AutoSize = true;
            willcephInstallButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            willcephInstallButton.Location = new Point(190, 218);
            willcephInstallButton.Margin = new Padding(9, 10, 2, 3);
            willcephInstallButton.Name = "willcephInstallButton";
            willcephInstallButton.Size = new Size(148, 55);
            willcephInstallButton.TabIndex = 26;
            willcephInstallButton.Text = "Will-Ceph";
            willcephInstallButton.UseVisualStyleBackColor = true;
            willcephInstallButton.Click += WillcephInstallButton_Click;
            // 
            // finishButton
            // 
            finishButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finishButton.Location = new Point(530, 401);
            finishButton.Margin = new Padding(2, 3, 2, 3);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(69, 31);
            finishButton.TabIndex = 27;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Visible = false;
            finishButton.Click += FinishButton_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(634, 442);
            btnHelp.Margin = new Padding(2, 3, 2, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(69, 33);
            btnHelp.TabIndex = 28;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // InstallerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            ClientSize = new Size(713, 487);
            Controls.Add(btnHelp);
            Controls.Add(finishButton);
            Controls.Add(willcephInstallButton);
            Controls.Add(odInstallButton);
            Controls.Add(wmInstallButton);
            Controls.Add(continueButton);
            Controls.Add(backButton);
            Controls.Add(statusText);
            Controls.Add(progressBar);
            Controls.Add(descriptionLabel);
            Controls.Add(standardInstallButton);
            Controls.Add(optionsLabel);
            Controls.Add(Logo);
            Controls.Add(supportLabel);
            Controls.Add(homeButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "InstallerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HDX WILL - Installer";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button homeButton;
        private Label supportLabel;
        private PictureBox Logo;
        private Label optionsLabel;
        private Button standardInstallButton;
        private Label descriptionLabel;
        private ProgressBar progressBar;
        private TextBox statusText;
        private Button backButton;
        private Button continueButton;
        private Button wmInstallButton;
        private Button odInstallButton;
        private Button willcephInstallButton;
        private Button finishButton;
        private Button btnHelp;
    }
}