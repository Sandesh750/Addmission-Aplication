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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private static string NumberToWords(int number)
        {
            if (number == 0)
            {
                return "zero";
            }
            if (number < 0)
            {
                return " minus" + NumberToWords(Math.Abs(number));
            }
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thausand";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "") words += " and";
                var unitMap = new[] { " zero", " one", " two", " three", " four", " five", " six", " seven", " eight", " nine", " ten", " eleven", " twelve", " thirteen", " forteen", " fifteen", " sixteen", " seventeen", " eighteen", " nineteen" };
                var tensMap = new[] { " zero", " ten", " twenty", " thirty", " fourty", " fifty", " sixty", " seventy", " eighty", " ninety" };
                if (number < 20)
                {
                    words += unitMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += "" + unitMap[number % 10];
                    }
                }
            }
            return words;
        }


        private void txTotalFees_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txRsWord.Text = NumberToWords(Convert.ToInt32(txTotalFees.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmReceipt_Load(object sender, EventArgs e)
        {
            GlobalClass.record_Reader("Select AddmissionNo from [StudentInfo$]");
            while (GlobalClass.dr.Read())
            {
                cmbAddNo.Items.Add(GlobalClass.dr[0].ToString());
            }
            GlobalClass.dr.Close();
            GlobalClass.con.Close();
            groupBox1.BackColor = System.Drawing.Color.Transparent;
        }

        private void cmbAddNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                txCourse.Text = "";

                GlobalClass.record_Reader("select * from [StudentInfo$] where AddmissionNo='" + cmbAddNo.Text + "'");
                while (GlobalClass.dr.Read())
                {
                    txStuName.Text = GlobalClass.dr[3].ToString();
                    txCourse.Text = GlobalClass.dr[6].ToString();
                    txCName.Text = GlobalClass.dr[7].ToString();
                    txTotalFees.Text = GlobalClass.dr[9].ToString();
                    txPaidFees.Text = GlobalClass.dr[10].ToString();
                    txDueFees.Text = GlobalClass.dr[11].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
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

                if (Convert.ToInt32(txNowpay.Text) > Convert.ToInt32(txDueFees.Text))
                {
                    MessageBox.Show("Enter valid Amount");
                }
                else
                {
                    txDueFees.Text = Convert.ToString(Convert.ToInt32(txDueFees.Text) - Convert.ToInt32(txNowpay.Text));
                    txPaidFees.Text = Convert.ToString(Convert.ToInt32(txPaidFees.Text) + Convert.ToInt32(txNowpay.Text));
                }

                GlobalClass.Record_Manip("insert into [Receipt$] values (" + cmbAddNo.Text + ",'" + dtpDate.Text + "','" + txStuName.Text + "','" + txTotalFees.Text + "','" + txPaidFees.Text + "','" + txDueFees.Text + "')");
                MessageBox.Show("Record Save");

                GlobalClass.Record_Manip("Update [StudentInfo$] set PaidFees='" + txPaidFees.Text + "',DueFees='" + txDueFees.Text + "' where AddmissionNo='" + cmbAddNo.Text + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txNowpay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true)
            {
                //MessageBox.Show("Plese enter only digit");
                e.Handled = true;
            }
        }
    }
}
