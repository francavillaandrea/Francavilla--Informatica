using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4
{
    public partial class FrmMain : Form
    {
        const int RIGHE = 6, COLONNE = 7;
        int[,] m; // Matrice per la gestione della partita 
        int giocatore; // Gestione turno del giocatore (1 - 2) 

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblGiocatore.Text = "Premi gioca per iniziare la partita";
            settaDgv();
        }

        private void dgv_CellClick(object sender, 
                                    DataGridViewCellEventArgs e)
        {
            int i, j;
            i = e.RowIndex; 
            j = e.ColumnIndex;

            i = posizionaGettone(j);

            if (i >= 0)
            {
                // - Controllo vittoria
                if(controlloVittoria(m, i, j, giocatore))
                {
                    MessageBox.Show("Vince Giocatore " + giocatore.ToString());
                }
                // - Controllo patta
                else if(controllaPatta(m))
                {
                    MessageBox.Show("Pareggio");

                }
                else
                {
                    // - Cambio giocatore

                    giocatore = (giocatore == 1) ? 2 : 1;
                    lblGiocatore.Text = "TOCCA AL GIOCATORE " + giocatore.ToString();
                    lblGiocatore.BackColor = (giocatore == 1) ? Color.Red : Color.Yellow;
                }
                
            }
            else
                dgv.ClearSelection();
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

        private int posizionaGettone(int j)
        {
            int i = RIGHE - 1;

            while (i >= 0 && m[i, j] != 0)
                i--;

            if(i >= 0)
            {
                m[i, j] = giocatore;
                
                dgv.Rows[i].Cells[j].Style.BackColor = 
                            (giocatore == 1) ? Color.Red : Color.Yellow;
                dgv.ClearSelection();
                /*
                 if(giocatore == 1)
                    dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                 else 
                    dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                 */
            }

            return i; 
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            m = new int[RIGHE, COLONNE];
            giocatore = 1;
            lblGiocatore.Text = "TOCCA AL GIOCATORE " + giocatore.ToString();
            lblGiocatore.BackColor = Color.Red;
            dgv.Enabled = true; 

            // 
        }

        private void settaDgv()
        {
            dgv.RowCount = RIGHE;
            dgv.ColumnCount = COLONNE;
            // Rimuovo intestazione riga/colonna 
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            // Solo in lettura 
            dgv.ReadOnly = true;
            // Tolgo selezione automatica 
            dgv.ClearSelection();
            // Rimuovo possibilità di resize 
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false; 

            // Resize celle 
            for(int i=0; i<RIGHE; i++)
            {
                for(int j=0; j<COLONNE; j++)
                {
                    dgv.Rows[i].Height = 50;
                    dgv.Columns[j].Width = 50; 
                }
            }

            dgv.Enabled = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect; 
        }
    }
}
