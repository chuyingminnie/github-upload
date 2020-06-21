namespace UI
{
    partial class FormRentalStatus
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
            this.Rented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRentalStatusSearchShowcase = new System.Windows.Forms.Label();
            this.txtRentalStatusSearchShowcase = new System.Windows.Forms.TextBox();
            this.lblRentalStatusShop = new System.Windows.Forms.Label();
            this.comboBoxlblRentalStatusShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowcaseID,
            this.Rented,
            this.RentedBy,
            this.RentalFrom,
            this.RentalTo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowcaseID
            // 
            this.ShowcaseID.HeaderText = "ShowcaseID";
            this.ShowcaseID.Name = "ShowcaseID";
            // 
            // Rented
            // 
            this.Rented.HeaderText = "Rented(Y/N)";
            this.Rented.Name = "Rented";
            // 
            // RentedBy
            // 
            this.RentedBy.HeaderText = "Rented By";
            this.RentedBy.Name = "RentedBy";
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
            // lblRentalStatusSearchShowcase
            // 
            this.lblRentalStatusSearchShowcase.AutoSize = true;
            this.lblRentalStatusSearchShowcase.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalStatusSearchShowcase.ForeColor = System.Drawing.Color.White;
            this.lblRentalStatusSearchShowcase.Location = new System.Drawing.Point(557, 275);
            this.lblRentalStatusSearchShowcase.Name = "lblRentalStatusSearchShowcase";
            this.lblRentalStatusSearchShowcase.Size = new System.Drawing.Size(226, 24);
            this.lblRentalStatusSearchShowcase.TabIndex = 1;
            this.lblRentalStatusSearchShowcase.Text = "Search Showcase ID";
            // 
            // txtRentalStatusSearchShowcase
            // 
            this.txtRentalStatusSearchShowcase.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtRentalStatusSearchShowcase.Location = new System.Drawing.Point(561, 314);
            this.txtRentalStatusSearchShowcase.Name = "txtRentalStatusSearchShowcase";
            this.txtRentalStatusSearchShowcase.Size = new System.Drawing.Size(212, 40);
            this.txtRentalStatusSearchShowcase.TabIndex = 3;
            // 
            // lblRentalStatusShop
            // 
            this.lblRentalStatusShop.AutoSize = true;
            this.lblRentalStatusShop.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalStatusShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblRentalStatusShop.Location = new System.Drawing.Point(561, 47);
            this.lblRentalStatusShop.Name = "lblRentalStatusShop";
            this.lblRentalStatusShop.Size = new System.Drawing.Size(60, 24);
            this.lblRentalStatusShop.TabIndex = 4;
            this.lblRentalStatusShop.Text = "Shop";
            // 
            // comboBoxlblRentalStatusShop
            // 
            this.comboBoxlblRentalStatusShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxlblRentalStatusShop.FormattingEnabled = true;
            this.comboBoxlblRentalStatusShop.Location = new System.Drawing.Point(561, 83);
            this.comboBoxlblRentalStatusShop.Name = "comboBoxlblRentalStatusShop";
            this.comboBoxlblRentalStatusShop.Size = new System.Drawing.Size(204, 41);
            this.comboBoxlblRentalStatusShop.TabIndex = 5;
            // 
            // FormRentalStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.comboBoxlblRentalStatusShop);
            this.Controls.Add(this.lblRentalStatusShop);
            this.Controls.Add(this.txtRentalStatusSearchShowcase);
            this.Controls.Add(this.lblRentalStatusSearchShowcase);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRentalStatus";
            this.Text = "RentalStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rented;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTo;
        private System.Windows.Forms.Label lblRentalStatusSearchShowcase;
        private System.Windows.Forms.TextBox txtRentalStatusSearchShowcase;
        private System.Windows.Forms.Label lblRentalStatusShop;
        private System.Windows.Forms.ComboBox comboBoxlblRentalStatusShop;
    }
}