namespace CarRentalForms
{
    partial class SendCarToService
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
            lblSelectCar = new Label();
            cmbCars = new ComboBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblSelectCar
            // 
            lblSelectCar.AutoSize = true;
            lblSelectCar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSelectCar.Location = new Point(31, 22);
            lblSelectCar.Name = "lblSelectCar";
            lblSelectCar.Size = new Size(100, 25);
            lblSelectCar.TabIndex = 0;
            lblSelectCar.Text = "Select Car:";
            // 
            // cmbCars
            // 
            cmbCars.FormattingEnabled = true;
            cmbCars.Location = new Point(31, 74);
            cmbCars.Name = "cmbCars";
            cmbCars.Size = new Size(191, 23);
            cmbCars.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSend.Location = new Point(31, 129);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(191, 38);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send To Service:";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // SendCarToService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 213);
            Controls.Add(btnSend);
            Controls.Add(cmbCars);
            Controls.Add(lblSelectCar);
            Name = "SendCarToService";
            Text = "SendCarToService";
            Load += SendCarToService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectCar;
        private ComboBox cmbCars;
        private Button btnSend;
    }
}