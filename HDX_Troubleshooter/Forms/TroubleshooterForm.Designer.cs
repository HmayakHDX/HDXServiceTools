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
            lblSupport = new Label();
            txtSearch = new TextBox();
            lblInstructions = new Label();
            lstError = new ListBox();
            lblDescription = new Label();
            txtStatus = new TextBox();
            btnBack = new Button();
            btnContinue = new Button();
            btnHome = new Button();
            btnHelp = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(11, 13);
            Logo.Margin = new Padding(2, 3, 2, 22);
            Logo.Name = "Logo";
            Logo.Size = new Size(274, 54);
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // lblSupport
            // 
            lblSupport.Anchor = AnchorStyles.Bottom;
            lblSupport.AutoSize = true;
            lblSupport.BackColor = Color.Transparent;
            lblSupport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupport.Location = new Point(189, 448);
            lblSupport.Margin = new Padding(180, 10, 180, 0);
            lblSupport.Name = "lblSupport";
            lblSupport.Size = new Size(335, 30);
            lblSupport.TabIndex = 5;
            lblSupport.Text = "For any questions or concerns, please contact HDX support:\r\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            lblSupport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(19, 124);
            txtSearch.Margin = new Padding(10, 3, 2, 3);
            txtSearch.MaxLength = 50;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 29);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(19, 89);
            lblInstructions.Margin = new Padding(10, 0, 2, 0);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(235, 21);
            lblInstructions.TabIndex = 7;
            lblInstructions.Text = "Enter the error code or message:";
            // 
            // lstError
            // 
            lstError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstError.FormattingEnabled = true;
            lstError.ItemHeight = 21;
            lstError.Location = new Point(266, 124);
            lstError.Margin = new Padding(10, 3, 10, 30);
            lstError.Name = "lstError";
            lstError.Size = new Size(428, 256);
            lstError.TabIndex = 8;
            lstError.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(19, 89);
            lblDescription.Margin = new Padding(2, 0, 2, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(128, 21);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Error Description";
            lblDescription.Visible = false;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.Window;
            txtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(19, 124);
            txtStatus.Margin = new Padding(2, 3, 2, 30);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(675, 256);
            txtStatus.TabIndex = 10;
            txtStatus.TabStop = false;
            txtStatus.Visible = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(189, 402);
            btnBack.Margin = new Padding(2, 3, 13, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 31);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Visible = false;
            btnBack.Click += BtnBack_Click;
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(422, 402);
            btnContinue.Margin = new Padding(13, 3, 2, 3);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(102, 31);
            btnContinue.TabIndex = 6;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Visible = false;
            btnContinue.Click += BtnContinue_Click;
            // 
            // btnHome
            // 
            btnHome.AutoSize = true;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(634, 13);
            btnHome.Margin = new Padding(2, 3, 2, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(69, 33);
            btnHome.TabIndex = 4;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += BtnHome_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(634, 442);
            btnHelp.Margin = new Padding(2, 3, 2, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(69, 33);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // btnNext
            // 
            btnNext.AutoSize = true;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(306, 402);
            btnNext.Margin = new Padding(2, 3, 2, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 31);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += BtnNext_Click;
            // 
            // TroubleshooterForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(713, 487);
            Controls.Add(btnNext);
            Controls.Add(btnHelp);
            Controls.Add(btnHome);
            Controls.Add(btnContinue);
            Controls.Add(btnBack);
            Controls.Add(txtStatus);
            Controls.Add(lblDescription);
            Controls.Add(lstError);
            Controls.Add(lblInstructions);
            Controls.Add(txtSearch);
            Controls.Add(lblSupport);
            Controls.Add(Logo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
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
        private Label lblSupport;
        private TextBox txtSearch;
        private Label lblInstructions;
        private ListBox lstError;
        private Label lblDescription;
        private TextBox txtStatus;
        private Button btnBack;
        private Button btnContinue;
        private Button btnHome;
        private Button btnHelp;
        private Button btnNext;
    }
}
