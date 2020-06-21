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
    public partial class Formsearchtenant : Form
    {
        public Formsearchtenant()
        {
            InitializeComponent();
        }



        private void btnSearchName_Click(object sender, EventArgs e)
        {
            String f = txtfirstname.Text;
            String l = txtlastname.Text;
            using (var ctx = new Entities())
            {


                var tenantList = ctx.tenants.SqlQuery("Select t.tenantID, t.firstname, t.lastname,t.phonenumber, t.email,a.showcaseID from tenant inner join applyforrental on t.tenantID = a.tenantID where firstname  = '" + f + "' and lastname  = '" + l + "'").ToList();



                foreach (var detail in tenantList.ToList())
                {
                    dgvDetail.Rows.Add(detail.tenantID, detail.firstname, detail.lastname, detail.phonenumber, detail.email);

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
          
            int i = int.Parse(txtid.Text);
            using (var ctx = new Entities())
            {

                var tenantList = ctx.tenants.Where(a => a.tenantID.Equals(i)).ToList();
              

                foreach (var detail in tenantList.ToList())
                {
                    foreach (var applyForDetail in detail.applyforrentals)
                    {
                        dgvDetail.Rows.Add(detail.tenantID, detail.firstname, detail.lastname, detail.phonenumber, detail.email, applyForDetail.showcaseID);
                    }

                }


            }
        }
    }
}
