using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Alto_Basso
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        int n_segreto;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            n_segreto = rnd.Next(1,101);
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            int n;
            if(int.TryParse(txtNumero.Text, out n)&& n>0 && n<=100)
            {
                //MessageBox.Show("Input Corretto");
                if(n== n_segreto)
                {
                    lblRisultato.Text = "Indovinato!!!";
                    lblRisultato.ForeColor = Color.Green;
                    btnVerifica.Enabled = false;
                }
                else
                {
                    if(n > n_segreto)
                    {
                        lblRisultato.Text = " Alto!!!";
                        lblRisultato.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblRisultato.Text = " Basso!!!";
                        lblRisultato.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Errore! Inserisci numero valido! [1-100]");
            }
            txtNumero.Text = "";
            txtNumero.Focus();
        }
    }
}
