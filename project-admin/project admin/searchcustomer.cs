using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_admin
{
    public partial class Formsearchcustomer : Form
    {
        public Formsearchcustomer()
        {
            InitializeComponent();
        }

     

        private void btnsearchName_Click(object sender, EventArgs e)
        {
            String f = txtfirstname.Text;
            String l = txtlastname.Text;
            using (var ctx = new Entities())
            {


                var custList = ctx.customers.SqlQuery("Select * from customer where firstname  = '" + f + "' and lastname  = '" + l + "'").ToList();



                foreach (var detail in custList.ToList())
                {
                    dgvDetail.Rows.Add(detail.custID, detail.firstname, detail.lastname, detail.phonenumber, detail.email);

                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvDetail.DataSource = null;
            this.dgvDetail.Rows.Clear();

        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            String s = txtid.Text;
            using (var ctx = new Entities())
            {


                var customerList = ctx.customers.SqlQuery("Select * from customer where custID = '" + s + "' ").ToList();



                foreach (var detail in customerList.ToList())
                {
                    dgvDetail.Rows.Add(detail.custID, detail.firstname, detail.lastname, detail.phonenumber, detail.email);

                }


            }
        }
    }
}
