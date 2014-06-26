using System;
using System.Data.Odbc;
using System.Windows.Forms;

namespace AsimTraders
{
    class db_scalar
    {
        OdbcConnection conn = new OdbcConnection(@"Driver={MySQL Odbc 3.51 Driver};Provider=MySQLProv;server=localhost;Database=asimtraders;uid=root;");        
        public static int getSno(string tblName)
        {
            int sno = 0;                      
            try
            {
                OdbcConnection conn = new OdbcConnection(@"Driver={MySQL Odbc 3.51 Driver};Provider=MySQLProv;server=localhost;Database=asimtraders;uid=root;");        
                conn.Open();                
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select max(sno) from " + tblName;
                object ob = (object)cmd.ExecuteScalar();
                string temp = ob.ToString();
                if (temp.Length > 0)
                    sno = Convert.ToInt32(temp);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            return ++sno;
        }

        public static int getSno(string tblName,string field)
        {
            int sno = 0;
            try
            {
                OdbcConnection conn = new OdbcConnection(@"Driver={MySQL Odbc 3.51 Driver};Provider=MySQLProv;server=localhost;Database=asimtraders;uid=root;");        
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select max(" + field + ") from " + tblName;
                object ob = (object)cmd.ExecuteScalar();
                string temp = ob.ToString();
                if (temp.Length > 0)
                    sno = Convert.ToInt32(temp);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ++sno;
        }

        public long longscalar(string qury)
        {
            long res = 0;
            conn.Open();
            try
            {
                object ob = null;
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                ob = cmd.ExecuteScalar();
                string temp = "";
                if (ob != null)
                    temp = ob.ToString();
                if (temp.Length != 0)
                    res = Convert.ToInt32(temp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return res;
        }

        public string stringscalar(string qury)
        {
            string res = "0";
            try
            {
                conn.Open();
                OdbcCommand cmd = conn.CreateCommand();
                cmd.CommandText = qury;
                object ob = (object)cmd.ExecuteScalar();
                string a = ob.ToString();
                if (a.Length != 0 && a != null)
                    res = a;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return res;
        } 
    }
}
