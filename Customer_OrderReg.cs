using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmCustomer_OrderReg : Form
    {
        public frmCustomer_OrderReg()
        {
            InitializeComponent();
        }

        private void dgvOrder_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.Rows.Count < 1)
                return;
            if (e.ColumnIndex == 2)
            {
                try
                {
                    if (Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[1].Value) > 0 && Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[2].Value) > 0)
                    {
                        int x = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[1].Value);
                        int y = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[2].Value);
                        dgvOrder.Rows[e.RowIndex].Cells[3].Value = x * y;
                        //MessageBox.Show(Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[1].Value) + "  cell1 " + Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells[1].Value));

                    }
                    //MessageBox.Show(dgvOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             
                
        }
        int y = 0;
        private void dgvOrder_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            y = 0;
            for (int i = 0; i <= e.RowIndex; i++)
            {
                y += Convert.ToInt32(dgvOrder.Rows[i].Cells[3].Value);
            }
            if (e.RowIndex == 0)
                dgvOrder.Rows[e.RowIndex].Cells[4].Value = y;
            else
            {
                dgvOrder.Rows[e.RowIndex-1].Cells[4].Value = 0;
                dgvOrder.Rows[e.RowIndex].Cells[4].Value = y;
            }
 
            
            
        }

        private void dgvOrder_Leave(object sender, EventArgs e)
        {
            int cre = Convert.ToInt32(txtPre_credit.Text)+ y +Convert.ToInt32( txtpre_debit.Text);
            txtPay_Amount.Text = cre.ToString();
        }

        private void txtPaid_Amount_Leave(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtPay_Amount.Text);
            int c = Convert.ToInt32(txtPaid_Amount.Text);
            int z = x - c;
            if (z > 0)
                txtCur_credit.Text = z.ToString();
            if (z < 0)
                txtcur_debit.Text = z.ToString();
        }

        private void Input_Customer_Load(object sender, EventArgs e)
        {
            // Names to combobox
            txtcus_id.Focus();
            this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellLeave);
           db_read dbr = new db_read();
           dbr.fillComboBoxcustom(cbName, "name", "add_customer");         
        } 

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader dr=null;
            string str = "";
            txtCur_credit.Text = "0";
            txtcur_debit.Text = "0";
            txtPre_credit.Text = "0";
            txtpre_debit.Text = "0";
            txtPay_Amount.Text = "0";
            txtPaid_Amount.Text = "0";
            try
            {//get id of customer
                dbr.datareeder("id","add_customer", "where name='" + cbName.Text + "'",ref dr);
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
            int t=0;
            
               try
                {// Get order id
                  dbr.datareeder("select max(order_id) as order_id from balance where id=" + txtcus_id.Text + " group by id",ref dr);
                    if (dr.Read())
                    {
                       t  =Convert.ToInt32( dr[0]);
                       int t1 = t+1;
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
                dbr.closereader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_update dbu = new db_update();
            string values="";
           
            for (int i = 0; i < dgvOrder.Rows.Count-1; i++)
            { 
                // inserting items that have been ordered(details)
            values = Convert.ToInt32(txtcus_id.Text) + ",";
            values += Convert.ToInt32(txtOr_id.Text) + ",";
            values += "'" + dateTimePicker1.Text + "'" + ",";
            values += "'" + dgvOrder.Rows[i].Cells[0].Value.ToString() +"'" + ",";
            values += "'" + dgvOrder.Rows[i].Cells[1].Value.ToString() +"'" + ",";
            values += "'" + dgvOrder.Rows[i].Cells[2].Value.ToString() + "'" + ",";
            values += "'" + dgvOrder.Rows[i].Cells[3].Value.ToString() + "'" ;
            
                
            dbu.update(values, "order_table");
            }
            // inserting main values of order
            values = "'" + cbName.Text + "'" + ",";
            values += Convert.ToInt32(txtcus_id.Text) + ",";
            values += Convert.ToInt32(txtOr_id.Text) + ",";
            values += "'" + dateTimePicker1.Text + "'" + ",";
            values += y.ToString()+ ",";
            values += Convert.ToInt32(txtPay_Amount.Text) + ",";
            values += Convert.ToInt32(txtPaid_Amount.Text) + ",";
            values += Convert.ToInt32(txtCur_credit.Text) + ",";
            values += Convert.ToInt32(txtcur_debit.Text) ;
           
            dbu.update(values, "balance");
            // updateing stock

            values = "";
                values = "select ";
            // retrive
            for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
            {

                if (i == 0)
                    values += dgvOrder.Rows[i].Cells[0].Value.ToString(); //+ "=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
                else
                    values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();// +"=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
            }
            values += " from current_stalk";
            
           // updat
            db_read dbr = new db_read();
            OdbcDataReader dr = null;
            dbr.datareeder(values, ref dr);
            values = "update current_stalk set ";
            if (dr.Read())
            {
                for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                {
                 int value =Convert.ToInt32(dr[dgvOrder.Rows[i].Cells[0].Value.ToString()]) - Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value);
                 
                 if (i == 0)
                     values += dgvOrder.Rows[i].Cells[0].Value.ToString() + "=" + value.ToString();
                 else
                     values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString() + "=" + value.ToString();
                }

             }
            
             dbu.update(values);

            //this.Close();

            // daily stalk
             values = "";
             values = "select ";
            // retrieve
             for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
             {

                 if (i == 0)
                     values += dgvOrder.Rows[i].Cells[0].Value.ToString(); //+ "=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
                 else
                     values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();// +"=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
             }
             values += ",Daily_Debt,Daily_Credit,Daily_Sale from daily_stalk where date=" + "'" + dateTimePicker1.Text + "'";
             

              dbr = new db_read();
             dr = null;
             dbr.datareeder(values, ref dr);


             
            // if retrive than update
             if (dr.Read())
             {
                 values = "update daily_stalk set ";
                 for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                 {
                     int value = Convert.ToInt32(dr[dgvOrder.Rows[i].Cells[0].Value.ToString()]) + Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value);
                     if (i == 0)
                         values += dgvOrder.Rows[i].Cells[0].Value.ToString() + "=" + value.ToString();
                     else
                     {
                         values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString() + "=" + value.ToString();
                     }
                 }
                
                 //,,Daily Sale
                 int value1 = Convert.ToInt32(dr["Daily_Debt"]) + Convert.ToInt32(txtcur_debit.Text);
                 int value2 = Convert.ToInt32(dr["Daily_Credit"]) + Convert.ToInt32(txtCur_credit.Text);
                 int value3 = Convert.ToInt32(dr["Daily_Sale"]) + Convert.ToInt32(txtPaid_Amount.Text);

                 values += ",Daily_Debt=" + value1;
                 values += ",Daily_Credit=" + value2;
                 values += ",Daily_Sale=" + value3;
                 values += " where date=" + "'" + dateTimePicker1.Text + "'" ;
                 
                 dbu.update(values);
             }
                 // insert a new row for next day
             else
             {
                 values = "insert into daily_stalk (date";

                 for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                 {
                     values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();
                 }
                 values += ",Daily_Debt,Daily_Credit,Daily_Sale)";
                 values += " values(" + "'" + dateTimePicker1.Text + "'";
                 for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                 {
                     values +=","+ Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value);
               
                 }
                 values += "," + Convert.ToInt32(txtcur_debit.Text);
                 values += "," + Convert.ToInt32(txtCur_credit.Text) ;
                 values += "," + Convert.ToInt32(txtPaid_Amount.Text);
                 

                 values += ")";
                
             }
             dbr = new db_read();
             dr = null;
             dbr.datareeder(values, ref dr);
             this.Hide();
             this.Owner.Show();
           
             

             


        }

        private void txtPaid_Amount_TextChanged(object sender, EventArgs e)
        {
            txtCur_credit.Text = "0";
            txtcur_debit.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
           
        }

        private void frmInputOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

       

    }
}