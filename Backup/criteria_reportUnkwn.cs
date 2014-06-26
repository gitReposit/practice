using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmUN_cus_rep : Form
    {
        public frmUN_cus_rep()
        {
            InitializeComponent();
        }
        
        private void rdbSpecific_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = rdbSpecific_rec.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            editTable et = new editTable();
            editTable et1 = new editTable();
            string values = "";
            string valu = "";

            
            if (rbDailyRecord.Checked)
            {
                
                values = "select * from unknown_cus_order where date='" + dateTimePicker1.Text + "'";
                if (chkbxDetails.Checked)
                {
                    valu = "select * from unknown_cus_details where date='" + dateTimePicker1.Text + "'";
                    et1.qury = valu;
                    et1.Show();

                }    
            }

            if (rdbSpecific_rec.Checked)
            {

                values = "select * from unknown_cus_order where date='" + dateTimePicker2.Text + "' and name='" + txtbxCus_name.Text+"'" ;
                if (chkbxDetails.Checked)
                {
                    valu = "select * from unknown_cus_details where sno =(select sno from unknown_cus_order where date='" + dateTimePicker2.Text + "' and name='" + txtbxCus_name.Text+"')";
                    
                    et1.qury = valu;
                    et1.Show();
                }
                
            }

            if (rdbAll.Checked)
            {

                values = "select * from unknown_cus_order";
                if (chkbxDetails.Checked)
                {
                    valu = "select * from unknown_cus_details";
                    et1.qury = valu;
                    et1.Show();


                }
            }
           
            et.qury = values;
            
            et.Show();
            
        }

        

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void Criteria_bankReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            editTable et = new editTable();
            editTable et1 = new editTable();
            string values = "";
            string valu = "";
            values = "select * from unknown_cus_order where sno='" + txtbxSno.Text + "'";
            if (chkbxDetail.Checked)
            {
                valu = "select * from unknown_cus_details where sno='" + txtbxSno.Text + "'";
                et1.qury = valu;
                et1.Show();
            }
            et.qury = values;

            et.Show();
        }

        private void rbDailyRecord_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = rbDailyRecord.Checked;
        }

        

    }
}