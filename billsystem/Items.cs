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
    public partial class Items : Form
    {
        BillDBContext db;
        public Items()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            //Load Companies Names
            cb_item_campany_name.DataSource = db.Companies.ToList();
            cb_item_campany_name.DisplayMember = "Name";
            cb_item_campany_name.ValueMember = "Id";

            //Load Unit Names
            cb_unit.DataSource = db.Units.ToList();
            cb_unit.DisplayMember = "Name";
            cb_unit.ValueMember = "Id";
        }

        private void item_save_Click(object sender, EventArgs e)
        {
            if(int.Parse(Seling_price.Text) < 0 || Seling_price.Text=="")
            {
                MessageBox.Show("Selling Price Should be greater than or equal to zero!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (int.Parse(Buying_price.Text) < 0 || Buying_price.Text=="")
            {
                MessageBox.Show("Selling Price Should be greater than or equal to zero!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(int.Parse(Seling_price.Text) < int.Parse(Buying_price.Text))
            {
                MessageBox.Show("Selling Price Should be greater than Buying Price!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Item it = null;
            try
            {
                it = new Item()
                {
                    Name = Item_name.Text,
                    Selling_Price = int.Parse(Seling_price.Text),
                    Buying_Price = int.Parse(Buying_price.Text),
                    Notes = not1.Text,
                    Type_Id = (int) cb_item_type_name.SelectedValue,
                    Unit_Id = (int) cb_unit.SelectedValue
                };
                db.Items.Add(it);
                db.SaveChanges();
                MessageBox.Show("Item Added Successfully","Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message, "Item Name Should be Unique"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Items.Remove(it);
            }

        }
        
private void item_campany_name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Load Types Names
            cb_item_type_name.DataSource = db.Types.Where(t => t.Comp_Id == (int)cb_item_campany_name.SelectedValue).ToList();
            cb_item_type_name.DisplayMember = "Name";
            cb_item_type_name.ValueMember = "Id";
        }

        private void item_cancel_Click(object sender, EventArgs e)
        {
            cb_item_campany_name.SelectedIndex = cb_item_type_name.SelectedIndex = 0;
            Item_name.Text = Seling_price.Text = Buying_price.Text = not1.Text = "";
        }

        private void cb_item_campany_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_item_type_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
