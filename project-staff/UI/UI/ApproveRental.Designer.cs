namespace UI
{
    partial class FormApproveRental
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
            this.dataGridViewApproveRental = new System.Windows.Forms.DataGridView();
            this.ShowcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnApproveRentalApprove = new System.Windows.Forms.Button();
            this.btnApproveRentalDecline = new System.Windows.Forms.Button();
            this.comboBoxApproveRental = new System.Windows.Forms.ComboBox();
            this.lblApproveRentalGuide = new System.Windows.Forms.Label();
            this.lblApproveRentalShop = new System.Windows.Forms.Label();
            this.comboBoxApproveRentalShop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApproveRental)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewApproveRental
            // 
            this.dataGridViewApproveRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApproveRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ShowcaseID,
            this.Size,
            this.Price,
            this.RentalBy,
            this.RentalFrom,
            this.RentalTo,
            this.Duration});
            this.dataGridViewApproveRental.Location = new System.Drawing.Point(12, 82);
            this.dataGridViewApproveRental.Name = "dataGridViewApproveRental";
            this.dataGridViewApproveRental.RowTemplate.Height = 24;
            this.dataGridViewApproveRental.Size = new System.Drawing.Size(744, 284);
            this.dataGridViewApproveRental.TabIndex = 0;
            // 
            // ShowcaseID
            // 
            this.ShowcaseID.HeaderText = "ShowcaseID";
            this.ShowcaseID.Name = "ShowcaseID";
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // RentalBy
            // 
            this.RentalBy.HeaderText = "Rental By";
            this.RentalBy.Name = "RentalBy";
            // 
            // RentalFrom
            // 
            this.RentalFrom.HeaderText = "Rental From";
            this.RentalFrom.Name = "RentalFrom";
            // 
            // RentalTo
            // 
            this.RentalTo.HeaderText = "RentalTo";
            this.RentalTo.Name = "RentalTo";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // btnApproveRentalApprove
            // 
            this.btnApproveRentalApprove.BackColor = System.Drawing.Color.White;
            this.btnApproveRentalApprove.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveRentalApprove.Location = new System.Drawing.Point(62, 441);
            this.btnApproveRentalApprove.Name = "btnApproveRentalApprove";
            this.btnApproveRentalApprove.Size = new System.Drawing.Size(159, 61);
            this.btnApproveRentalApprove.TabIndex = 3;
            this.btnApproveRentalApprove.Text = "Approve";
            this.btnApproveRentalApprove.UseVisualStyleBackColor = false;
            // 
            // btnApproveRentalDecline
            // 
            this.btnApproveRentalDecline.BackColor = System.Drawing.Color.White;
            this.btnApproveRentalDecline.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveRentalDecline.Location = new System.Drawing.Point(291, 441);
            this.btnApproveRentalDecline.Name = "btnApproveRentalDecline";
            this.btnApproveRentalDecline.Size = new System.Drawing.Size(167, 61);
            this.btnApproveRentalDecline.TabIndex = 4;
            this.btnApproveRentalDecline.Text = "Decline";
            this.btnApproveRentalDecline.UseVisualStyleBackColor = false;
            // 
            // comboBoxApproveRental
            // 
            this.comboBoxApproveRental.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxApproveRental.FormattingEnabled = true;
            this.comboBoxApproveRental.Location = new System.Drawing.Point(501, 392);
            this.comboBoxApproveRental.Name = "comboBoxApproveRental";
            this.comboBoxApproveRental.Size = new System.Drawing.Size(238, 41);
            this.comboBoxApproveRental.TabIndex = 5;
            // 
            // lblApproveRentalGuide
            // 
            this.lblApproveRentalGuide.AutoSize = true;
            this.lblApproveRentalGuide.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproveRentalGuide.ForeColor = System.Drawing.Color.White;
            this.lblApproveRentalGuide.Location = new System.Drawing.Point(24, 392);
            this.lblApproveRentalGuide.Name = "lblApproveRentalGuide";
            this.lblApproveRentalGuide.Size = new System.Drawing.Size(456, 24);
            this.lblApproveRentalGuide.TabIndex = 6;
            this.lblApproveRentalGuide.Text = "Please select a showcase id to approve:";
            // 
            // lblApproveRentalShop
            // 
            this.lblApproveRentalShop.AutoSize = true;
            this.lblApproveRentalShop.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApproveRentalShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblApproveRentalShop.Location = new System.Drawing.Point(57, 26);
            this.lblApproveRentalShop.Name = "lblApproveRentalShop";
            this.lblApproveRentalShop.Size = new System.Drawing.Size(85, 30);
            this.lblApproveRentalShop.TabIndex = 7;
            this.lblApproveRentalShop.Text = "Shop:";
            // 
            // comboBoxApproveRentalShop
            // 
            this.comboBoxApproveRentalShop.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.comboBoxApproveRentalShop.FormattingEnabled = true;
            this.comboBoxApproveRentalShop.Location = new System.Drawing.Point(148, 21);
            this.comboBoxApproveRentalShop.Name = "comboBoxApproveRentalShop";
            this.comboBoxApproveRentalShop.Size = new System.Drawing.Size(252, 41);
            this.comboBoxApproveRentalShop.TabIndex = 8;
            // 
            // FormApproveRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.comboBoxApproveRentalShop);
            this.Controls.Add(this.lblApproveRentalShop);
            this.Controls.Add(this.lblApproveRentalGuide);
            this.Controls.Add(this.comboBoxApproveRental);
            this.Controls.Add(this.btnApproveRentalDecline);
            this.Controls.Add(this.btnApproveRentalApprove);
            this.Controls.Add(this.dataGridViewApproveRental);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormApproveRental";
            this.Text = "Approve Rental";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApproveRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewApproveRental;
        private System.Windows.Forms.Button btnApproveRentalApprove;
        private System.Windows.Forms.Button btnApproveRentalDecline;
        private System.Windows.Forms.ComboBox comboBoxApproveRental;
        private System.Windows.Forms.Label lblApproveRentalGuide;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShowcaseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.Label lblApproveRentalShop;
        private System.Windows.Forms.ComboBox comboBoxApproveRentalShop;
    }
}