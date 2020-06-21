namespace Sdpui
{
    partial class Stafflogin
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
            this.btnForgetpassword = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStaffpassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblStaffid = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForgetpassword
            // 
            this.btnForgetpassword.BackColor = System.Drawing.Color.White;
            this.btnForgetpassword.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetpassword.Location = new System.Drawing.Point(224, 391);
            this.btnForgetpassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnForgetpassword.Name = "btnForgetpassword";
            this.btnForgetpassword.Size = new System.Drawing.Size(159, 61);
            this.btnForgetpassword.TabIndex = 14;
            this.btnForgetpassword.Text = "Forget Password";
            this.btnForgetpassword.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(605, 391);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 61);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStaffpassword
            // 
            this.lblStaffpassword.AutoSize = true;
            this.lblStaffpassword.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblStaffpassword.Location = new System.Drawing.Point(219, 277);
            this.lblStaffpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffpassword.Name = "lblStaffpassword";
            this.lblStaffpassword.Size = new System.Drawing.Size(150, 30);
            this.lblStaffpassword.TabIndex = 12;
            this.lblStaffpassword.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 277);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 30);
            this.textBox2.TabIndex = 11;
            // 
            // lblStaffid
            // 
            this.lblStaffid.AutoSize = true;
            this.lblStaffid.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblStaffid.Location = new System.Drawing.Point(228, 186);
            this.lblStaffid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffid.Name = "lblStaffid";
            this.lblStaffid.Size = new System.Drawing.Size(125, 30);
            this.lblStaffid.TabIndex = 10;
            this.lblStaffid.Text = "Staff ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 181);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 31);
            this.textBox1.TabIndex = 9;
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.ForeColor = System.Drawing.Color.White;
            this.lblcompanyname.Image = global::Sdpui.Properties.Resources.cube1;
            this.lblcompanyname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblcompanyname.Location = new System.Drawing.Point(188, 41);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(593, 41);
            this.lblcompanyname.TabIndex = 15;
            this.lblcompanyname.Text = "    Hong Kong Cube Shop Limited";
            this.lblcompanyname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Stafflogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.btnForgetpassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblStaffpassword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblStaffid);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stafflogin";
            this.Text = "Staff Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnForgetpassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStaffpassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblStaffid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblcompanyname;
    }
}