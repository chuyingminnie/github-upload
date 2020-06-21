namespace project_admin
{
    partial class Formsearchtenant
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
            this.btnSearchName = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.tenantid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showcaseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblpersonal = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(50, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "firstname";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(229, 83);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(222, 20);
            this.txtfirstname.TabIndex = 58;
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.White;
            this.btnSearchName.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchName.Location = new System.Drawing.Point(496, 113);
            this.btnSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(161, 32);
            this.btnSearchName.TabIndex = 57;
            this.btnSearchName.Text = "Search Name";
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantid,
            this.firstname,
            this.lastname,
            this.phonenumber,
            this.email,
            this.showcaseID});
            this.dgvDetail.Location = new System.Drawing.Point(17, 233);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(640, 240);
            this.dgvDetail.TabIndex = 55;
            // 
            // tenantid
            // 
            this.tenantid.HeaderText = "tenantid";
            this.tenantid.Name = "tenantid";
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
            // showcaseID
            // 
            this.showcaseID.HeaderText = "showcaseID";
            this.showcaseID.MinimumWidth = 3;
            this.showcaseID.Name = "showcaseID";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(667, 376);
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
            this.lblpersonal.Location = new System.Drawing.Point(50, 184);
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
            this.lblsearch.Location = new System.Drawing.Point(53, 39);
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
            this.btnSearchID.Location = new System.Drawing.Point(496, 33);
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
            this.txtid.Location = new System.Drawing.Point(229, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(222, 20);
            this.txtid.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 60;
            this.label2.Text = "lastname";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(229, 125);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(222, 20);
            this.txtlastname.TabIndex = 61;
            // 
            // Formsearchtenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(766, 485);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.dgvDetail);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblpersonal);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.txtid);
            this.Name = "Formsearchtenant";
            this.Text = "searchtenant";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblpersonal;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseID;
    }
}