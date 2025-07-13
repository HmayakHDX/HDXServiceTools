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
            btnHome = new Button();
            lblSupport = new Label();
            Logo = new PictureBox();
            lblOptions = new Label();
            prgInstall = new ProgressBar();
            txtStatus = new TextBox();
            btnContinue = new Button();
            btnFinish = new Button();
            btnHelp = new Button();
            lstOptions = new ListBox();
            rtbDescription = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.AutoSize = true;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.Location = new Point(634, 13);
            btnHome.Margin = new Padding(2, 3, 2, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(69, 33);
            btnHome.TabIndex = 2;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += BtnHome_Click;
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
            lblSupport.TabIndex = 15;
            lblSupport.Text = "For any questions or concerns, please contact HDX support:\r\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            lblSupport.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblOptions
            // 
            lblOptions.AutoSize = true;
            lblOptions.BackColor = Color.Transparent;
            lblOptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOptions.Location = new Point(19, 89);
            lblOptions.Margin = new Padding(10, 0, 151, 10);
            lblOptions.Name = "lblOptions";
            lblOptions.Size = new Size(216, 21);
            lblOptions.TabIndex = 17;
            lblOptions.Text = "Please select an option below:";
            lblOptions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // prgInstall
            // 
            prgInstall.BackColor = SystemColors.Control;
            prgInstall.Location = new Point(19, 364);
            prgInstall.Margin = new Padding(100, 3, 100, 3);
            prgInstall.Name = "prgInstall";
            prgInstall.Size = new Size(675, 25);
            prgInstall.TabIndex = 20;
            prgInstall.Visible = false;
            // 
            // txtStatus
            // 
            txtStatus.BackColor = SystemColors.Control;
            txtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(19, 123);
            txtStatus.Margin = new Padding(50, 3, 10, 3);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(675, 235);
            txtStatus.TabIndex = 21;
            txtStatus.TabStop = false;
            txtStatus.Visible = false;
            // 
            // btnContinue
            // 
            btnContinue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContinue.Location = new Point(306, 402);
            btnContinue.Margin = new Padding(13, 3, 275, 3);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(102, 31);
            btnContinue.TabIndex = 10;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += BtnContinue_Click;
            // 
            // btnFinish
            // 
            btnFinish.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinish.Location = new Point(306, 402);
            btnFinish.Margin = new Padding(2, 3, 2, 3);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(102, 31);
            btnFinish.TabIndex = 11;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Visible = false;
            btnFinish.Click += BtnFinish_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(634, 442);
            btnHelp.Margin = new Padding(2, 3, 2, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(69, 33);
            btnHelp.TabIndex = 1;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += BtnHelp_Click;
            // 
            // lstOptions
            // 
            lstOptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstOptions.FormattingEnabled = true;
            lstOptions.ItemHeight = 21;
            lstOptions.Location = new Point(19, 123);
            lstOptions.Margin = new Padding(10, 3, 10, 30);
            lstOptions.Name = "lstOptions";
            lstOptions.Size = new Size(266, 235);
            lstOptions.TabIndex = 23;
            lstOptions.TabStop = false;
            lstOptions.SelectedIndexChanged += LstOptions_SelectedIndexChanged;
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.LightGray;
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbDescription.Location = new Point(362, 123);
            rtbDescription.Margin = new Padding(3, 3, 10, 3);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.ReadOnly = true;
            rtbDescription.ScrollBars = RichTextBoxScrollBars.None;
            rtbDescription.Size = new Size(332, 235);
            rtbDescription.TabIndex = 25;
            rtbDescription.TabStop = false;
            rtbDescription.Text = "";
            // 
            // InstallerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            ClientSize = new Size(713, 487);
            Controls.Add(rtbDescription);
            Controls.Add(lstOptions);
            Controls.Add(btnHelp);
            Controls.Add(btnFinish);
            Controls.Add(btnContinue);
            Controls.Add(txtStatus);
            Controls.Add(prgInstall);
            Controls.Add(lblOptions);
            Controls.Add(Logo);
            Controls.Add(lblSupport);
            Controls.Add(btnHome);
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

        private Button btnHome;
        private Label lblSupport;
        private PictureBox Logo;
        private Label lblOptions;
        private ProgressBar prgInstall;
        private TextBox txtStatus;
        private Button btnContinue;
        private Button btnFinish;
        private Button btnHelp;
        private ListBox lstOptions;
        private RichTextBox rtbDescription;
    }
}