namespace CarRentalForms
{
    partial class EditCustomerForm
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
            button1 = new Button();
            txtName = new TextBox();
            label1 = new Label();
            lblLic = new Label();
            lblPhon = new Label();
            label4 = new Label();
            txtLicense = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 384);
            button1.Name = "button1";
            button1.Size = new Size(227, 56);
            button1.TabIndex = 0;
            button1.Text = "Потвърди";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 2;
            label1.Text = "Име:";
            // 
            // lblLic
            // 
            lblLic.AutoSize = true;
            lblLic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLic.Location = new Point(12, 75);
            lblLic.Name = "lblLic";
            lblLic.Size = new Size(169, 25);
            lblLic.TabIndex = 3;
            lblLic.Text = "Номер на книжка:";
            // 
            // lblPhon
            // 
            lblPhon.AutoSize = true;
            lblPhon.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhon.Location = new Point(12, 132);
            lblPhon.Name = "lblPhon";
            lblPhon.Size = new Size(91, 25);
            lblPhon.TabIndex = 4;
            lblPhon.Text = "Телефон:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 5;
            label4.Text = "Email:";
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(12, 103);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(227, 23);
            txtLicense.TabIndex = 6;
            txtLicense.TextChanged += txtLicense_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(227, 23);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 225);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(227, 23);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // EditCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 452);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLicense);
            Controls.Add(label4);
            Controls.Add(lblPhon);
            Controls.Add(lblLic);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "EditCustomerForm";
            Text = "EditCustomerForm";
            Load += EditCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private Label label1;
        private Label lblLic;
        private Label lblPhon;
        private Label label4;
        private TextBox txtLicense;
        private TextBox txtPhone;
        private TextBox txtEmail;
    }
}