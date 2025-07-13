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
            lblSupport = new Label();
            Logo = new PictureBox();
            lblWelcome = new Label();
            btnInstall = new Button();
            btnTroubleshoot = new Button();
            btnQA = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
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
            lblSupport.TabIndex = 6;
            lblSupport.Text = "For any questions or concerns, please contact HDX support:\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            lblSupport.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(173, 99);
            lblWelcome.Margin = new Padding(2, 10, 2, 10);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(358, 42);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "Welcome to the HDX WILL Self Service Application\nPlease select one of the options below:";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInstall
            // 
            btnInstall.AutoSize = true;
            btnInstall.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInstall.Location = new Point(276, 249);
            btnInstall.Margin = new Padding(9, 3, 2, 20);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(162, 55);
            btnInstall.TabIndex = 3;
            btnInstall.Text = "Software Installation\n";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += BtnInstall_Click;
            // 
            // btnTroubleshoot
            // 
            btnTroubleshoot.AutoSize = true;
            btnTroubleshoot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTroubleshoot.Location = new Point(276, 171);
            btnTroubleshoot.Margin = new Padding(266, 20, 266, 20);
            btnTroubleshoot.Name = "btnTroubleshoot";
            btnTroubleshoot.Size = new Size(162, 55);
            btnTroubleshoot.TabIndex = 2;
            btnTroubleshoot.Text = "Troubleshoot\n";
            btnTroubleshoot.UseVisualStyleBackColor = true;
            btnTroubleshoot.Click += BtnTroubleshoot_Click;
            // 
            // btnQA
            // 
            btnQA.AutoSize = true;
            btnQA.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQA.Location = new Point(276, 327);
            btnQA.Margin = new Padding(2, 3, 2, 30);
            btnQA.Name = "btnQA";
            btnQA.Size = new Size(162, 55);
            btnQA.TabIndex = 4;
            btnQA.Text = "QA/QC";
            btnQA.UseVisualStyleBackColor = true;
            btnQA.Click += BtnQA_Click;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(633, 442);
            btnHelp.Margin = new Padding(2, 3, 2, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(69, 33);
            btnHelp.TabIndex = 1;
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
            Controls.Add(btnQA);
            Controls.Add(btnTroubleshoot);
            Controls.Add(btnInstall);
            Controls.Add(lblWelcome);
            Controls.Add(Logo);
            Controls.Add(lblSupport);
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

        private Label lblSupport;
        private PictureBox Logo;
        private Label lblWelcome;
        private Button btnInstall;
        private Button btnTroubleshoot;
        private Button btnQA;
        private Button btnHelp;
    }
}