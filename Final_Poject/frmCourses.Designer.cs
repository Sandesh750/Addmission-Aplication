namespace Final_Poject
{
    partial class frmCourses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCourses));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txCatagory = new System.Windows.Forms.TextBox();
            this.cmbSrNo = new System.Windows.Forms.ComboBox();
            this.txDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txContents = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAllCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtOffline = new System.Windows.Forms.RadioButton();
            this.rbtOnline = new System.Windows.Forms.RadioButton();
            this.txOfflineInsta = new System.Windows.Forms.TextBox();
            this.txTotalFees = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txExamFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txOfflineLum = new System.Windows.Forms.TextBox();
            this.txOnline = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txCatagory);
            this.groupBox1.Controls.Add(this.cmbSrNo);
            this.groupBox1.Controls.Add(this.txDuration);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txContents);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txCName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAllCategory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course";
            // 
            // txCatagory
            // 
            this.txCatagory.Location = new System.Drawing.Point(356, 34);
            this.txCatagory.Name = "txCatagory";
            this.txCatagory.Size = new System.Drawing.Size(139, 20);
            this.txCatagory.TabIndex = 13;
            
            // 
            // cmbSrNo
            // 
            this.cmbSrNo.FormattingEnabled = true;
            this.cmbSrNo.Location = new System.Drawing.Point(90, 31);
            this.cmbSrNo.Name = "cmbSrNo";
            this.cmbSrNo.Size = new System.Drawing.Size(91, 21);
            this.cmbSrNo.TabIndex = 12;
            this.cmbSrNo.SelectedIndexChanged += new System.EventHandler(this.cmbSrNo_SelectedIndexChanged);
            // 
            // txDuration
            // 
            this.txDuration.Location = new System.Drawing.Point(359, 138);
            this.txDuration.Name = "txDuration";
            this.txDuration.Size = new System.Drawing.Size(156, 20);
            this.txDuration.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durations";
            // 
            // txContents
            // 
            this.txContents.Location = new System.Drawing.Point(90, 118);
            this.txContents.Multiline = true;
            this.txContents.Name = "txContents";
            this.txContents.Size = new System.Drawing.Size(169, 40);
            this.txContents.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contents";
            // 
            // txCName
            // 
            this.txCName.Location = new System.Drawing.Point(359, 77);
            this.txCName.Multiline = true;
            this.txCName.Name = "txCName";
            this.txCName.Size = new System.Drawing.Size(156, 37);
            this.txCName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course Code";
            // 
            // cmbCCode
            // 
            this.cmbCCode.FormattingEnabled = true;
            this.cmbCCode.Location = new System.Drawing.Point(90, 73);
            this.cmbCCode.Name = "cmbCCode";
            this.cmbCCode.Size = new System.Drawing.Size(169, 21);
            this.cmbCCode.TabIndex = 4;
            this.cmbCCode.SelectedIndexChanged += new System.EventHandler(this.cmbCCode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Catagory";
            // 
            // cmbAllCategory
            // 
            this.cmbAllCategory.FormattingEnabled = true;
            this.cmbAllCategory.Location = new System.Drawing.Point(356, 34);
            this.cmbAllCategory.Name = "cmbAllCategory";
            this.cmbAllCategory.Size = new System.Drawing.Size(156, 21);
            this.cmbAllCategory.TabIndex = 2;
            this.cmbAllCategory.SelectedIndexChanged += new System.EventHandler(this.cmbAllCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sr.No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtOffline);
            this.groupBox3.Controls.Add(this.rbtOnline);
            this.groupBox3.Controls.Add(this.txOfflineInsta);
            this.groupBox3.Controls.Add(this.txTotalFees);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txExamFees);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txOfflineLum);
            this.groupBox3.Controls.Add(this.txOnline);
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 162);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fees";
            // 
            // rbtOffline
            // 
            this.rbtOffline.AutoSize = true;
            this.rbtOffline.Location = new System.Drawing.Point(19, 79);
            this.rbtOffline.Name = "rbtOffline";
            this.rbtOffline.Size = new System.Drawing.Size(55, 17);
            this.rbtOffline.TabIndex = 4;
            this.rbtOffline.TabStop = true;
            this.rbtOffline.Text = "Offline";
            this.rbtOffline.UseVisualStyleBackColor = true;
            this.rbtOffline.CheckedChanged += new System.EventHandler(this.rbtOffline_CheckedChanged);
            // 
            // rbtOnline
            // 
            this.rbtOnline.AutoSize = true;
            this.rbtOnline.Location = new System.Drawing.Point(19, 45);
            this.rbtOnline.Name = "rbtOnline";
            this.rbtOnline.Size = new System.Drawing.Size(55, 17);
            this.rbtOnline.TabIndex = 5;
            this.rbtOnline.TabStop = true;
            this.rbtOnline.Text = "Online";
            this.rbtOnline.UseVisualStyleBackColor = true;
            this.rbtOnline.CheckedChanged += new System.EventHandler(this.rbtOnline_CheckedChanged);
            // 
            // txOfflineInsta
            // 
            this.txOfflineInsta.Location = new System.Drawing.Point(215, 79);
            this.txOfflineInsta.Name = "txOfflineInsta";
            this.txOfflineInsta.Size = new System.Drawing.Size(124, 20);
            this.txOfflineInsta.TabIndex = 34;
            // 
            // txTotalFees
            // 
            this.txTotalFees.Location = new System.Drawing.Point(391, 119);
            this.txTotalFees.Name = "txTotalFees";
            this.txTotalFees.Size = new System.Drawing.Size(124, 20);
            this.txTotalFees.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Total Fees";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(259, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Instalment";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Lumsum";
            // 
            // txExamFees
            // 
            this.txExamFees.Location = new System.Drawing.Point(80, 116);
            this.txExamFees.Name = "txExamFees";
            this.txExamFees.Size = new System.Drawing.Size(124, 20);
            this.txExamFees.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Exam Fess";
            // 
            // txOfflineLum
            // 
            this.txOfflineLum.Location = new System.Drawing.Point(80, 79);
            this.txOfflineLum.Name = "txOfflineLum";
            this.txOfflineLum.Size = new System.Drawing.Size(124, 20);
            this.txOfflineLum.TabIndex = 27;
            // 
            // txOnline
            // 
            this.txOnline.Location = new System.Drawing.Point(80, 45);
            this.txOnline.Name = "txOnline";
            this.txOnline.Size = new System.Drawing.Size(124, 20);
            this.txOnline.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(79, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(19, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 25);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(107, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(196, 25);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 25);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(562, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coueses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txContents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txCName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAllCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txOfflineInsta;
        private System.Windows.Forms.TextBox txTotalFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txExamFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txOfflineLum;
        private System.Windows.Forms.TextBox txOnline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbtOffline;
        private System.Windows.Forms.RadioButton rbtOnline;
        private System.Windows.Forms.ComboBox cmbSrNo;
        private System.Windows.Forms.TextBox txCatagory;
    }
}

