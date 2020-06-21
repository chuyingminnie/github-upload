namespace UI
{
    partial class FormPrintReceipt
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
            this.btnPrintReceiptPrint = new System.Windows.Forms.Button();
            this.lblPrintReceiptSearch = new System.Windows.Forms.Label();
            this.txtPrintReceiptSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReceiptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintReceiptPrint
            // 
            this.btnPrintReceiptPrint.BackColor = System.Drawing.Color.White;
            this.btnPrintReceiptPrint.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceiptPrint.Location = new System.Drawing.Point(396, 289);
            this.btnPrintReceiptPrint.Name = "btnPrintReceiptPrint";
            this.btnPrintReceiptPrint.Size = new System.Drawing.Size(349, 99);
            this.btnPrintReceiptPrint.TabIndex = 0;
            this.btnPrintReceiptPrint.Text = "Print Receipt";
            this.btnPrintReceiptPrint.UseVisualStyleBackColor = false;
            // 
            // lblPrintReceiptSearch
            // 
            this.lblPrintReceiptSearch.AutoSize = true;
            this.lblPrintReceiptSearch.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintReceiptSearch.ForeColor = System.Drawing.Color.White;
            this.lblPrintReceiptSearch.Location = new System.Drawing.Point(438, 57);
            this.lblPrintReceiptSearch.Name = "lblPrintReceiptSearch";
            this.lblPrintReceiptSearch.Size = new System.Drawing.Size(260, 30);
            this.lblPrintReceiptSearch.TabIndex = 1;
            this.lblPrintReceiptSearch.Text = "Search Receipt ID";
            // 
            // txtPrintReceiptSearch
            // 
            this.txtPrintReceiptSearch.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtPrintReceiptSearch.Location = new System.Drawing.Point(438, 104);
            this.txtPrintReceiptSearch.Name = "txtPrintReceiptSearch";
            this.txtPrintReceiptSearch.Size = new System.Drawing.Size(260, 40);
            this.txtPrintReceiptSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReceiptID,
            this.Date,
            this.Time});
            this.dataGridView1.Location = new System.Drawing.Point(13, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(341, 477);
            this.dataGridView1.TabIndex = 3;
            // 
            // ReceiptID
            // 
            this.ReceiptID.HeaderText = "ReceiptID";
            this.ReceiptID.Name = "ReceiptID";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // FormPrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrintReceiptSearch);
            this.Controls.Add(this.lblPrintReceiptSearch);
            this.Controls.Add(this.btnPrintReceiptPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrintReceipt";
            this.Text = "Print Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrintReceiptPrint;
        private System.Windows.Forms.Label lblPrintReceiptSearch;
        private System.Windows.Forms.TextBox txtPrintReceiptSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}