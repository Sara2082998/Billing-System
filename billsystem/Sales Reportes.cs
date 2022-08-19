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
    public partial class Sales_Reportes : Form
    {
        BillDBContext db;
        public Sales_Reportes()
        {
            InitializeComponent();
            db = new BillDBContext();
        }

        private void report_save_Click(object sender, EventArgs e)
        {
            var report = db.Bills.Where(b=> b.Date.Day >= dp_startDate.Value.Day && b.Date.Day <= dp_endDate.Value.Day).SelectMany(b => b.Bill_Item, (b, i) => new {Bill_Number=b.Number,Client_Name=b.Client.Name,Employee_Name=b.Employee.Name,Item=i.Item.Name, Bill_Date = b.Date }).OrderBy(x=>x.Bill_Date).ToList();

            dgv_Reports.DataSource = report;
        }
    }
}
