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
    public partial class employee : Form
    {
        BillDBContext db;
        public employee()
        {
            InitializeComponent();
            db= new BillDBContext();
        }

        private void btn_emp_Save_Click(object sender, EventArgs e)
        {
            if (txt_emp_name.Text == "")
            {
                MessageBox.Show("Employee Name Is Required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Employee emp = null;
            try
            {
                emp = new Employee()
                { Name = txt_emp_name.Text };
                db.Employees.Add(emp);
                db.SaveChanges();
                MessageBox.Show("Employee Added Successfully!");
                btn_emp_cancle_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.Replace(ex.Message, "Employee Name Should be Unique"), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                db.Employees.Remove(emp);

            }
        }

        private void btn_emp_cancle_Click(object sender, EventArgs e)
        {
            txt_emp_name.Text = "";
        }
    }
}
