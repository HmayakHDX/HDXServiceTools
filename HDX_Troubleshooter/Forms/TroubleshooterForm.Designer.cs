namespace HDX_ServiceTools.Forms
{
    partial class TroubleshooterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Logo = new PictureBox();
            supportLabel = new Label();
            searchText = new TextBox();
            enterLabel = new Label();
            errorList = new ListBox();
            errorLabel = new Label();
            statusText = new TextBox();
            backButton = new Button();
            continueButton = new Button();
            homeButton = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(14, 16);
            Logo.Margin = new Padding(3, 4, 3, 27);
            Logo.Name = "Logo";
            Logo.Size = new Size(343, 67);
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // supportLabel
            // 
            supportLabel.Anchor = AnchorStyles.Bottom;
            supportLabel.AutoSize = true;
            supportLabel.BackColor = Color.Transparent;
            supportLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supportLabel.Location = new Point(248, 557);
            supportLabel.Margin = new Padding(3, 13, 3, 0);
            supportLabel.Name = "supportLabel";
            supportLabel.Size = new Size(425, 40);
            supportLabel.TabIndex = 5;
            supportLabel.Text = "For any questions or concerns, please contact HDX support:\r\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            supportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Left;
            searchText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchText.Location = new Point(14, 155);
            searchText.Margin = new Padding(3, 4, 3, 4);
            searchText.MaxLength = 50;
            searchText.Name = "searchText";
            searchText.Size = new Size(342, 34);
            searchText.TabIndex = 6;
            searchText.TextChanged += SearchText_TextChanged;
            // 
            // enterLabel
            // 
            enterLabel.AutoSize = true;
            enterLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterLabel.Location = new Point(14, 109);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new Size(358, 28);
            enterLabel.TabIndex = 7;
            enterLabel.Text = "Please enter the error code or message :";
            // 
            // errorList
            // 
            errorList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorList.FormattingEnabled = true;
            errorList.ItemHeight = 28;
            errorList.Location = new Point(363, 155);
            errorList.Margin = new Padding(3, 4, 3, 4);
            errorList.Name = "errorList";
            errorList.Size = new Size(517, 312);
            errorList.TabIndex = 8;
            errorList.DoubleClick += ErrorList_DoubleClick;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            errorLabel.Location = new Point(14, 109);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(101, 28);
            errorLabel.TabIndex = 9;
            errorLabel.Text = "errorLabel";
            errorLabel.Visible = false;
            // 
            // statusText
            // 
            statusText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusText.Location = new Point(14, 155);
            statusText.Margin = new Padding(3, 4, 3, 4);
            statusText.Multiline = true;
            statusText.Name = "statusText";
            statusText.ReadOnly = true;
            statusText.ScrollBars = ScrollBars.Vertical;
            statusText.Size = new Size(867, 309);
            statusText.TabIndex = 10;
            statusText.Visible = false;
            // 
            // backButton
            // 
            backButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backButton.Location = new Point(249, 473);
            backButton.Margin = new Padding(3, 4, 3, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(86, 39);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Visible = false;
            backButton.Click += BackButton_Click;
            // 
            // continueButton
            // 
            continueButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            continueButton.Location = new Point(504, 473);
            continueButton.Margin = new Padding(3, 4, 3, 4);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(128, 39);
            continueButton.TabIndex = 12;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            continueButton.Visible = false;
            continueButton.Click += ContinueButton_Click;
            // 
            // homeButton
            // 
            homeButton.AutoSize = true;
            homeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeButton.Location = new Point(792, 16);
            homeButton.Margin = new Padding(3, 4, 3, 4);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(86, 41);
            homeButton.TabIndex = 13;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += HomeButton_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(792, 552);
            btnHelp.Margin = new Padding(3, 4, 3, 4);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(86, 41);
            btnHelp.TabIndex = 14;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // TroubleshooterForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(891, 609);
            Controls.Add(btnHelp);
            Controls.Add(homeButton);
            Controls.Add(continueButton);
            Controls.Add(backButton);
            Controls.Add(statusText);
            Controls.Add(errorLabel);
            Controls.Add(errorList);
            Controls.Add(enterLabel);
            Controls.Add(searchText);
            Controls.Add(supportLabel);
            Controls.Add(Logo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TroubleshooterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HDX WILL - Troubleshooter";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Logo;
        private Label supportLabel;
        private TextBox searchText;
        private Label enterLabel;
        private ListBox errorList;
        private Label errorLabel;
        private TextBox statusText;
        private Button backButton;
        private Button continueButton;
        private Button homeButton;
        private Button btnHelp;
    }
}
