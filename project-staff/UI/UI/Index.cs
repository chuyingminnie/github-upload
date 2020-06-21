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
    public partial class FormStaffMenu : Form
    {
        public FormStaffMenu()
        {
            InitializeComponent();
            panelIndex.Controls.Clear();
            FormWelcome form = new FormWelcome();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.timerWelcome.Enabled = true;
            form.timerWelcome.Start();
        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            btnLogout.Size = new System.Drawing.Size(200, 70);
        }

        private void btnPunch_MouseHover(object sender, EventArgs e)
        {
            btnPunch.Size = new System.Drawing.Size(200, 70);
        }

        private void btnCheckAttendance_MouseHover(object sender, EventArgs e)
        {
            btnCheckAttendance.Size = new System.Drawing.Size(200, 70);
        }

        private void btnApproveRental_MouseHover(object sender, EventArgs e)
        {
            btnApproveRental.Size = new System.Drawing.Size(200, 70);
        }

        private void btnApprovePreStockin_MouseHover(object sender, EventArgs e)
        {
            btnApprovePreStockIn.Size = new System.Drawing.Size(200, 70);
        }

        private void btnInvetoryChange_MouseHover(object sender, EventArgs e)
        {
            btnInvetoryChange.Size = new System.Drawing.Size(200, 70);
        }

        private void btnRentalRecord_MouseHover(object sender, EventArgs e)
        {
            btnRentalRecord.Size = new System.Drawing.Size(200, 70);
        }

        private void btnRentalStatus_MouseHover(object sender, EventArgs e)
        {
            btnRentalStatus.Size = new System.Drawing.Size(200, 70);
        }

        private void btnPrintReceipt_MouseHover(object sender, EventArgs e)
        {
            btnPrintReceipt.Size = new System.Drawing.Size(200, 70);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.Size = new System.Drawing.Size(194, 62);
        }

        private void btnPunch_MouseLeave(object sender, EventArgs e)
        {
            btnPunch.Size = new System.Drawing.Size(194, 62);
        }

        private void btnCheckAttendance_MouseLeave(object sender, EventArgs e)
        {
            btnCheckAttendance.Size = new System.Drawing.Size(194, 62);
        }

        private void btnApproveRental_MouseLeave(object sender, EventArgs e)
        {
            btnApproveRental.Size = new System.Drawing.Size(194, 62);
        }

        private void btnApprovePreStockin_MouseLeave(object sender, EventArgs e)
        {
            btnApprovePreStockIn.Size = new System.Drawing.Size(194, 62);
        }

        private void btnInvetoryChange_MouseLeave(object sender, EventArgs e)
        {
            btnInvetoryChange.Size = new System.Drawing.Size(194, 62);
        }

        private void btnRentalRecord_MouseLeave(object sender, EventArgs e)
        {
            btnRentalRecord.Size = new System.Drawing.Size(194, 62);
        }

        private void btnRentalStatus_MouseLeave(object sender, EventArgs e)
        {
            btnRentalStatus.Size = new System.Drawing.Size(194, 62);
        }

        private void btnPrintReceipt_MouseLeave(object sender, EventArgs e)
        {
            btnPrintReceipt.Size = new System.Drawing.Size(194, 62);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnPunch_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = Color.LightBlue;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormPunch form = new FormPunch();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.timerPunch.Enabled = true;
            form.timerPunch.Start();
        }

        private void btnCheckAttendance_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = Color.LightBlue;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormCheckAttendance form = new FormCheckAttendance();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnApproveRental_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = Color.LightBlue;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormApproveRental form = new FormApproveRental();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnApprovePreStockIn_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = Color.LightBlue;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormApprovePreStockIn form = new FormApprovePreStockIn();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnInvetoryChange_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = Color.LightBlue;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormInventoryChange form = new FormInventoryChange();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnRentalRecord_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = Color.LightBlue;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormRentalRecord form = new FormRentalRecord();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnRentalStatus_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = Color.LightBlue;
            btnPrintReceipt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            panelIndex.Controls.Clear();
            FormRentalStatus form = new FormRentalStatus();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            btnPunch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnCheckAttendance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApproveRental.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnApprovePreStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnInvetoryChange.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalRecord.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnRentalStatus.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            btnPrintReceipt.BackColor = Color.LightBlue;
            panelIndex.Controls.Clear();
            FormPrintReceipt form = new FormPrintReceipt();
            form.TopLevel = false;
            panelIndex.Controls.Add(form);
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void panelIndex_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
