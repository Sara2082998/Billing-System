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
    public partial class Types : Form
    {
        BillDBContext db;
        public Types()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void Types_Load(object sender, EventArgs e)
        {
            //Load Companies Names
            cb_Type_campany_name.DataSource = db.Companies.ToList();
            cb_Type_campany_name.DisplayMember = "Name";
            cb_Type_campany_name.ValueMember = "Id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Type_save_Click(object sender, EventArgs e)
        {
            if (Type_Name.Text == "")
            {
                MessageBox.Show("Type Name is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            billsystem.Model.Type ty = null;
            try
            {
                ty = new billsystem.Model.Type()
                {
                    Name = Type_Name.Text,
                    Notes = not1.Text,
                    Comp_Id = (int)cb_Type_campany_name.SelectedValue
                };
                db.Types.Add(ty);
                db.SaveChanges();
                MessageBox.Show("Type Added Successfully","Success");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message, "Type Name Should be Unique"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Types.Remove(ty);
            }
        }

        private void type_cancle_Click(object sender, EventArgs e)
        {
            Type_Name.Text = not1.Text = "";
            cb_Type_campany_name.SelectedIndex = 0;
        }

        private void cb_Type_campany_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
