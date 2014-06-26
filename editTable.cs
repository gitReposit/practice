using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace AsimTraders
{
    public partial class editTable : Form
    {
        public editTable()
        {
            InitializeComponent();
        }

        public string tblnm = "";
        public string qury = "";
        public string criteria="";

        private void viewReport_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("-- View Report Load"); 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(viewReport_KeyDown);
            db_read dread = new db_read();            
            DataSet ds = dread.readDS(qury);
            dataGridView1.DataSource = ds.Tables[0];
            this.WindowState = FormWindowState.Maximized;
            if (dataGridView1.Columns[0].Name == "sno" || dataGridView1.Columns[0].Name == "Sno")
                dataGridView1.Columns[0].ReadOnly = true;
        }

        private void viewReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                this.Close();
            else
            {
                if (!dataGridView1.Focused)
                    return;
                db_update d = new db_update();
                int x = dataGridView1.CurrentCell.RowIndex;
                int y = dataGridView1.CurrentCell.ColumnIndex;

                if (e.KeyValue == 46)
                {
                    string id = dataGridView1.Columns[0].Name;
                    if (id != "Sno" && id != "Visit_Sno")
                        preVal1 = "'" + preVal1 + "'";
                    qury = "delete from " + tblnm + " where " + id + "=" + preVal1 + " and " + dataGridView1.Columns[1].Name + "=" + preVal2;
                    d.update(qury);
                }
                else
                    if (e.KeyValue == 13)
                    {
                        string strr = "";
                        if (dataGridView1.Columns[y].Name == "file_attached")
                        {
                            if (dataGridView1.Rows[x].Cells[y].Value.ToString() == "yes")
                            {

                                strr = dataGridView1.Rows[x].Cells[0].Value.ToString();
                                try
                                {
                                    Process.Start("d:\\data\\" + strr + ".doc");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(" " + ex);
                                }
                            }
                            

                        }
                    }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print();
            export_datagridview_to_excel(dataGridView1, "StudentMarks.xls");
        }
        private void print()
        {
          //  PrintDGV1.Print_DataGridView(dataGridView1, tblnm +" Report on " + DateTime.Now.ToString("yyyy-MM-dd"));
        }

        

        string preVal1 = "", preVal2 = "";
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            preVal1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
           
            preVal2 = "'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            db_update d = new db_update();
            string field = dataGridView1.Columns[e.ColumnIndex].Name;
            try
            {
                string id = dataGridView1.Columns[0].Name;
                string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (field != "sno" && field != "Visit_Sno" && field != "Amount")
                    value = "'" + value + "'";
                if (id != "Sno" && id != "Visit_Sno")
                    preVal1 = "'" + preVal1 + "'";
                preVal2 = "'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
                if (e.ColumnIndex > 1)
                    qury = "update " + tblnm + " set " + field + "=" + value + " where " + id + "=" + preVal1 + " and " + dataGridView1.Columns[1].Name + "=" + preVal2;
                else
                    if (e.ColumnIndex == 1)
                        qury = "update " + tblnm + " set " + field + "=" + value + " where " + id + "=" + preVal1;
                    else
                        if (e.ColumnIndex == 0)
                            return;
                d.update(qury);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //preVal1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        
            //preVal2 = "'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'";
        }
        public void export_datagridview_to_excel(DataGridView dgv, string excel_file)
        {
            int cols;
            //open file
            StreamWriter wr = new StreamWriter(excel_file);

            //determine the number of columns and write columns to file
            cols = dgv.Columns.Count;
            for (int i = 0; i < cols; i++)
            {
                wr.Write(dgv.Columns[i].Name.ToString().ToUpper() + "\t");
            }

            wr.WriteLine();

            //write rows to excel file
            for (int i = 0; i < (dgv.Rows.Count - 1); i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                        wr.Write(dgv.Rows[i].Cells[j].Value + "\t");
                    else
                    {
                        wr.Write("\t");
                    }
                }

                wr.WriteLine();
            }

            //close file
            wr.Close();
        }


        
    }
}
/* values = "'" + txtReg.Text + "'" + ",";
            values += "'" + txtName.Text + "'" + ",";
            values += "'" + gender + "'" + ",";
            values += "'" + dtpDOB.Text + "'" + ",";
            values += "'" + txtPob.Text + "'" + ",";
            values += "'" + txtReligons.Text + "'" + ",";
            values += "'" + txtNationality.Text + "'" + ",";
            values += "'" + txtFname.Text + "'" + ",";
            values += "'" + txtFnic.Text + "'" + ",";
            values += "'" + txtFocc.Text + "'" + ",";
            values += "'" + txtPrAddr.Text + "'" + ",";
            values += "'" + txtMobNo.Text + "'" + ",";
            values += "'" + txtSno.Text + "'" + ",";
            values += "'" + dtpAdmDate.Text + "'" + ",";
            values += "'" + txttested.Text + "'" + ",";
            values += "'" + txtRemarks.Text + "'" + ",";
            values += "'" + txtClass.Text + "'" + ",";
            values += Convert.ToInt32(txtADMISSION_FEE.Text) + ",";
            values += Convert.ToInt32(txtSECURITY.Text) + ",";
            values += Convert.ToInt32(txtREG_FEE.Text) + ""; */