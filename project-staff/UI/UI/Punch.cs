using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormPunch : Form
    {
        public FormPunch()
        {
            InitializeComponent();
        }

        private void FormPunch_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timerPunch.Start();
        }

        private void timerPunch_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timerPunch.Start();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
