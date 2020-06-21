namespace Tenant
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUniqueID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblChgName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radST = new System.Windows.Forms.RadioButton();
            this.radKF = new System.Windows.Forms.RadioButton();
            this.radMK2 = new System.Windows.Forms.RadioButton();
            this.radMk1 = new System.Windows.Forms.RadioButton();
            this.radCB = new System.Windows.Forms.RadioButton();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblSmallTitle = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCSaleRecord = new System.Windows.Forms.Button();
            this.btnInventorymanagement = new System.Windows.Forms.Button();
            this.btnCInventory = new System.Windows.Forms.Button();
            this.btnChaPrestock = new System.Windows.Forms.Button();
            this.btnPrestock = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCSaleRecord);
            this.panel1.Controls.Add(this.btnInventorymanagement);
            this.panel1.Controls.Add(this.btnCInventory);
            this.panel1.Controls.Add(this.btnChaPrestock);
            this.panel1.Controls.Add(this.btnPrestock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 524);
            this.panel1.TabIndex = 3;
            // 
            // lblUniqueID
            // 
            this.lblUniqueID.AutoSize = true;
            this.lblUniqueID.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUniqueID.Location = new System.Drawing.Point(256, 86);
            this.lblUniqueID.Name = "lblUniqueID";
            this.lblUniqueID.Size = new System.Drawing.Size(42, 21);
            this.lblUniqueID.TabIndex = 6;
            this.lblUniqueID.Text = " ID :";
            this.lblUniqueID.Click += new System.EventHandler(this.lblUniqueID_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblChgName
            // 
            this.lblChgName.AutoSize = true;
            this.lblChgName.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblChgName.Location = new System.Drawing.Point(259, 143);
            this.lblChgName.Name = "lblChgName";
            this.lblChgName.Size = new System.Drawing.Size(71, 21);
            this.lblChgName.TabIndex = 18;
            this.lblChgName.Text = "Name :";
            this.lblChgName.Click += new System.EventHandler(this.lblChgName_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPrice.Location = new System.Drawing.Point(259, 205);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 21);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "Price :";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDescription.Location = new System.Drawing.Point(259, 359);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(134, 21);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description :";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(188, 20);
            this.textBox3.TabIndex = 23;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(260, 395);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(350, 70);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // radST
            // 
            this.radST.AutoSize = true;
            this.radST.Enabled = false;
            this.radST.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radST.ForeColor = System.Drawing.Color.White;
            this.radST.Location = new System.Drawing.Point(663, 297);
            this.radST.Name = "radST";
            this.radST.Size = new System.Drawing.Size(80, 31);
            this.radST.TabIndex = 36;
            this.radST.TabStop = true;
            this.radST.Text = "Sha Tin";
            this.radST.UseVisualStyleBackColor = true;
            this.radST.CheckedChanged += new System.EventHandler(this.radST_CheckedChanged);
            // 
            // radKF
            // 
            this.radKF.AutoSize = true;
            this.radKF.Enabled = false;
            this.radKF.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radKF.ForeColor = System.Drawing.Color.White;
            this.radKF.Location = new System.Drawing.Point(466, 297);
            this.radKF.Name = "radKF";
            this.radKF.Size = new System.Drawing.Size(99, 31);
            this.radKF.TabIndex = 35;
            this.radKF.TabStop = true;
            this.radKF.Text = "Kwai Fong";
            this.radKF.UseVisualStyleBackColor = true;
            this.radKF.CheckedChanged += new System.EventHandler(this.radKF_CheckedChanged);
            // 
            // radMK2
            // 
            this.radMK2.AutoSize = true;
            this.radMK2.Enabled = false;
            this.radMK2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMK2.ForeColor = System.Drawing.Color.White;
            this.radMK2.Location = new System.Drawing.Point(725, 260);
            this.radMK2.Name = "radMK2";
            this.radMK2.Size = new System.Drawing.Size(133, 31);
            this.radMK2.TabIndex = 34;
            this.radMK2.TabStop = true;
            this.radMK2.Text = "Mong Kok No.2";
            this.radMK2.UseVisualStyleBackColor = true;
            this.radMK2.CheckedChanged += new System.EventHandler(this.radMK2_CheckedChanged);
            // 
            // radMk1
            // 
            this.radMk1.AutoSize = true;
            this.radMk1.Enabled = false;
            this.radMk1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMk1.ForeColor = System.Drawing.Color.White;
            this.radMk1.Location = new System.Drawing.Point(555, 260);
            this.radMk1.Name = "radMk1";
            this.radMk1.Size = new System.Drawing.Size(133, 31);
            this.radMk1.TabIndex = 33;
            this.radMk1.TabStop = true;
            this.radMk1.Text = "Mong Kok No.1";
            this.radMk1.UseVisualStyleBackColor = true;
            this.radMk1.CheckedChanged += new System.EventHandler(this.radMk1_CheckedChanged);
            // 
            // radCB
            // 
            this.radCB.AutoSize = true;
            this.radCB.Enabled = false;
            this.radCB.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCB.ForeColor = System.Drawing.Color.White;
            this.radCB.Location = new System.Drawing.Point(396, 260);
            this.radCB.Name = "radCB";
            this.radCB.Size = new System.Drawing.Size(121, 31);
            this.radCB.TabIndex = 32;
            this.radCB.TabStop = true;
            this.radCB.Text = "Causeway Bay";
            this.radCB.UseVisualStyleBackColor = true;
            this.radCB.CheckedChanged += new System.EventHandler(this.radCB_CheckedChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblLocation.Location = new System.Drawing.Point(256, 260);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(107, 21);
            this.lblLocation.TabIndex = 31;
            this.lblLocation.Text = "Location :";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblSmallTitle
            // 
            this.lblSmallTitle.AutoSize = true;
            this.lblSmallTitle.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallTitle.ForeColor = System.Drawing.Color.White;
            this.lblSmallTitle.Location = new System.Drawing.Point(231, 25);
            this.lblSmallTitle.Name = "lblSmallTitle";
            this.lblSmallTitle.Size = new System.Drawing.Size(329, 26);
            this.lblSmallTitle.TabIndex = 37;
            this.lblSmallTitle.Text = "Pre-stock in management";
            this.lblSmallTitle.Click += new System.EventHandler(this.lblSmallTitle_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.White;
            this.btnlogout.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(1, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(190, 70);
            this.btnlogout.TabIndex = 35;
            this.btnlogout.Text = "logout";
            this.btnlogout.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(4, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 60);
            this.button2.TabIndex = 34;
            this.button2.Text = "Showcase rental Apply";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(4, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 60);
            this.button3.TabIndex = 33;
            this.button3.Text = "Check available showcase";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(4, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 60);
            this.button4.TabIndex = 32;
            this.button4.Text = "Check Sale Record";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(4, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 60);
            this.button5.TabIndex = 31;
            this.button5.Text = " Inventory management";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(4, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 60);
            this.button6.TabIndex = 30;
            this.button6.Text = "Check Current Inventory";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(4, 219);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(190, 60);
            this.button7.TabIndex = 29;
            this.button7.Text = "Pre-stock in management";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(4, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 60);
            this.button8.TabIndex = 28;
            this.button8.Text = "Pre-stock in";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(16, 36);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(151, 25);
            this.btnApply.TabIndex = 27;
            this.btnApply.Text = "Showcase rental Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCSaleRecord
            // 
            this.btnCSaleRecord.Location = new System.Drawing.Point(16, 443);
            this.btnCSaleRecord.Name = "btnCSaleRecord";
            this.btnCSaleRecord.Size = new System.Drawing.Size(151, 25);
            this.btnCSaleRecord.TabIndex = 26;
            this.btnCSaleRecord.Text = "Check Sale Record";
            this.btnCSaleRecord.UseVisualStyleBackColor = true;
            // 
            // btnInventorymanagement
            // 
            this.btnInventorymanagement.Location = new System.Drawing.Point(16, 348);
            this.btnInventorymanagement.Name = "btnInventorymanagement";
            this.btnInventorymanagement.Size = new System.Drawing.Size(151, 25);
            this.btnInventorymanagement.TabIndex = 25;
            this.btnInventorymanagement.Text = " Inventory management";
            this.btnInventorymanagement.UseVisualStyleBackColor = true;
            // 
            // btnCInventory
            // 
            this.btnCInventory.Location = new System.Drawing.Point(16, 260);
            this.btnCInventory.Name = "btnCInventory";
            this.btnCInventory.Size = new System.Drawing.Size(151, 25);
            this.btnCInventory.TabIndex = 24;
            this.btnCInventory.Text = "Check Current Inventory";
            this.btnCInventory.UseVisualStyleBackColor = true;
            // 
            // btnChaPrestock
            // 
            this.btnChaPrestock.Location = new System.Drawing.Point(16, 181);
            this.btnChaPrestock.Name = "btnChaPrestock";
            this.btnChaPrestock.Size = new System.Drawing.Size(151, 25);
            this.btnChaPrestock.TabIndex = 23;
            this.btnChaPrestock.Text = "Pre-stock in management";
            this.btnChaPrestock.UseVisualStyleBackColor = true;
            // 
            // btnPrestock
            // 
            this.btnPrestock.Location = new System.Drawing.Point(16, 98);
            this.btnPrestock.Name = "btnPrestock";
            this.btnPrestock.Size = new System.Drawing.Size(151, 25);
            this.btnPrestock.TabIndex = 22;
            this.btnPrestock.Text = "Pre-stock in";
            this.btnPrestock.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(863, 428);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 40);
            this.button9.TabIndex = 40;
            this.button9.Text = "Canel";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(702, 428);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(111, 40);
            this.button10.TabIndex = 39;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(610, 72);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(111, 43);
            this.button11.TabIndex = 38;
            this.button11.Text = "Submit";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(776, 359);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(111, 40);
            this.button12.TabIndex = 41;
            this.button12.Text = "Update";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.lblSmallTitle);
            this.Controls.Add(this.radST);
            this.Controls.Add(this.radKF);
            this.Controls.Add(this.radMK2);
            this.Controls.Add(this.radMk1);
            this.Controls.Add(this.radCB);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblChgName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUniqueID);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUniqueID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblChgName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radST;
        private System.Windows.Forms.RadioButton radKF;
        private System.Windows.Forms.RadioButton radMK2;
        private System.Windows.Forms.RadioButton radMk1;
        private System.Windows.Forms.RadioButton radCB;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblSmallTitle;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCSaleRecord;
        private System.Windows.Forms.Button btnInventorymanagement;
        private System.Windows.Forms.Button btnCInventory;
        private System.Windows.Forms.Button btnChaPrestock;
        private System.Windows.Forms.Button btnPrestock;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}