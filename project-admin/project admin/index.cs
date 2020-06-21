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
        }

        private void btnpersonalData_Click(object sender, EventArgs e)
        {
            personalData form = new personalData();
            form.TopLevel = false;
            paneldisplay.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
