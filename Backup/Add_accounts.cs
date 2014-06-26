using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmbalance_update : Form
    {
        public frmbalance_update()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmAdd_customer frm = new frmAdd_customer();
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

    }
}