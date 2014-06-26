using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace AsimTraders
{
    class db_read_access
    {

       // OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Database\SIT.accd;Persist Security Info=False");
                     
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=D:\database\SIT.accdb");
        public DataSet readDS(string qury, string tabl)
        {
            DataSet ds = new DataSet();
            try
            {                
                OleDbDataAdapter adp = new OleDbDataAdapter(qury, conn);               
                adp.Fill(ds, tabl);                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
            return ds;
        }        

        public string readAvalue(string field, string tblname, string criteria)
        {
            string res = "";            
            if (criteria.Length != 0)
                criteria = " where " + criteria;
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select " + field + " from " + tblname + criteria;
                //MessageBox.Show(cmd.CommandText);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    res = dr[field].ToString();

                conn.Close();
               // MessageBox.Show("--");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            return res;
        }        


        public OleDbDataReader datareeder(string field, string tblname, string criteria)
        {            
            if (criteria.Length != 0)
                criteria = " where " + criteria;
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.CommandText = "select " + field + " from " + tblname + criteria;                       
            return dr;
        }

        public OleDbDataReader datareeder(string qury)
        {
            OleDbDataReader dr = null;
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dr;           
        }        

        public void filComboBox(string field, string table, ComboBox cb)
        {
            try
            {                
                cb.Items.Clear();
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select distinct " + field + " from " + table + " order by " + field;
                //MessageBox.Show(cmd.CommandText);
                OleDbDataReader dr = cmd.ExecuteReader();                                
                while (dr.Read())
                {                    
                    cb.Items.Add(dr[field].ToString());
                    data.Add(dr[field].ToString());                    
                }               
                cb.AutoCompleteCustomSource = data;                
                conn.Close();                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
            }                       
        }
        
        // Not Much Good
        /* Inefficient
        public void filGrid(DataTable dt, DataGridView dgv)
        {
            for (int d = 0; d < dt.Columns.Count; d++)
            {
                string hed = dt.Columns[d].ColumnName;
                dgv.Columns.Add(hed, hed);
            }
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                dgv.Rows.Add();
                for (int c = 0; c < dt.Columns.Count; c++)
                    dgv.Rows[r].Cells[c].Value = dt.Rows[r][c].ToString();
            }
        }*/

        public void closereader()
        {            
            try
            {
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
