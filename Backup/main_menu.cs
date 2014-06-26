using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnInput_Click_1(object sender, EventArgs e)
        {
            frmAccounts frm = new frmAccounts();
            
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnViewreport_Click(object sender, EventArgs e)
        {
            FrmCus_report cr = new FrmCus_report();
            cr.Owner = this;
            this.Hide();
            cr.Show();

           
        }

        private void btnStalks_Click(object sender, EventArgs e)
        {
            frmStalks_Menu frmM_S = new frmStalks_Menu();
            frmM_S.Owner = this;
            this.Hide();
            frmM_S.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Criteria_bankReport frm = new Criteria_bankReport();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}