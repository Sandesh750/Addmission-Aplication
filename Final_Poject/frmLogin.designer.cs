namespace Final_Poject
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.txUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lilbForgotPass = new System.Windows.Forms.LinkLabel();
            this.lbDash = new System.Windows.Forms.Label();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(114, 25);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txPass);
            this.groupBox1.Controls.Add(this.txUName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txPass
            // 
            this.txPass.Location = new System.Drawing.Point(109, 92);
            this.txPass.Name = "txPass";
            this.txPass.PasswordChar = '*';
            this.txPass.Size = new System.Drawing.Size(136, 20);
            this.txPass.TabIndex = 4;
            // 
            // txUName
            // 
            this.txUName.Location = new System.Drawing.Point(109, 31);
            this.txUName.Name = "txUName";
            this.txUName.Size = new System.Drawing.Size(136, 20);
            this.txUName.TabIndex = 3;
            this.txUName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txUName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // lilbForgotPass
            // 
            this.lilbForgotPass.AutoSize = true;
            this.lilbForgotPass.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lilbForgotPass.LinkColor = System.Drawing.Color.Yellow;
            this.lilbForgotPass.Location = new System.Drawing.Point(59, 188);
            this.lilbForgotPass.Name = "lilbForgotPass";
            this.lilbForgotPass.Size = new System.Drawing.Size(95, 13);
            this.lilbForgotPass.TabIndex = 4;
            this.lilbForgotPass.TabStop = true;
            this.lilbForgotPass.Text = "Forgot Password ?";
            this.lilbForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbDash
            // 
            this.lbDash.AutoSize = true;
            this.lbDash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDash.ForeColor = System.Drawing.Color.Yellow;
            this.lbDash.Location = new System.Drawing.Point(160, 188);
            this.lbDash.Name = "lbDash";
            this.lbDash.Size = new System.Drawing.Size(9, 13);
            this.lbDash.TabIndex = 5;
            this.lbDash.Text = "|";
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkSignIn.LinkColor = System.Drawing.Color.Yellow;
            this.linkSignIn.Location = new System.Drawing.Point(175, 188);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(105, 13);
            this.linkSignIn.TabIndex = 6;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Registration (Sign In)";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 274);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.lbDash);
            this.Controls.Add(this.lilbForgotPass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.TextBox txUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lilbForgotPass;
        private System.Windows.Forms.Label lbDash;
        private System.Windows.Forms.LinkLabel linkSignIn;
    }
}