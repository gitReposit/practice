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
    public partial class frmCustomer_OrderUnkwn : Form
    {
        public frmCustomer_OrderUnkwn()
        {
            InitializeComponent();
        }
        int sno = 0;

        private void dgvOrder_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            /// cell enter
           
            if (e.ColumnIndex == 3)
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
            
            txtPay_Amount.Text = y.ToString();
        }



        private void Input_Customer_Load(object sender, EventArgs e)
        {
            string values = "select max(sno) as sno from unknown_cus_order";
            db_read dbr = new db_read();
            OdbcDataReader dr = null;
            dbr.datareeder(values, ref dr);
            if (dr.Read())
            {
                sno = Convert.ToInt32(dr["sno"]);
                sno += 1;// for next entry
                label4.Text=sno.ToString();
            }
        }

        /*private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader dr=null;
            string str = "";
           
            txtPay_Amount.Text = "0";
            txtPaid_Amount.Text = "0";
           
            int t=0;
            
               try
                {
                  dbr.datareeder("select max(order_id) as order_id from order_table where id=" + txtcus_id.Text + " group by id",ref dr);
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
                {
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
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            db_update dbu = new db_update();
            string values = "";

            for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
            {
                values = sno + ",";

                values += "'" + dateTimePicker1.Text + "'" + ",";
                values += "'" + dgvOrder.Rows[i].Cells[0].Value.ToString() + "'" + ",";
                values += "'" + dgvOrder.Rows[i].Cells[1].Value.ToString() + "'" + ",";
                values += "'" + dgvOrder.Rows[i].Cells[2].Value.ToString() + "'" + ",";
                values += "'" + dgvOrder.Rows[i].Cells[3].Value.ToString() + "'";


                dbu.update(values, "unknown_cus_details");
            }

            //
            //
            //
            values = sno + ",";
            values += "'" + cbName.Text + "'" + ",";
            values += "'" + dateTimePicker1.Text + "'" + ",";
            values += y.ToString();


            dbu.update(values, "unknown_cus_order");

            //Updating current Stalk table
            values = "";
                values = "select ";
            for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
            {

                if (i == 0)
                    values += dgvOrder.Rows[i].Cells[0].Value.ToString(); //+ "=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
                else
                    values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();// +"=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
            }
            values += " from current_stalk";
       
           
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
            //


         //DAIlY sale
             values = "";
             values = "select ";
             for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
             {

                 if (i == 0)
                     values += dgvOrder.Rows[i].Cells[0].Value.ToString(); //+ "=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
                 else
                     values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();// +"=" + dgvOrder.Rows[i].Cells[1].Value.ToString();
             }
             values += ",Daily_Sale from daily_stalk where date=" + "'" + dateTimePicker1.Text + "'";
             

              dbr = new db_read();
             dr = null;
             dbr.datareeder(values, ref dr);


             

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
                 
                 int value3 = Convert.ToInt32(dr["Daily_Sale"]) + Convert.ToInt32(txtPaid_Amount.Text);

                
                 values += ",Daily_Sale=" + value3;
                 
                 dbu.update(values);
             }
                 
             else
             {
                 values = "insert into daily_stalk (date";

                 for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                 {
                     values += "," + dgvOrder.Rows[i].Cells[0].Value.ToString();
                 }
                 values += ",Daily_Sale)";
                 values += " values(" + "'" + dateTimePicker1.Text + "'";
                 for (int i = 0; i < dgvOrder.Rows.Count - 1; i++)
                 {
                     values +=","+ Convert.ToInt32(dgvOrder.Rows[i].Cells[1].Value);
               
                 }
                
                 values += "," + Convert.ToInt32(txtPaid_Amount.Text);
                 

                 values += ")";
                 
             }
             dbr = new db_read();
             dr = null;
             dbr.datareeder(values, ref dr);
             this.Hide();
            this.Owner.Show();
            
           





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