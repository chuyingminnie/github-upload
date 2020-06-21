namespace UI
{
    partial class FormRentalRecord
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ShowcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRentalRecordSearchTenant = new System.Windows.Forms.Label();
            this.lblRentalRecordSearchShowcase = new System.Windows.Forms.Label();
            this.txtRentalRecordSearchTenant = new System.Windows.Forms.TextBox();
            this.txtRentalRecordSearchShowcase = new System.Windows.Forms.TextBox();
            this.lblRentalRecordShop = new System.Windows.Forms.Label();
            this.comboBoxRentalRecordShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowcaseID,
            this.TenantID,
            this.RentalFrom,
            this.RentalTo});
            this.dataGridView1.Location = new System.Drawing.Point(13, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 475);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowcaseID
            // 
            this.ShowcaseID.HeaderText = "ShowcaseID";
            this.ShowcaseID.Name = "ShowcaseID";
            // 
            // TenantID
            // 
            this.TenantID.HeaderText = "TenantID";
            this.TenantID.Name = "TenantID";
            // 
            // RentalFrom
            // 
            this.RentalFrom.HeaderText = "Rental From";
            this.RentalFrom.Name = "RentalFrom";
            // 
            // RentalTo
            // 
            this.RentalTo.HeaderText = "Rental To";
            this.RentalTo.Name = "RentalTo";
            // 
            // lblRentalRecordSearchTenant
            // 
            this.lblRentalRecordSearchTenant.AutoSize = true;
            this.lblRentalRecordSearchTenant.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalRecordSearchTenant.ForeColor = System.Drawing.Color.White;
            this.lblRentalRecordSearchTenant.Location = new System.Drawing.Point(464, 182);
            this.lblRentalRecordSearchTenant.Name = "lblRentalRecordSearchTenant";
            this.lblRentalRecordSearchTenant.Size = new System.Drawing.Size(224, 26);
            this.lblRentalRecordSearchTenant.TabIndex = 1;
            this.lblRentalRecordSearchTenant.Text = "Search Tenant ID";
            // 
            // lblRentalRecordSearchShowcase
            // 
            this.lblRentalRecordSearchShowcase.AutoSize = true;
            this.lblRentalRecordSearchShowcase.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalRecordSearchShowcase.ForeColor = System.Drawing.Color.White;
            this.lblRentalRecordSearchShowcase.Location = new System.Drawing.Point(464, 330);
            this.lblRentalRecordSearchShowcase.Name = "lblRentalRecordSearchShowcase";
            this.lblRentalRecordSearchShowcase.Size = new System.Drawing.Size(257, 26);
            this.lblRentalRecordSearchShowcase.TabIndex = 2;
            this.lblRentalRecordSearchShowcase.Text = "Search Showcase ID";
            // 
            // txtRentalRecordSearchTenant
            // 
            this.txtRentalRecordSearchTenant.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtRentalRecordSearchTenant.Location = new System.Drawing.Point(464, 221);
            this.txtRentalRecordSearchTenant.Name = "txtRentalRecordSearchTenant";
            this.txtRentalRecordSearchTenant.Size = new System.Drawing.Size(290, 40);
            this.txtRentalRecordSearchTenant.TabIndex = 3;
            // 
            // txtRentalRecordSearchShowcase
            // 
            this.txtRentalRecordSearchShowcase.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtRentalRecordSearchShowcase.Location = new System.Drawing.Point(464, 369);
            this.txtRentalRecordSearchShowcase.Name = "txtRentalRecordSearchShowcase";
            this.txtRentalRecordSearchShowcase.Size = new System.Drawing.Size(290, 40);
            this.txtRentalRecordSearchShowcase.TabIndex = 4;
            // 
            // lblRentalRecordShop
            // 
            this.lblRentalRecordShop.AutoSize = true;
            this.lblRentalRecordShop.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalRecordShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRentalRecordShop.Location = new System.Drawing.Point(464, 31);
            this.lblRentalRecordShop.Name = "lblRentalRecordShop";
            this.lblRentalRecordShop.Size = new System.Drawing.Size(69, 26);
            this.lblRentalRecordShop.TabIndex = 5;
            this.lblRentalRecordShop.Text = "Shop";
            // 
            // comboBoxRentalRecordShop
            // 
            this.comboBoxRentalRecordShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxRentalRecordShop.FormattingEnabled = true;
            this.comboBoxRentalRecordShop.Location = new System.Drawing.Point(464, 70);
            this.comboBoxRentalRecordShop.Name = "comboBoxRentalRecordShop";
            this.comboBoxRentalRecordShop.Size = new System.Drawing.Size(290, 41);
            this.comboBoxRentalRecordShop.TabIndex = 6;
            // 
            // FormRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.comboBoxRentalRecordShop);
            this.Controls.Add(this.lblRentalRecordShop);
            this.Controls.Add(this.txtRentalRecordSearchShowcase);
            this.Controls.Add(this.txtRentalRecordSearchTenant);
            this.Controls.Add(this.lblRentalRecordSearchShowcase);
            this.Controls.Add(this.lblRentalRecordSearchTenant);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRentalRecord";
            this.Text = "Rental Record";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRentalRecordSearchTenant;
        private System.Windows.Forms.Label lblRentalRecordSearchShowcase;
        private System.Windows.Forms.TextBox txtRentalRecordSearchTenant;
        private System.Windows.Forms.TextBox txtRentalRecordSearchShowcase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTo;
        private System.Windows.Forms.Label lblRentalRecordShop;
        private System.Windows.Forms.ComboBox comboBoxRentalRecordShop;
    }
}