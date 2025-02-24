using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrisSender
{
    public partial class FrmMain : Form
    {
        const int R = 3, C = 3; 

        string[,] m; // matrice di controllo
        string giocatore; // "X" o "O"
        int cnt; // CONTATORE MOSSE 

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCampo_Click(object sender, EventArgs e)
        {
            Button b = (Button) sender;
            int i = -1, j = -1;

            cnt++;
            
            calcolaPosizione(b.Name, ref i, ref j);
            //MessageBox.Show(i.ToString() + ", " + j.ToString());
            b.Text = giocatore;
            b.Enabled = false;
            // 1. Posiziono giocatore in matrice 
            // btn1, btn2, btn3.... btn9
            m[i, j] = giocatore; 

            // 2. Controllo vittoria/patta
            if(vittoria(m, giocatore) != " ")
            {
                MessageBox.Show($"VINCE IL GIOCATORE {giocatore}");
                // Reset/blocco della partita 
                avviaResettaPartita(false);
            }
            else
            {
                if (cnt == R * C)
                {
                    MessageBox.Show($"PAREGGIO");
                    // Reset/blocco della partita 
                    avviaResettaPartita(false);
                }
                else 
                    giocatore = (giocatore == "X") ? "O" : "X";
            }
        }

        private void calcolaPosizione(string name, ref int i, ref int j)
        {
            int iBtn = Convert.ToInt32(name[3]) - 48;
            iBtn--;

            i = iBtn / 3;
            j = iBtn % 3; 
        }
        private static string vittoria(string[,] t, string ch)
        {
            if ((t[0, 0] == ch && t[0, 1] == ch && t[0, 2] == ch) ||
                    (t[1, 0] == ch && t[1, 1] == ch && t[1, 2] == ch) ||
                    (t[2, 0] == ch && t[2, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 0] == ch && t[2, 0] == ch) ||
                    (t[0, 1] == ch && t[1, 1] == ch && t[2, 1] == ch) ||
                    (t[0, 2] == ch && t[1, 2] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 2] == ch && t[1, 1] == ch && t[2, 0] == ch))
                return ch;
            else
                return " ";
        }
        private void btnGioca_Click(object sender, EventArgs e)
        {
            m = new string[R, C];
            giocatore = "X";
            //btn1.Text = "?"; btn2.Text = "?";
            //btn1.Enabled = true; btn2.Enabled = false;
            //btnGioca.Enabled = false;
            // Scansiono tutte le componenti del FORM 
            // "FORZANDO" a priori un cast a Button
            // (SOLO SE NON PRESENTI ALTRI TIPI COMPONENTI)
            avviaResettaPartita(true);
           
            cnt = 0;
        }

        private void avviaResettaPartita(bool inizia)
        {
            foreach (Button btn in this.Controls)
            {
                if (btn.Name != "btnGioca")
                {
                    btn.Text = "?";
                    btn.Enabled = inizia;
                }
                else
                {
                    btn.Enabled = !inizia;
                }
            }
        }
    }
}
