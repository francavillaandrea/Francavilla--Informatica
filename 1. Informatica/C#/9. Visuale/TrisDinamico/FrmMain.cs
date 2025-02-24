using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrisDinamico
{
    public partial class FrmMain : Form
    {
        const int R = 3, C = 3; 
        string[,] m;
        string giocatore;
        int cnt; 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Button btn;
            int posX = 10, posY = 10; 
            // 1. Inserisco i 9 Pulsanti 
            for(int i=0; i<R; i++)
            {
                for(int j=0; j<C; j++)
                {
                    btn = new Button();  // Creo istanza nuovo Button
                    // bnt_0_0, btn_0_1, btn_0_2... btn_2_2
                    btn.Name = "btn_" + i.ToString() + "_" + j.ToString();
                    btn.Text = "?"; // i.ToString() + "_" + j.ToString();
                    // Dimensione pulsante
                    btn.Size = new Size(120, 120);
                    // btn.Width = 120; btn.Height = 120;
                    btn.Font = new Font(btn.Font, FontStyle.Bold); 
                    btn.Font = new Font(btn.Font.FontFamily, 18);
                    // Posizione Button
                    btn.Location = new Point(posX, posY);
                    // btn.Left = posX; 
                    posX = posX + 120;

                    btn.Enabled = false;

                    btn.Click += new EventHandler(btnCampo_Click);
                    // Inserimento nel FORM 
                    this.Controls.Add(btn); 
                }
                posX = 10;
                posY = posY + 120;
                // btn.Top = posY + 120;
            }

            // 2. Inserisco il pulsante "gioca" 
            btn = new Button();
            btn.Name = "btnGioca";
            btn.Text = "GIOCA";
            btn.Size = new Size(360, 120); 
            btn.Location = new Point(10, 380);
            btn.Font = new Font(btn.Font.FontFamily, 20);

            btn.Click += new EventHandler(btnGioca_Click);
            this.Controls.Add(btn);

        }

        private void btnCampo_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
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
            if (vittoria(m, giocatore) != " ")
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
            // btn_0_0, btn_0_1... btn_2_2
            i = Convert.ToInt32(name.Substring(4, 1));
            j = Convert.ToInt32(name.Substring(6));
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
