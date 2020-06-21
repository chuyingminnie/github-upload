namespace Sdpui
{
    partial class Payment
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
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPaymentmessage = new System.Windows.Forms.Label();
            this.btnPaymentupdate = new System.Windows.Forms.Button();
            this.btnPaymentback = new System.Windows.Forms.Button();
            this.btnPaymentlogout = new System.Windows.Forms.Button();
            this.gbPaymentchoose = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtnPaymentcreditcard = new System.Windows.Forms.RadioButton();
            this.txtPaymentmethod1 = new System.Windows.Forms.TextBox();
            this.txtPaymentmethod2 = new System.Windows.Forms.TextBox();
            this.txtPaymentmethod3 = new System.Windows.Forms.TextBox();
            this.btnPaymentsetdefault1 = new System.Windows.Forms.Button();
            this.btnPaymentsetdefault2 = new System.Windows.Forms.Button();
            this.btnPaymentsetdefault3 = new System.Windows.Forms.Button();
            this.btnPaymentremove1 = new System.Windows.Forms.Button();
            this.btnPaymentremove2 = new System.Windows.Forms.Button();
            this.btnPaymentremove3 = new System.Windows.Forms.Button();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.gbPaymentchoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPayment.Location = new System.Drawing.Point(355, 80);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(263, 32);
            this.lblPayment.TabIndex = 18;
            this.lblPayment.Text = "Payment Method";
            // 
            // lblPaymentmessage
            // 
            this.lblPaymentmessage.AutoSize = true;
            this.lblPaymentmessage.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentmessage.ForeColor = System.Drawing.Color.White;
            this.lblPaymentmessage.Location = new System.Drawing.Point(272, 136);
            this.lblPaymentmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentmessage.Name = "lblPaymentmessage";
            this.lblPaymentmessage.Size = new System.Drawing.Size(416, 21);
            this.lblPaymentmessage.TabIndex = 19;
            this.lblPaymentmessage.Text = "Choose or update your payment methods";
            // 
            // btnPaymentupdate
            // 
            this.btnPaymentupdate.BackColor = System.Drawing.Color.White;
            this.btnPaymentupdate.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentupdate.Location = new System.Drawing.Point(815, 373);
            this.btnPaymentupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentupdate.Name = "btnPaymentupdate";
            this.btnPaymentupdate.Size = new System.Drawing.Size(107, 57);
            this.btnPaymentupdate.TabIndex = 20;
            this.btnPaymentupdate.Text = "Update";
            this.btnPaymentupdate.UseVisualStyleBackColor = false;
            // 
            // btnPaymentback
            // 
            this.btnPaymentback.BackColor = System.Drawing.Color.White;
            this.btnPaymentback.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentback.Location = new System.Drawing.Point(815, 291);
            this.btnPaymentback.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentback.Name = "btnPaymentback";
            this.btnPaymentback.Size = new System.Drawing.Size(107, 57);
            this.btnPaymentback.TabIndex = 21;
            this.btnPaymentback.Text = "Back";
            this.btnPaymentback.UseVisualStyleBackColor = false;
            // 
            // btnPaymentlogout
            // 
            this.btnPaymentlogout.BackColor = System.Drawing.Color.White;
            this.btnPaymentlogout.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentlogout.ForeColor = System.Drawing.Color.Black;
            this.btnPaymentlogout.Location = new System.Drawing.Point(825, 24);
            this.btnPaymentlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentlogout.Name = "btnPaymentlogout";
            this.btnPaymentlogout.Size = new System.Drawing.Size(82, 42);
            this.btnPaymentlogout.TabIndex = 22;
            this.btnPaymentlogout.Text = "Logout";
            this.btnPaymentlogout.UseVisualStyleBackColor = false;
            // 
            // gbPaymentchoose
            // 
            this.gbPaymentchoose.Controls.Add(this.radioButton1);
            this.gbPaymentchoose.Controls.Add(this.rbtnPaymentcreditcard);
            this.gbPaymentchoose.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPaymentchoose.ForeColor = System.Drawing.Color.White;
            this.gbPaymentchoose.Location = new System.Drawing.Point(254, 344);
            this.gbPaymentchoose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPaymentchoose.Name = "gbPaymentchoose";
            this.gbPaymentchoose.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPaymentchoose.Size = new System.Drawing.Size(464, 100);
            this.gbPaymentchoose.TabIndex = 23;
            this.gbPaymentchoose.TabStop = false;
            this.gbPaymentchoose.Text = "Add new payment method";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Image = global::Sdpui.Properties.Resources.Paypal__3_;
            this.radioButton1.Location = new System.Drawing.Point(296, 47);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 30);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "       ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtnPaymentcreditcard
            // 
            this.rbtnPaymentcreditcard.AutoSize = true;
            this.rbtnPaymentcreditcard.Image = global::Sdpui.Properties.Resources.visa_mastercard_amex__1_;
            this.rbtnPaymentcreditcard.Location = new System.Drawing.Point(30, 42);
            this.rbtnPaymentcreditcard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtnPaymentcreditcard.Name = "rbtnPaymentcreditcard";
            this.rbtnPaymentcreditcard.Size = new System.Drawing.Size(210, 35);
            this.rbtnPaymentcreditcard.TabIndex = 0;
            this.rbtnPaymentcreditcard.TabStop = true;
            this.rbtnPaymentcreditcard.Text = "       ";
            this.rbtnPaymentcreditcard.UseVisualStyleBackColor = true;
            // 
            // txtPaymentmethod1
            // 
            this.txtPaymentmethod1.BackColor = System.Drawing.Color.White;
            this.txtPaymentmethod1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentmethod1.Location = new System.Drawing.Point(302, 196);
            this.txtPaymentmethod1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentmethod1.Multiline = true;
            this.txtPaymentmethod1.Name = "txtPaymentmethod1";
            this.txtPaymentmethod1.Size = new System.Drawing.Size(177, 26);
            this.txtPaymentmethod1.TabIndex = 24;
            // 
            // txtPaymentmethod2
            // 
            this.txtPaymentmethod2.BackColor = System.Drawing.Color.White;
            this.txtPaymentmethod2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentmethod2.Location = new System.Drawing.Point(302, 242);
            this.txtPaymentmethod2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentmethod2.Multiline = true;
            this.txtPaymentmethod2.Name = "txtPaymentmethod2";
            this.txtPaymentmethod2.Size = new System.Drawing.Size(177, 26);
            this.txtPaymentmethod2.TabIndex = 25;
            // 
            // txtPaymentmethod3
            // 
            this.txtPaymentmethod3.BackColor = System.Drawing.Color.White;
            this.txtPaymentmethod3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPaymentmethod3.Location = new System.Drawing.Point(302, 286);
            this.txtPaymentmethod3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPaymentmethod3.Multiline = true;
            this.txtPaymentmethod3.Name = "txtPaymentmethod3";
            this.txtPaymentmethod3.Size = new System.Drawing.Size(177, 26);
            this.txtPaymentmethod3.TabIndex = 26;
            // 
            // btnPaymentsetdefault1
            // 
            this.btnPaymentsetdefault1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentsetdefault1.FlatAppearance.BorderSize = 0;
            this.btnPaymentsetdefault1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsetdefault1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsetdefault1.ForeColor = System.Drawing.Color.White;
            this.btnPaymentsetdefault1.Location = new System.Drawing.Point(483, 196);
            this.btnPaymentsetdefault1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentsetdefault1.Name = "btnPaymentsetdefault1";
            this.btnPaymentsetdefault1.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentsetdefault1.TabIndex = 27;
            this.btnPaymentsetdefault1.Text = "Set as default";
            this.btnPaymentsetdefault1.UseVisualStyleBackColor = true;
            // 
            // btnPaymentsetdefault2
            // 
            this.btnPaymentsetdefault2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentsetdefault2.FlatAppearance.BorderSize = 0;
            this.btnPaymentsetdefault2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsetdefault2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsetdefault2.ForeColor = System.Drawing.Color.White;
            this.btnPaymentsetdefault2.Location = new System.Drawing.Point(483, 242);
            this.btnPaymentsetdefault2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentsetdefault2.Name = "btnPaymentsetdefault2";
            this.btnPaymentsetdefault2.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentsetdefault2.TabIndex = 28;
            this.btnPaymentsetdefault2.Text = "Set as default";
            this.btnPaymentsetdefault2.UseVisualStyleBackColor = true;
            // 
            // btnPaymentsetdefault3
            // 
            this.btnPaymentsetdefault3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentsetdefault3.FlatAppearance.BorderSize = 0;
            this.btnPaymentsetdefault3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsetdefault3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsetdefault3.ForeColor = System.Drawing.Color.White;
            this.btnPaymentsetdefault3.Location = new System.Drawing.Point(483, 286);
            this.btnPaymentsetdefault3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentsetdefault3.Name = "btnPaymentsetdefault3";
            this.btnPaymentsetdefault3.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentsetdefault3.TabIndex = 29;
            this.btnPaymentsetdefault3.Text = "Set as default";
            this.btnPaymentsetdefault3.UseVisualStyleBackColor = true;
            // 
            // btnPaymentremove1
            // 
            this.btnPaymentremove1.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentremove1.FlatAppearance.BorderSize = 0;
            this.btnPaymentremove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentremove1.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentremove1.ForeColor = System.Drawing.Color.White;
            this.btnPaymentremove1.Location = new System.Drawing.Point(583, 196);
            this.btnPaymentremove1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentremove1.Name = "btnPaymentremove1";
            this.btnPaymentremove1.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentremove1.TabIndex = 30;
            this.btnPaymentremove1.Text = "Remove";
            this.btnPaymentremove1.UseVisualStyleBackColor = true;
            // 
            // btnPaymentremove2
            // 
            this.btnPaymentremove2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentremove2.FlatAppearance.BorderSize = 0;
            this.btnPaymentremove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentremove2.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentremove2.ForeColor = System.Drawing.Color.White;
            this.btnPaymentremove2.Location = new System.Drawing.Point(583, 242);
            this.btnPaymentremove2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentremove2.Name = "btnPaymentremove2";
            this.btnPaymentremove2.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentremove2.TabIndex = 31;
            this.btnPaymentremove2.Text = "Remove";
            this.btnPaymentremove2.UseVisualStyleBackColor = true;
            // 
            // btnPaymentremove3
            // 
            this.btnPaymentremove3.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPaymentremove3.FlatAppearance.BorderSize = 0;
            this.btnPaymentremove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentremove3.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentremove3.ForeColor = System.Drawing.Color.White;
            this.btnPaymentremove3.Location = new System.Drawing.Point(583, 286);
            this.btnPaymentremove3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentremove3.Name = "btnPaymentremove3";
            this.btnPaymentremove3.Size = new System.Drawing.Size(83, 26);
            this.btnPaymentremove3.TabIndex = 32;
            this.btnPaymentremove3.Text = "Remove";
            this.btnPaymentremove3.UseVisualStyleBackColor = true;
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.ForeColor = System.Drawing.Color.White;
            this.lblcompanyname.Image = global::Sdpui.Properties.Resources.cube1;
            this.lblcompanyname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblcompanyname.Location = new System.Drawing.Point(175, 17);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(593, 41);
            this.lblcompanyname.TabIndex = 17;
            this.lblcompanyname.Text = "    Hong Kong Cube Shop Limited";
            this.lblcompanyname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.btnPaymentremove3);
            this.Controls.Add(this.btnPaymentremove2);
            this.Controls.Add(this.btnPaymentremove1);
            this.Controls.Add(this.btnPaymentsetdefault3);
            this.Controls.Add(this.btnPaymentsetdefault2);
            this.Controls.Add(this.btnPaymentsetdefault1);
            this.Controls.Add(this.txtPaymentmethod3);
            this.Controls.Add(this.txtPaymentmethod2);
            this.Controls.Add(this.txtPaymentmethod1);
            this.Controls.Add(this.gbPaymentchoose);
            this.Controls.Add(this.btnPaymentlogout);
            this.Controls.Add(this.btnPaymentback);
            this.Controls.Add(this.btnPaymentupdate);
            this.Controls.Add(this.lblPaymentmessage);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblcompanyname);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.gbPaymentchoose.ResumeLayout(false);
            this.gbPaymentchoose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPaymentmessage;
        private System.Windows.Forms.Button btnPaymentupdate;
        private System.Windows.Forms.Button btnPaymentback;
        private System.Windows.Forms.Button btnPaymentlogout;
        private System.Windows.Forms.GroupBox gbPaymentchoose;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtnPaymentcreditcard;
        private System.Windows.Forms.TextBox txtPaymentmethod1;
        private System.Windows.Forms.TextBox txtPaymentmethod2;
        private System.Windows.Forms.TextBox txtPaymentmethod3;
        private System.Windows.Forms.Button btnPaymentsetdefault1;
        private System.Windows.Forms.Button btnPaymentsetdefault2;
        private System.Windows.Forms.Button btnPaymentsetdefault3;
        private System.Windows.Forms.Button btnPaymentremove1;
        private System.Windows.Forms.Button btnPaymentremove2;
        private System.Windows.Forms.Button btnPaymentremove3;
    }
}