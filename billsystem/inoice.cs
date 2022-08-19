using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using billsystem.Model;

namespace billsystem
{
    public partial class inoice : Form
    {
        BillDBContext db;
        Item temp_item;
        List<object> itms;

        public inoice()
        {
            InitializeComponent();
            db = new BillDBContext();
            itms = new List<object>();
        }


        private void inoice_Load(object sender, EventArgs e)
        {

            LoadData();
            txt_Bills_number.Enabled = false;
            Bill bil = db.Bills.ToList().LastOrDefault();
            txt_Bills_number.Text = bil == null ? "1" :(bil.Number + 1).ToString();
           
            num_quantity.Enabled = false;
            num_percentDisc.Enabled =txt_vale_discount.Enabled=txt_theNet.Enabled=txt_TheRest.Enabled=txt_Paid_UP.Enabled=false;

            //btn_Cancle_Click(null, null);
        }
        private void LoadData()
        {
            //Load Client ComboBox
            cb_Invoice_clint_name.DataSource = db.Clients.ToList();
            cb_Invoice_clint_name.DisplayMember = "Name";
            cb_Invoice_clint_name.ValueMember = "Id";

            //Load Employee ComboBox
            cb_emp_Name.DataSource = db.Employees.ToList();
            cb_emp_Name.DisplayMember = "Name";
            cb_emp_Name.ValueMember = "Id";

            //Load Item ComboBox
            cb_items_name.DataSource= db.Items.ToList();
            cb_items_name.DisplayMember= "Name";
            cb_items_name.ValueMember= "Id";

            //Today's Date
            dp_billDate.Value = DateTime.Now;  
        }

        private void cb_items_name_SelectionChangeCommitted(object sender, EventArgs e)
        {

            temp_item = db.Items.Where(i => i.Id == (int)cb_items_name.SelectedValue).First();
            txt_sellingprice.Text = temp_item.Selling_Price.ToString();
           
            num_quantity.Enabled=true;
        }


        private void num_quantity_ValueChanged(object sender, EventArgs e)
        {
            temp_item.Quntatiy = (int)num_quantity.Value;
            txt_total.Text = ((num_quantity.Value) * decimal.Parse(txt_sellingprice.Text)).ToString();
            temp_item.total = ((num_quantity.Value) * decimal.Parse(txt_sellingprice.Text));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            for (int i = itms.Count-1; i >= 0 ; i--)
            {
                if ((int)cb_items_name.SelectedValue == int.Parse(itms[i].GetType().GetProperty("Item_Code").GetValue(itms[i], null).ToString()))
                {

                    decimal oldQuantity = decimal.Parse(itms[i].GetType().GetProperty("Quantity").GetValue(itms[i], null).ToString());
                    decimal oldPrice = decimal.Parse(itms[i].GetType().GetProperty("Total").GetValue(itms[i], null).ToString());
                    itms.RemoveAt(i);


                    itms.Add((object)new { Item_Code = temp_item.Id, Item_Name = temp_item.Name, Unit = temp_item.Unit.Name, Quantity = num_quantity.Value + oldQuantity, Selling_Price = decimal.Parse(txt_sellingprice.Text), Total = decimal.Parse(txt_total.Text) + oldPrice  });
                    dgv_sales_invoice.DataSource = null;
                    dgv_sales_invoice.DataSource = itms;
                    clac_bill_Total();
                    return;
                }

            }


            itms.Add((object)new { Item_Code = temp_item.Id, Item_Name = temp_item.Name, Unit = temp_item.Unit.Name, Quantity = num_quantity.Value, Selling_Price = decimal.Parse(txt_sellingprice.Text), Total = decimal.Parse(txt_total.Text) });
            dgv_sales_invoice.DataSource = null;
            dgv_sales_invoice.DataSource=itms;
            clac_bill_Total();
           
        }
        
        private void clac_bill_Total()
        {

            decimal billTotal = 0;
            foreach (var i in itms)
            {
                //To access anonymous object Fields
                billTotal += decimal.Parse(i.GetType().GetProperty("Total").GetValue(i, null).ToString());
            } 
            txt_bills_total.Text = billTotal.ToString();
            num_percentDisc.Enabled = true;

        }

        private void num_percentDisc_ValueChanged(object sender, EventArgs e)
        {

            //القيمه بعد الخصم
            txt_vale_discount.Text = ((num_percentDisc.Value/100)*decimal.Parse(txt_bills_total.Text)).ToString();
        }

        private void txt_vale_discount_TextChanged(object sender, EventArgs e)
        {

            //التوتال بعد الخصم
            txt_theNet.Text = (decimal.Parse(txt_bills_total.Text) - decimal.Parse(txt_vale_discount.Text)).ToString();
            txt_Paid_UP.Enabled = true;
        }

        private void txt_Paid_UP_TextChanged(object sender, EventArgs e)
        {
            if (txt_Paid_UP.Text != ""  )
            {
                //الباقي  الراجع من الفلوس
                txt_TheRest.Text = (decimal.Parse(txt_Paid_UP.Text) - decimal.Parse(txt_theNet.Text)).ToString();

            }
            
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (decimal.Parse(txt_Paid_UP.Text) < decimal.Parse(txt_theNet.Text))
            {
                MessageBox.Show("Paid Money Must be Greater Than Net Value !", "Warning");
                return;
            }

            Bill bl1 = new Bill()
            {
                Number= int.Parse(txt_Bills_number.Text),
                Date = dp_billDate.Value,
                Client_Id=(int)cb_Invoice_clint_name.SelectedValue,
                Emp_Id=(int)cb_emp_Name.SelectedValue,
            };

            db.Bills.Add(bl1);
            db.SaveChanges();

            int bil_Id = db.Bills.Where(b=>b.Number == bl1.Number).First().Id;

            Bill_Item temp_bill_item = null;
            foreach(var i in itms)
            {
                temp_bill_item = new Bill_Item()
                {
                    Bill_Id = bil_Id,
                    Item_Id = int.Parse(i.GetType().GetProperty("Item_Code").GetValue(i, null).ToString()),
                    Quantity = int.Parse(i.GetType().GetProperty("Quantity").GetValue(i, null).ToString())
                };
                db.Bill_Items.Add(temp_bill_item);
            }

            db.SaveChanges();
            MessageBox.Show("Bill Finshed Successfully", "Success");
            inoice_Load(null,null);

        }

        private void btn_Cancle_Click(object sender, EventArgs e)

        {
            dgv_sales_invoice.DataSource = null;
            itms.Clear();
            num_quantity.Enabled= false;
            cb_items_name.SelectedIndex = cb_Invoice_clint_name.SelectedIndex = cb_emp_Name.SelectedIndex = 0;
            num_quantity.Value = num_percentDisc.Value = 0;
            txt_bills_total.Text = txt_sellingprice.Text  =txt_theNet.Text=txt_TheRest.Text = "0";

        }
    }
}
