namespace UI
{
    partial class FormApprovePreStockIn
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
            this.dataGridViewApprovePreStockIn = new System.Windows.Forms.DataGridView();
            this.TenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApprovePreStockInSearchTenant = new System.Windows.Forms.TextBox();
            this.lblApprovePreStockInSearchTenant = new System.Windows.Forms.Label();
            this.lblApprovePreStockInSearchShowcase = new System.Windows.Forms.Label();
            this.txtApprovePreStockInSearchShowcaseID = new System.Windows.Forms.TextBox();
            this.btnApprovePreStockInApprove = new System.Windows.Forms.Button();
            this.btnApprovePreStockInDecline = new System.Windows.Forms.Button();
            this.lblApprovePreStockInShop = new System.Windows.Forms.Label();
            this.comboBoxApprovePreStockInShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApprovePreStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApprovePreStockIn
            // 
            this.dataGridViewApprovePreStockIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApprovePreStockIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenantID,
            this.ShowcaseID,
            this.Product,
            this.Amount,
            this.UnitPrice});
            this.dataGridViewApprovePreStockIn.Location = new System.Drawing.Point(12, 20);
            this.dataGridViewApprovePreStockIn.Name = "dataGridViewApprovePreStockIn";
            this.dataGridViewApprovePreStockIn.RowTemplate.Height = 24;
            this.dataGridViewApprovePreStockIn.Size = new System.Drawing.Size(524, 478);
            this.dataGridViewApprovePreStockIn.TabIndex = 0;
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
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // txtApprovePreStockInSearchTenant
            // 
            this.txtApprovePreStockInSearchTenant.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtApprovePreStockInSearchTenant.Location = new System.Drawing.Point(561, 153);
            this.txtApprovePreStockInSearchTenant.Name = "txtApprovePreStockInSearchTenant";
            this.txtApprovePreStockInSearchTenant.Size = new System.Drawing.Size(210, 40);
            this.txtApprovePreStockInSearchTenant.TabIndex = 1;
            // 
            // lblApprovePreStockInSearchTenant
            // 
            this.lblApprovePreStockInSearchTenant.AutoSize = true;
            this.lblApprovePreStockInSearchTenant.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovePreStockInSearchTenant.ForeColor = System.Drawing.Color.White;
            this.lblApprovePreStockInSearchTenant.Location = new System.Drawing.Point(557, 126);
            this.lblApprovePreStockInSearchTenant.Name = "lblApprovePreStockInSearchTenant";
            this.lblApprovePreStockInSearchTenant.Size = new System.Drawing.Size(197, 24);
            this.lblApprovePreStockInSearchTenant.TabIndex = 2;
            this.lblApprovePreStockInSearchTenant.Text = "Search Tenant ID";
            // 
            // lblApprovePreStockInSearchShowcase
            // 
            this.lblApprovePreStockInSearchShowcase.AutoSize = true;
            this.lblApprovePreStockInSearchShowcase.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovePreStockInSearchShowcase.ForeColor = System.Drawing.Color.White;
            this.lblApprovePreStockInSearchShowcase.Location = new System.Drawing.Point(557, 229);
            this.lblApprovePreStockInSearchShowcase.Name = "lblApprovePreStockInSearchShowcase";
            this.lblApprovePreStockInSearchShowcase.Size = new System.Drawing.Size(226, 24);
            this.lblApprovePreStockInSearchShowcase.TabIndex = 4;
            this.lblApprovePreStockInSearchShowcase.Text = "Search Showcase ID";
            // 
            // txtApprovePreStockInSearchShowcaseID
            // 
            this.txtApprovePreStockInSearchShowcaseID.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtApprovePreStockInSearchShowcaseID.Location = new System.Drawing.Point(561, 256);
            this.txtApprovePreStockInSearchShowcaseID.Name = "txtApprovePreStockInSearchShowcaseID";
            this.txtApprovePreStockInSearchShowcaseID.Size = new System.Drawing.Size(210, 40);
            this.txtApprovePreStockInSearchShowcaseID.TabIndex = 3;
            // 
            // btnApprovePreStockInApprove
            // 
            this.btnApprovePreStockInApprove.BackColor = System.Drawing.Color.White;
            this.btnApprovePreStockInApprove.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePreStockInApprove.Location = new System.Drawing.Point(561, 325);
            this.btnApprovePreStockInApprove.Name = "btnApprovePreStockInApprove";
            this.btnApprovePreStockInApprove.Size = new System.Drawing.Size(192, 72);
            this.btnApprovePreStockInApprove.TabIndex = 5;
            this.btnApprovePreStockInApprove.Text = "Approve";
            this.btnApprovePreStockInApprove.UseVisualStyleBackColor = false;
            // 
            // btnApprovePreStockInDecline
            // 
            this.btnApprovePreStockInDecline.BackColor = System.Drawing.Color.White;
            this.btnApprovePreStockInDecline.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprovePreStockInDecline.Location = new System.Drawing.Point(561, 416);
            this.btnApprovePreStockInDecline.Name = "btnApprovePreStockInDecline";
            this.btnApprovePreStockInDecline.Size = new System.Drawing.Size(191, 71);
            this.btnApprovePreStockInDecline.TabIndex = 6;
            this.btnApprovePreStockInDecline.Text = "Decline";
            this.btnApprovePreStockInDecline.UseVisualStyleBackColor = false;
            // 
            // lblApprovePreStockInShop
            // 
            this.lblApprovePreStockInShop.AutoSize = true;
            this.lblApprovePreStockInShop.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprovePreStockInShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblApprovePreStockInShop.Location = new System.Drawing.Point(557, 30);
            this.lblApprovePreStockInShop.Name = "lblApprovePreStockInShop";
            this.lblApprovePreStockInShop.Size = new System.Drawing.Size(60, 24);
            this.lblApprovePreStockInShop.TabIndex = 7;
            this.lblApprovePreStockInShop.Text = "Shop";
            // 
            // comboBoxApprovePreStockInShop
            // 
            this.comboBoxApprovePreStockInShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxApprovePreStockInShop.FormattingEnabled = true;
            this.comboBoxApprovePreStockInShop.Location = new System.Drawing.Point(561, 57);
            this.comboBoxApprovePreStockInShop.Name = "comboBoxApprovePreStockInShop";
            this.comboBoxApprovePreStockInShop.Size = new System.Drawing.Size(210, 41);
            this.comboBoxApprovePreStockInShop.TabIndex = 8;
            // 
            // FormApprovePreStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.comboBoxApprovePreStockInShop);
            this.Controls.Add(this.lblApprovePreStockInShop);
            this.Controls.Add(this.btnApprovePreStockInDecline);
            this.Controls.Add(this.btnApprovePreStockInApprove);
            this.Controls.Add(this.lblApprovePreStockInSearchShowcase);
            this.Controls.Add(this.txtApprovePreStockInSearchShowcaseID);
            this.Controls.Add(this.lblApprovePreStockInSearchTenant);
            this.Controls.Add(this.txtApprovePreStockInSearchTenant);
            this.Controls.Add(this.dataGridViewApprovePreStockIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApprovePreStockIn";
            this.Text = "Approve Pre-Stock In";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApprovePreStockIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApprovePreStockIn;
        private System.Windows.Forms.TextBox txtApprovePreStockInSearchTenant;
        private System.Windows.Forms.Label lblApprovePreStockInSearchTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.Label lblApprovePreStockInSearchShowcase;
        private System.Windows.Forms.TextBox txtApprovePreStockInSearchShowcaseID;
        private System.Windows.Forms.Button btnApprovePreStockInApprove;
        private System.Windows.Forms.Button btnApprovePreStockInDecline;
        private System.Windows.Forms.Label lblApprovePreStockInShop;
        private System.Windows.Forms.ComboBox comboBoxApprovePreStockInShop;
    }
}