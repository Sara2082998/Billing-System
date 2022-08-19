namespace billsystem
{
    partial class inoice
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
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dp_billDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_emp_Name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Invoice_clint_name = new System.Windows.Forms.ComboBox();
            this.txt_Bills_number = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sellingprice = new System.Windows.Forms.TextBox();
            this.cb_items_name = new System.Windows.Forms.ComboBox();
            this.dgv_sales_invoice = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.num_percentDisc = new System.Windows.Forms.NumericUpDown();
            this.txt_pricentage = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TheRest = new System.Windows.Forms.TextBox();
            this.txt_Paid_UP = new System.Windows.Forms.TextBox();
            this.txt_theNet = new System.Windows.Forms.TextBox();
            this.txt_vale_discount = new System.Windows.Forms.TextBox();
            this.txt_bills_total = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_invoice)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_percentDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dp_billDate);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cb_emp_Name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_Invoice_clint_name);
            this.panel1.Controls.Add(this.txt_Bills_number);
            this.panel1.Location = new System.Drawing.Point(86, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 120);
            this.panel1.TabIndex = 1;
            // 
            // dp_billDate
            // 
            this.dp_billDate.Location = new System.Drawing.Point(161, 10);
            this.dp_billDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dp_billDate.Name = "dp_billDate";
            this.dp_billDate.Size = new System.Drawing.Size(469, 20);
            this.dp_billDate.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(25, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "Employee Name";
            // 
            // cb_emp_Name
            // 
            this.cb_emp_Name.FormattingEnabled = true;
            this.cb_emp_Name.Location = new System.Drawing.Point(161, 85);
            this.cb_emp_Name.Name = "cb_emp_Name";
            this.cb_emp_Name.Size = new System.Drawing.Size(469, 21);
            this.cb_emp_Name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bills Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bills Date";
            // 
            // cb_Invoice_clint_name
            // 
            this.cb_Invoice_clint_name.FormattingEnabled = true;
            this.cb_Invoice_clint_name.Location = new System.Drawing.Point(161, 61);
            this.cb_Invoice_clint_name.Name = "cb_Invoice_clint_name";
            this.cb_Invoice_clint_name.Size = new System.Drawing.Size(469, 21);
            this.cb_Invoice_clint_name.TabIndex = 3;
            this.cb_Invoice_clint_name.Text = "choose from clinets";
            // 
            // txt_Bills_number
            // 
            this.txt_Bills_number.Location = new System.Drawing.Point(161, 35);
            this.txt_Bills_number.Name = "txt_Bills_number";
            this.txt_Bills_number.Size = new System.Drawing.Size(469, 20);
            this.txt_Bills_number.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.num_quantity);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_total);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_sellingprice);
            this.panel2.Controls.Add(this.cb_items_name);
            this.panel2.Location = new System.Drawing.Point(86, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 123);
            this.panel2.TabIndex = 2;
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(161, 77);
            this.num_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_quantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(468, 20);
            this.num_quantity.TabIndex = 8;
            this.num_quantity.ValueChanged += new System.EventHandler(this.num_quantity_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Items Name";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(161, 100);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(469, 20);
            this.txt_total.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Items Details";
            // 
            // txt_sellingprice
            // 
            this.txt_sellingprice.Location = new System.Drawing.Point(161, 48);
            this.txt_sellingprice.Name = "txt_sellingprice";
            this.txt_sellingprice.Size = new System.Drawing.Size(469, 20);
            this.txt_sellingprice.TabIndex = 2;
            // 
            // cb_items_name
            // 
            this.cb_items_name.FormattingEnabled = true;
            this.cb_items_name.Location = new System.Drawing.Point(161, 21);
            this.cb_items_name.Name = "cb_items_name";
            this.cb_items_name.Size = new System.Drawing.Size(469, 21);
            this.cb_items_name.TabIndex = 0;
            this.cb_items_name.Text = "choose from items";
            this.cb_items_name.SelectionChangeCommitted += new System.EventHandler(this.cb_items_name_SelectionChangeCommitted);
            // 
            // dgv_sales_invoice
            // 
            this.dgv_sales_invoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_sales_invoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_sales_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales_invoice.Location = new System.Drawing.Point(86, 281);
            this.dgv_sales_invoice.Name = "dgv_sales_invoice";
            this.dgv_sales_invoice.RowHeadersWidth = 51;
            this.dgv_sales_invoice.Size = new System.Drawing.Size(634, 120);
            this.dgv_sales_invoice.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.num_percentDisc);
            this.panel3.Controls.Add(this.txt_pricentage);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_TheRest);
            this.panel3.Controls.Add(this.txt_Paid_UP);
            this.panel3.Controls.Add(this.txt_theNet);
            this.panel3.Controls.Add(this.txt_vale_discount);
            this.panel3.Controls.Add(this.txt_bills_total);
            this.panel3.Location = new System.Drawing.Point(86, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 236);
            this.panel3.TabIndex = 4;
            // 
            // num_percentDisc
            // 
            this.num_percentDisc.Location = new System.Drawing.Point(165, 91);
            this.num_percentDisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_percentDisc.Name = "num_percentDisc";
            this.num_percentDisc.Size = new System.Drawing.Size(468, 20);
            this.num_percentDisc.TabIndex = 12;
            this.num_percentDisc.ValueChanged += new System.EventHandler(this.num_percentDisc_ValueChanged);
            // 
            // txt_pricentage
            // 
            this.txt_pricentage.AutoSize = true;
            this.txt_pricentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pricentage.Location = new System.Drawing.Point(10, 89);
            this.txt_pricentage.Name = "txt_pricentage";
            this.txt_pricentage.Size = new System.Drawing.Size(158, 20);
            this.txt_pricentage.TabIndex = 11;
            this.txt_pricentage.Text = "Precentage Discount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "The Rest";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Paid UP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(3, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Other Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "The Net";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Value Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Bills Total";
            // 
            // txt_TheRest
            // 
            this.txt_TheRest.Location = new System.Drawing.Point(165, 213);
            this.txt_TheRest.Name = "txt_TheRest";
            this.txt_TheRest.Size = new System.Drawing.Size(469, 20);
            this.txt_TheRest.TabIndex = 5;
            // 
            // txt_Paid_UP
            // 
            this.txt_Paid_UP.Location = new System.Drawing.Point(165, 180);
            this.txt_Paid_UP.Name = "txt_Paid_UP";
            this.txt_Paid_UP.Size = new System.Drawing.Size(469, 20);
            this.txt_Paid_UP.TabIndex = 4;
            this.txt_Paid_UP.TextChanged += new System.EventHandler(this.txt_Paid_UP_TextChanged);
            // 
            // txt_theNet
            // 
            this.txt_theNet.Location = new System.Drawing.Point(165, 149);
            this.txt_theNet.Name = "txt_theNet";
            this.txt_theNet.Size = new System.Drawing.Size(469, 20);
            this.txt_theNet.TabIndex = 3;
            // 
            // txt_vale_discount
            // 
            this.txt_vale_discount.Location = new System.Drawing.Point(165, 121);
            this.txt_vale_discount.Name = "txt_vale_discount";
            this.txt_vale_discount.Size = new System.Drawing.Size(469, 20);
            this.txt_vale_discount.TabIndex = 2;
            this.txt_vale_discount.TextChanged += new System.EventHandler(this.txt_vale_discount_TextChanged);
            // 
            // txt_bills_total
            // 
            this.txt_bills_total.Location = new System.Drawing.Point(165, 56);
            this.txt_bills_total.Name = "txt_bills_total";
            this.txt_bills_total.Size = new System.Drawing.Size(469, 20);
            this.txt_bills_total.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Save.Location = new System.Drawing.Point(645, 646);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Finish";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Location = new System.Drawing.Point(644, 247);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.BackColor = System.Drawing.Color.Red;
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Cancle.Location = new System.Drawing.Point(555, 646);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 7;
            this.btn_Cancle.Text = "Cancle";
            this.btn_Cancle.UseVisualStyleBackColor = false;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // inoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1081, 630);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgv_sales_invoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inoice";
            this.Text = "inoice";
            this.Load += new System.EventHandler(this.inoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales_invoice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_percentDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Invoice_clint_name;
        private System.Windows.Forms.TextBox txt_Bills_number;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_sellingprice;
        private System.Windows.Forms.ComboBox cb_items_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_sales_invoice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_pricentage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TheRest;
        private System.Windows.Forms.TextBox txt_Paid_UP;
        private System.Windows.Forms.TextBox txt_theNet;
        private System.Windows.Forms.TextBox txt_vale_discount;
        private System.Windows.Forms.TextBox txt_bills_total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_emp_Name;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.DateTimePicker dp_billDate;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.NumericUpDown num_percentDisc;
    }
}