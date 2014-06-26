using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class Frmcriteria_report : Form
    {
        public Frmcriteria_report()
        {
            InitializeComponent();
        }

        
        private void criteriaForGeneralInfo_Load(object sender, EventArgs e)
        {
            //this.dgvOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellLeave);
            db_read dbr = new db_read();
            dbr.fillComboBoxcustom(cbName, "name", "add_customer");            
           
        }
        
       
     
        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader dr = null;
            string str = "";
            try
            {
                dbr.datareeder("id", "add_customer", "where name='" + cbName.Text + "'", ref dr);
                if (dr.Read())
                {
                    str = dr["id"].ToString();
                }
                txtcus_id.Text = str;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbr.closereader();
            int t = 0;
            
           try
            {
                dbr.datareeder("select max(order_id) as order_id from order_table where id=" + txtcus_id.Text + " group by id", ref dr);
                if (dr.Read())
                {
                    t = Convert.ToInt32(dr[0]);
                   
                    txtOr_id.Text = t.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbr.closereader();
            
        }

        private void rdbSpecific_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSpecific.Checked)
            {
                txtOrderSpecific.Enabled = true;
                lblOrderSpecific.Enabled = true;
            }
            if (!rdbSpecific.Checked)
            {
                txtOrderSpecific.Enabled = false;
                lblOrderSpecific.Enabled = false;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            editTable et = new editTable();
            editTable et1 = new editTable();
            editTable et2 = new editTable();
            if(rdbSpecific.Checked)
            {
                
                //et.tblnm = "balance";
                //et.criteria = "";
                et.qury = "select * from balance where id=" + txtcus_id.Text + " and order_id=" + txtOrderSpecific.Text + " group by id";
                et.Show();
                if (chkbxOrderDetails.Checked)
                {
                    et1.qury = "select * from order_table where id=" + txtcus_id.Text + " and order_id=" + txtOrderSpecific.Text ;
                    et1.Show();

                }
                if (chkbxBalnce.Checked)
                {
                    et2.qury = "select * from customer_balance where id=" + txtcus_id.Text + " and order_id=" + txtOrderSpecific.Text;
                }
            }
                if(rdbAll.Checked)
                {
                    et.qury = "select * from balance where id=" + txtcus_id.Text ;
                    et.Show();
                    if (chkbxOrderDetails.Checked)
                    {
                        et1.qury = "select * from order_table where id=" + txtcus_id.Text;
                        et1.Show();
                    }
                    if (chkbxBalnce.Checked)
                    {
                        et2.qury = "select * from customer_balance where id=" + txtcus_id.Text;
                    }


                       
                }
                if (rdbLast.Checked) 
                {
                    if (chkbxOrderDetails.Checked)
                    {
                        et1.qury = "select * from order_table  where id=" + txtcus_id.Text + " and order_id=" + txtOr_id.Text ;
                        et1.Show();
                    }
                    et.qury = "select * from balance where id=" + txtcus_id.Text + " and order_id=" + txtOr_id.Text + " group by id";
                    et.Show();
                    if (chkbxBalnce.Checked)
                    {
                        string str = "select max(sno) as sno from customer_balance where id=" + txtcus_id.Text+" group by id";
                        et2.qury = "select * from customer_balance where id=" + txtcus_id.Text + " and sno=("+str+")";
                        MessageBox.Show(et2.qury);
                    }
                }

                if (chkbxBalnce.Checked)
                {
                    et2.Show();
                }


        }

        private void chkbxCus_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxCus_Name.Checked)
                txtbxCus_name.Enabled = true;
            else
                txtbxCus_name.Enabled = false;

            if (chkbxCus_Id.Checked)
                txtBxCus_Id.Enabled = true;
            else
                txtBxCus_Id.Enabled = false;
            
            if (chkbxAddress.Checked)
                txtbxCus_Adsress.Enabled = true;
            else
                txtbxCus_Adsress.Enabled = false;
            
            if (chkbxDetails.Checked)
                txtbxDetails.Enabled = true;
            else
                txtbxDetails.Enabled = false;
            
            if (chkbxCus_type.Checked)
                txtbxCus_type.Enabled = true;
            else
                txtbxCus_type.Enabled = false;
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string values = "select * from add_customer where ";

            if (chkbxCus_Name.Checked)
                values += "name like ('%"+txtbxCus_name.Text+"%')";
            else
                values += "name like ('%"+""+"%')";

             if (chkbxCus_Id.Checked)
                 values += " and id like ('%" + txtBxCus_Id.Text + "%')";

             if (chkbxAddress.Checked)
                 values += " and address like ('%" + txtbxCus_Adsress.Text + "%')";

             if (chkbxDetails.Checked)
                 values += " and details like ('%" + txtbxDetails.Text + "%')";

             if (chkbxCus_type.Checked)
                 values += " and customer type like ('%" + txtbxCus_type.Text + "%')";
             MessageBox.Show(values);
             editTable et2 = new editTable();
             et2.qury = values;
             et2.Show();
       
        }

        private void criteria_report_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

      
    }
}