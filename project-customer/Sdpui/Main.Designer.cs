namespace Sdpui
{
    partial class Main
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
            this.btnTenant = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTenant
            // 
            this.btnTenant.BackColor = System.Drawing.Color.White;
            this.btnTenant.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTenant.FlatAppearance.BorderSize = 600;
            this.btnTenant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTenant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTenant.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.ForeColor = System.Drawing.Color.Black;
            this.btnTenant.Location = new System.Drawing.Point(527, 314);
            this.btnTenant.Margin = new System.Windows.Forms.Padding(2);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(163, 71);
            this.btnTenant.TabIndex = 10;
            this.btnTenant.Text = "Tenant";
            this.btnTenant.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.White;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomer.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnCustomer.Location = new System.Drawing.Point(343, 408);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(134, 63);
            this.btnCustomer.TabIndex = 9;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.White;
            this.btnStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStaff.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnStaff.FlatAppearance.BorderSize = 500;
            this.btnStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnStaff.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Location = new System.Drawing.Point(263, 220);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(2);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(164, 85);
            this.btnStaff.TabIndex = 8;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.ForeColor = System.Drawing.Color.White;
            this.lblcompanyname.Image = global::Sdpui.Properties.Resources.cube1;
            this.lblcompanyname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblcompanyname.Location = new System.Drawing.Point(184, 29);
            this.lblcompanyname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(593, 41);
            this.lblcompanyname.TabIndex = 7;
            this.lblcompanyname.Text = "    Hong Kong Cube Shop Limited";
            this.lblcompanyname.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(479, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 95);
            this.button1.TabIndex = 11;
            this.button1.Text = "Administator";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.btnTenant);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnStaff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button button1;
    }
}

