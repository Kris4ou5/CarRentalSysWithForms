namespace CarRentalForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelSideMain = new Panel();
            btnMain = new Button();
            panel3 = new Panel();
            btnCars = new Button();
            btnRentals = new Button();
            btnCustomers = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            logoLabel = new Label();
            panel1 = new Panel();
            pCurPanel = new Panel();
            panelCars = new Panel();
            dgvCars = new DataGridView();
            btnService = new Button();
            btnPriceCalc = new Button();
            btnAvailableCars = new Button();
            btnChangeCarStatus = new Button();
            btnAddCar = new Button();
            panelMain = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridMainCars = new DataGridView();
            dataGridMainRentals = new DataGridView();
            dataGridMainCustomers = new DataGridView();
            CustomerPanel = new Panel();
            dataCustomers = new DataGridView();
            btnRegisterCustomer = new Button();
            btnEditCustomer = new Button();
            button1 = new Button();
            splitter1 = new Splitter();
            label5 = new Label();
            labelCurPanel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnRefresh = new Button();
            panelSideMain.SuspendLayout();
            panelLogo.SuspendLayout();
            pCurPanel.SuspendLayout();
            panelCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMainCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMainRentals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMainCustomers).BeginInit();
            CustomerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataCustomers).BeginInit();
            SuspendLayout();
            // 
            // panelSideMain
            // 
            panelSideMain.BackColor = SystemColors.GrayText;
            panelSideMain.Controls.Add(btnRefresh);
            panelSideMain.Controls.Add(btnMain);
            panelSideMain.Controls.Add(panel3);
            panelSideMain.Controls.Add(btnCars);
            panelSideMain.Controls.Add(btnRentals);
            panelSideMain.Controls.Add(btnCustomers);
            panelSideMain.Controls.Add(panelLogo);
            panelSideMain.Location = new Point(3, 0);
            panelSideMain.Name = "panelSideMain";
            panelSideMain.Size = new Size(216, 575);
            panelSideMain.TabIndex = 0;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.Transparent;
            btnMain.FlatAppearance.BorderColor = Color.DimGray;
            btnMain.FlatStyle = FlatStyle.Flat;
            btnMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMain.Location = new Point(3, 397);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(213, 48);
            btnMain.TabIndex = 5;
            btnMain.Text = "Main";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMain_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(216, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 443);
            panel3.TabIndex = 4;
            // 
            // btnCars
            // 
            btnCars.BackColor = Color.Transparent;
            btnCars.FlatAppearance.BorderColor = Color.DimGray;
            btnCars.FlatStyle = FlatStyle.Flat;
            btnCars.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCars.Location = new Point(3, 316);
            btnCars.Name = "btnCars";
            btnCars.Size = new Size(213, 48);
            btnCars.TabIndex = 2;
            btnCars.Text = "Cars";
            btnCars.UseVisualStyleBackColor = false;
            btnCars.Click += btnCars_Click;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = Color.Transparent;
            btnRentals.FlatAppearance.BorderColor = Color.DimGray;
            btnRentals.FlatStyle = FlatStyle.Flat;
            btnRentals.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRentals.Location = new Point(0, 232);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new Size(213, 48);
            btnRentals.TabIndex = 1;
            btnRentals.Text = "Rentals";
            btnRentals.UseVisualStyleBackColor = false;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.BackColor = Color.Transparent;
            btnCustomers.FlatAppearance.BorderColor = Color.DimGray;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomers.Location = new Point(3, 147);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(213, 48);
            btnCustomers.TabIndex = 0;
            btnCustomers.Text = "Customers";
            btnCustomers.UseVisualStyleBackColor = false;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = SystemColors.MenuHighlight;
            panelLogo.Controls.Add(panel2);
            panelLogo.Controls.Add(logoLabel);
            panelLogo.Controls.Add(panel1);
            panelLogo.Location = new Point(0, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(216, 104);
            panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(216, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 440);
            panel2.TabIndex = 4;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoLabel.Location = new Point(5, 33);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(208, 32);
            logoLabel.TabIndex = 3;
            logoLabel.Text = "CarRentalSystem";
            // 
            // panel1
            // 
            panel1.Location = new Point(213, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(773, 100);
            panel1.TabIndex = 1;
            // 
            // pCurPanel
            // 
            pCurPanel.BackColor = SystemColors.ActiveCaption;
            pCurPanel.Controls.Add(panelCars);
            pCurPanel.Controls.Add(panelMain);
            pCurPanel.Controls.Add(CustomerPanel);
            pCurPanel.Controls.Add(splitter1);
            pCurPanel.Controls.Add(label5);
            pCurPanel.Controls.Add(labelCurPanel);
            pCurPanel.Location = new Point(216, 0);
            pCurPanel.Name = "pCurPanel";
            pCurPanel.Size = new Size(776, 575);
            pCurPanel.TabIndex = 1;
            // 
            // panelCars
            // 
            panelCars.Controls.Add(dgvCars);
            panelCars.Controls.Add(btnService);
            panelCars.Controls.Add(btnPriceCalc);
            panelCars.Controls.Add(btnAvailableCars);
            panelCars.Controls.Add(btnChangeCarStatus);
            panelCars.Controls.Add(btnAddCar);
            panelCars.Location = new Point(0, 90);
            panelCars.Name = "panelCars";
            panelCars.Size = new Size(770, 482);
            panelCars.TabIndex = 2;
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(262, 68);
            dgvCars.Name = "dgvCars";
            dgvCars.Size = new Size(476, 311);
            dgvCars.TabIndex = 5;
            // 
            // btnService
            // 
            btnService.Location = new Point(62, 340);
            btnService.Name = "btnService";
            btnService.Size = new Size(110, 39);
            btnService.TabIndex = 4;
            btnService.Text = "Send Car to Service";
            btnService.UseVisualStyleBackColor = true;
            btnService.Click += btnService_Click;
            // 
            // btnPriceCalc
            // 
            btnPriceCalc.Location = new Point(62, 266);
            btnPriceCalc.Name = "btnPriceCalc";
            btnPriceCalc.Size = new Size(110, 39);
            btnPriceCalc.TabIndex = 3;
            btnPriceCalc.Text = "Calculate Rent";
            btnPriceCalc.UseVisualStyleBackColor = true;
            btnPriceCalc.Click += btnPriceCalc_Click;
            // 
            // btnAvailableCars
            // 
            btnAvailableCars.Location = new Point(62, 203);
            btnAvailableCars.Name = "btnAvailableCars";
            btnAvailableCars.Size = new Size(110, 39);
            btnAvailableCars.TabIndex = 2;
            btnAvailableCars.Text = "Show all Available cars";
            btnAvailableCars.UseVisualStyleBackColor = true;
            btnAvailableCars.Click += btnAvailableCars_Click;
            // 
            // btnChangeCarStatus
            // 
            btnChangeCarStatus.Location = new Point(62, 132);
            btnChangeCarStatus.Name = "btnChangeCarStatus";
            btnChangeCarStatus.Size = new Size(110, 39);
            btnChangeCarStatus.TabIndex = 1;
            btnChangeCarStatus.Text = "Change Car Status";
            btnChangeCarStatus.UseVisualStyleBackColor = true;
            btnChangeCarStatus.Click += btnChangeCarStatus_Click;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(62, 66);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(110, 39);
            btnAddCar.TabIndex = 0;
            btnAddCar.Text = "Register Car";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(dataGridMainCars);
            panelMain.Controls.Add(dataGridMainRentals);
            panelMain.Controls.Add(dataGridMainCustomers);
            panelMain.Location = new Point(3, 109);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(770, 472);
            panelMain.TabIndex = 4;
            panelMain.Paint += panelMain_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(525, 75);
            label4.Name = "label4";
            label4.Size = new Size(74, 32);
            label4.TabIndex = 6;
            label4.Text = "Коли";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(259, 75);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 5;
            label3.Text = "Наеми";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 75);
            label2.Name = "label2";
            label2.Size = new Size(114, 32);
            label2.TabIndex = 4;
            label2.Text = "Клиенти";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 13);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 3;
            label1.Text = "Добре дошли!";
            // 
            // dataGridMainCars
            // 
            dataGridMainCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainCars.Location = new Point(522, 129);
            dataGridMainCars.Name = "dataGridMainCars";
            dataGridMainCars.Size = new Size(245, 301);
            dataGridMainCars.TabIndex = 2;
            // 
            // dataGridMainRentals
            // 
            dataGridMainRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainRentals.Location = new Point(259, 129);
            dataGridMainRentals.Name = "dataGridMainRentals";
            dataGridMainRentals.Size = new Size(245, 301);
            dataGridMainRentals.TabIndex = 1;
            // 
            // dataGridMainCustomers
            // 
            dataGridMainCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMainCustomers.Location = new Point(13, 129);
            dataGridMainCustomers.Name = "dataGridMainCustomers";
            dataGridMainCustomers.Size = new Size(230, 301);
            dataGridMainCustomers.TabIndex = 0;
            // 
            // CustomerPanel
            // 
            CustomerPanel.Controls.Add(dataCustomers);
            CustomerPanel.Controls.Add(btnRegisterCustomer);
            CustomerPanel.Controls.Add(btnEditCustomer);
            CustomerPanel.Controls.Add(button1);
            CustomerPanel.Location = new Point(6, 109);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(770, 443);
            CustomerPanel.TabIndex = 1;
            CustomerPanel.Paint += CustomerPanel_Paint;
            // 
            // dataCustomers
            // 
            dataCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCustomers.Location = new Point(259, 32);
            dataCustomers.Name = "dataCustomers";
            dataCustomers.Size = new Size(473, 398);
            dataCustomers.TabIndex = 1;
            // 
            // btnRegisterCustomer
            // 
            btnRegisterCustomer.Location = new Point(28, 62);
            btnRegisterCustomer.Name = "btnRegisterCustomer";
            btnRegisterCustomer.Size = new Size(206, 45);
            btnRegisterCustomer.TabIndex = 0;
            btnRegisterCustomer.Text = "Register Customer";
            btnRegisterCustomer.UseVisualStyleBackColor = true;
            btnRegisterCustomer.Click += btnRegisterCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(28, 153);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(206, 46);
            btnEditCustomer.TabIndex = 2;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // button1
            // 
            button1.Location = new Point(28, 247);
            button1.Name = "button1";
            button1.Size = new Size(206, 46);
            button1.TabIndex = 3;
            button1.Text = "Customer Rental History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 575);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 75);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 5;
            // 
            // labelCurPanel
            // 
            labelCurPanel.AutoSize = true;
            labelCurPanel.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurPanel.Location = new Point(284, 27);
            labelCurPanel.Name = "labelCurPanel";
            labelCurPanel.Size = new Size(77, 40);
            labelCurPanel.TabIndex = 0;
            labelCurPanel.Text = "TEST";
            labelCurPanel.Click += labelCurPanel_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(3, 502);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(204, 28);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 575);
            Controls.Add(pCurPanel);
            Controls.Add(panelSideMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelSideMain.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            pCurPanel.ResumeLayout(false);
            pCurPanel.PerformLayout();
            panelCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMainCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMainRentals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridMainCustomers).EndInit();
            CustomerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMain;
        private Panel panelLogo;
        private Panel panel1;
        private Panel pCurPanel;
        private Button btnCustomers;
        private Button btnCars;
        private Button btnRentals;
        private Label logoLabel;
        private Label labelCurPanel;
        private Panel CustomerPanel;
        private Button button1;
        private Button btnEditCustomer;
        private DataGridView dataCustomers;
        private Button btnRegisterCustomer;
        private Panel panel2;
        private Panel panel3;
        private Panel panelMain;
        private Button btnMain;
        private DataGridView dataGridMainCustomers;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridMainCars;
        private DataGridView dataGridMainRentals;
        private Splitter splitter1;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Panel panelCars;
        private Button btnAvailableCars;
        private Button btnChangeCarStatus;
        private Button btnAddCar;
        private Button btnService;
        private Button btnPriceCalc;
        private DataGridView dgvCars;
        private Button btnRefresh;
    }
}
