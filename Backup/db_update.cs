using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    class db_update
    {
        OdbcConnection conn = new OdbcConnection(@"Driver={MySQL Odbc 3.51 Driver};  Provider=MySQLProv;server=localhost;Database=asimtraders;uid=root;");
        
        public int update(string qury)
        {
            
            int res = 0;               
            try
            {                
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                //MessageBox.Show(cmd.CommandText);
                res = cmd.ExecuteNonQuery();               
            }
            catch
            {
                conn.Close();
                MessageBox.Show("Invalid values");
            }
            conn.Close();
            return res;
        }

        public int update(string vals, string tblName)
        {
            int res = 0;
            try
            {

                conn.Open();
                OdbcCommand cmd = new OdbcCommand();
                cmd.Connection = conn;                
                cmd.CommandText = "insert into " + tblName + " values(" + vals + ")";
                //MessageBox.Show(cmd.CommandText);
                res = cmd.ExecuteNonQuery();
                conn.Close();                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            return res;
        }

        public int insertValues(string tblname,string values)
        {
            int res = 0;
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO " + tblname + " VALUES (" + values + ")";                      
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Invalid Values   "+ex);
            }            
            conn.Close();
            return res;
        }

        public void updateTransaction(string[] qury)
        {
            conn.Open();
            OdbcCommand cmd = conn.CreateCommand();
            OdbcTransaction tr = conn.BeginTransaction();            
            try
            {                
                cmd.Transaction = tr;
                for (int count = 0; count < qury.Length; count++)
                {
                    cmd.CommandText = qury[count];
                    cmd.ExecuteNonQuery();
                }
                tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();
                MessageBox.Show(ex.Message);
                
                conn.Close();
            }
            conn.Close();
        }

        public void ResetIds(string table, string sno)
        {
            conn.Open();
            OdbcCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update " + table + " set sno=sno-1 where sno>" + sno;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
