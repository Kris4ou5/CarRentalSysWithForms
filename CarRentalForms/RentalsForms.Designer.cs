namespace CarRentalForms
{
    partial class RentalsForms
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            dgvRentals = new DataGridView();
            label12 = new Label();
            btnCreateRent = new Button();
            button2 = new Button();
            btnStartRent = new Button();
            btnFinish = new Button();
            btnAddDmg = new Button();
            btnCalculatePayment = new Button();
            btnReturnDeposit = new Button();
            cmbClient = new ComboBox();
            cmbCar = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            txtDeposit = new TextBox();
            txtPricePerDay = new TextBox();
            label10 = new Label();
            dgvDmg = new DataGridView();
            label11 = new Label();
            dgvCars = new DataGridView();
            label13 = new Label();
            txtPromo = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label8 = new Label();
            txtDscDmg = new TextBox();
            label14 = new Label();
            cmbSeverity = new ComboBox();
            btnCreateInspection = new Button();
            lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDmg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(307, 31);
            label1.TabIndex = 0;
            label1.Text = "RENTALS MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 80);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 1;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(333, 80);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Автомобил:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 125);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 3;
            label4.Text = "Начална Дата:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(344, 125);
            label5.Name = "label5";
            label5.Size = new Size(103, 21);
            label5.TabIndex = 4;
            label5.Text = "Крайна Дата:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 556);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 5;
            label6.Text = "Депозит:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(333, 556);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 6;
            label7.Text = "Цена:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 290);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 8;
            label9.Text = "Наеми:";
            // 
            // dgvRentals
            // 
            dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Location = new Point(34, 331);
            dgvRentals.Name = "dgvRentals";
            dgvRentals.Size = new Size(731, 198);
            dgvRentals.TabIndex = 9;
            dgvRentals.CellContentClick += dgvRentals_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(44, 605);
            label12.Name = "label12";
            label12.Size = new Size(160, 21);
            label12.TabIndex = 12;
            label12.Text = "Допълнителна Такса:";
            // 
            // btnCreateRent
            // 
            btnCreateRent.Location = new Point(31, 229);
            btnCreateRent.Name = "btnCreateRent";
            btnCreateRent.Size = new Size(221, 45);
            btnCreateRent.TabIndex = 13;
            btnCreateRent.Text = "Създай наем";
            btnCreateRent.UseVisualStyleBackColor = true;
            btnCreateRent.Click += btnCreateRent_Click;
            // 
            // button2
            // 
            button2.Location = new Point(286, 229);
            button2.Name = "button2";
            button2.Size = new Size(221, 45);
            button2.TabIndex = 14;
            button2.Text = "Отмени наем";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnStartRent
            // 
            btnStartRent.Location = new Point(544, 178);
            btnStartRent.Name = "btnStartRent";
            btnStartRent.Size = new Size(221, 45);
            btnStartRent.TabIndex = 15;
            btnStartRent.Text = "Стартирай";
            btnStartRent.UseVisualStyleBackColor = true;
            btnStartRent.Click += btnStartRent_Click;
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(544, 229);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(221, 45);
            btnFinish.TabIndex = 16;
            btnFinish.Text = "Приключи";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnAddDmg
            // 
            btnAddDmg.Location = new Point(848, 605);
            btnAddDmg.Name = "btnAddDmg";
            btnAddDmg.Size = new Size(221, 45);
            btnAddDmg.TabIndex = 17;
            btnAddDmg.Text = "Добави щети";
            btnAddDmg.UseVisualStyleBackColor = true;
            btnAddDmg.Click += btnAddDmg_Click;
            // 
            // btnCalculatePayment
            // 
            btnCalculatePayment.Location = new Point(34, 648);
            btnCalculatePayment.Name = "btnCalculatePayment";
            btnCalculatePayment.Size = new Size(221, 45);
            btnCalculatePayment.TabIndex = 18;
            btnCalculatePayment.Text = "Обработи Плащане";
            btnCalculatePayment.UseVisualStyleBackColor = true;
            btnCalculatePayment.Click += btnCalculatePayment_Click;
            // 
            // btnReturnDeposit
            // 
            btnReturnDeposit.Location = new Point(286, 648);
            btnReturnDeposit.Name = "btnReturnDeposit";
            btnReturnDeposit.Size = new Size(221, 45);
            btnReturnDeposit.TabIndex = 19;
            btnReturnDeposit.Text = "Върни Депозит";
            btnReturnDeposit.UseVisualStyleBackColor = true;
            btnReturnDeposit.Click += btnReturnDeposit_Click;
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(100, 80);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(227, 23);
            cmbClient.TabIndex = 20;
            // 
            // cmbCar
            // 
            cmbCar.FormattingEnabled = true;
            cmbCar.Location = new Point(432, 78);
            cmbCar.Name = "cmbCar";
            cmbCar.Size = new Size(227, 23);
            cmbCar.TabIndex = 21;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(142, 123);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(196, 23);
            dtpStart.TabIndex = 24;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(453, 125);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(196, 23);
            dtpEnd.TabIndex = 25;
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(131, 556);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(100, 23);
            txtDeposit.TabIndex = 27;
            // 
            // txtPricePerDay
            // 
            txtPricePerDay.Location = new Point(389, 556);
            txtPricePerDay.Name = "txtPricePerDay";
            txtPricePerDay.Size = new Size(100, 23);
            txtPricePerDay.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(798, 31);
            label10.Name = "label10";
            label10.Size = new Size(53, 21);
            label10.TabIndex = 29;
            label10.Text = "Щети:";
            // 
            // dgvDmg
            // 
            dgvDmg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDmg.Location = new Point(798, 66);
            dgvDmg.Name = "dgvDmg";
            dgvDmg.Size = new Size(308, 159);
            dgvDmg.TabIndex = 30;
            dgvDmg.CellContentClick += dgvDmg_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(798, 253);
            label11.Name = "label11";
            label11.Size = new Size(48, 21);
            label11.TabIndex = 31;
            label11.Text = "Коли:";
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(798, 292);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(308, 159);
            dgvCars.TabIndex = 32;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(31, 160);
            label13.Name = "label13";
            label13.Size = new Size(102, 21);
            label13.TabIndex = 33;
            label13.Text = "Промоция%:";
            // 
            // txtPromo
            // 
            txtPromo.Location = new Point(139, 160);
            txtPromo.Name = "txtPromo";
            txtPromo.Size = new Size(100, 23);
            txtPromo.TabIndex = 34;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(798, 475);
            label8.Name = "label8";
            label8.Size = new Size(145, 21);
            label8.TabIndex = 35;
            label8.Text = "Описание на щета:";
            // 
            // txtDscDmg
            // 
            txtDscDmg.Location = new Point(798, 506);
            txtDscDmg.Name = "txtDscDmg";
            txtDscDmg.Size = new Size(308, 23);
            txtDscDmg.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(798, 545);
            label14.Name = "label14";
            label14.Size = new Size(124, 21);
            label14.TabIndex = 37;
            label14.Text = "Тежест на щета:";
            // 
            // cmbSeverity
            // 
            cmbSeverity.FormattingEnabled = true;
            cmbSeverity.Location = new Point(798, 569);
            cmbSeverity.Name = "cmbSeverity";
            cmbSeverity.Size = new Size(175, 23);
            cmbSeverity.TabIndex = 38;
            // 
            // btnCreateInspection
            // 
            btnCreateInspection.Location = new Point(848, 662);
            btnCreateInspection.Name = "btnCreateInspection";
            btnCreateInspection.Size = new Size(221, 45);
            btnCreateInspection.TabIndex = 39;
            btnCreateInspection.Text = "Инспекция";
            btnCreateInspection.UseVisualStyleBackColor = true;
            btnCreateInspection.Click += btnCreateInspection_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl.Location = new Point(210, 605);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 21);
            lbl.TabIndex = 40;
            // 
            // RentalsForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 719);
            Controls.Add(lbl);
            Controls.Add(btnCreateInspection);
            Controls.Add(cmbSeverity);
            Controls.Add(label14);
            Controls.Add(txtDscDmg);
            Controls.Add(label8);
            Controls.Add(txtPromo);
            Controls.Add(label13);
            Controls.Add(dgvCars);
            Controls.Add(label11);
            Controls.Add(dgvDmg);
            Controls.Add(label10);
            Controls.Add(txtPricePerDay);
            Controls.Add(txtDeposit);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbCar);
            Controls.Add(cmbClient);
            Controls.Add(btnReturnDeposit);
            Controls.Add(btnCalculatePayment);
            Controls.Add(btnAddDmg);
            Controls.Add(btnFinish);
            Controls.Add(btnStartRent);
            Controls.Add(button2);
            Controls.Add(btnCreateRent);
            Controls.Add(label12);
            Controls.Add(dgvRentals);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RentalsForms";
            Text = "RentalsForms";
            Load += RentalsForms_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDmg).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private DataGridView dgvRentals;
        private Label label12;
        private Button btnCreateRent;
        private Button button2;
        private Button btnStartRent;
        private Button btnFinish;
        private Button btnAddDmg;
        private Button btnCalculatePayment;
        private Button btnReturnDeposit;
        private ComboBox cmbClient;
        private ComboBox cmbCar;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private TextBox txtDeposit;
        private TextBox txtPricePerDay;
        private Label label10;
        private DataGridView dgvDmg;
        private Label label11;
        private DataGridView dgvCars;
        private Label label13;
        private TextBox txtPromo;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private TextBox txtDscDmg;
        private Label label14;
        private ComboBox cmbSeverity;
        private Button btnCreateInspection;
        private Label lbl;
    }
}