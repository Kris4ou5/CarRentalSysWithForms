namespace CarRentalForms
{
    partial class RegisterCarForm
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
            btnRegisterCar = new Button();
            txtBrand = new TextBox();
            label1 = new Label();
            txtModel = new TextBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            txtPricePerDay = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterCar
            // 
            btnRegisterCar.Location = new Point(12, 354);
            btnRegisterCar.Name = "btnRegisterCar";
            btnRegisterCar.Size = new Size(562, 57);
            btnRegisterCar.TabIndex = 0;
            btnRegisterCar.Text = "Register";
            btnRegisterCar.UseVisualStyleBackColor = true;
            btnRegisterCar.Click += btnRegisterCar_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(12, 60);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(165, 23);
            txtBrand.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 2;
            label1.Text = "Brand:";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 130);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(165, 23);
            txtModel.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 102);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 4;
            label2.Text = "Model:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(12, 201);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(165, 23);
            cmbCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 173);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 6;
            label3.Text = "Category:";
            // 
            // txtPricePerDay
            // 
            txtPricePerDay.Location = new Point(12, 286);
            txtPricePerDay.Name = "txtPricePerDay";
            txtPricePerDay.Size = new Size(165, 23);
            txtPricePerDay.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.car;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(224, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 297);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 248);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 9;
            label4.Text = "Price Per Day:";
            // 
            // RegisterCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 436);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(txtPricePerDay);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(label2);
            Controls.Add(txtModel);
            Controls.Add(label1);
            Controls.Add(txtBrand);
            Controls.Add(btnRegisterCar);
            Name = "RegisterCarForm";
            Text = "RegisterCarForm";
            Load += RegisterCarForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegisterCar;
        private TextBox txtBrand;
        private Label label1;
        private TextBox txtModel;
        private Label label2;
        private ComboBox cmbCategory;
        private Label label3;
        private TextBox txtPricePerDay;
        private PictureBox pictureBox1;
        private Label label4;
    }
}