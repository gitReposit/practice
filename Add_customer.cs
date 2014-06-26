using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class frmAdd_customer : Form
    {
        public frmAdd_customer()
        {
            InitializeComponent();
        }

        private void Add_customer_Load(object sender, EventArgs e)
        {
            int cre = 0;
            db_read dbr = new db_read();
            string str = "select max(id) as id from add_customer";
            OdbcDataReader dr =null;
            dbr.datareeder(str, ref dr);
            if (dr.Read())
            {
                cre = (Convert.ToInt32(dr["id"]) + 1);
            }

            
            
            lblCus_id.Text = cre.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string values="";
            values =  lblCus_id.Text + ",";
            values += "'" + txtName.Text + "'" + ",";
            values += "'" + txtAddress.Text + "'" + ",";
            values += "'" + txtPhoneNo.Text + "'" + ",";
            values += "'" + txtDetails.Text + "'" + ",";
            values += "'" + txtCustomerType.Text + "'";
            db_update dbu = new db_update();
            dbu.insertValues("add_customer", values);
            this.Hide();
            this.Owner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void frmAdd_customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}