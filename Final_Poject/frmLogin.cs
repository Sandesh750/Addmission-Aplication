using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Poject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                
                groupBox1.BackColor = System.Drawing.Color.Transparent;
                lilbForgotPass.BackColor = System.Drawing.Color.Transparent;
                lbDash.BackColor = System.Drawing.Color.Transparent;
                linkSignIn.BackColor = System.Drawing.Color.Transparent;
                btnLogin.BackColor = System.Drawing.Color.Transparent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            GlobalClass.record_Reader("Select * from [Login$]");
            while (GlobalClass.dr.Read())
            {
                GlobalClass.Uname = GlobalClass.dr[0].ToString();
                GlobalClass.Pass = GlobalClass.dr[1].ToString();
                

                if ((txUName.Text == GlobalClass.Uname) && (txPass.Text == GlobalClass.Pass))
                {
                    tmp = 1;
                    break;

                }
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();
            if (tmp == 1)
            {
                //MessageBox.Show("Login Successfuly");
                MDIParent1 obj = new MDIParent1();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Inccorect UName or Pass");
                txUName.Text = "";
                txPass.Text = "";
                txUName.Focus();
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPass obj = new frmForgetPass();
            obj.Show();
            this.Hide();
        }

        private void txUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                MessageBox.Show("Enter Only Characters");
                e.Handled = true;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistration obj = new frmRegistration();
            
            obj.Show();
            this.Hide();
        }

              
    }
} 
