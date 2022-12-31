using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Poject
{
    public partial class frmCashRpt : Form
    {
        public frmCashRpt()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.da = new OleDbDataAdapter("select * from [StudentInfo$] where Date= '" + dtpDate.Text +"'", GlobalClass.con);
                GlobalClass.da.Fill(GlobalClass.ds,"[StudentInfo$]");
                rptCash rpt = new rptCash();
                rpt.SetDataSource(GlobalClass.ds.Tables["[StudentInfo$]"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.ds.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalClass.da = new OleDbDataAdapter("select * from [StudentInfo$] where Month= '" + dtpMonth.Text +"'", GlobalClass.con);
                GlobalClass.da.Fill(GlobalClass.ds, "[StudentInfo$]");
                rptCash rpt = new rptCash();
                rpt.SetDataSource(GlobalClass.ds.Tables["[StudentInfo$]"]);
                crystalReportViewer1.ReportSource = rpt;
                GlobalClass.ds.Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void cmbdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCatagory.Text == "Addmission No")
                {
                    GlobalClass.da = new OleDbDataAdapter("select * from [StudentInfo$] where AddmissionNo= '" + cmbdata.Text + "'", GlobalClass.con);
                    GlobalClass.da.Fill(GlobalClass.ds, "[StudentInfo$]");
                    rptCash AddNO = new rptCash();
                    AddNO.SetDataSource(GlobalClass.ds.Tables["[StudentInfo$]"]);
                    crystalReportViewer1.ReportSource = AddNO;
                    GlobalClass.ds.Reset();
                }
                else if (cmbCatagory.Text == "Course")
                {
                    GlobalClass.da = new OleDbDataAdapter("select * from [StudentInfo$] where Course= '" + cmbdata.Text + "'", GlobalClass.con);
                    GlobalClass.da.Fill(GlobalClass.ds, "[StudentInfo$]");
                    rptCash Course = new rptCash();
                    Course.SetDataSource(GlobalClass.ds.Tables["[StudentInfo$]"]);
                    crystalReportViewer1.ReportSource = Course;
                    GlobalClass.ds.Reset();
                }
                else if (cmbCatagory.Text == "Student Name")
                {
                    GlobalClass.da = new OleDbDataAdapter("select * from [StudentInfo$] where StudentName= '" + cmbdata.Text + "'", GlobalClass.con);
                    GlobalClass.da.Fill(GlobalClass.ds, "[StudentInfo$]");
                    rptCash StudentName = new rptCash();
                    StudentName.SetDataSource(GlobalClass.ds.Tables["[StudentInfo$]"]);
                    crystalReportViewer1.ReportSource = StudentName;
                    GlobalClass.ds.Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                cmbdata.Items.Clear();

                if (cmbCatagory.Text == "Addmission No")
                {
                    GlobalClass.record_Reader("Select AddmissionNo from [StudentInfo$] ");
                    while (GlobalClass.dr.Read())
                    {
                        cmbdata.Items.Add(GlobalClass.dr[0].ToString());
                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();
                }
                else if (cmbCatagory.Text == "Course")
                {
                    GlobalClass.record_Reader("Select Distinct(Course) from [StudentInfo$] ");
                    while (GlobalClass.dr.Read())
                    {
                        cmbdata.Items.Add(GlobalClass.dr[0].ToString());
                    }
                    GlobalClass.dr.Close();
                    GlobalClass.con.Close();
                }
                else if (cmbCatagory.Text == "Student Name")
                {
                    GlobalClass.record_Reader("Select Distinct(StudentName) from [StudentInfo$] ");
                    while (GlobalClass.dr.Read())
                    {
                        cmbdata.Items.Add(GlobalClass.dr[0].ToString());
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
    }
}
