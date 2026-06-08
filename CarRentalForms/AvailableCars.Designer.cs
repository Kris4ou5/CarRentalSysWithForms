namespace CarRentalForms
{
    partial class AvailableCars
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
            dtStart = new DateTimePicker();
            dtEnd = new DateTimePicker();
            btnSearch = new Button();
            dgvAvailableCars = new DataGridView();
            lblStartDate = new Label();
            lblEndDate = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).BeginInit();
            SuspendLayout();
            // 
            // dtStart
            // 
            dtStart.Location = new Point(12, 73);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(200, 23);
            dtStart.TabIndex = 0;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(12, 149);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(200, 23);
            dtEnd.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(12, 207);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 55);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // dgvAvailableCars
            // 
            dgvAvailableCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableCars.Location = new Point(268, 41);
            dgvAvailableCars.Name = "dgvAvailableCars";
            dgvAvailableCars.Size = new Size(240, 221);
            dgvAvailableCars.TabIndex = 3;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblStartDate.Location = new Point(12, 41);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(98, 25);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEndDate.Location = new Point(12, 121);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(92, 25);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "End Date:";
            // 
            // AvailableCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 308);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(dgvAvailableCars);
            Controls.Add(btnSearch);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Name = "AvailableCars";
            Text = "AvailableCars";
            Load += AvailableCars_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Button btnSearch;
        private DataGridView dgvAvailableCars;
        private Label lblStartDate;
        private Label lblEndDate;
    }
}