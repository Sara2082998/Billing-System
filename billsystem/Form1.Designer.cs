namespace billsystem
{
    partial class Form1
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
            this.mainpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_clint = new System.Windows.Forms.Button();
            this.btn_items = new System.Windows.Forms.Button();
            this.btn_sales_reportes = new System.Windows.Forms.Button();
            this.btn_sales_invoice = new System.Windows.Forms.Button();
            this.btn_units = new System.Windows.Forms.Button();
            this.btn_types = new System.Windows.Forms.Button();
            this.btn_companyname = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainpanel.Controls.Add(this.button1);
            this.mainpanel.Controls.Add(this.btn_clint);
            this.mainpanel.Controls.Add(this.btn_items);
            this.mainpanel.Controls.Add(this.btn_sales_reportes);
            this.mainpanel.Controls.Add(this.btn_sales_invoice);
            this.mainpanel.Controls.Add(this.btn_units);
            this.mainpanel.Controls.Add(this.btn_types);
            this.mainpanel.Controls.Add(this.btn_companyname);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainpanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(185, 486);
            this.mainpanel.TabIndex = 0;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::billsystem.Properties.Resources.empp;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_clint
            // 
            this.btn_clint.FlatAppearance.BorderSize = 0;
            this.btn_clint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clint.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clint.Image = global::billsystem.Properties.Resources.clint;
            this.btn_clint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clint.Location = new System.Drawing.Point(-2, 221);
            this.btn_clint.Name = "btn_clint";
            this.btn_clint.Size = new System.Drawing.Size(186, 43);
            this.btn_clint.TabIndex = 8;
            this.btn_clint.Text = "Client";
            this.btn_clint.UseVisualStyleBackColor = true;
            this.btn_clint.Click += new System.EventHandler(this.btn_clint_Click);
            // 
            // btn_items
            // 
            this.btn_items.FlatAppearance.BorderSize = 0;
            this.btn_items.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_items.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_items.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Image = global::billsystem.Properties.Resources.item;
            this.btn_items.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_items.Location = new System.Drawing.Point(2, 183);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(181, 34);
            this.btn_items.TabIndex = 7;
            this.btn_items.Text = "Items";
            this.btn_items.UseVisualStyleBackColor = true;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // btn_sales_reportes
            // 
            this.btn_sales_reportes.FlatAppearance.BorderSize = 0;
            this.btn_sales_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sales_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_reportes.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_reportes.Image = global::billsystem.Properties.Resources.report;
            this.btn_sales_reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_reportes.Location = new System.Drawing.Point(3, 313);
            this.btn_sales_reportes.Name = "btn_sales_reportes";
            this.btn_sales_reportes.Size = new System.Drawing.Size(176, 37);
            this.btn_sales_reportes.TabIndex = 6;
            this.btn_sales_reportes.Text = "Sales Reports";
            this.btn_sales_reportes.UseVisualStyleBackColor = true;
            this.btn_sales_reportes.Click += new System.EventHandler(this.btn_sales_reportes_Click);
            // 
            // btn_sales_invoice
            // 
            this.btn_sales_invoice.FlatAppearance.BorderSize = 0;
            this.btn_sales_invoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sales_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales_invoice.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sales_invoice.Image = global::billsystem.Properties.Resources.invo;
            this.btn_sales_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sales_invoice.Location = new System.Drawing.Point(-1, 270);
            this.btn_sales_invoice.Name = "btn_sales_invoice";
            this.btn_sales_invoice.Size = new System.Drawing.Size(180, 37);
            this.btn_sales_invoice.TabIndex = 5;
            this.btn_sales_invoice.Text = "Sales Invoice";
            this.btn_sales_invoice.UseVisualStyleBackColor = true;
            this.btn_sales_invoice.Click += new System.EventHandler(this.btn_sales_invoice_Click);
            // 
            // btn_units
            // 
            this.btn_units.FlatAppearance.BorderSize = 0;
            this.btn_units.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_units.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_units.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_units.Image = global::billsystem.Properties.Resources.coin;
            this.btn_units.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_units.Location = new System.Drawing.Point(3, 147);
            this.btn_units.Name = "btn_units";
            this.btn_units.Size = new System.Drawing.Size(181, 30);
            this.btn_units.TabIndex = 3;
            this.btn_units.Text = "All units";
            this.btn_units.UseVisualStyleBackColor = true;
            this.btn_units.Click += new System.EventHandler(this.btn_units_Click);
            // 
            // btn_types
            // 
            this.btn_types.FlatAppearance.BorderSize = 0;
            this.btn_types.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_types.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_types.Image = global::billsystem.Properties.Resources.type;
            this.btn_types.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_types.Location = new System.Drawing.Point(3, 98);
            this.btn_types.Name = "btn_types";
            this.btn_types.Size = new System.Drawing.Size(186, 34);
            this.btn_types.TabIndex = 2;
            this.btn_types.Text = "Types";
            this.btn_types.UseVisualStyleBackColor = true;
            this.btn_types.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_companyname
            // 
            this.btn_companyname.BackColor = System.Drawing.Color.Transparent;
            this.btn_companyname.FlatAppearance.BorderSize = 0;
            this.btn_companyname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_companyname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_companyname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_companyname.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_companyname.Image = global::billsystem.Properties.Resources.pp;
            this.btn_companyname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_companyname.Location = new System.Drawing.Point(3, 44);
            this.btn_companyname.Name = "btn_companyname";
            this.btn_companyname.Size = new System.Drawing.Size(180, 37);
            this.btn_companyname.TabIndex = 1;
            this.btn_companyname.Text = "Company Data";
            this.btn_companyname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_companyname.UseVisualStyleBackColor = false;
            this.btn_companyname.Click += new System.EventHandler(this.btn_companyname_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(185, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 486);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainpanel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "bill system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_sales_invoice;
        private System.Windows.Forms.Button btn_units;
        private System.Windows.Forms.Button btn_types;
        private System.Windows.Forms.Button btn_companyname;
        private System.Windows.Forms.Button btn_sales_reportes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_items;
        private System.Windows.Forms.Button btn_clint;
        private System.Windows.Forms.Button button1;
    }
}

