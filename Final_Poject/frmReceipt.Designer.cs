namespace Final_Poject
{
    partial class frmReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceipt));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txNowpay = new System.Windows.Forms.TextBox();
            this.txCourse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txCName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txDueFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txPaidFees = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txTotalFees = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txRsWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txStuName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAddNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txNowpay);
            this.groupBox1.Controls.Add(this.txCourse);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txCName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txDueFees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txPaidFees);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txTotalFees);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txRsWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txStuName);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAddNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Now Pay";
            // 
            // txNowpay
            // 
            this.txNowpay.Location = new System.Drawing.Point(431, 267);
            this.txNowpay.Name = "txNowpay";
            this.txNowpay.Size = new System.Drawing.Size(144, 20);
            this.txNowpay.TabIndex = 19;
            this.txNowpay.Text = "0";
            this.txNowpay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNowpay_KeyPress);
            // 
            // txCourse
            // 
            this.txCourse.Enabled = false;
            this.txCourse.Location = new System.Drawing.Point(334, 72);
            this.txCourse.Name = "txCourse";
            this.txCourse.Size = new System.Drawing.Size(144, 20);
            this.txCourse.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Course Name";
            // 
            // txCName
            // 
            this.txCName.Enabled = false;
            this.txCName.Location = new System.Drawing.Point(103, 117);
            this.txCName.Name = "txCName";
            this.txCName.Size = new System.Drawing.Size(472, 20);
            this.txCName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Due Fees";
            // 
            // txDueFees
            // 
            this.txDueFees.Location = new System.Drawing.Point(431, 241);
            this.txDueFees.Name = "txDueFees";
            this.txDueFees.Size = new System.Drawing.Size(144, 20);
            this.txDueFees.TabIndex = 14;
            this.txDueFees.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Paid Fees";
            // 
            // txPaidFees
            // 
            this.txPaidFees.Location = new System.Drawing.Point(431, 215);
            this.txPaidFees.Name = "txPaidFees";
            this.txPaidFees.Size = new System.Drawing.Size(144, 20);
            this.txPaidFees.TabIndex = 12;
            this.txPaidFees.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Fees";
            // 
            // txTotalFees
            // 
            this.txTotalFees.Location = new System.Drawing.Point(431, 189);
            this.txTotalFees.Name = "txTotalFees";
            this.txTotalFees.Size = new System.Drawing.Size(144, 20);
            this.txTotalFees.TabIndex = 10;
            this.txTotalFees.Text = "0";
            this.txTotalFees.TextChanged += new System.EventHandler(this.txTotalFees_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rupees in word";
            // 
            // txRsWord
            // 
            this.txRsWord.Location = new System.Drawing.Point(103, 152);
            this.txRsWord.Name = "txRsWord";
            this.txRsWord.Size = new System.Drawing.Size(472, 20);
            this.txRsWord.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // txStuName
            // 
            this.txStuName.Location = new System.Drawing.Point(103, 72);
            this.txStuName.Name = "txStuName";
            this.txStuName.Size = new System.Drawing.Size(144, 20);
            this.txStuName.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(334, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(101, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // cmbAddNo
            // 
            this.cmbAddNo.FormattingEnabled = true;
            this.cmbAddNo.Location = new System.Drawing.Point(103, 25);
            this.cmbAddNo.Name = "cmbAddNo";
            this.cmbAddNo.Size = new System.Drawing.Size(88, 21);
            this.cmbAddNo.TabIndex = 1;
            this.cmbAddNo.SelectedIndexChanged += new System.EventHandler(this.cmbAddNo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addmission No";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(257, 334);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(95, 36);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(621, 382);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txDueFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txPaidFees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txTotalFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txRsWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txStuName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAddNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txCName;
        private System.Windows.Forms.TextBox txCourse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txNowpay;
    }
}