namespace Final_Poject
{
    partial class frmStudentInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txCName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.txTrainer = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbCerti = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txSharePaid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbReportentry = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txDueFees = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txPaidFees = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txTotalFees = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txMobileNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txStuName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.txCName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbMode);
            this.groupBox1.Controls.Add(this.cmbCourse);
            this.groupBox1.Controls.Add(this.txTrainer);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbCerti);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cmbExam);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txAddress);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txSharePaid);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbReportentry);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txDueFees);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txPaidFees);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txTotalFees);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txMobileNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txStuName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAddNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 370);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // txCName
            // 
            this.txCName.Location = new System.Drawing.Point(326, 153);
            this.txCName.Multiline = true;
            this.txCName.Name = "txCName";
            this.txCName.Size = new System.Drawing.Size(196, 54);
            this.txCName.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(245, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Couse Name";
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "Lumsum",
            "Instalment"});
            this.cmbMode.Location = new System.Drawing.Point(99, 231);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(113, 21);
            this.cmbMode.TabIndex = 35;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            this.cmbMode.Leave += new System.EventHandler(this.cmbMode_Leave);
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(99, 152);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(113, 21);
            this.cmbCourse.TabIndex = 34;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // txTrainer
            // 
            this.txTrainer.Location = new System.Drawing.Point(304, 318);
            this.txTrainer.Name = "txTrainer";
            this.txTrainer.Size = new System.Drawing.Size(113, 20);
            this.txTrainer.TabIndex = 31;
            this.txTrainer.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 321);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Trainer";
            // 
            // cmbCerti
            // 
            this.cmbCerti.FormattingEnabled = true;
            this.cmbCerti.Items.AddRange(new object[] {
            "With ",
            "Without"});
            this.cmbCerti.Location = new System.Drawing.Point(99, 315);
            this.cmbCerti.Name = "cmbCerti";
            this.cmbCerti.Size = new System.Drawing.Size(113, 21);
            this.cmbCerti.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Certificate";
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Items.AddRange(new object[] {
            "Ok",
            "Not"});
            this.cmbExam.Location = new System.Drawing.Point(304, 281);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(113, 21);
            this.cmbExam.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 284);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Exam";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(610, 94);
            this.txAddress.Multiline = true;
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(162, 61);
            this.txAddress.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(549, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Address";
            // 
            // txSharePaid
            // 
            this.txSharePaid.Location = new System.Drawing.Point(304, 231);
            this.txSharePaid.Name = "txSharePaid";
            this.txSharePaid.Size = new System.Drawing.Size(113, 20);
            this.txSharePaid.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "SharePaid ";
            // 
            // cmbReportentry
            // 
            this.cmbReportentry.FormattingEnabled = true;
            this.cmbReportentry.Items.AddRange(new object[] {
            "Addmission Ok",
            "Addmission Not Ok"});
            this.cmbReportentry.Location = new System.Drawing.Point(99, 281);
            this.cmbReportentry.Name = "cmbReportentry";
            this.cmbReportentry.Size = new System.Drawing.Size(113, 21);
            this.cmbReportentry.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Report Entry";
            // 
            // txDueFees
            // 
            this.txDueFees.Location = new System.Drawing.Point(573, 321);
            this.txDueFees.Name = "txDueFees";
            this.txDueFees.Size = new System.Drawing.Size(113, 20);
            this.txDueFees.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Due Fees";
            // 
            // txPaidFees
            // 
            this.txPaidFees.Location = new System.Drawing.Point(573, 295);
            this.txPaidFees.Name = "txPaidFees";
            this.txPaidFees.Size = new System.Drawing.Size(113, 20);
            this.txPaidFees.TabIndex = 17;
            this.txPaidFees.Leave += new System.EventHandler(this.txPaidFees_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Paid Fees";
            // 
            // txTotalFees
            // 
            this.txTotalFees.Location = new System.Drawing.Point(573, 269);
            this.txTotalFees.Name = "txTotalFees";
            this.txTotalFees.Size = new System.Drawing.Size(113, 20);
            this.txTotalFees.TabIndex = 15;
            this.txTotalFees.TextChanged += new System.EventHandler(this.txTotalFees_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total Fees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Course Code";
            // 
            // txMobileNo
            // 
            this.txMobileNo.Location = new System.Drawing.Point(376, 94);
            this.txMobileNo.Name = "txMobileNo";
            this.txMobileNo.Size = new System.Drawing.Size(146, 20);
            this.txMobileNo.TabIndex = 9;
            this.txMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMobileNo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mobile No";
            // 
            // txStuName
            // 
            this.txStuName.Location = new System.Drawing.Point(99, 94);
            this.txStuName.Name = "txStuName";
            this.txStuName.Size = new System.Drawing.Size(184, 20);
            this.txStuName.TabIndex = 7;
            this.txStuName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txStuName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Name";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMM-yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(512, 32);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(99, 20);
            this.dtpMonth.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(289, 33);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(128, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // cmbAddNo
            // 
            this.cmbAddNo.FormattingEnabled = true;
            this.cmbAddNo.Location = new System.Drawing.Point(99, 31);
            this.cmbAddNo.Name = "cmbAddNo";
            this.cmbAddNo.Size = new System.Drawing.Size(113, 21);
            this.cmbAddNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addmission No";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(347, 395);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 38);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 448);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.frmStudentInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAddNo;
        private System.Windows.Forms.TextBox txSharePaid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbReportentry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txDueFees;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txPaidFees;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txMobileNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txStuName;
        private System.Windows.Forms.ComboBox cmbCerti;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txTrainer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.TextBox txCName;
        private System.Windows.Forms.Label label17;
    }
}