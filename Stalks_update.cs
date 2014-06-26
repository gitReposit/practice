using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace AsimTraders
{
    public partial class frmStalks_update : Form
    {
        public frmStalks_update()
        {
            InitializeComponent();
        }

        private void Stalks_Load(object sender, EventArgs e)
        {
            db_read dbr = new db_read();
            OdbcDataReader dr = null;
            string values = "select * from current_stalk";
           dbr.datareeder(values,ref dr);
            if (dr.Read()) 
            {
                txtbxRSug_itfq.Text=dr["Sugar_ittefaq"].ToString();
               txtbxRSug_prvt.Text= dr["Sugar_private"].ToString();
               txtbxRNmt_tn16.Text = dr["Nemat_teen_16"].ToString();
               txtbxRNmt_tn10.Text = dr["Nemat_teen_10"].ToString();
              txtbxRNmt_gt16.Text =  dr["Nemat_gatta_16"].ToString();
              txtbxRNmt_gt10.Text =  dr["Nemat_gatta_10"].ToString();
              txtbxRNmt_gt5.Text = dr["Nemat_gatta_5"].ToString();
              txtbxRNmt_blt16.Text=  dr["Nemat_balty_16"].ToString();
              txtbxRNmt_blt10.Text =  dr["Nemat_balty_10"].ToString();
              txtbxRNmt_blt5.Text =  dr["Nemat_balty_5"].ToString();
              txtbxRNmt_blt2_5.Text = dr["Nemat_balty_2_5"].ToString();
              txtbxRNemat_saban.Text = dr["Nemat_saban"].ToString();
              txtbxRSlv_tn16.Text = dr["Salva_teen_16"].ToString();
              txtbxRSlv_tn10.Text = dr["Salva_teen_10"].ToString();
              txtbxRSlv_gt16.Text =dr["Salva_gata_16"].ToString();
              txtbxRSlv_gt10.Text = dr["Salva_gata_10"].ToString();
              txtbxRSlv_gt5.Text = dr["Salva_gata_5"].ToString();
               txtbxRpkw_oil5.Text= dr["Pakwan_oil_16"].ToString();
              txtbxRATTA20.Text    =dr["ATTA_20"].ToString();
               txtbxRMeeda40.Text =dr["Meeda_40"].ToString();
               txtbxRChokar24.Text  =dr["chokar_24"].ToString();
               txtbxRSooji50.Text = dr["sooji_50"].ToString();
               txtbxRRhm_tn16.Text = dr["Rehmat_teen_16"].ToString();
               txtbxRRhm_gt16.Text = dr["Rehmat_gata_16"].ToString();
               txtbxRRhm_gt12.Text = dr["Rehmat_gata_12"].ToString();
               txtbxRRhm_gt6.Text = dr["Rehmat_gata_16"].ToString();
               txtbxRSlv_blt16.Text = dr["Salva_balty_16"].ToString();
               txtbxRSlv_blt10.Text = dr["Salva_balty_10"].ToString();
               txtbxRSlv_blt5.Text = dr["Salva_balty_5"].ToString();
               txtbxRSlv_blt2_5.Text = dr["Salva_balty_2_5"].ToString();
               txtbxRSlv_oil5.Text = dr["Salva_oil_5"].ToString();

              
            }
          
   
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            db_update dbu = new db_update();
            dbu.update("delete from current_stalk");
            string values = "";
            values = "'" + dateTimePicker1.Text + "'" + ",";
            values += "'" + txtbxCSug_itfq.Text + "'" + ",";
            values += "'" + txtbxCSug_prvt.Text + "'" + ",";
            values += "'" + txtbxCNmt_tn16.Text + "'" + ",";
            values += "'" + txtbxCNmt_tn10.Text + "'" + ",";
            values += "'" + txtbxCNmt_gt16.Text + "'" + ",";
            values += "'" + txtbxCNmt_gt10.Text + "'" + ",";
            values += "'" + txtbxCNmt_gt5.Text + "'" + ",";
            values += "'" + txtbxCNmt_blt16.Text + "'" + ",";
            values += "'" + txtbxCNmt_blt10.Text + "'" + ",";
            values += "'" + txtbxCNmt_blt5.Text + "'" + ",";
            values += "'" + txtbxCNmt_blt2_5.Text + "'" + ",";
            values += "'" + txtbxCNemat_saban.Text + "'" + ",";
            values += "'" + txtbxCSlv_tn16.Text + "'" + ",";
            values += "'" + txtbxCSlv_tn10.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt16.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt10.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt5.Text + "'" + ",";
            values += "'" + txtbxCpkw_oil5.Text + "'" + ",";
            values += "'" + txtbxCATTA20.Text + "'" + ",";
            values += "'" + txtbxCMeeda40.Text + "'" + ",";
            values += "'" + txtbxCChokar24.Text + "'" + ",";
            values += "'" + txtbxCSooji50.Text + "'" + ",";
            values += "'" + txtbxCRhm_tn16.Text + "'" + ",";
            values += "'" + txtbxCRhm_gt16.Text + "'" + ",";
            values += "'" + txtbxCRhm_gt12.Text + "'" + ",";
            values += "'" + txtbxCRhm_gt6.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt16.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt10.Text + "'" + ",";
            values += "'" + txtbxCSlv_gt5.Text + "'" + ",";
            values += "'" + txtbxCSlv_blt2_5.Text + "'" + ",";
            values += "'" + txtbxCSlv_oil5.Text + "'";
        
            //dbu.update("update current_stalk set Sugar_ittefaq='30'");
            dbu.update(values, "current_stalk");

            //for Record in add stalks
             values = "";
            values = "'" + dateTimePicker1.Text + "'" + ",";
            values += "'" + txtbxSug_itfq.Text + "'" + ",";
            values += "'" + txtbxSug_prvt.Text + "'" + ",";
            values += "'" + txtbxNmt_tn16.Text + "'" + ",";

            values += "'" + txtbxNmt_tn10.Text + "'" + ",";
            values += "'" + txtbxNmt_gt16.Text + "'" + ",";
            values += "'" + txtbxNmt_gt10.Text + "'" + ",";
            values += "'" + txtbxNmt_gt5.Text + "'" + ",";
            values += "'" + txtbxNmt_blt16.Text + "'" + ",";
            values += "'" + txtbxNmt_blt10.Text + "'" + ",";
            values += "'" + txtbxNmt_blt5.Text + "'" + ",";
            values += "'" + txtbxNmt_blt2_5.Text + "'" + ",";
            values += "'" + txtbxNemat_saban.Text + "'" + ",";
            values += "'" + txtbxSlv_tn16.Text + "'" + ",";
            values += "'" + txtbxSlv_tn10.Text + "'" + ",";
            values += "'" + txtbxSlv_gt16.Text + "'" + ",";
            values += "'" + txtbxSlv_gt10.Text + "'" + ",";
            values += "'" + txtbxSlv_gt5.Text + "'" + ",";
            values += "'" + txtbxpkw_oil5.Text + "'" + ",";
            values += "'" + txtbxATTA20.Text + "'" + ",";
            values += "'" + txtbxMeeda40.Text + "'" + ",";
            values += "'" + txtbxChokar24.Text + "'" + ",";
            values += "'" + txtbxSooji50.Text + "'" + ",";
            values += "'" + txtbxRRhm_tn16.Text + "'" + ",";
            values += "'" + txtbxRRhm_gt16.Text + "'" + ",";
            values += "'" + txtbxRRhm_gt12.Text + "'" + ",";
            values += "'" + txtbxRRhm_gt6.Text + "'" + ",";
            values += "'" + txtbxSlv_gt16.Text + "'" + ",";
            values += "'" + txtbxSlv_gt10.Text + "'" + ",";
            values += "'" + txtbxSlv_gt5.Text + "'" + ",";
            values += "'" + txtbxSlv_blt2_5.Text + "'" + ",";
            values += "'" + txtbxSlv_oil5.Text + "'" ;
          
            dbu.update(values, "Add_stalk");
            this.Hide();
            this.Owner.Show();

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbxCSug_itfq.Text = (Convert.ToInt32(txtbxRSug_itfq.Text) + Convert.ToInt32(txtbxSug_itfq.Text)).ToString();
            txtbxCSug_prvt.Text =(Convert.ToInt32(txtbxRSug_prvt.Text)+Convert.ToInt32(txtbxSug_prvt.Text)).ToString();
            txtbxCNmt_tn16.Text = (Convert.ToInt32(txtbxRNmt_tn16.Text) + Convert.ToInt32(txtbxNmt_tn16.Text)).ToString();
            txtbxCNmt_tn10.Text = (Convert.ToInt32(txtbxRNmt_tn10.Text) + Convert.ToInt32(txtbxNmt_tn10.Text)).ToString(); 
            txtbxCNmt_gt16.Text = (Convert.ToInt32(txtbxRNmt_gt16.Text) + Convert.ToInt32(txtbxNmt_gt16.Text)).ToString();
            txtbxCNmt_gt10.Text = (Convert.ToInt32(txtbxRNmt_gt10.Text) + Convert.ToInt32(txtbxNmt_gt10.Text)).ToString();
            txtbxCNmt_gt5.Text = (Convert.ToInt32(txtbxRNmt_gt5.Text) + Convert.ToInt32(txtbxNmt_gt5.Text)).ToString();
            txtbxCNmt_blt16.Text = (Convert.ToInt32(txtbxRNmt_blt16.Text) + Convert.ToInt32(txtbxNmt_blt16.Text)).ToString();
            txtbxCNmt_blt10.Text = (Convert.ToInt32(txtbxRNmt_blt10.Text) + Convert.ToInt32(txtbxNmt_blt10.Text)).ToString();
            txtbxCNmt_blt5.Text = (Convert.ToInt32(txtbxRNmt_blt5.Text) + Convert.ToInt32(txtbxNmt_blt5.Text)).ToString();
            txtbxCNmt_blt2_5.Text = (Convert.ToInt32(txtbxRNmt_blt2_5.Text) + Convert.ToInt32(txtbxNmt_blt2_5.Text)).ToString();
            txtbxCNemat_saban.Text = (Convert.ToInt32(txtbxRNemat_saban.Text) + Convert.ToInt32(txtbxNemat_saban.Text)).ToString();
            txtbxCSlv_tn16.Text = (Convert.ToInt32(txtbxRSlv_tn16.Text) + Convert.ToInt32(txtbxSlv_tn16.Text)).ToString();

            txtbxCSlv_tn10.Text = (Convert.ToInt32(txtbxRSlv_tn10.Text) + Convert.ToInt32(txtbxSlv_tn10.Text)).ToString();
            txtbxCSlv_gt16.Text = (Convert.ToInt32(txtbxRSlv_gt16.Text) + Convert.ToInt32(txtbxSlv_gt16.Text)).ToString();

            txtbxCSlv_gt10.Text = (Convert.ToInt32(txtbxRSlv_gt10.Text) + Convert.ToInt32(txtbxSlv_gt10.Text)).ToString();
            txtbxCSlv_gt5.Text = (Convert.ToInt32(txtbxRSlv_gt5.Text) + Convert.ToInt32(txtbxSlv_gt5.Text)).ToString();

            txtbxCpkw_oil5.Text = (Convert.ToInt32(txtbxRpkw_oil5.Text) + Convert.ToInt32(txtbxpkw_oil5.Text)).ToString();
            txtbxCATTA20.Text = (Convert.ToInt32(txtbxRATTA20.Text) + Convert.ToInt32(txtbxATTA20.Text)).ToString();
            txtbxCMeeda40.Text = (Convert.ToInt32(txtbxRMeeda40.Text) + Convert.ToInt32(txtbxMeeda40.Text)).ToString();
            txtbxCChokar24.Text = (Convert.ToInt32(txtbxRChokar24.Text) + Convert.ToInt32(txtbxChokar24.Text)).ToString();
            txtbxCSooji50.Text = (Convert.ToInt32(txtbxRSooji50.Text) + Convert.ToInt32(txtbxSooji50.Text)).ToString();

            txtbxCRhm_tn16.Text = (Convert.ToInt32(txtbxRRhm_tn16.Text) + Convert.ToInt32(txtbxRhm_tn16.Text)).ToString();
            txtbxCRhm_gt16.Text = (Convert.ToInt32(txtbxRRhm_gt16.Text) + Convert.ToInt32(txtbxRhm_gt16.Text)).ToString();
            txtbxCRhm_gt12.Text = (Convert.ToInt32(txtbxRRhm_gt12.Text) + Convert.ToInt32(txtbxRhm_gt12.Text)).ToString();
            txtbxCRhm_gt6.Text = (Convert.ToInt32(txtbxRRhm_gt6.Text) + Convert.ToInt32(txtbxRhm_gt6.Text)).ToString();
            txtbxCSlv_blt16.Text = (Convert.ToInt32(txtbxRSlv_blt16.Text) + Convert.ToInt32(txtbxSlv_blt16.Text)).ToString();
            txtbxCSlv_blt10.Text = (Convert.ToInt32(txtbxRSlv_blt10.Text) + Convert.ToInt32(txtbxSlv_blt10.Text)).ToString();
            txtbxCSlv_blt5.Text = (Convert.ToInt32(txtbxRSlv_blt5.Text) + Convert.ToInt32(txtbxSlv_blt5.Text)).ToString();
            txtbxCSlv_blt2_5.Text = (Convert.ToInt32(txtbxRSlv_blt2_5.Text) + Convert.ToInt32(txtbxSlv_blt2_5.Text)).ToString();
            txtbxCSlv_oil5.Text = (Convert.ToInt32(txtbxRSlv_oil5.Text) + Convert.ToInt32(txtbxSlv_oil5.Text)).ToString();
            
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }

        private void frmStalks_update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        
        /* dr["Sugar_ittefaq"].ToString();
                dr["Sugar_private"].ToString();
                dr["Nemat_teen_16"].ToString();
                dr["Nemat_gatta_16"].ToString();
                dr["Nemat_gatta_10"].ToString();
                dr["Nemat_balty_16 "].ToString();
                dr["Nemat_balty_10"].ToString();
                dr["Nemat_balty_5"].ToString();
                dr["Nemat_balty_2.5"].ToString();
                dr["Salva_teen_16"].ToString();
                dr["Salva_gata_16"].ToString();
                dr["Pakwan_oil_16"].ToString();
                dr["ATTA_20"].ToString();
                dr["Meeda_40"].ToString();
                dr["chokar_24"].ToString();
                dr["sooji_50"].ToString();
         * 
         dateTimePicker1.Text
          txtbxCSug_itfq.Text 
          txtbxCSug_prvt.Text 
          txtbxCNmt_tn16.Text 
          txtbxCNmt_gt16.Text 
          txtbxCNmt_gt10.Text 
          txtbxCNmt_blt16.Text
          txtbxCNmt_blt10.Text 
          txtbxCNmt_blt5.Text 
          txtbxCNmt_blt2_5.Text 
          txtbxCSlv_tn16.Text  
          txtbxCSlv_gt16.Text 
          txtbxCpkw_oil5.Text 
          txtbxCATTA20.Text  
          txtbxCMeeda40.Text 
          txtbxCChokar24.Text 
          txtbxCSooji50.Text

         * 
         * Sugar_ittefaq  Sugar_private  Nemat_teen_16  Nemat_gatta_16  Nemat_gatta_10  Nemat_balty_16 
         * Nemat_balty_10  Nemat_balty_5  Nemat_balty_2.5  Salva_teen_16  Salva_gata_16  Pakwan_oil_16  ATTA_20 
         * Meeda_40  chokar_24  sooji_50 */
    }
}