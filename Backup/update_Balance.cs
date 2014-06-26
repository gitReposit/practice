using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class update_Balance : Form
    {
        public update_Balance()
        {
            InitializeComponent();
        }
        db_read dbr = new db_read();
        OdbcDataReader dr = null;
        string values = "";
        int x = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
             
            values = "insert into balance_update values('" + dateTimePicker1.Text + "'," + txtbxRem_balance.Text + "," + txtbxAddBalance.Text + "," + txtbxCur_balnce.Text + ")";
            db_update dbu = new db_update();
            
            dbu.update(values);
            values = "insert into banking (date,balance) values('" + dateTimePicker1.Text + "'," + txtbxCur_balnce.Text + ")";
            
            dbu.update(values);
            this.Hide();
            this.Owner.Show();
        }

        private void update_Load(object sender, EventArgs e)
        {
             values = "select balance from banking where sno= (select max(sno) from banking)";
            //values = "select max(sno)as sno from banking";
            dbr.datareeder(values, ref dr);
            if (dr.Read())
            {
                txtbxRem_balance.Text = dr["balance"].ToString();
            }
        }

        private void update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void txtbxAddBalance_Leave(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtbxRem_balance.Text) + Convert.ToInt32(txtbxAddBalance.Text);
            txtbxCur_balnce.Text = x.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}