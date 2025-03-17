using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4Dinamico
{
    public partial class FrmMain : Form
    {
        const int rows = 6, cols = 7;
        int[,] m;
        int player; 

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            disegnaCampo();
            abilitaGioco(false);
        }
        // Flag = False => Pulsanti di gioco disabilitati 
        // Flag = True => Avvio partita/pulsanti di gioco attivi
        private void abilitaGioco(bool flag)
        {
            //foreach(Control c in this.Controls)
            //{
            //    if(c is Button)
            //    {
            //        if (c.Name == "btnGioca")
            //            c.Enabled = !flag;
            //        else
            //            c.Enabled = flag;
            //    }
            //}
            foreach (Button b in this.Controls.OfType<Button>())
            {
                if (b.Name == "btnGioca")
                {
                    b.Enabled = !flag;

                }
                else
                {
                    b.Enabled = flag;
                    b.BackColor = Color.White;
                }
            }
        }

        private void disegnaCampo()
        {
            Button btn;
            Label lbl; 
            int posX = 10, posY = 100;

            lbl = new Label();
            lbl.Name = "lblGiocatore";
            lbl.Text = "Premi gioca per iniziare...";
            lbl.Location = new Point(10, 10); 
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            lbl.Font = new Font(lbl.Font.FontFamily, 18);
            lbl.ForeColor = Color.Red;
            lbl.AutoSize = true; 
            this.Controls.Add(lbl);
            // INSERISCO GRIGLIA PULSANTI 
            for (int i=0; i<rows; i++)
            {
                for(int j=0; j<cols; j++)
                {
                    btn = new Button();

                    btn.Name = $"btn_{i}_{j}";
                   // btn.Text = i.ToString() + ", " + j.ToString();
                    btn.Size = new Size(80, 80);
                    btn.Location = new Point(posX, posY);
                    posX = posX + 80;
                    this.Controls.Add(btn);
                }
                posX = 10; 
                posY = posY + 80; 
            }
            // INSERISCO PULSANTI PER POSIZIONARE IL GETTONE 
            posY = posY + 20;
            for(int j=0; j<C; j++)
            {
                btn = new Button();
                btn.Name = $"btnC{j}";
                btn.Text = "↑";
                btn.Size = new Size(80, 80);
                btn.Location = new Point(posX, posY);
                posX = posX + 80;

                btn.Click += new EventHandler(btnColonna_Click);
                this.Controls.Add(btn);
            }

            // INSERISCO PULSANTE GIOCA 
            posX = 10;
            btn = new Button();
            btn.Name = "btnGioca";
            btn.Text = "GIOCA";
            btn.Size = new Size(cols*80, 80);
            btn.Location = new Point(posX, posY+100);
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.Font = new Font(btn.Font.FontFamily, 20);
            btn.BackColor = Color.LightBlue;
            btn.Cursor = Cursors.Hand;

            btn.Click += new EventHandler(btnGioca_Click);   
            this.Controls.Add(btn);
        }

        private void btnColonna_Click(object sender, EventArgs e)
        {
            // btnC0, btnC1, btnC2, btnC3....
            Button btn = (Button)sender;
            int posJ = Convert.ToInt32(btn.Name.Substring(4));
            int posI; 

            
            posI = posizionaGettone(posJ);

            // Funzione per colorare il button rispettivo 
            coloraPulsante(posI, posJ);
        
            // CONTROLLO VITTORIA/PAREGGIO 
            if(controlloVittoria(m, posI, posJ, player))
            {
                MessageBox.Show($"VINCE GIOCATORE {player}");
                abilitaGioco(false);
            }
            else if(controllaPatta(m))
            {
                MessageBox.Show("PARTITA PATTA");
                abilitaGioco(false);
            }
            else
            {
                player = (player == 1) ? 2 : 1;
                this.Controls["lblGiocatore"].Text = $"Turno Giocatore: {player};
            }
        }

        private void coloraPulsante(int posI, int posJ)
        {
            string nomeBtn = $"btn_{posI}_{posJ}";
            Button btn = (Button)this.Controls[nomeBtn];

            btn.BackColor = (player == 1) ? Color.Red : Color.Yellow;

            if (posI == 0) // Accedo a pulsante colonna e disabilito perché pieno
            {
                this.Controls["btnC" + posJ.ToString()].Enabled = false;
            }
        }

        private int posizionaGettone(int posJ)
        {
            int i = rows - 1;

            while (m[i, posJ] != 0)
            {
                i--;
            }

            m[i, posJ] = player;
            return i; 
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            Label lbl; 

            abilitaGioco(true);
            player = 1;
            m = new int[rows, cols];

            lbl = (Label)this.Controls["lblGiocatore"];
            lbl.Text = "Turno Giocatore: " + player.ToString(); 

        }
        private bool controllaPatta(int[,] m)
        {
            int j = 0;
            while (j < C && m[0, j] != 0)
                j++;

            return (j == C);
        }

        private bool controlloVittoria(int[,] campo, int i, int j, int giocatoreCorrente)
        {
            bool vittoria = false;
            int pos_i = i, pos_j = j;
            int cnt = 0;

            // Controllo VERTICALE 
            while (i < campo.GetLength(0) && campo[i, j] == giocatoreCorrente)
            {
                cnt++;
                i++;
            }
            if (cnt == 4)
                vittoria = true;
            else
            { // Controllo ORIZZONTALE 
                cnt = 0;
                i = pos_i;
                j = pos_j;

                // conta destra 
                while (j < campo.GetLength(1) && campo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    j++;
                }
                j = pos_j - 1;
                // conta sinistra 
                while (j >= 0 && campo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    j--;
                }
                if (cnt >= 4)
                    vittoria = true;
                else
                { // Controllo DIAGONALE
                    // Diagonale principale 
                    cnt = 0;
                    i = pos_i; j = pos_j;
                    // in basso a dx 
                    while (j < campo.GetLength(1) && i < campo.GetLength(0)
                                        && campo[i, j] == giocatoreCorrente)
                    {
                        i++;
                        j++;
                        cnt++;
                    }
                    i = pos_i - 1;
                    j = pos_j - 1;
                    while (j >= 0 && i >= 0
                                && campo[i, j] == giocatoreCorrente)
                    {
                        i--;
                        j--;
                        cnt++;
                    }
                    if (cnt >= 4)
                        vittoria = true;
                    else
                    {  // Diagonale secondaria
                        cnt = 0;
                        i = pos_i; j = pos_j;
                        while (j >= 0 && i < campo.GetLength(0)
                                            && campo[i, j] == giocatoreCorrente)
                        {
                            i++;
                            j--;
                            cnt++;
                        }
                        i = pos_i - 1;
                        j = pos_j + 1;
                        while (j < campo.GetLength(1) && i >= 0
                                    && campo[i, j] == giocatoreCorrente)
                        {
                            i--;
                            j++;
                            cnt++;
                        }
                        if (cnt >= 4)
                            vittoria = true;
                    }
                }
            }
            return vittoria;
        }

    }
}
