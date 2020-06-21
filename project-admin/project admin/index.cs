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
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            paneldisplay.Controls.Clear();
            FormWelcome form = new FormWelcome();
            form.TopLevel = false;
            paneldisplay.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.timer.Enabled = true;
            form.timer.Start();
        }

     

        private void btnsearchingcustomer_Click(object sender, EventArgs e)
        {
            paneldisplay.Controls.Clear();
            Formsearchcustomer cform = new Formsearchcustomer();
            cform.TopLevel = false;
            paneldisplay.Controls.Add(cform);
            cform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           cform.Dock = DockStyle.Fill;
            cform.Show();
        }

        private void btnsearchingstaff_Click(object sender, EventArgs e)
        {
            paneldisplay.Controls.Clear();
            Formsearchstaff sform = new Formsearchstaff();
            sform.TopLevel = false;
            paneldisplay.Controls.Add(sform);
            sform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sform.Dock = DockStyle.Fill;
            sform.Show();
        }

        private void btnsearchingtenant_Click(object sender, EventArgs e)
        {
            paneldisplay.Controls.Clear();
            Formsearchtenant tform = new Formsearchtenant();
            tform.TopLevel = false;
            paneldisplay.Controls.Add(tform);
            tform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            tform.Dock = DockStyle.Fill;
            tform.Show();
        }
    }
}
