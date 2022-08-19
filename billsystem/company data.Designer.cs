namespace billsystem
{
    partial class company_data
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.notes1 = new System.Windows.Forms.Label();
            this.not1 = new System.Windows.Forms.RichTextBox();
            this.company_name = new System.Windows.Forms.TextBox();
            this.companyname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(404, 317);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 31);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Campany Data Form";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel.Location = new System.Drawing.Point(251, 317);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(85, 31);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // notes1
            // 
            this.notes1.AutoSize = true;
            this.notes1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes1.Location = new System.Drawing.Point(102, 162);
            this.notes1.Name = "notes1";
            this.notes1.Size = new System.Drawing.Size(58, 18);
            this.notes1.TabIndex = 10;
            this.notes1.Text = "Notes";
            this.notes1.Click += new System.EventHandler(this.notes1_Click);
            // 
            // not1
            // 
            this.not1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.not1.Location = new System.Drawing.Point(254, 181);
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(396, 103);
            this.not1.TabIndex = 8;
            this.not1.Text = "";
            // 
            // company_name
            // 
            this.company_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.company_name.Location = new System.Drawing.Point(254, 145);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(396, 20);
            this.company_name.TabIndex = 7;
            // 
            // companyname
            // 
            this.companyname.AutoSize = true;
            this.companyname.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyname.Location = new System.Drawing.Point(102, 144);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(128, 18);
            this.companyname.TabIndex = 6;
            this.companyname.Text = "Company Name";
            // 
            // company_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.notes1);
            this.Controls.Add(this.not1);
            this.Controls.Add(this.company_name);
            this.Controls.Add(this.companyname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "company_data";
            this.Text = "company_data";
            this.Load += new System.EventHandler(this.company_data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label notes1;
        private System.Windows.Forms.RichTextBox not1;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.Label companyname;
    }
}