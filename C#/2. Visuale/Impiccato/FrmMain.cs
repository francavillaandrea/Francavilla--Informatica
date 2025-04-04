using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impiccato
{
    public partial class FrmMain : Form
    {
        string parola; // Leggo e carico contenuto txtParolaSegreta
        int len, cntImg; 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            parola = txtParolaSegreta.Text;
            if (parola.Length > 0)
            {
                len = parola.Length;
                pic.Image = Image.FromFile(@"Img\Vuoto.png");
                // Image.FromFile("Img\\Vuoto.png"); => Raddoppio carattere 
                // Oppure utilizzo carattere @ all'inizio della stringa 

                lblOutput.Text = ""; 
                txtParolaSegreta.Text = "";
                for (int i = 0; i < len; i++)
                    lblOutput.Text += "*";

                gbPartita.Visible = true;
                btnAvvia.Enabled = false;

                cntImg = 0;
            }
            else
                MessageBox.Show("Inserisci almeno un carattere!");
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            gestisciLettera();
        }

        private void gestisciLettera()
        {
            string ch = txtLettera.Text;
            bool trovato; // Se il carattere inserito è presente in "parola"

            if (!string.IsNullOrEmpty(ch) && char.IsLetter(Convert.ToChar(ch)))
            {
                trovato = aggiornaOutput(ch);

                if(!trovato)
                { // ERRORE 
                    gestisciErrore();
                }
                else if(parola == lblOutput.Text)
                { // VITTORIA 
                    MessageBox.Show("COMPLIMENTI! HAI VINTO!");
                    gbPartita.Visible = false;
                    btnAvvia.Enabled = true;
                }
            }
            else
                MessageBox.Show("Inserisci carattere valido!");

            txtLettera.Text = "";
            txtLettera.Focus(); 
        }

        private void gestisciErrore()
        {
            /*
                Vuoto.png
                Img1.png
                Img2.png
                Img3.png
                Img4.png
                Img5.png
                Img6.png
             */
            pic.Image = Image.FromFile(@"Img\Img" + 
                                    (++cntImg).ToString() + ".png");
            if(cntImg == 6)
            {
                MessageBox.Show("PECCATO, HAI PERSO!\nLa parola era " +
                                    parola);
                gbPartita.Visible = false;
                btnAvvia.Enabled = true;
            }
        }

        private bool aggiornaOutput(string ch)
        {
            bool trovato = false;
            int pos = -1; // Controllo e gestisco posizione carattere se presente in parola
            // parola = "BUONGIORNO"
            // lblOuput.Text = "B*O***O**O"
            // ch = "O"
            // pos => 2, 6, 9

            do
            {
                pos = parola.IndexOf(ch, pos+1);
                
                if(pos != -1) // Trovato
                {
                    trovato = true;
                    lblOutput.Text = aggiornaTestoOutput(ch, pos);
                }
            } while (pos != -1);

            return trovato; 
        }

        private string aggiornaTestoOutput(string ch, int pos)
        {
            string aus = "";
            for (int i = 0; i < parola.Length; i++)
            {
                if (i == pos)
                    aus += ch;
                else
                    aus += lblOutput.Text[i]; 
            }
            return aus;
        }
    }
}
