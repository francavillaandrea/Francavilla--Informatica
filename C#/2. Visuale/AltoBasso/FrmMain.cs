using System;
using System.Drawing;
using System.Windows.Forms;

namespace AltoBasso
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
            n_segreto = rnd.Next(1, 101); 
        }

        private void btnControlla_Click(object sender, EventArgs e)
        {
            int n; 

            if (int.TryParse(txtNumero.Text, out n) && n > 0 && n <= 100)
            {
                //MessageBox.Show("Input corretto");
                if (n == n_segreto)
                {
                    // indovinato
                    lblRisultato.Text = "INDOVINATO!!!";
                    lblRisultato.ForeColor = Color.Green;
                    btnControlla.Enabled = false; 
                }
                else
                {// o alto o basso 
                    if (n > n_segreto)
                        lblRisultato.Text = "ALTO!";
                    else
                        lblRisultato.Text = "BASSO!";
                    lblRisultato.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Errore! Inserisci numero valido [1-100]!");
            }
            txtNumero.Text = "";
            txtNumero.Focus();
        }
    }
}
