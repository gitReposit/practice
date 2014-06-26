using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    class db_read
    {
        OdbcConnection conn = new OdbcConnection(@"Driver={MySQL Odbc 3.51 Driver};Provider=MySQLProv;server=localhost;Database=asimtraders;uid=root;");

        public  DataSet readDS(string qury)
        {
            
            DataSet ds = null;
            try
            {                
                ds = new DataSet();
                
                OdbcDataAdapter dap = new OdbcDataAdapter(qury, conn);
                dap.Fill(ds);                
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

      
        public  string checkExistance(string field, string tblname, string criteria)
        {            
            string res = "";
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
               // MessageBox.Show("select " + field + " from " + tblname + criteria);
                cmd.CommandText = "select " + field + " from " + tblname + criteria;
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    res = dr[field].ToString();
                }
                else
                    MessageBox.Show("Search Result Nothing.....you have to ADD New");

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);                
            }
            return res;
        }

        public  void fillComboBox(ComboBox cb)
        {            
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select CNIC from Personal_Info";
                OdbcDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {                    
                    cb.Items.Add(dr[0].ToString());
                    cb.AutoCompleteCustomSource.Add(dr[0].ToString());
                }
                    

                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }            
        }
        public  void fillComboBoxcustom(ComboBox cb,string field,string tbl)
        {
            conn.Open();
            try
            {
                
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select "+field+" from "+tbl;
                OdbcDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[0].ToString());
                    cb.AutoCompleteCustomSource.Add(dr[0].ToString());
                }


               
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }


        public  void datareeder(string field, string tblname, string criteria,ref OdbcDataReader dr)
        {
            
                conn.Open();
               
            try
            {
                
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select " + field + " from " + tblname + " " + criteria;
                 dr = cmd.ExecuteReader();

             }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            
            
        }       

        public  void datareeder(string qury,ref OdbcDataReader dr)
        {
           
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                dr = cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                conn.Close();    
                MessageBox.Show(ex.Message);
            }
             
                       
        }

        public  void fillCheckBoxlist(string qury, CheckedListBox cbl)
        {
            OdbcDataReader dr = null;
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                dr = cmd.ExecuteReader();                
                while (dr.Read())
                {
                    if (dr[0].ToString() != "Sno" && dr[0].ToString() != "CNIC")
                        cbl.Items.Add(dr[0].ToString());                    
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }       
        }

        public  void fillComboBox(string field, string table, ComboBox cb)
        {
            try
            {                
                cb.Items.Clear();
                AutoCompleteStringCollection data = new AutoCompleteStringCollection();
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select distinct " + field + " from " + table + " order by " + field;                
                OdbcDataReader dr = cmd.ExecuteReader();                                
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
                conn.Close();
                MessageBox.Show(ex.Message);
            }                       
        }

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
        public  string readLstClmnCel(string field,string tblname)
        {
            string rtrn = "";
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select " + field + " from " + tblname;
                
                OdbcDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    rtrn = dr[field].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return rtrn;
        }
        public DataTable readDt(string qury)
        {
            DataSet ds = new DataSet();
            OdbcDataAdapter dap = new OdbcDataAdapter(qury, conn);
            dap.Fill(ds);
            return ds.Tables[0];
        }
    }
}
