namespace billsystem
{
    partial class Types
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
            this.cb_Type_campany_name = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_Name = new System.Windows.Forms.TextBox();
            this.not1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.type_cancle = new System.Windows.Forms.Button();
            this.Type_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Types Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_Type_campany_name
            // 
            this.cb_Type_campany_name.FormattingEnabled = true;
            this.cb_Type_campany_name.Location = new System.Drawing.Point(228, 112);
            this.cb_Type_campany_name.Name = "cb_Type_campany_name";
            this.cb_Type_campany_name.Size = new System.Drawing.Size(471, 21);
            this.cb_Type_campany_name.TabIndex = 1;
            this.cb_Type_campany_name.SelectedIndexChanged += new System.EventHandler(this.cb_Type_campany_name_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Campany Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type Name";
            // 
            // Type_Name
            // 
            this.Type_Name.Location = new System.Drawing.Point(228, 162);
            this.Type_Name.Name = "Type_Name";
            this.Type_Name.Size = new System.Drawing.Size(471, 20);
            this.Type_Name.TabIndex = 4;
            // 
            // not1
            // 
            this.not1.Location = new System.Drawing.Point(228, 211);
            this.not1.Name = "not1";
            this.not1.Size = new System.Drawing.Size(471, 110);
            this.not1.TabIndex = 9;
            this.not1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Notes";
            // 
            // type_cancle
            // 
            this.type_cancle.BackColor = System.Drawing.Color.Red;
            this.type_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.type_cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.type_cancle.Location = new System.Drawing.Point(228, 349);
            this.type_cancle.Name = "type_cancle";
            this.type_cancle.Size = new System.Drawing.Size(89, 32);
            this.type_cancle.TabIndex = 11;
            this.type_cancle.Text = "Cancel";
            this.type_cancle.UseVisualStyleBackColor = false;
            this.type_cancle.Click += new System.EventHandler(this.type_cancle_Click);
            // 
            // Type_save
            // 
            this.Type_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Type_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Type_save.Location = new System.Drawing.Point(362, 349);
            this.Type_save.Name = "Type_save";
            this.Type_save.Size = new System.Drawing.Size(98, 32);
            this.Type_save.TabIndex = 12;
            this.Type_save.Text = "Save";
            this.Type_save.UseVisualStyleBackColor = false;
            this.Type_save.Click += new System.EventHandler(this.Type_save_Click);
            // 
            // Types
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Type_save);
            this.Controls.Add(this.type_cancle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.not1);
            this.Controls.Add(this.Type_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Type_campany_name);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Types";
            this.Text = "Types";
            this.Load += new System.EventHandler(this.Types_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Type_campany_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Type_Name;
        private System.Windows.Forms.RichTextBox not1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button type_cancle;
        private System.Windows.Forms.Button Type_save;
    }
}