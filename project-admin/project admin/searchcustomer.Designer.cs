namespace project_admin
{
    partial class Formsearchcustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.btnsearchName = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.customerid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblpersonal = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbllastname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(82, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "firstname";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(253, 94);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(222, 20);
            this.txtfirstname.TabIndex = 58;
            // 
            // btnsearchName
            // 
            this.btnsearchName.BackColor = System.Drawing.Color.White;
            this.btnsearchName.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchName.Location = new System.Drawing.Point(520, 123);
            this.btnsearchName.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearchName.Name = "btnsearchName";
            this.btnsearchName.Size = new System.Drawing.Size(161, 32);
            this.btnsearchName.TabIndex = 57;
            this.btnsearchName.Text = "Search Name";
            this.btnsearchName.UseVisualStyleBackColor = false;
            this.btnsearchName.Click += new System.EventHandler(this.btnsearchName_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerid,
            this.firstname,
            this.lastname,
            this.phonenumber,
            this.email});
            this.dgvDetail.Location = new System.Drawing.Point(60, 235);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(541, 211);
            this.dgvDetail.TabIndex = 55;
            // 
            // customerid
            // 
            this.customerid.HeaderText = "customerid";
            this.customerid.Name = "customerid";
            // 
            // firstname
            // 
            this.firstname.HeaderText = "firstname";
            this.firstname.Name = "firstname";
            // 
            // lastname
            // 
            this.lastname.HeaderText = "lastname";
            this.lastname.Name = "lastname";
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "phonenumber";
            this.phonenumber.Name = "phonenumber";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 9;
            this.email.Name = "email";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(659, 390);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 56);
            this.btnClear.TabIndex = 54;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblpersonal
            // 
            this.lblpersonal.AutoSize = true;
            this.lblpersonal.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblpersonal.Location = new System.Drawing.Point(74, 193);
            this.lblpersonal.Name = "lblpersonal";
            this.lblpersonal.Size = new System.Drawing.Size(232, 21);
            this.lblpersonal.TabIndex = 53;
            this.lblpersonal.Text = "personal information:";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblsearch.Location = new System.Drawing.Point(104, 45);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(84, 21);
            this.lblsearch.TabIndex = 49;
            this.lblsearch.Text = "user ID ";
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.White;
            this.btnSearchID.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchID.Location = new System.Drawing.Point(520, 39);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(130, 32);
            this.btnSearchID.TabIndex = 48;
            this.btnSearchID.Text = "Search ID";
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(253, 45);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(222, 20);
            this.txtid.TabIndex = 47;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(253, 137);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(222, 20);
            this.txtlastname.TabIndex = 61;
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbllastname.Location = new System.Drawing.Point(86, 134);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(107, 21);
            this.lbllastname.TabIndex = 60;
            this.lbllastname.Text = "lastname";
            // 
            // Formsearchcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnsearchName);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblpersonal);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.txtid);
            this.Name = "Formsearchcustomer";
            this.Text = "searchCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Button btnsearchName;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblpersonal;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbllastname;
    }
}