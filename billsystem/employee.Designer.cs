namespace billsystem
{
    partial class employee
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
            this.btn_emp_Save = new System.Windows.Forms.Button();
            this.btn_emp_cancle = new System.Windows.Forms.Button();
            this.txt_emp_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Name";
            // 
            // btn_emp_Save
            // 
            this.btn_emp_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emp_Save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_emp_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_emp_Save.Location = new System.Drawing.Point(539, 278);
            this.btn_emp_Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_Save.Name = "btn_emp_Save";
            this.btn_emp_Save.Size = new System.Drawing.Size(144, 41);
            this.btn_emp_Save.TabIndex = 8;
            this.btn_emp_Save.Text = "Save";
            this.btn_emp_Save.UseVisualStyleBackColor = false;
            this.btn_emp_Save.Click += new System.EventHandler(this.btn_emp_Save_Click);
            // 
            // btn_emp_cancle
            // 
            this.btn_emp_cancle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_emp_cancle.BackColor = System.Drawing.Color.Red;
            this.btn_emp_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_emp_cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_emp_cancle.Location = new System.Drawing.Point(323, 278);
            this.btn_emp_cancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_emp_cancle.Name = "btn_emp_cancle";
            this.btn_emp_cancle.Size = new System.Drawing.Size(139, 41);
            this.btn_emp_cancle.TabIndex = 9;
            this.btn_emp_cancle.Text = "Cancle";
            this.btn_emp_cancle.UseVisualStyleBackColor = false;
            this.btn_emp_cancle.Click += new System.EventHandler(this.btn_emp_cancle_Click);
            // 
            // txt_emp_name
            // 
            this.txt_emp_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_emp_name.Location = new System.Drawing.Point(291, 166);
            this.txt_emp_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp_name.Name = "txt_emp_name";
            this.txt_emp_name.Size = new System.Drawing.Size(641, 22);
            this.txt_emp_name.TabIndex = 0;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(995, 398);
            this.Controls.Add(this.btn_emp_cancle);
            this.Controls.Add(this.btn_emp_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_emp_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "employee";
            this.Text = "employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_emp_Save;
        private System.Windows.Forms.Button btn_emp_cancle;
        private System.Windows.Forms.TextBox txt_emp_name;
    }
}