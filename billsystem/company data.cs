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
using System.Data.Entity.Validation;

namespace billsystem
{
    public partial class company_data : Form
    {
        BillDBContext db;
        public company_data()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (company_name.Text == "")
            {
                MessageBox.Show("Company Name is Required!", "Hint",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Company comp = null;
            try
            {
                comp = new Company()
                {
                    Name = company_name.Text,
                    Notes = not1.Text
                };
                db.Companies.Add(comp);
                db.SaveChanges();
                MessageBox.Show("Company Added Successfully","Success");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message,"Company Name Should be Unique"),"Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Companies.Remove(comp);
            }
            
            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            company_name.Text = not1.Text = "";
        }

        private void company_data_Load(object sender, EventArgs e)
        {

        }

        private void notes1_Click(object sender, EventArgs e)
        {

        }
    }
}
