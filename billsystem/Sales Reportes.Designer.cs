namespace billsystem
{
    partial class Sales_Reportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.report_cancle = new System.Windows.Forms.Button();
            this.report_save = new System.Windows.Forms.Button();
            this.dgv_Reports = new System.Windows.Forms.DataGridView();
            this.dp_startDate = new System.Windows.Forms.DateTimePicker();
            this.dp_endDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start Date";
            // 
            // report_cancle
            // 
            this.report_cancle.BackColor = System.Drawing.Color.Red;
            this.report_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report_cancle.Location = new System.Drawing.Point(202, 251);
            this.report_cancle.Name = "report_cancle";
            this.report_cancle.Size = new System.Drawing.Size(129, 34);
            this.report_cancle.TabIndex = 5;
            this.report_cancle.Text = "Cancle";
            this.report_cancle.UseVisualStyleBackColor = false;
            // 
            // report_save
            // 
            this.report_save.BackColor = System.Drawing.Color.Green;
            this.report_save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.report_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.report_save.Location = new System.Drawing.Point(404, 251);
            this.report_save.Name = "report_save";
            this.report_save.Size = new System.Drawing.Size(121, 34);
            this.report_save.TabIndex = 6;
            this.report_save.Text = "Generate Report";
            this.report_save.UseVisualStyleBackColor = false;
            this.report_save.Click += new System.EventHandler(this.report_save_Click);
            // 
            // dgv_Reports
            // 
            this.dgv_Reports.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Reports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reports.Location = new System.Drawing.Point(12, 308);
            this.dgv_Reports.Name = "dgv_Reports";
            this.dgv_Reports.RowHeadersWidth = 51;
            this.dgv_Reports.Size = new System.Drawing.Size(776, 130);
            this.dgv_Reports.TabIndex = 7;
            // 
            // dp_startDate
            // 
            this.dp_startDate.Location = new System.Drawing.Point(202, 135);
            this.dp_startDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dp_startDate.Name = "dp_startDate";
            this.dp_startDate.Size = new System.Drawing.Size(428, 20);
            this.dp_startDate.TabIndex = 8;
            // 
            // dp_endDate
            // 
            this.dp_endDate.Location = new System.Drawing.Point(202, 184);
            this.dp_endDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dp_endDate.Name = "dp_endDate";
            this.dp_endDate.Size = new System.Drawing.Size(428, 20);
            this.dp_endDate.TabIndex = 9;
            // 
            // Sales_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dp_endDate);
            this.Controls.Add(this.dp_startDate);
            this.Controls.Add(this.dgv_Reports);
            this.Controls.Add(this.report_save);
            this.Controls.Add(this.report_cancle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_Reportes";
            this.Text = "Sales_Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button report_cancle;
        private System.Windows.Forms.Button report_save;
        private System.Windows.Forms.DataGridView dgv_Reports;
        private System.Windows.Forms.DateTimePicker dp_startDate;
        private System.Windows.Forms.DateTimePicker dp_endDate;
    }
}