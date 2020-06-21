namespace UI
{
    partial class FormInventoryChange
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
            this.dataGridViewInvetoryChange = new System.Windows.Forms.DataGridView();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInvetoryChangeApprove = new System.Windows.Forms.Button();
            this.btnInvetoryChangeDecline = new System.Windows.Forms.Button();
            this.lblInvetoryChangeSearchTenant = new System.Windows.Forms.Label();
            this.lblInvetoryChangeSearchShowcase = new System.Windows.Forms.Label();
            this.txtInvetoryChangeSearchTenant = new System.Windows.Forms.TextBox();
            this.txtInvetoryChangeSearchShowcase = new System.Windows.Forms.TextBox();
            this.lblInventoryChangeShop = new System.Windows.Forms.Label();
            this.comboBoxInventoryChangeShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvetoryChange)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInvetoryChange
            // 
            this.dataGridViewInvetoryChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvetoryChange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantID,
            this.ShowcaseID,
            this.ChangeFrom,
            this.ChangeTo});
            this.dataGridViewInvetoryChange.Location = new System.Drawing.Point(12, 13);
            this.dataGridViewInvetoryChange.Name = "dataGridViewInvetoryChange";
            this.dataGridViewInvetoryChange.RowTemplate.Height = 24;
            this.dataGridViewInvetoryChange.Size = new System.Drawing.Size(438, 478);
            this.dataGridViewInvetoryChange.TabIndex = 0;
            // 
            // TenantID
            // 
            this.TenantID.HeaderText = "TenantID";
            this.TenantID.Name = "TenantID";
            // 
            // ShowcaseID
            // 
            this.ShowcaseID.HeaderText = "ShowcaseID";
            this.ShowcaseID.Name = "ShowcaseID";
            // 
            // ChangeFrom
            // 
            this.ChangeFrom.HeaderText = "Change From";
            this.ChangeFrom.Name = "ChangeFrom";
            // 
            // ChangeTo
            // 
            this.ChangeTo.HeaderText = "ChangeTo";
            this.ChangeTo.Name = "ChangeTo";
            // 
            // btnInvetoryChangeApprove
            // 
            this.btnInvetoryChangeApprove.BackColor = System.Drawing.Color.White;
            this.btnInvetoryChangeApprove.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvetoryChangeApprove.Location = new System.Drawing.Point(466, 303);
            this.btnInvetoryChangeApprove.Name = "btnInvetoryChangeApprove";
            this.btnInvetoryChangeApprove.Size = new System.Drawing.Size(276, 73);
            this.btnInvetoryChangeApprove.TabIndex = 1;
            this.btnInvetoryChangeApprove.Text = "Approve";
            this.btnInvetoryChangeApprove.UseVisualStyleBackColor = false;
            // 
            // btnInvetoryChangeDecline
            // 
            this.btnInvetoryChangeDecline.BackColor = System.Drawing.Color.White;
            this.btnInvetoryChangeDecline.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvetoryChangeDecline.Location = new System.Drawing.Point(466, 406);
            this.btnInvetoryChangeDecline.Name = "btnInvetoryChangeDecline";
            this.btnInvetoryChangeDecline.Size = new System.Drawing.Size(276, 74);
            this.btnInvetoryChangeDecline.TabIndex = 2;
            this.btnInvetoryChangeDecline.Text = "Decline";
            this.btnInvetoryChangeDecline.UseVisualStyleBackColor = false;
            // 
            // lblInvetoryChangeSearchTenant
            // 
            this.lblInvetoryChangeSearchTenant.AutoSize = true;
            this.lblInvetoryChangeSearchTenant.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvetoryChangeSearchTenant.ForeColor = System.Drawing.Color.White;
            this.lblInvetoryChangeSearchTenant.Location = new System.Drawing.Point(459, 105);
            this.lblInvetoryChangeSearchTenant.Name = "lblInvetoryChangeSearchTenant";
            this.lblInvetoryChangeSearchTenant.Size = new System.Drawing.Size(192, 24);
            this.lblInvetoryChangeSearchTenant.TabIndex = 3;
            this.lblInvetoryChangeSearchTenant.Text = "Search TenantID";
            // 
            // lblInvetoryChangeSearchShowcase
            // 
            this.lblInvetoryChangeSearchShowcase.AutoSize = true;
            this.lblInvetoryChangeSearchShowcase.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvetoryChangeSearchShowcase.ForeColor = System.Drawing.Color.White;
            this.lblInvetoryChangeSearchShowcase.Location = new System.Drawing.Point(459, 198);
            this.lblInvetoryChangeSearchShowcase.Name = "lblInvetoryChangeSearchShowcase";
            this.lblInvetoryChangeSearchShowcase.Size = new System.Drawing.Size(221, 24);
            this.lblInvetoryChangeSearchShowcase.TabIndex = 4;
            this.lblInvetoryChangeSearchShowcase.Text = "Search ShowcaseID";
            // 
            // txtInvetoryChangeSearchTenant
            // 
            this.txtInvetoryChangeSearchTenant.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtInvetoryChangeSearchTenant.Location = new System.Drawing.Point(460, 132);
            this.txtInvetoryChangeSearchTenant.Name = "txtInvetoryChangeSearchTenant";
            this.txtInvetoryChangeSearchTenant.Size = new System.Drawing.Size(289, 40);
            this.txtInvetoryChangeSearchTenant.TabIndex = 5;
            // 
            // txtInvetoryChangeSearchShowcase
            // 
            this.txtInvetoryChangeSearchShowcase.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtInvetoryChangeSearchShowcase.Location = new System.Drawing.Point(460, 225);
            this.txtInvetoryChangeSearchShowcase.Name = "txtInvetoryChangeSearchShowcase";
            this.txtInvetoryChangeSearchShowcase.Size = new System.Drawing.Size(289, 40);
            this.txtInvetoryChangeSearchShowcase.TabIndex = 6;
            // 
            // lblInventoryChangeShop
            // 
            this.lblInventoryChangeShop.AutoSize = true;
            this.lblInventoryChangeShop.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryChangeShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblInventoryChangeShop.Location = new System.Drawing.Point(462, 13);
            this.lblInventoryChangeShop.Name = "lblInventoryChangeShop";
            this.lblInventoryChangeShop.Size = new System.Drawing.Size(60, 24);
            this.lblInventoryChangeShop.TabIndex = 7;
            this.lblInventoryChangeShop.Text = "Shop";
            // 
            // comboBoxInventoryChangeShop
            // 
            this.comboBoxInventoryChangeShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxInventoryChangeShop.FormattingEnabled = true;
            this.comboBoxInventoryChangeShop.Location = new System.Drawing.Point(462, 40);
            this.comboBoxInventoryChangeShop.Name = "comboBoxInventoryChangeShop";
            this.comboBoxInventoryChangeShop.Size = new System.Drawing.Size(287, 41);
            this.comboBoxInventoryChangeShop.TabIndex = 8;
            // 
            // FormInventoryChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.comboBoxInventoryChangeShop);
            this.Controls.Add(this.lblInventoryChangeShop);
            this.Controls.Add(this.txtInvetoryChangeSearchShowcase);
            this.Controls.Add(this.txtInvetoryChangeSearchTenant);
            this.Controls.Add(this.lblInvetoryChangeSearchShowcase);
            this.Controls.Add(this.lblInvetoryChangeSearchTenant);
            this.Controls.Add(this.btnInvetoryChangeDecline);
            this.Controls.Add(this.btnInvetoryChangeApprove);
            this.Controls.Add(this.dataGridViewInvetoryChange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventoryChange";
            this.Text = "Approve Inventory Change";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvetoryChange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInvetoryChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangeTo;
        private System.Windows.Forms.Button btnInvetoryChangeApprove;
        private System.Windows.Forms.Button btnInvetoryChangeDecline;
        private System.Windows.Forms.Label lblInvetoryChangeSearchTenant;
        private System.Windows.Forms.Label lblInvetoryChangeSearchShowcase;
        private System.Windows.Forms.TextBox txtInvetoryChangeSearchTenant;
        private System.Windows.Forms.TextBox txtInvetoryChangeSearchShowcase;
        private System.Windows.Forms.Label lblInventoryChangeShop;
        private System.Windows.Forms.ComboBox comboBoxInventoryChangeShop;
    }
}