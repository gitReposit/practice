using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frm1stOrder : Form
    {
        public frm1stOrder()
        {
            InitializeComponent();
        }
        db_read dbr = new db_read();
        OdbcDataReader dr = null;
        string values = "";

        private void banking_Load(object sender, EventArgs e)
        {

            txtcus_id.Focus();
            
            db_read dbr = new db_read();
            dbr.fillComboBoxcustom(cbName, "name", "add_customer"); 
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db_update dbu = new db_update();
            values = "insert into balance (name,id,order_id,`date` ,`credit` ,`debit`) values('";
            values += cbName.Text + "'," + txtcus_id.Text + "," + txtOr_id.Text + ",'" + dateTimePicker1.Text + "'," + txtbxCredit.Text + "," + txtbxDebit.Text + ")";

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

       

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader dr = null;
            string str = "";
           ;
            try
            {//get id of customer
                dbr.datareeder("id", "add_customer", "where name='" + cbName.Text + "'", ref dr);
                if (dr.Read())
                {
                    str = dr["id"].ToString();
                    txtcus_id.Text = str;
                }
                else
                    txtcus_id.Text = "0"; ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbr.closereader();
            int t = 0;

            try
            {// Get order id
                dbr.datareeder("select max(order_id) as order_id from order_table where id=" + txtcus_id.Text + " group by id", ref dr);
                if (dr.Read())
                {
                    t = Convert.ToInt32(dr[0]);
                    int t1 = t + 1;
                    txtOr_id.Text = t1.ToString();
                }
                else
                    txtOr_id.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbr.closereader();
            
            
        }
    }
}