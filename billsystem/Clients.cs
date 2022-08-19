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
using System.Text.RegularExpressions;
namespace billsystem
{
    public partial class Clients : Form
    {
        BillDBContext db;
        public Clients()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            Number.Enabled=false;
            Client clint = db.Clients.ToList().LastOrDefault();
            Number.Text = clint == null? "1" : (clint.Number+1).ToString();
           
        }

        private void client_save_Click(object sender, EventArgs e)
        {
            if (Clint_name.Text == "")
            {
                MessageBox.Show("Client Name is Required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (phone.Text == "")
            {
                MessageBox.Show("Phone is Required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Address.Text=="")
            {
                MessageBox.Show("Address is Required!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Regex phone_reg = new Regex(@"^01[0-2,5]\d{11}$");
            if (!(phone_reg.IsMatch(phone.Text)))
            {
                MessageBox.Show("Enter a Valid Phone Number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Client c1 = null;
            try
            {
                c1 = new Client()
                {
                    Name = Clint_name.Text,
                    Phone = phone.Text,
                    Number = int.Parse(Number.Text),
                    Address = Address.Text,
                };
                db.Clients.Add(c1);
                db.SaveChanges();
                client_cancle_Click(null,null);
                MessageBox.Show("Client Added Successfully", "Success");
                Clients_Load(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message, "Client Name Should be Unique"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Clients.Remove(c1);

            }

        }

        private void client_cancle_Click(object sender, EventArgs e)
        {
            Clint_name.Text = phone.Text = Address.Text = Number.Text= "";

        }
    }
}
