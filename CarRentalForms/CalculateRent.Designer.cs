namespace CarRentalForms
{
    partial class CalculateRent
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
            cmbCars = new ComboBox();
            btnCalculate = new Button();
            txtDays = new TextBox();
            txtPromo = new TextBox();
            txtResult = new TextBox();
            lblCars = new Label();
            lblDays = new Label();
            lblPromo = new Label();
            lblPrice = new Label();
            SuspendLayout();
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(41, 60);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(132, 23);
            cmbCars.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCalculate.Location = new Point(41, 286);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 35);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(41, 146);
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(132, 23);
            txtDays.TabIndex = 2;
            // 
            // txtPromo
            // 
            txtPromo.Location = new Point(41, 230);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(132, 23);
            txtPromo.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(41, 381);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(132, 23);
            txtResult.TabIndex = 4;
            // 
            // lblCars
            // 
            lblCars.AutoSize = true;
            lblCars.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblCars.Location = new Point(41, 19);
            lblCars.Name = "lblCars";
            lblCars.Size = new Size(45, 25);
            lblCars.TabIndex = 5;
            lblCars.Text = "Car:";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDays.Location = new Point(41, 109);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(56, 25);
            lblDays.TabIndex = 6;
            lblDays.Text = "Days:";
            // 
            // lblPromo
            // 
            lblPromo.AutoSize = true;
            lblPromo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPromo.Location = new Point(41, 192);
            lblPromo.Name = "lblPromo";
            lblPromo.Size = new Size(105, 25);
            lblPromo.TabIndex = 7;
            lblPromo.Text = "Promo (%):";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPrice.Location = new Point(41, 343);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(103, 25);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Total Price:";
            lblPrice.Click += label4_Click;
            // 
            // CalculateRent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice);
            Controls.Add(lblPromo);
            Controls.Add(lblDays);
            Controls.Add(lblCars);
            Controls.Add(txtResult);
            Controls.Add(txtPromo);
            Controls.Add(txtDays);
            Controls.Add(btnCalculate);
            Controls.Add(cmbCars);
            Name = "CalculateRent";
            Text = "CalculateRent";
            Load += CalculateRent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCars;
        private Button btnCalculate;
        private TextBox txtDays;
        private TextBox txtPromo;
        private TextBox txtResult;
        private Label lblCars;
        private Label lblDays;
        private Label lblPromo;
        private Label lblPrice;
    }
}