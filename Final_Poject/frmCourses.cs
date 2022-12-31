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
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            
            try
            {
               
                cmbSrNo.Text = Convert.ToString(GlobalClass.id_Reader("select max(SrNo) from [Addmission$]"));

                GlobalClass.record_Reader("Select * from [Addmission$] where Status = 'Active'");
                while (GlobalClass.dr.Read())
                {
                    cmbSrNo.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();


                GlobalClass.record_Reader("Select Distinct(AllCategory) from [Category$]");
                while (GlobalClass.dr.Read())
                {
                    cmbAllCategory.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSrNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //cmbAllCategory.Enabled = false;
                GlobalClass.record_Reader("select * from [Addmission$] where SrNo= " + cmbSrNo.Text);
                while (GlobalClass.dr.Read())
                {
                    txCatagory.Text = GlobalClass.dr[1].ToString();
                    //cmbAllCategory.Text = txCatagory.Text;
                    cmbCCode.Text = GlobalClass.dr[2].ToString();   

                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();


                GlobalClass.record_Reader("Select * from [Addmission$] where Ccode='" + cmbCCode.Text + "'");
                while (GlobalClass.dr.Read())
                {
                    
                    txCName.Text = GlobalClass.dr[3].ToString();
                    txContents.Text = GlobalClass.dr[4].ToString();
                    txDuration.Text = GlobalClass.dr[5].ToString();
                    txOfflineLum.Text = GlobalClass.dr[6].ToString();
                    txOfflineInsta.Text = GlobalClass.dr[7].ToString();
                    txOnline.Text = GlobalClass.dr[8].ToString();
                    txExamFees.Text = GlobalClass.dr[9].ToString();
                    txTotalFees.Text = GlobalClass.dr[10].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                GlobalClass.record_Reader("Select Paymode from [Addmission$] where Ccode='" + cmbCCode.Text + "'");
                while (GlobalClass.dr.Read())
                {
                    GlobalClass.Paymode = GlobalClass.dr[0].ToString();

                    if(GlobalClass.Paymode=="Online")
                    {
                        rbtOnline.Checked = true;
                    }
                    else if (GlobalClass.Paymode == "Offline")
                    {
                        rbtOffline.Checked = true;
                    }
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                btnNew.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbAllCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCCode.Items.Clear();
                cmbCCode.Text = "";
                txContents.Text = "";
                txDuration.Text = "";
                txCName.Text = "";
                txOfflineInsta.Text = "";
                txOfflineLum.Text = "";
                txOnline.Text = "";
                txExamFees.Text = "";
                txTotalFees.Text = "";

                GlobalClass.record_Reader("select CCode from [Category$] where AllCategory='" + cmbAllCategory.Text + "'");
                while (GlobalClass.dr.Read())
                {
                    txCatagory.Text = cmbAllCategory.Text;
                    cmbCCode.Items.Add(GlobalClass.dr[0].ToString());
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.record_Reader("Select * from [Course$] where Ccode='" + cmbCCode.Text + "'");
                while (GlobalClass.dr.Read())
                {
                    txCName.Text = GlobalClass.dr[1].ToString();
                    txContents.Text = GlobalClass.dr[2].ToString();
                    txDuration.Text = GlobalClass.dr[3].ToString();
                    txOfflineLum.Text = GlobalClass.dr[4].ToString();
                    txOfflineInsta.Text = GlobalClass.dr[5].ToString();
                    txOnline.Text = GlobalClass.dr[6].ToString();
                    txExamFees.Text = GlobalClass.dr[7].ToString();
                }
                GlobalClass.dr.Close();
                GlobalClass.con.Close();

                rbtOffline.Checked = false;
                rbtOnline.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtOnline_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txOnline.Text == "0")
                {
                    rbtOffline.Checked = true;
                }
                else
                {
                    txTotalFees.Text = Convert.ToString(Convert.ToInt32(txOnline.Text) + Convert.ToInt32(txExamFees.Text));
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtOffline_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if ((txOfflineInsta.Text)=="0" || (txOfflineLum.Text)=="0")
                {
                    rbtOnline.Checked = true;
                }
                else
                {
                    txTotalFees.Text = Convert.ToString(Convert.ToInt32(txOfflineLum.Text)+ Convert.ToInt32(txOfflineInsta.Text) + Convert.ToInt32(txExamFees.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmbAllCategory.Enabled = true;
            cmbSrNo.Text = Convert.ToString(GlobalClass.id_Reader("select max(SrNo) from [Addmission$]"));
            cmbAllCategory.Text = "";
            cmbCCode.Text = "";
            txCName.Text = "";
            txContents.Text = "";
            txDuration.Text = "";
            txOfflineInsta.Text = "";
            txOnline.Text = "";
            txOfflineLum.Text = "";
            txExamFees.Text = "";
            txTotalFees.Text = "";
            txCatagory.Text = "";
           
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtOnline.Checked == true)
                {
                    GlobalClass.Record_Manip("Insert into [Addmission$] values (" + cmbSrNo.Text + ",'" + cmbAllCategory.Text + "','" + cmbCCode.Text + "','" + txCName.Text + "','" + txContents.Text + "','" + txDuration.Text + "','" + txOfflineLum.Text + "','" + txOfflineInsta.Text + "','" + txOnline.Text + "','" + txExamFees.Text + "','" + txTotalFees.Text + "','Online','Active')");
                    cmbSrNo.Items.Add(cmbSrNo.Text);
                    MessageBox.Show("Record Save");
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                }
                else if (rbtOffline.Checked == true)
                {
                    GlobalClass.Record_Manip("Insert into [Addmission$] values (" + cmbSrNo.Text + ",'" + cmbAllCategory.Text + "','" + cmbCCode.Text + "','" + txCName.Text + "','" + txContents.Text + "','" + txDuration.Text + "','" + txOfflineLum.Text + "','" + txOfflineInsta.Text + "','" + txOnline.Text + "','" + txExamFees.Text + "','" + txTotalFees.Text + "','Offline','Active')");
                    cmbSrNo.Items.Add(cmbSrNo.Text);
                    MessageBox.Show("Record Save");
                    btnSave.Enabled = false;
                    btnNew.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtOnline.Checked == true)
                {
                    GlobalClass.Record_Manip("Update [Addmission$] set AllCategory='" + cmbAllCategory.Text + "',Ccode='" + cmbCCode.Text + "',Cname='" + txCName.Text + "',Contents='" + txContents + "',Duration='" + txDuration.Text + "',OfflineFeesLumsum='" + txOfflineLum.Text + "',OfflineFeesInstalment='" + txOfflineInsta.Text + "',OnlineFees='" + txOnline.Text + "',ExamFees='" + txExamFees.Text + "',TotalFees='" + txTotalFees.Text + "',Status = 'Active' where SrNo=" + cmbSrNo.Text);
                    MessageBox.Show("Record Update");
                }
                else if (rbtOffline.Checked == true)
                {
                    GlobalClass.Record_Manip("Update [Addmission$] set AllCategory='" + cmbAllCategory.Text + "',Ccode='" + cmbCCode.Text + "',Cname='" + txCName.Text + "',Contents='" + txContents + "',Duration='" + txDuration.Text + "',OfflineFeesLumsum='" + txOfflineLum.Text + "',OfflineFeesInstalment='" + txOfflineInsta.Text + "',OnlineFees='" + txOnline.Text + "',ExamFees='" + txExamFees.Text + "',TotalFees='" + txTotalFees.Text + "',Status = 'Active' where SrNo=" + cmbSrNo.Text);
                    MessageBox.Show("Record Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtOnline.Checked == true)
                {
                    GlobalClass.Record_Manip("Update [Addmission$] set AllCategory='" + cmbAllCategory.Text + "',Ccode='" + cmbCCode.Text + "',Cname='" + txCName.Text + "',Contents='" + txContents.Text + "',Duration='" + txDuration.Text + "',OfflineFeesLumsum='"+txOfflineLum.Text+"',OfflineFeesInstalment='"+txOfflineInsta.Text+"',OnlineFees='" + txOnline.Text + "',ExamFees='" + txExamFees.Text + "',TotalFees='" + txTotalFees.Text + "',Paymode= 'Online',Status = 'Deactive' where SrNo=" + cmbSrNo.Text);
                    cmbSrNo.Items.Remove(cmbSrNo.Text);
                    txCatagory.Text = "";
                    cmbAllCategory.Text = "";
                    cmbCCode.Text = "";
                    txDuration.Text = "";
                    txContents.Text = "";
                    txOfflineInsta.Text = "";
                    txOfflineLum.Text = "";
                    txOnline.Text = "";
                    txExamFees.Text = "";
                    txTotalFees.Text = "";
                    txCName.Text = "";
                    rbtOffline.Checked = false;
                    rbtOnline.Checked = false;
                    MessageBox.Show("Record Delete");
                }
                else if (rbtOffline.Checked == true)
                {
                    GlobalClass.Record_Manip("Update [Addmission$] set AllCategory='" + cmbAllCategory.Text + "',Ccode='" + cmbCCode.Text + "',Cname='" + txCName.Text + "',Contents='" + txContents.Text + "',Duration='" + txDuration.Text + "',OfflineFeesLumsum='" + txOfflineLum.Text + "',OfflineFeesInstalment='" + txOfflineInsta.Text + "',OnlineFees='" + txOnline.Text + "',ExamFees='" + txExamFees.Text + "',TotalFees='" + txTotalFees.Text + "',Paymode= 'Offline',Status = 'Deactive' where SrNo=" + cmbSrNo.Text);
                    cmbSrNo.Items.Remove(cmbSrNo.Text);
                    txCatagory.Text = "";
                    cmbAllCategory.Text = "";
                    cmbCCode.Text = "";
                    txDuration.Text = "";
                    txContents.Text = "";
                    txOfflineInsta.Text = "";
                    txOfflineLum.Text = "";
                    txOnline.Text = "";
                    txExamFees.Text = "";
                    txTotalFees.Text = "";
                    txCName.Text = "";
                    rbtOffline.Checked = false;
                    rbtOnline.Checked = false;
                    MessageBox.Show("Record Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

      
    }
}
