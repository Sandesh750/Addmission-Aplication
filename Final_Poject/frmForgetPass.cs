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
    public partial class frmForgetPass : Form
    {
        public frmForgetPass()
        {
            InitializeComponent();
        }        
        private void frmForgetPass_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select Distinct(Question) from [SecurityQuestion$]");
                while (GlobalClass.dr.Read())
                {
                    cmbQues.Items.Add(GlobalClass.dr[0].ToString());
                    //cmbUName.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                GlobalClass.record_Reader("Select * from [SecurityQuestion$]");
                while (GlobalClass.dr.Read())
                {
                    //cmbQues.Items.Add(GlobalClass.dr[0].ToString());
                    cmbUName.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                groupBox1.BackColor = System.Drawing.Color.Transparent;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("select * from [securityQuestion$]");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.Uname = GlobalClass.dr[0].ToString();
                    GlobalClass.Que = GlobalClass.dr[2].ToString();
                    GlobalClass.Pass = GlobalClass.dr[1].ToString();
                    GlobalClass.Ans = GlobalClass.dr[3].ToString();

                    if (cmbUName.Text == GlobalClass.Uname)
                    {
                        if ((cmbQues.Text == GlobalClass.Que) && (txAns.Text == GlobalClass.Ans))
                        {
                            MessageBox.Show("Your Password is " +GlobalClass.Pass.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Wrong Qus Or Ans");
                        }
                    }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }
    }
}
