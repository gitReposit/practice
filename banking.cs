using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class banking : Form
    {
        public banking()
        {
            InitializeComponent();
        }
        db_read dbr = new db_read();
        OdbcDataReader dr = null;
        string values = "";

        private void banking_Load(object sender, EventArgs e)
        {

            values = "select balance from banking where sno= (select max(sno) from banking)";
            //values = "select max(sno)as sno from banking";
            dbr.datareeder(values, ref dr);
            if (dr.Read())
            {
                txtbxBalance.Text = dr["balance"].ToString();
            }
        }

        private void txtbxAmount_Leave(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtbxBalance.Text) - Convert.ToInt32(txtbxAmount.Text);
            txtbxCur_Balance.Text = x.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db_update dbu = new db_update();
            values = "insert into banking (date,check_no,account_tittle,name,amount,balance,slip_no) values('";
            values += dateTimePicker1.Text + "','" + txtbxChk_No.Text + "','" + txtbxAcc_Title.Text + "','" + txtbxName.Text + "'," + txtbxAmount.Text + "," + txtbxCur_Balance.Text + "," + txtbxSlipNo.Text+")";

          
            dbu.update(values);
            this.Hide();
            this.Owner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void banking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}