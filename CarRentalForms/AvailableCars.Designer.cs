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
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).BeginInit();
            SuspendLayout();
            // 
            // dtStart
            // 
            dtStart.Location = new Point(12, 40);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(200, 23);
            dtStart.TabIndex = 0;
            // 
            // dtEnd
            // 
            dtEnd.Location = new Point(12, 89);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(200, 23);
            dtEnd.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearch.Location = new Point(12, 142);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvAvailableCars
            // 
            dgvAvailableCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableCars.Location = new Point(263, 40);
            dgvAvailableCars.Name = "dgvAvailableCars";
            dgvAvailableCars.Size = new Size(240, 150);
            dgvAvailableCars.TabIndex = 3;
            // 
            // AvailableCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 233);
            Controls.Add(dgvAvailableCars);
            Controls.Add(btnSearch);
            Controls.Add(dtEnd);
            Controls.Add(dtStart);
            Name = "AvailableCars";
            Text = "AvailableCars";
            Load += AvailableCars_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtStart;
        private DateTimePicker dtEnd;
        private Button btnSearch;
        private DataGridView dgvAvailableCars;
    }
}