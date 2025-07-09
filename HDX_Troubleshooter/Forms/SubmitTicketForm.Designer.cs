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
            Logo.Margin = new Padding(2, 3, 2, 22);
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
            supportLabel.Location = new Point(198, 446);
            supportLabel.Margin = new Padding(2, 10, 2, 0);
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
            instructionsLabel.Location = new Point(166, 98);
            instructionsLabel.Margin = new Padding(2, 10, 2, 10);
            instructionsLabel.Name = "instructionsLabel";
            instructionsLabel.Size = new Size(282, 21);
            instructionsLabel.TabIndex = 10;
            instructionsLabel.Text = "Please fill out all fields and click submit.";
            instructionsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtClinicName
            // 
            txtClinicName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClinicName.Location = new Point(129, 138);
            txtClinicName.Margin = new Padding(2, 3, 2, 3);
            txtClinicName.Name = "txtClinicName";
            txtClinicName.Size = new Size(357, 29);
            txtClinicName.TabIndex = 12;
            // 
            // clinicNamelabel
            // 
            clinicNamelabel.AutoSize = true;
            clinicNamelabel.BackColor = Color.Transparent;
            clinicNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clinicNamelabel.Location = new Point(11, 142);
            clinicNamelabel.Margin = new Padding(2, 10, 2, 10);
            clinicNamelabel.Name = "clinicNamelabel";
            clinicNamelabel.Size = new Size(94, 21);
            clinicNamelabel.TabIndex = 16;
            clinicNamelabel.Text = "Clinic name:";
            clinicNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dentistNamelabel
            // 
            dentistNamelabel.AutoSize = true;
            dentistNamelabel.BackColor = Color.Transparent;
            dentistNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dentistNamelabel.Location = new Point(11, 186);
            dentistNamelabel.Margin = new Padding(2, 10, 2, 10);
            dentistNamelabel.Name = "dentistNamelabel";
            dentistNamelabel.Size = new Size(105, 21);
            dentistNamelabel.TabIndex = 17;
            dentistNamelabel.Text = "Dentist name:";
            dentistNamelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDentistName
            // 
            txtDentistName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDentistName.Location = new Point(129, 183);
            txtDentistName.Margin = new Padding(2, 3, 2, 3);
            txtDentistName.Name = "txtDentistName";
            txtDentistName.Size = new Size(357, 29);
            txtDentistName.TabIndex = 18;
            // 
            // emailContactLabel
            // 
            emailContactLabel.AutoSize = true;
            emailContactLabel.BackColor = Color.Transparent;
            emailContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailContactLabel.Location = new Point(11, 230);
            emailContactLabel.Margin = new Padding(2, 10, 2, 10);
            emailContactLabel.Name = "emailContactLabel";
            emailContactLabel.Size = new Size(108, 21);
            emailContactLabel.TabIndex = 19;
            emailContactLabel.Text = "Contact email:";
            emailContactLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(129, 226);
            txtEmail.Margin = new Padding(2, 3, 2, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 29);
            txtEmail.TabIndex = 20;
            // 
            // phoneContactLabel
            // 
            phoneContactLabel.AutoSize = true;
            phoneContactLabel.BackColor = Color.Transparent;
            phoneContactLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneContactLabel.Location = new Point(11, 273);
            phoneContactLabel.Margin = new Padding(2, 10, 2, 10);
            phoneContactLabel.Name = "phoneContactLabel";
            phoneContactLabel.Size = new Size(114, 21);
            phoneContactLabel.TabIndex = 21;
            phoneContactLabel.Text = "Contact phone:";
            phoneContactLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(129, 270);
            txtPhone.Margin = new Padding(2, 3, 2, 3);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(357, 29);
            txtPhone.TabIndex = 22;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.BackColor = Color.Transparent;
            descriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionLabel.Location = new Point(11, 317);
            descriptionLabel.Margin = new Padding(2, 10, 2, 10);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(92, 21);
            descriptionLabel.TabIndex = 23;
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(129, 314);
            txtDescription.Margin = new Padding(2, 3, 2, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(357, 115);
            txtDescription.TabIndex = 24;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(558, 317);
            btnSubmit.Margin = new Padding(2, 3, 2, 3);
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
            btnCancel.Location = new Point(558, 401);
            btnCancel.Margin = new Padding(2, 3, 2, 3);
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
            lblTVId.Location = new Point(558, 98);
            lblTVId.Margin = new Padding(2, 10, 2, 10);
            lblTVId.Name = "lblTVId";
            lblTVId.Size = new Size(116, 21);
            lblTVId.TabIndex = 28;
            lblTVId.Text = "TeamViewer ID:";
            lblTVId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTVId
            // 
            txtTVId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTVId.Location = new Point(539, 138);
            txtTVId.Margin = new Padding(2, 3, 2, 3);
            txtTVId.Name = "txtTVId";
            txtTVId.Size = new Size(153, 29);
            txtTVId.TabIndex = 29;
            // 
            // lblTVPassword
            // 
            lblTVPassword.AutoSize = true;
            lblTVPassword.BackColor = Color.Transparent;
            lblTVPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTVPassword.Location = new Point(539, 191);
            lblTVPassword.Margin = new Padding(2, 10, 2, 10);
            lblTVPassword.Name = "lblTVPassword";
            lblTVPassword.Size = new Size(167, 21);
            lblTVPassword.TabIndex = 30;
            lblTVPassword.Text = "TeamViewer Password:";
            lblTVPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTVPassword
            // 
            txtTVPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTVPassword.Location = new Point(539, 226);
            txtTVPassword.Margin = new Padding(2, 3, 2, 3);
            txtTVPassword.Name = "txtTVPassword";
            txtTVPassword.Size = new Size(153, 29);
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