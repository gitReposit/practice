using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmStalks_Menu : Form
    {
        public frmStalks_Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {            
                    
        }

        private void btnGeneal_Click(object sender, EventArgs e)
        {
            frmStalks_update frmS_U = new frmStalks_update();
            frmS_U.Owner = this;
            this.Hide();
            frmS_U.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            editTable et0 = new editTable();
            et0.qury="select * from current_stalk ";
            et0.tblnm = "current_stalk";
            et0.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void frmStalks_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnBioData_Click(object sender, EventArgs e)
        {

        }

        private void btnBioData_Click_1(object sender, EventArgs e)
        {
            editTable et = new editTable();
            et.qury = "select * from daily_stalk where date=" + "'" + dateTimePicker1.Text + "'";
            et.Show();
        }

       


     
       
    }
}