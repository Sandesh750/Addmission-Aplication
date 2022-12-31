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
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void btnHaveAcc_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txPass.Text == txConfirm.Text)
                {                                                          
                    GlobalClass.Record_Manip("Insert into [Login$] values ('" + txUName.Text + "','" + txConfirm.Text + "')");
                    GlobalClass.Record_Manip("Insert into [securityQuestion$] values ('" + txUName.Text + "','" + txConfirm.Text + "','" + cmbQue.Text + "','" + txAns.Text + "')");
                    MessageBox.Show("Register Successfuly");
                    frmLogin obj = new frmLogin();
                    obj.Show();
                    this.Hide();                    
                }
                else
                {
                    MessageBox.Show("Password And Confirm Password not same");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            groupBox1.BackColor = System.Drawing.Color.Transparent;

            GlobalClass.record_Reader("Select Distinct(Question) from [securityQuestion$]");
            while (GlobalClass.dr.Read())
            {
                cmbQue.Items.Add(GlobalClass.dr[0].ToString());
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();
        }

        private void txUName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                //MessageBox.Show("Plese enter only character");
                e.Handled = true;
            }
        }

        
    }
}
