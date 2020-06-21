namespace project_admin
{
    partial class Formsearchstaff
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
            this.txtsearchid = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cbxshop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpersonal = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.staffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsearchShop = new System.Windows.Forms.Button();
            this.btnsearchName = new System.Windows.Forms.Button();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearchid
            // 
            this.txtsearchid.Location = new System.Drawing.Point(132, 52);
            this.txtsearchid.Name = "txtsearchid";
            this.txtsearchid.Size = new System.Drawing.Size(222, 20);
            this.txtsearchid.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(385, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 32);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search ID";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblsearch.Location = new System.Drawing.Point(30, 52);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(84, 21);
            this.lblsearch.TabIndex = 33;
            this.lblsearch.Text = "user ID ";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSelect.Location = new System.Drawing.Point(30, 134);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(87, 21);
            this.lblSelect.TabIndex = 34;
            this.lblSelect.Text = "Select :";
            // 
            // cbxshop
            // 
            this.cbxshop.FormattingEnabled = true;
            this.cbxshop.Items.AddRange(new object[] {
            "CWB",
            "MK1",
            "MK2",
            "KF",
            "ST"});
            this.cbxshop.Location = new System.Drawing.Point(199, 134);
            this.cbxshop.Name = "cbxshop";
            this.cbxshop.Size = new System.Drawing.Size(222, 21);
            this.cbxshop.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Shop :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblpersonal
            // 
            this.lblpersonal.AutoSize = true;
            this.lblpersonal.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblpersonal.Location = new System.Drawing.Point(30, 176);
            this.lblpersonal.Name = "lblpersonal";
            this.lblpersonal.Size = new System.Drawing.Size(232, 21);
            this.lblpersonal.TabIndex = 40;
            this.lblpersonal.Text = "personal information:";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffid,
            this.firstname,
            this.lastname,
            this.phonenumber,
            this.email,
            this.shop,
            this.salary});
            this.dgvDetail.Location = new System.Drawing.Point(12, 220);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(742, 253);
            this.dgvDetail.TabIndex = 42;
            // 
            // staffid
            // 
            this.staffid.HeaderText = "staffid";
            this.staffid.Name = "staffid";
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
            // shop
            // 
            this.shop.HeaderText = "shop";
            this.shop.MinimumWidth = 3;
            this.shop.Name = "shop";
            // 
            // salary
            // 
            this.salary.HeaderText = "salary";
            this.salary.Name = "salary";
            // 
            // btnsearchShop
            // 
            this.btnsearchShop.BackColor = System.Drawing.Color.White;
            this.btnsearchShop.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchShop.Location = new System.Drawing.Point(445, 128);
            this.btnsearchShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearchShop.Name = "btnsearchShop";
            this.btnsearchShop.Size = new System.Drawing.Size(161, 32);
            this.btnsearchShop.TabIndex = 43;
            this.btnsearchShop.Text = "Search shop";
            this.btnsearchShop.UseVisualStyleBackColor = false;
            this.btnsearchShop.Click += new System.EventHandler(this.btnsearchShop_Click);
            // 
            // btnsearchName
            // 
            this.btnsearchName.BackColor = System.Drawing.Color.White;
            this.btnsearchName.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearchName.Location = new System.Drawing.Point(577, 79);
            this.btnsearchName.Margin = new System.Windows.Forms.Padding(2);
            this.btnsearchName.Name = "btnsearchName";
            this.btnsearchName.Size = new System.Drawing.Size(161, 32);
            this.btnsearchName.TabIndex = 44;
            this.btnsearchName.Text = "Search Name";
            this.btnsearchName.UseVisualStyleBackColor = false;
            this.btnsearchName.Click += new System.EventHandler(this.btnsearchName_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(144, 92);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(140, 20);
            this.txtfirstname.TabIndex = 45;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblfirstname.Location = new System.Drawing.Point(28, 91);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(111, 21);
            this.lblfirstname.TabIndex = 46;
            this.lblfirstname.Text = "firstname";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbllastname.Location = new System.Drawing.Point(289, 91);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(107, 21);
            this.lbllastname.TabIndex = 47;
            this.lbllastname.Text = "lastname";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(401, 91);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(155, 20);
            this.txtlastname.TabIndex = 48;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(276, 170);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 32);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Formsearchstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnsearchName);
            this.Controls.Add(this.btnsearchShop);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.lblpersonal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxshop);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearchid);
            this.Name = "Formsearchstaff";
            this.Text = "searchStaff";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearchid;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cbxshop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpersonal;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnsearchShop;
        private System.Windows.Forms.Button btnsearchName;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Button btnClear;
    }
}