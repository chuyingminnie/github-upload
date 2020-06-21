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
    public partial class Formsearchstaff : Form
    {
        public Formsearchstaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String s = txtsearchid.Text;
            using (var ctx = new Entities())
            {
                
                
                    var staffList = ctx.staffs.SqlQuery("Select * from staff where staffID = '" + s + "' ").ToList();

                

                foreach (var detail in staffList.ToList())
                {
                    dgvDetail.Rows.Add(detail.staffID, detail.firstname, detail.lastname, detail.phonenumber, detail.email,detail.shop, detail.salary);

                }


            }
        }

        private void btnsearchShop_Click(object sender, EventArgs e)
        {
            String tmp = cbxshop.SelectedItem.ToString();
            using (var ctx = new Entities())
            {


                var staffList = ctx.staffs.SqlQuery("Select * from staff where shop = '" + tmp + "' ").ToList();



                foreach (var detail in staffList.ToList())
                {
                    dgvDetail.Rows.Add(detail.staffID, detail.firstname, detail.lastname, detail.phonenumber, detail.email,detail.shop,detail.salary);

                }


            }
        }

        private void btnsearchName_Click(object sender, EventArgs e)
        {
            String f = txtfirstname.Text;
            String l = txtlastname.Text;
            using (var ctx = new Entities())
            {


                var staffList = ctx.staffs.SqlQuery("Select * from staff where firstname  = '" + f + "' and lastname  = '" + l + "'").ToList();



                foreach (var detail in staffList.ToList())
                {
                    dgvDetail.Rows.Add(detail.staffID, detail.firstname, detail.lastname, detail.phonenumber, detail.email, detail.shop, detail.salary);

                }


            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvDetail.DataSource = null;
            this.dgvDetail.Rows.Clear();
         
        }
    }
}
