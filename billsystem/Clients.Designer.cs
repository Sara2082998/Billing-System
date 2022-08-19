namespace billsystem
{
    partial class Clients
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
            this.Clint_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.client_cancle = new System.Windows.Forms.Button();
            this.client_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clint_name
            // 
            this.Clint_name.Location = new System.Drawing.Point(299, 145);
            this.Clint_name.Margin = new System.Windows.Forms.Padding(4);
            this.Clint_name.Name = "Clint_name";
            this.Clint_name.Size = new System.Drawing.Size(632, 22);
            this.Clint_name.TabIndex = 0;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(299, 206);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(632, 22);
            this.phone.TabIndex = 1;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(299, 281);
            this.Number.Margin = new System.Windows.Forms.Padding(4);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(632, 22);
            this.Number.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(299, 346);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(632, 22);
            this.Address.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Clients";
            // 
            // client_cancle
            // 
            this.client_cancle.BackColor = System.Drawing.Color.Red;
            this.client_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_cancle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client_cancle.Location = new System.Drawing.Point(299, 443);
            this.client_cancle.Margin = new System.Windows.Forms.Padding(4);
            this.client_cancle.Name = "client_cancle";
            this.client_cancle.Size = new System.Drawing.Size(131, 39);
            this.client_cancle.TabIndex = 12;
            this.client_cancle.Text = "Cancle";
            this.client_cancle.UseVisualStyleBackColor = false;
            this.client_cancle.Click += new System.EventHandler(this.client_cancle_Click);
            // 
            // client_save
            // 
            this.client_save.BackColor = System.Drawing.Color.Green;
            this.client_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.client_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client_save.Location = new System.Drawing.Point(507, 443);
            this.client_save.Margin = new System.Windows.Forms.Padding(4);
            this.client_save.Name = "client_save";
            this.client_save.Size = new System.Drawing.Size(132, 39);
            this.client_save.TabIndex = 13;
            this.client_save.Text = "Save";
            this.client_save.UseVisualStyleBackColor = false;
            this.client_save.Click += new System.EventHandler(this.client_save_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.client_save);
            this.Controls.Add(this.client_cancle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Clint_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Clint_name;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button client_cancle;
        private System.Windows.Forms.Button client_save;
    }
}