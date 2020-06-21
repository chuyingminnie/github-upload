namespace UI
{
    partial class FormPunch
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
            this.components = new System.ComponentModel.Container();
            this.btnPunch = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timerPunch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPunch
            // 
            this.btnPunch.BackColor = System.Drawing.Color.White;
            this.btnPunch.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunch.Location = new System.Drawing.Point(208, 282);
            this.btnPunch.Name = "btnPunch";
            this.btnPunch.Size = new System.Drawing.Size(363, 182);
            this.btnPunch.TabIndex = 0;
            this.btnPunch.Text = "Punch-in/ Punch-out";
            this.btnPunch.UseVisualStyleBackColor = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTime.Location = new System.Drawing.Point(105, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(207, 71);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDate.Location = new System.Drawing.Point(85, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(227, 71);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // timerPunch
            // 
            this.timerPunch.Enabled = true;
            this.timerPunch.Tick += new System.EventHandler(this.timerPunch_Tick);
            // 
            // FormPunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnPunch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPunch";
            this.Text = "Punch-in / Punch-out";
            this.Load += new System.EventHandler(this.FormPunch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPunch;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Timer timerPunch;
    }
}