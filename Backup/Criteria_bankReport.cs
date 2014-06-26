using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AsimTraders
{
    public partial class Criteria_bankReport : Form
    {
        public Criteria_bankReport()
        {
            InitializeComponent();
        }

        private void rdbSpecific_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = rdbSpecific.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbSpecific.Checked)
            {
                editTable et = new editTable();
                et.qury = "select * from balance_update where date='" + dateTimePicker1.Text + "'";
                et.Show();
            }

            if (rdbAll.Checked)
            {
                editTable et = new editTable();
                et.qury = "select * from balance_update";
                et.Show();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = rbSpecific_rec.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbSpecific_rec.Checked)
            {
                string values = "select * from banking where ";

                if (chkbxName.Checked)
                    values += "name like ('%" + txtbxCus_name.Text + "%')";
                else
                    values += "name like ('%" + "" + "%')";
                if (chkbxDate.Checked)
                    values += " and date='" + dateTimePicker2.Text + "'";
                MessageBox.Show(values);

                editTable et = new editTable();
                et.qury = values;
                et.Show();
            }

            if (rbAll_rec.Checked)
            {
                editTable et = new editTable();
                et.qury = "select * from banking";
                et.Show();
            }

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

        

      

        



    }
}