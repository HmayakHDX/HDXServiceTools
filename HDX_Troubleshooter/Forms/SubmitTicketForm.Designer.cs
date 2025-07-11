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
            supportLabel = new Label();
            instructionsLabel = new Label();
            txtClinicName = new TextBox();
            clinicNamelabel = new Label();
            dentistNamelabel = new Label();
            txtDentistName = new TextBox();
            emailContactLabel = new Label();
            txtEmail = new TextBox();
            phoneContactLabel = new Label();
            txtPhone = new TextBox();
            descriptionLabel = new Label();
            txtDescription = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            lblTVId = new Label();
            txtTVId = new TextBox();
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
            // supportLabel
            // 
            supportLabel.Anchor = AnchorStyles.Bottom;
            supportLabel.AutoSize = true;
            supportLabel.BackColor = Color.Transparent;
            supportLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supportLabel.Location = new Point(189, 448);
            supportLabel.Margin = new Padding(180, 10, 180, 0);
            supportLabel.Name = "supportLabel";
            supportLabel.Size = new Size(335, 30);
            supportLabel.TabIndex = 9;
            supportLabel.Text = "For any questions or concerns, please contact HDX support:\n888–850–8810 (Ext. 3) | support@hdxwillna.com";
            supportLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // instructionsLabel
            // 
            instructionsLabel.AutoSize = true;
            instructionsLabel.BackColor = Color.Transparent;
            instructionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionsLabel.Location = new Point(184, 87);
            instructionsLabel.Margin = new Padding(175, 10, 175, 10);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(344, 21);
            instructionsLabel.TabIndex = 10;
            instructionsLabel.Text = "Please fill out all required fields and click Submit";
            instructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClinicName
            // 
            txtClinicName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClinicName.Location = new Point(19, 150);
            txtClinicName.Margin = new Padding(2, 3, 2, 5);
            txtClinicName.Name = "txtClinicName";
            txtClinicName.Size = new Size(379, 29);
            txtClinicName.TabIndex = 12;
            // 
            // clinicNamelabel
            // 
            clinicNamelabel.AutoSize = true;
            clinicNamelabel.BackColor = Color.Transparent;
            clinicNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNamelabel.Location = new Point(19, 123);
            clinicNamelabel.Margin = new Padding(10, 10, 2, 3);
            clinicNamelabel.Name = "clinicNamelabel";
            clinicNamelabel.Size = new Size(101, 21);
            clinicNamelabel.TabIndex = 16;
            clinicNamelabel.Text = "Clinic Name*";
            clinicNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dentistNamelabel
            // 
            dentistNamelabel.AutoSize = true;
            dentistNamelabel.BackColor = Color.Transparent;
            dentistNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistNamelabel.Location = new Point(450, 123);
            dentistNamelabel.Margin = new Padding(2, 5, 2, 10);
            dentistNamelabel.Name = "dentistNamelabel";
            dentistNamelabel.Size = new Size(110, 21);
            dentistNamelabel.TabIndex = 17;
            dentistNamelabel.Text = "Doctor Name*";
            dentistNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDentistName
            // 
            txtDentistName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDentistName.Location = new Point(450, 150);
            txtDentistName.Margin = new Padding(50, 10, 10, 5);
            txtDentistName.Name = "txtDentistName";
            txtDentistName.Size = new Size(244, 29);
            txtDentistName.TabIndex = 18;
            // 
            // emailContactLabel
            // 
            emailContactLabel.AutoSize = true;
            emailContactLabel.BackColor = Color.Transparent;
            emailContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailContactLabel.Location = new Point(19, 189);
            emailContactLabel.Margin = new Padding(2, 5, 2, 3);
            emailContactLabel.Name = "emailContactLabel";
            emailContactLabel.Size = new Size(112, 21);
            emailContactLabel.TabIndex = 19;
            emailContactLabel.Text = "Email Contact*";
            emailContactLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // phoneContactLabel
            // 
            phoneContactLabel.AutoSize = true;
            phoneContactLabel.BackColor = Color.Transparent;
            phoneContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneContactLabel.Location = new Point(450, 189);
            phoneContactLabel.Margin = new Padding(2, 5, 2, 10);
            phoneContactLabel.Name = "phoneContactLabel";
            phoneContactLabel.Size = new Size(111, 21);
            phoneContactLabel.TabIndex = 21;
            phoneContactLabel.Text = "Phone Contact";
            phoneContactLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(19, 255);
            descriptionLabel.Margin = new Padding(2, 5, 2, 3);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(96, 21);
            descriptionLabel.TabIndex = 23;
            descriptionLabel.Text = "Description*";
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblTVId
            // 
            lblTVId.AutoSize = true;
            lblTVId.BackColor = Color.Transparent;
            lblTVId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTVId.Location = new Point(450, 255);
            lblTVId.Margin = new Padding(2, 10, 2, 3);
            lblTVId.Name = "lblTVId";
            lblTVId.Size = new Size(113, 21);
            lblTVId.TabIndex = 28;
            lblTVId.Text = "TeamViewer ID";
            lblTVId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTVId
            // 
            txtTVId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTVId.Location = new Point(450, 282);
            txtTVId.Margin = new Padding(2, 3, 10, 5);
            txtTVId.Name = "txtTVId";
            txtTVId.Size = new Size(244, 29);
            txtTVId.TabIndex = 29;
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
            Controls.Add(txtTVId);
            Controls.Add(lblTVId);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtDescription);
            Controls.Add(descriptionLabel);
            Controls.Add(txtPhone);
            Controls.Add(phoneContactLabel);
            Controls.Add(txtEmail);
            Controls.Add(emailContactLabel);
            Controls.Add(txtDentistName);
            Controls.Add(dentistNamelabel);
            Controls.Add(clinicNamelabel);
            Controls.Add(txtClinicName);
            Controls.Add(instructionsLabel);
            Controls.Add(supportLabel);
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
        private Label supportLabel;
        private Label instructionsLabel;
        private TextBox txtClinicName;
        private Label clinicNamelabel;
        private Label dentistNamelabel;
        private TextBox txtDentistName;
        private Label emailContactLabel;
        private TextBox txtEmail;
        private Label phoneContactLabel;
        private TextBox txtPhone;
        private Label descriptionLabel;
        private TextBox txtDescription;
        private Button btnSubmit;
        private Button btnCancel;
        private Label lblTVId;
        private TextBox txtTVId;
        private Label lblTVPassword;
        private TextBox txtTVPassword;
    }
}