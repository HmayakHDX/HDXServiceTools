namespace HDX_ServiceTools.Forms
{
    partial class SubmitTicketForm
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
            Logo = new PictureBox();
            lblSupport = new Label();
            lblInstructions = new Label();
            txtClinic = new TextBox();
            lblClinic = new Label();
            lblDentist = new Label();
            txtDentist = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblTVID = new Label();
            txtTVID = new TextBox();
            lblTVPassword = new Label();
            txtTVPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.BackColor = Color.Transparent;
            Logo.Location = new Point(11, 13);
            Logo.Margin = new Padding(2, 3, 2, 10);
            Logo.Name = "Logo";
            Logo.Size = new Size(274, 54);
            Logo.TabIndex = 8;
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
            lblSupport.TabIndex = 9;
            lblSupport.Text = "For any questions or concerns, please contact HDX support:\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            lblSupport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = Color.Transparent;
            lblInstructions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(184, 87);
            lblInstructions.Margin = new Padding(175, 10, 175, 10);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(344, 21);
            lblInstructions.TabIndex = 10;
            lblInstructions.Text = "Please fill out all required fields and click Submit";
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClinic
            // 
            txtClinic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClinic.Location = new Point(19, 150);
            txtClinic.Margin = new Padding(2, 3, 2, 5);
            txtClinic.Name = "txtClinic";
            txtClinic.Size = new Size(379, 29);
            txtClinic.TabIndex = 12;
            // 
            // lblClinic
            // 
            lblClinic.AutoSize = true;
            lblClinic.BackColor = Color.Transparent;
            lblClinic.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClinic.Location = new Point(19, 123);
            lblClinic.Margin = new Padding(10, 10, 2, 3);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(101, 21);
            lblClinic.TabIndex = 16;
            lblClinic.Text = "Clinic Name*";
            lblClinic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDentist
            // 
            lblDentist.AutoSize = true;
            lblDentist.BackColor = Color.Transparent;
            lblDentist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDentist.Location = new Point(450, 123);
            lblDentist.Margin = new Padding(2, 5, 2, 10);
            lblDentist.Name = "lblDentist";
            lblDentist.Size = new Size(110, 21);
            lblDentist.TabIndex = 17;
            lblDentist.Text = "Doctor Name*";
            lblDentist.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDentist
            // 
            txtDentist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDentist.Location = new Point(450, 150);
            txtDentist.Margin = new Padding(50, 10, 10, 5);
            txtDentist.Name = "txtDentist";
            txtDentist.Size = new Size(244, 29);
            txtDentist.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(19, 189);
            lblEmail.Margin = new Padding(2, 5, 2, 3);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(112, 21);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email Contact*";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(19, 216);
            txtEmail.Margin = new Padding(2, 3, 2, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(379, 29);
            txtEmail.TabIndex = 20;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(450, 189);
            lblPhone.Margin = new Padding(2, 5, 2, 10);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(111, 21);
            lblPhone.TabIndex = 21;
            lblPhone.Text = "Phone Contact";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(450, 216);
            txtPhone.Margin = new Padding(2, 10, 2, 5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(244, 29);
            txtPhone.TabIndex = 22;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(19, 255);
            lblDescription.Margin = new Padding(2, 5, 2, 3);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 21);
            lblDescription.TabIndex = 23;
            lblDescription.Text = "Description*";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(19, 282);
            txtDescription.Margin = new Padding(2, 3, 2, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(379, 146);
            txtDescription.TabIndex = 24;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(450, 397);
            btnSubmit.Margin = new Padding(2, 10, 2, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(102, 31);
            btnSubmit.TabIndex = 25;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(592, 397);
            btnCancel.Margin = new Padding(2, 3, 10, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 31);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // lblTVID
            // 
            lblTVID.AutoSize = true;
            lblTVID.BackColor = Color.Transparent;
            lblTVID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTVID.Location = new Point(450, 255);
            lblTVID.Margin = new Padding(2, 10, 2, 3);
            lblTVID.Name = "lblTVID";
            lblTVID.Size = new Size(113, 21);
            lblTVID.TabIndex = 28;
            lblTVID.Text = "TeamViewer ID";
            lblTVID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTVID
            // 
            txtTVID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTVID.Location = new Point(450, 282);
            txtTVID.Margin = new Padding(2, 3, 10, 5);
            txtTVID.Name = "txtTVID";
            txtTVID.Size = new Size(244, 29);
            txtTVID.TabIndex = 29;
            // 
            // lblTVPassword
            // 
            lblTVPassword.AutoSize = true;
            lblTVPassword.BackColor = Color.Transparent;
            lblTVPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTVPassword.Location = new Point(450, 321);
            lblTVPassword.Margin = new Padding(2, 5, 2, 3);
            lblTVPassword.Name = "lblTVPassword";
            lblTVPassword.Size = new Size(164, 21);
            lblTVPassword.TabIndex = 30;
            lblTVPassword.Text = "TeamViewer Password";
            lblTVPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTVPassword
            // 
            txtTVPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTVPassword.Location = new Point(450, 348);
            txtTVPassword.Margin = new Padding(2, 3, 2, 10);
            txtTVPassword.Name = "txtTVPassword";
            txtTVPassword.Size = new Size(244, 29);
            txtTVPassword.TabIndex = 31;
            // 
            // SubmitTicketForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.LightGray;
            ClientSize = new Size(713, 487);
            Controls.Add(txtTVPassword);
            Controls.Add(lblTVPassword);
            Controls.Add(txtTVID);
            Controls.Add(lblTVID);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDentist);
            Controls.Add(lblDentist);
            Controls.Add(lblClinic);
            Controls.Add(txtClinic);
            Controls.Add(lblInstructions);
            Controls.Add(lblSupport);
            Controls.Add(Logo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "SubmitTicketForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HDX WILL - Submit Ticket";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label lblSupport;
        private Label lblInstructions;
        private TextBox txtClinic;
        private Label lblClinic;
        private Label lblDentist;
        private TextBox txtDentist;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblTVID;
        private TextBox txtTVID;
        private Label lblTVPassword;
        private TextBox txtTVPassword;
    }
}