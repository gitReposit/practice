using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmBalnce : Form
    {
        public frmBalnce()
        {
            InitializeComponent();
        }
        db_read dbr = new db_read();
        OdbcDataReader dr = null;
        string values = "";
        string str0 = "";
        private void banking_Load(object sender, EventArgs e)
        {
           str0= dateTimePicker1.Text;
            txtcus_id.Focus();
            
            db_read dbr = new db_read();
            dbr.fillComboBoxcustom(cbName, "name", "add_customer"); 
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader drr = null;
            db_update dbu = new db_update();
            values = "insert into customer_balance (name,id,order_id,`date`,amount) values('";
            values += cbName.Text + "'," + txtcus_id.Text + "," + txtOr_id.Text + ",'" + dateTimePicker1.Text + "'," + txtbxPaidAmount.Text + ")";
            
            dbu.update(values);
            values = "";
            values = "update balance set credit=" + txtCur_credit.Text + ",debit=" + txtcur_debit.Text + " where name='" + cbName.Text + "' and order_id=" + txtOr_id.Text;

            
            dbu.update(values);
            //Daily Sale
            values = "select Daily_Sale from daily_stalk where date='" + dateTimePicker1.Text + "'";
            dbr.datareeder(values, ref drr);
            if (drr.Read())
            {
                int vall = Convert.ToInt32(drr["Daily_Sale"]);
                vall += Convert.ToInt32(txtbxPaidAmount.Text);
                values = "update daily_stalk set Daily_Sale=" + vall;
                dbu.update(values);
            
            }
            else
            {
                values = "insert into daily_stalk (date,Daily_Sale) values('" + dateTimePicker1.Text+ "','" + txtbxPaidAmount.Text + "')";
                dbu.update(values);
            }
            


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
            txtbxCredit.Text = "0";
            txtbxDebit.Text = "0";
            txtCur_credit.Text = "0";
            txtcur_debit.Text = "0";
            txtbxPaidAmount.Text = "0";
            try
            {
                //get last order Values  of customer
                string valu = "select * from balance where order_id=(select max(order_id) as order_id from balance where name='" + cbName.Text + "') and name='" + cbName.Text + "'";
                
                //dbr.datareeder("id", "add_customer", "where name='" + cbName.Text + "'", ref dr);

                
                dbr.datareeder(valu, ref dr);
                
                if (dr.Read())
                {
                    str = dr["id"].ToString();
                    txtcus_id.Text = str;

                    str = dr["order_id"].ToString();
                    txtOr_id.Text = str;

                   // str = dr["Date"].ToString();
                    //dateTimePicker1.Text = str;

                    str = dr["credit"].ToString();
                    txtbxCredit.Text = str;

                    str = dr["debit"].ToString();
                    txtbxDebit.Text = str;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            dbr.closereader();
            /*  int t = 0;

                try
                {// Get order id
                    dbr.datareeder("select max(order_id) as order_id from order_table where id=" + txtcus_id.Text + " group by id", ref dr);
                    if (dr.Read())
                    {
                        t = Convert.ToInt32(dr[0]);
                        int t1 = t + 1;
                        txtOr_id.Text = t1.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dbr.closereader();
                try
                {// debit credit retrive
                    dbr.datareeder("select credit,debit from balance where id=" + txtcus_id.Text + " and order_id=" + t.ToString() + " group by id", ref dr);
                    // MessageBox.Show("select credit,debit from balance where id=" + txtcus_id.Text + " and order_id=" + t.ToString());
                    if (dr.Read())
                    {
                        txtPre_credit.Text = dr["credit"].ToString();
                        txtpre_debit.Text = dr["debit"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                dbr.closereader();*/
            }
        

         private void textBox1_Leave(object sender, EventArgs e)
        {
            int cre = Convert.ToInt32(txtbxCredit.Text) + Convert.ToInt32(txtbxDebit.Text) - Convert.ToInt32(txtbxPaidAmount.Text);
            if (cre == 0)
            {
                txtcur_debit.Text = "0";
                txtCur_credit.Text = "0";
            }
                if (cre < 0)
                txtcur_debit.Text = cre.ToString();
            else
                txtCur_credit.Text = cre.ToString();
        }

      

        

      

        

             
    }
}