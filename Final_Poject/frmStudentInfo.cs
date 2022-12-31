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
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {
            cmbAddNo.Text = Convert.ToString(GlobalClass.id_Reader("select AddmissionNo from [StudentInfo$]"));

            GlobalClass.record_Reader("select Ccode from [Category$]");
            while (GlobalClass.dr.Read())
            {
                cmbCourse.Items.Add(GlobalClass.dr[0].ToString());
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();

            frmStudentInfo.ActiveForm.BringToFront();
            
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMode.Text == "Lumsum")
                {
                    GlobalClass.record_Reader("select OfflineFeesLumsum from [Course$] where Ccode='" + cmbCourse.Text + "'");
                    while (GlobalClass.dr.Read())
                    {
                        txTotalFees.Text = GlobalClass.dr[0].ToString();

                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();
                }
                else if (cmbMode.Text == "Instalment")
                {
                    GlobalClass.record_Reader("select OfflineFeesInstalment from [Course$] where Ccode='" + cmbCourse.Text + "'");
                    while (GlobalClass.dr.Read())
                    {
                        txTotalFees.Text = GlobalClass.dr[0].ToString();
                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbMode_Leave(object sender, EventArgs e)
        {
            try
            {
                txSharePaid.Text = Convert.ToString(Convert.ToInt32(txTotalFees.Text) / 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txPaidFees_Leave(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(txTotalFees.Text) < Convert.ToInt32(txPaidFees.Text))
                {
                    MessageBox.Show("Enter Valid Amount");
                    txPaidFees.Text = "";
                }
                else
                {
                    txDueFees.Text = Convert.ToString(Convert.ToInt32(txTotalFees.Text) - Convert.ToInt32(txPaidFees.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txStuName.Text == "") && (txMobileNo.Text == "") && (txAddress.Text == "") && (cmbCourse.Text == "") && (cmbMode.Text == "") && (cmbReportentry.Text == "") && (cmbExam.Text == "") && (cmbCerti.Text == "") && (txPaidFees.Text == ""))
                {
                    MessageBox.Show("Enter the data");
                }
                else
                {
                    GlobalClass.Record_Manip("Insert into [StudentInfo$] values (" + cmbAddNo.Text + ",'" + dtpDate.Text + "','" + dtpMonth.Text + "','" + txStuName.Text + "','" + txMobileNo.Text + "','" + txAddress.Text + "','" + cmbCourse.Text + "','" + txCName.Text + "','" + cmbMode.Text + "','" + txTotalFees.Text + "','" + txPaidFees.Text + "','" + txDueFees.Text + "','" + cmbReportentry.Text + "','" + txSharePaid.Text + "','" + cmbExam.Text + "','" + cmbCerti.Text + "','" + txTrainer.Text + "')");
                    MessageBox.Show("Record Save");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpMonth.Value = dtpDate.Value.AddMonths(0);
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalClass.record_Reader("select CName from [Course$] where Ccode= '" + cmbCourse.Text + "'");
            while (GlobalClass.dr.Read())
            {
                txCName.Text = GlobalClass.dr[0].ToString();
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();
        }

        private void txTotalFees_TextChanged(object sender, EventArgs e)
        {
            txSharePaid.Text = Convert.ToString(Convert.ToInt32(txTotalFees.Text) / 10);
        }

        private void txStuName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == true)
            {
                //MessageBox.Show("Plese enter only character");
                e.Handled = true;
            }
        }

        private void txMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                //MessageBox.Show("Plese enter only digit");
                e.Handled = true;
            }
        }

       

        

        

          
    }
}
