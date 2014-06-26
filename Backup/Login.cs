using System;
using System.Data.Odbc;
using System.Drawing;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace AsimTraders
{
    public partial class Login : Form
    {
        public static string uname = "";
        db_read dRead = new db_read();
        public Login()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {                
                submit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.KeyValue.ToString()); return;
                if (e.KeyValue == 13)
                {
                    if (txtuname.Focused)
                        txtPass.Focus();
                    else
                        if (txtPass.Focused)
                            submit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void submit()
        {
            try
            {                
                int dattime = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                if (dattime < 2011)
                {
                    MessageBox.Show("First Set Your Date and Time Of Windows");
                    return;
                }

                string role = dRead.checkExistance("role", "users", " where uname='" + txtuname.Text + "' and pass='" + txtPass.Text + "'");
                if (role.Length > 0)
                {
                    txtPass.Text = "";
                    uname = txtuname.Text;
                    this.Hide();
                    FrmMainMenu m = new FrmMainMenu();
                    m.Owner = this;
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User Name or Password");
                }
                switch (role)
                {
                    case "Chief":
                        break;
                    case "Admin":
                        break;
                    case "SalesMan":
                        break;
                    default: break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                db_read d = new db_read();
                OdbcDataReader dr = null;
                    d.datareeder("select uname from users",ref dr);
                while (dr.Read())
                {
                    txtuname.Items.Add(dr["uname"].ToString());
                    txtuname.AutoCompleteCustomSource.Add(dr["uname"].ToString());
                }
                d.closereader();                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

