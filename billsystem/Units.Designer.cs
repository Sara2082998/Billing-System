namespace billsystem
{
    partial class Units
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
            this.Untit_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.not1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Unit_cancle = new System.Windows.Forms.Button();
            this.Unit_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Units Form";
            // 
            // Untit_Name
            // 
            this.Untit_Name.Location = new System.Drawing.Point(283, 145);
            this.Untit_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Untit_Name.Name = "Untit_Name";
            this.Untit_Name.Size = new System.Drawing.Size(607, 22);
            this.Untit_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Name";
            // 
            // not1
            // 
            this.not1.Location = new System.Drawing.Point(283, 223);
            this.not1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(607, 126);
            this.not1.TabIndex = 9;
            this.not1.Text = "";
            this.not1.TextChanged += new System.EventHandler(this.not1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nots";
            // 
            // Unit_cancle
            // 
            this.Unit_cancle.BackColor = System.Drawing.Color.Red;
            this.Unit_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unit_cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Unit_cancle.Location = new System.Drawing.Point(283, 396);
            this.Unit_cancle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Unit_cancle.Name = "Unit_cancle";
            this.Unit_cancle.Size = new System.Drawing.Size(145, 50);
            this.Unit_cancle.TabIndex = 12;
            this.Unit_cancle.Text = "Cancle";
            this.Unit_cancle.UseVisualStyleBackColor = false;
            this.Unit_cancle.Click += new System.EventHandler(this.Unit_cancle_Click);
            // 
            // Unit_save
            // 
            this.Unit_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Unit_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unit_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Unit_save.Location = new System.Drawing.Point(516, 396);
            this.Unit_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Unit_save.Name = "Unit_save";
            this.Unit_save.Size = new System.Drawing.Size(133, 50);
            this.Unit_save.TabIndex = 13;
            this.Unit_save.Text = "Save";
            this.Unit_save.UseVisualStyleBackColor = false;
            this.Unit_save.Click += new System.EventHandler(this.Unit_save_Click);
            // 
            // Units
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Unit_save);
            this.Controls.Add(this.Unit_cancle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.not1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Untit_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Units";
            this.Text = "Units";
            this.Load += new System.EventHandler(this.Units_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Untit_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox not1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Unit_cancle;
        private System.Windows.Forms.Button Unit_save;
    }
}