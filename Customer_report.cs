using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class FrmCus_report : Form
    {
        public FrmCus_report()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Frmcriteria_report frm = new Frmcriteria_report();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
          
        }

        private void Add_accounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            frmUN_cus_rep frm = new frmUN_cus_rep();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

    }
}