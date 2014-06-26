using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmBank_MENU : Form
    {
        public frmBank_MENU()
        {
            InitializeComponent();
        }

        private void Bank_MENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnGeneal_Click(object sender, EventArgs e)
        {
           update_Balance frm = new update_Balance();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnBioData_Click(object sender, EventArgs e)
        {
            banking frm = new banking();
            frm.Owner = this;
            this.Hide();
            frm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void frmBank_MENU_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}