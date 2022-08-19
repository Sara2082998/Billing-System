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
    public partial class Units : Form
    {
        BillDBContext db;
        public Units()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void not1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Units_Load(object sender, EventArgs e)
        {

        }

        private void Unit_save_Click(object sender, EventArgs e)
        {
            if (Untit_Name.Text == "")
            {
                MessageBox.Show("Unit Name is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Unit unt = null;
            try
            {
            unt = new Unit()
            {
                Name = Untit_Name.Text,
                Notes = not1.Text
            };
            db.Units.Add(unt);
            db.SaveChanges();
                MessageBox.Show("Unit Added Successfully!");
                Unit_cancle_Click(null,null);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message, "Unit Name Should be Unique"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Units.Remove(unt);
            }
        }

        private void Unit_cancle_Click(object sender, EventArgs e)
        {
            Untit_Name.Text = "";
            not1.Text = "";
        }
    }
}
