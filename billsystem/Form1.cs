using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using billsystem.Model;

namespace billsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {

            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //types button
        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new Types());
        }

        

        private void btn_companyname_Click(object sender, EventArgs e)
        {
            loadform(new company_data());
        }

        private void btn_units_Click(object sender, EventArgs e)
        {
            loadform(new Units());
        }

        private void home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            loadform(new Items());
        }

        private void btn_categoise_Click(object sender, EventArgs e)
        {
            loadform(new Categories());
        }

        private void btn_clint_Click(object sender, EventArgs e)
        {
            loadform(new Clients());
        }

        private void btn_sales_invoice_Click(object sender, EventArgs e)
        {
            loadform(new inoice());
        }

        private void btn_sales_reportes_Click(object sender, EventArgs e)
        {
            loadform(new Sales_Reportes());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new employee());
        }
    }
}
