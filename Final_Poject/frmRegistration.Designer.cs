namespace Final_Poject
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.txUName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txConfirm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHaveAcc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txAns = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbQue = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Name";
            // 
            // txUName
            // 
            this.txUName.Location = new System.Drawing.Point(151, 31);
            this.txUName.Name = "txUName";
            this.txUName.Size = new System.Drawing.Size(145, 20);
            this.txUName.TabIndex = 1;
            this.txUName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUName_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txConfirm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txPass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txUName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(55, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 170);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in";
            // 
            // txConfirm
            // 
            this.txConfirm.Location = new System.Drawing.Point(151, 119);
            this.txConfirm.Name = "txConfirm";
            this.txConfirm.PasswordChar = '*';
            this.txConfirm.Size = new System.Drawing.Size(145, 20);
            this.txConfirm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password";
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(151, 74);
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(145, 20);
            this.txPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(149, 339);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 32);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register Now";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnHaveAcc
            // 
            this.btnHaveAcc.Location = new System.Drawing.Point(130, 377);
            this.btnHaveAcc.Name = "btnHaveAcc";
            this.btnHaveAcc.Size = new System.Drawing.Size(190, 32);
            this.btnHaveAcc.TabIndex = 4;
            this.btnHaveAcc.Text = "Have Account ? Login Now";
            this.btnHaveAcc.UseVisualStyleBackColor = true;
            this.btnHaveAcc.Click += new System.EventHandler(this.btnHaveAcc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txAns);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbQue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(36, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Security Question";
            // 
            // txAns
            // 
            this.txAns.Location = new System.Drawing.Point(84, 69);
            this.txAns.Name = "txAns";
            this.txAns.Size = new System.Drawing.Size(145, 20);
            this.txAns.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Answer";
            // 
            // cmbQue
            // 
            this.cmbQue.FormattingEnabled = true;
            this.cmbQue.Location = new System.Drawing.Point(84, 23);
            this.cmbQue.Name = "cmbQue";
            this.cmbQue.Size = new System.Drawing.Size(278, 21);
            this.cmbQue.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Question";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 423);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHaveAcc);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txUName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnHaveAcc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txAns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbQue;
        private System.Windows.Forms.Label label4;
    }
}