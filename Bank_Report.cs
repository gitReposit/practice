using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmBankReport : Form
    {
        public frmBankReport()
        {
            InitializeComponent();
        }

       


        private void btnbtnGeneal_Click(object sender, EventArgs e)
        {
            editTable et = new editTable();
            et.qury = "select * from banking";
            et.Show();
        }

        private void btnBioData_Click(object sender, EventArgs e)
        {
            editTable et = new editTable();
            et.qury = "select * from balance_update";
            et.Show();
            /*criteriaForBioData vbc = new criteriaForBioData();
            this.Hide();
            vbc.Owner = this;
            vbc.Show();*/            
        }

        private void frmBankReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}