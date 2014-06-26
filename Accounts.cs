using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmAccounts : Form
    {
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmCustomer_OrderReg frm = new frmCustomer_OrderReg();

            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmbalance_update frm = new frmbalance_update();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

       

        private void btnViewCases_Click(object sender, EventArgs e)
        {
            frmBank_MENU frm = new frmBank_MENU();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void frmAccounts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCustomer_OrderUnkwn frm = new frmCustomer_OrderUnkwn();
            frm.Owner = this;
            this.Hide();
            frm.Show();

        }

        private void btnIst_order_Click(object sender, EventArgs e)
        {
            frm1stOrder frm = new frm1stOrder();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnCus_Balance_Click(object sender, EventArgs e)
        {

            frmBalnce frm = new frmBalnce();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        
    }
}