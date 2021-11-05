using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 
     
*/

namespace GPS_TK103Simulador
{
    public partial class frmGPS_TK103Simulador : Form
    {
        public frmGPS_TK103Simulador()
        {
            InitializeComponent();
        }

        IpClient tok;

        private void frmGPS_TK103Simulador_Load(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.ToLower() == "enviar")
            {
                pctBoxEnvio.Visible = true;
                MontaStringEnvio();

                if (this.chkIntervalo.Checked)
                {
                    ((Button)sender).Text = "Parar Envio";
                    this.Refresh();

                    tmrEnvioLoop.Interval = (int)(numUpDwIntervalo.Value * 1000);
                    conectaEnviaServer();

                    tmrEnvioLoop.Enabled = true;
                }
                else
                {
                    conectaEnviaServer();
                    
                }

            }
            else
            {
                ((Button)sender).Text = "Enviar";
                tmrEnvioLoop.Enabled = false;
                pctBoxEnvio.Visible = false;
            }

        }

        private bool conectaEnviaServer()
        {

            bool r = false;
            string ipServer = chkIp1.Checked ? txtIp1.Text.Trim() : txtIp2.Text.Trim();

            MontaStringEnvio(); // atualiza basicamente a hora (UTC 0)
            tok = new IpClient(ipServer, Convert.ToInt32(txtPort.Text.Trim()), txtSentenca.Text.Trim() + '\n');

            if (tok != null)
                r = true;

            pnlPisca.Visible = true;
            tmrPisca.Enabled = true;

            if (chkIgnit.Checked) // pra só enviar na 1a vez
                chkIgnit.Checked = false;

            return r;

        }

        private void MontaStringEnvio()
        {
            string strPraEnviar = string.Empty;
            string htFormatado = string.Empty;

            string dtFormatado = DateTime.UtcNow.Year.ToString().Substring(2,2) + DateTime.UtcNow.Month.ToString("00") + DateTime.UtcNow.Day.ToString("00") ;    //
            dtFormatado += DateTime.UtcNow.Hour.ToString("00") + DateTime.UtcNow.Minute.ToString("00") + DateTime.UtcNow.Second.ToString("00");

            if (chkEnviaConsole.Checked)
                htFormatado = txtIdConsole.Text.Trim();
            else
                htFormatado = DateTime.UtcNow.Hour.ToString("00") + DateTime.UtcNow.Minute.ToString("00") + DateTime.UtcNow.Second.ToString("00") + ".000";
            

            strPraEnviar += "imei:";
            strPraEnviar += txtEmei.Text.Trim();

            if(chkBoxEnviaStatus.Checked)
            {
                chkIgnit.Checked = false;
                chkIgnit.Enabled = false;
                lblAvisochkIgnit.Visible = true;
                if (radioButton1.Checked)
                    strPraEnviar += ",help me";
                else if (radioButton2.Checked)
                    strPraEnviar += ",Fadiga_01";
                else if (radioButton3.Checked)
                    strPraEnviar += ",Fadiga_02";
                else if (radioButton4.Checked)
                    strPraEnviar += ",Fadiga_03";
                else
                    strPraEnviar += ",tracker";    // não é pra cair aqui, mas...
            }
            else
            {
                chkIgnit.Enabled = true;
                lblAvisochkIgnit.Visible = false;
                strPraEnviar += chkIgnit.Checked ? (radBtnIgnitOn.Checked ? ",acc on" : ",acc off") : chkRfid.Checked ? ",rfid" : ",tracker";   // Ignição ou RFID
            }

            strPraEnviar += "," + dtFormatado;
            strPraEnviar += "," + txtIDMotorista.Text.Trim();  // valor estático ?
            strPraEnviar += ",F";
            strPraEnviar += "," + htFormatado;
            strPraEnviar += chkPosValida.Checked ? ",A" : ",V"; // Pos válida ou não

            strPraEnviar += "," + txtLat.Text.Trim();
            strPraEnviar += ",S";
            strPraEnviar += "," + txtLng.Text.Trim();
            strPraEnviar += ",W";
            strPraEnviar +=  "," + txtVel.Text + "," ; //",1.00,";

            /*
                on: 
                    imei:865067020906882,acc on,1912031153,13554900601,F,205958.000,A,2334.6881,S,04637.6122,W,1.00,;
                off:
                    imei:865067020906882,acc off,1912031154,13554900601,F,115400.000,A,2334.6870,S,04637.6128,W,1.00,;

                    imei:865067020906882,tracker,1911262054,13554900601,F,205400.397,A,2334.6830,S,04637.5982,W,1.00,;  
             */


            lblUTCTime.Text = DateTime.UtcNow.Hour.ToString("00") + " : " + DateTime.UtcNow.Minute.ToString("00") + " : " + DateTime.UtcNow.Second.ToString("00");
            txtSentenca.Text = strPraEnviar;

        }

        private void tmrEnvioLoop_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            conectaEnviaServer();
        }

        private void chkIgnit_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }
        private void chkBoxEnviaStatus_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void radBtnIgnitOff_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }
        private void radBtnIgnitOn_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void txtLat_TextChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void txtLng_TextChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void txtEmei_TextChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        
        private void chkRfid_CheckedChanged(object sender, EventArgs e)
        {
            MontaStringEnvio();
        }

        private void tmrPisca_Tick(object sender, EventArgs e)
        {
            tmrPisca.Enabled = false;
            pnlPisca.Visible = false;

        }

        private void txtVel_Leave(object sender, EventArgs e)
        {
            // valida valor entrada da velocidade
            txtVel.Text = txtVel.Text.Replace(',', '.').Trim();

            if (!isNumeric(txtVel.Text) || txtVel.Text.StartsWith("-"))
            {
                MessageBox.Show("Velocidade deve ser um valor numérico >= 0");
                txtVel.Focus();
                return;
            }

        }

        private bool isNumeric(string toSee)
        {
            double _dummyOut;
            return double.TryParse(toSee, out _dummyOut);
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://marcelocampos.cc/");

        }
    }
}
