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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void frmWelcome_Load_1(object sender, EventArgs e)
        {
            lbName.BackColor = System.Drawing.Color.Transparent;
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Left = lbName.Left + 10;

            if (lbName.Left >= this.Width - lbName.Width-15 )
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbName.Left = lbName.Left - 10;

            if (lbName.Left <= lbName.Width-480 )
            {
                timer2.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
