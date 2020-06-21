namespace UI
{
    partial class FormStaffMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffMenu));
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnRentalStatus = new System.Windows.Forms.Button();
            this.btnRentalRecord = new System.Windows.Forms.Button();
            this.btnInvetoryChange = new System.Windows.Forms.Button();
            this.btnApprovePreStockIn = new System.Windows.Forms.Button();
            this.btnApproveRental = new System.Windows.Forms.Button();
            this.btnCheckAttendance = new System.Windows.Forms.Button();
            this.btnPunch = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelIndex = new System.Windows.Forms.Panel();
            this.panelBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBtn
            // 
            this.panelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.panelBtn.Controls.Add(this.btnPrintReceipt);
            this.panelBtn.Controls.Add(this.btnRentalStatus);
            this.panelBtn.Controls.Add(this.btnRentalRecord);
            this.panelBtn.Controls.Add(this.btnInvetoryChange);
            this.panelBtn.Controls.Add(this.btnApprovePreStockIn);
            this.panelBtn.Controls.Add(this.btnApproveRental);
            this.panelBtn.Controls.Add(this.btnCheckAttendance);
            this.panelBtn.Controls.Add(this.btnPunch);
            this.panelBtn.Controls.Add(this.btnLogout);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBtn.Location = new System.Drawing.Point(0, 0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(200, 524);
            this.panelBtn.TabIndex = 0;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnPrintReceipt.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintReceipt.Image")));
            this.btnPrintReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintReceipt.Location = new System.Drawing.Point(3, 541);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(194, 67);
            this.btnPrintReceipt.TabIndex = 8;
            this.btnPrintReceipt.Text = "     Print      Receipt";
            this.btnPrintReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            this.btnPrintReceipt.MouseLeave += new System.EventHandler(this.btnPrintReceipt_MouseLeave);
            this.btnPrintReceipt.MouseHover += new System.EventHandler(this.btnPrintReceipt_MouseHover);
            // 
            // btnRentalStatus
            // 
            this.btnRentalStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnRentalStatus.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalStatus.ForeColor = System.Drawing.Color.Black;
            this.btnRentalStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnRentalStatus.Image")));
            this.btnRentalStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentalStatus.Location = new System.Drawing.Point(4, 461);
            this.btnRentalStatus.Name = "btnRentalStatus";
            this.btnRentalStatus.Size = new System.Drawing.Size(190, 60);
            this.btnRentalStatus.TabIndex = 7;
            this.btnRentalStatus.Text = "    Rental     Status";
            this.btnRentalStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentalStatus.UseVisualStyleBackColor = false;
            this.btnRentalStatus.Click += new System.EventHandler(this.btnRentalStatus_Click);
            this.btnRentalStatus.MouseLeave += new System.EventHandler(this.btnRentalStatus_MouseLeave);
            this.btnRentalStatus.MouseHover += new System.EventHandler(this.btnRentalStatus_MouseHover);
            // 
            // btnRentalRecord
            // 
            this.btnRentalRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnRentalRecord.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalRecord.ForeColor = System.Drawing.Color.Black;
            this.btnRentalRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRentalRecord.Image")));
            this.btnRentalRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentalRecord.Location = new System.Drawing.Point(4, 401);
            this.btnRentalRecord.Name = "btnRentalRecord";
            this.btnRentalRecord.Size = new System.Drawing.Size(190, 60);
            this.btnRentalRecord.TabIndex = 6;
            this.btnRentalRecord.Text = "   Rental    Record";
            this.btnRentalRecord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentalRecord.UseVisualStyleBackColor = false;
            this.btnRentalRecord.Click += new System.EventHandler(this.btnRentalRecord_Click);
            this.btnRentalRecord.MouseLeave += new System.EventHandler(this.btnRentalRecord_MouseLeave);
            this.btnRentalRecord.MouseHover += new System.EventHandler(this.btnRentalRecord_MouseHover);
            // 
            // btnInvetoryChange
            // 
            this.btnInvetoryChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnInvetoryChange.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvetoryChange.ForeColor = System.Drawing.Color.Black;
            this.btnInvetoryChange.Image = ((System.Drawing.Image)(resources.GetObject("btnInvetoryChange.Image")));
            this.btnInvetoryChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvetoryChange.Location = new System.Drawing.Point(4, 341);
            this.btnInvetoryChange.Name = "btnInvetoryChange";
            this.btnInvetoryChange.Size = new System.Drawing.Size(190, 60);
            this.btnInvetoryChange.TabIndex = 5;
            this.btnInvetoryChange.Text = "Inventory Change";
            this.btnInvetoryChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvetoryChange.UseVisualStyleBackColor = false;
            this.btnInvetoryChange.Click += new System.EventHandler(this.btnInvetoryChange_Click);
            this.btnInvetoryChange.MouseLeave += new System.EventHandler(this.btnInvetoryChange_MouseLeave);
            this.btnInvetoryChange.MouseHover += new System.EventHandler(this.btnInvetoryChange_MouseHover);
            // 
            // btnApprovePreStockIn
            // 
            this.btnApprovePreStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnApprovePreStockIn.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePreStockIn.ForeColor = System.Drawing.Color.Black;
            this.btnApprovePreStockIn.Image = ((System.Drawing.Image)(resources.GetObject("btnApprovePreStockIn.Image")));
            this.btnApprovePreStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprovePreStockIn.Location = new System.Drawing.Point(4, 280);
            this.btnApprovePreStockIn.Name = "btnApprovePreStockIn";
            this.btnApprovePreStockIn.Size = new System.Drawing.Size(190, 60);
            this.btnApprovePreStockIn.TabIndex = 4;
            this.btnApprovePreStockIn.Text = "Approve Pre-Stock in";
            this.btnApprovePreStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApprovePreStockIn.UseVisualStyleBackColor = false;
            this.btnApprovePreStockIn.Click += new System.EventHandler(this.btnApprovePreStockIn_Click);
            this.btnApprovePreStockIn.MouseLeave += new System.EventHandler(this.btnApprovePreStockin_MouseLeave);
            this.btnApprovePreStockIn.MouseHover += new System.EventHandler(this.btnApprovePreStockin_MouseHover);
            // 
            // btnApproveRental
            // 
            this.btnApproveRental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnApproveRental.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveRental.ForeColor = System.Drawing.Color.Black;
            this.btnApproveRental.Image = ((System.Drawing.Image)(resources.GetObject("btnApproveRental.Image")));
            this.btnApproveRental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveRental.Location = new System.Drawing.Point(3, 219);
            this.btnApproveRental.Name = "btnApproveRental";
            this.btnApproveRental.Size = new System.Drawing.Size(190, 60);
            this.btnApproveRental.TabIndex = 3;
            this.btnApproveRental.Text = "  Approve Rental";
            this.btnApproveRental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApproveRental.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApproveRental.UseVisualStyleBackColor = false;
            this.btnApproveRental.Click += new System.EventHandler(this.btnApproveRental_Click);
            this.btnApproveRental.MouseLeave += new System.EventHandler(this.btnApproveRental_MouseLeave);
            this.btnApproveRental.MouseHover += new System.EventHandler(this.btnApproveRental_MouseHover);
            // 
            // btnCheckAttendance
            // 
            this.btnCheckAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnCheckAttendance.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnCheckAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckAttendance.Image")));
            this.btnCheckAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAttendance.Location = new System.Drawing.Point(4, 158);
            this.btnCheckAttendance.Name = "btnCheckAttendance";
            this.btnCheckAttendance.Size = new System.Drawing.Size(190, 60);
            this.btnCheckAttendance.TabIndex = 2;
            this.btnCheckAttendance.Text = "Check Attendance";
            this.btnCheckAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckAttendance.UseVisualStyleBackColor = false;
            this.btnCheckAttendance.Click += new System.EventHandler(this.btnCheckAttendance_Click);
            this.btnCheckAttendance.MouseLeave += new System.EventHandler(this.btnCheckAttendance_MouseLeave);
            this.btnCheckAttendance.MouseHover += new System.EventHandler(this.btnCheckAttendance_MouseHover);
            // 
            // btnPunch
            // 
            this.btnPunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnPunch.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunch.ForeColor = System.Drawing.Color.Black;
            this.btnPunch.Image = ((System.Drawing.Image)(resources.GetObject("btnPunch.Image")));
            this.btnPunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPunch.Location = new System.Drawing.Point(4, 97);
            this.btnPunch.Name = "btnPunch";
            this.btnPunch.Size = new System.Drawing.Size(190, 60);
            this.btnPunch.TabIndex = 1;
            this.btnPunch.Text = " Punch-in Punch-out";
            this.btnPunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPunch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPunch.UseVisualStyleBackColor = false;
            this.btnPunch.Click += new System.EventHandler(this.btnPunch_Click);
            this.btnPunch.MouseLeave += new System.EventHandler(this.btnPunch_MouseLeave);
            this.btnPunch.MouseHover += new System.EventHandler(this.btnPunch_MouseHover);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.btnLogout.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 70);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            this.btnLogout.MouseHover += new System.EventHandler(this.btnLogout_MouseHover);
            // 
            // panelIndex
            // 
            this.panelIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panelIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIndex.Location = new System.Drawing.Point(200, 0);
            this.panelIndex.Name = "panelIndex";
            this.panelIndex.Size = new System.Drawing.Size(784, 524);
            this.panelIndex.TabIndex = 1;
            this.panelIndex.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIndex_Paint);
            // 
            // FormStaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.panelIndex);
            this.Controls.Add(this.panelBtn);
            this.Name = "FormStaffMenu";
            this.Text = "Staff Menu";
            this.panelBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnRentalStatus;
        private System.Windows.Forms.Button btnRentalRecord;
        private System.Windows.Forms.Button btnInvetoryChange;
        private System.Windows.Forms.Button btnApprovePreStockIn;
        private System.Windows.Forms.Button btnApproveRental;
        private System.Windows.Forms.Button btnCheckAttendance;
        private System.Windows.Forms.Button btnPunch;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelIndex;
    }
}

