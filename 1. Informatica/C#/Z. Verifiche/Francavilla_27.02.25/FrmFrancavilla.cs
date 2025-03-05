using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Francavilla_27._02._25
{
    public partial class FrmFrancavilla : Form
    {
        static Random rnd = new Random();
        const int rows = 5;
        const int cols = 5;
        int[] x = new int [5];
        int[] y = new int [5];
        string[] squadre = new string[] { "JU", "MI", "TO", "IN", "NA" };
        string[,] risultati = new string[rows, cols];
        public FrmFrancavilla()
        {
            InitializeComponent();
        }

        private void FrmFrancavilla_Load(object sender, EventArgs e)
        {
            settaDGV();
        }

        private void settaDGV()
        {
            dgvRis.ColumnCount = squadre.Length;
            dgvRis.RowCount = squadre.Length;
            dgvRis.ReadOnly = true;
            dgvRis.ColumnHeadersHeight = 60;
            dgvRis.RowHeadersWidth = 60;
            dgvRis.ClearSelection();
            IntestazioneColonne(dgvRis, squadre);
            IntestazioneRighe(dgvRis, squadre);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dgvRis.Rows[i].Height = 50;
                    dgvRis.Columns[j].Width = 50;
                }
            }
        }

        private void IntestazioneRighe(DataGridView dgvRis, string[] squadre)
        {
            for (int i = 0; i < squadre.Length; i++)
                dgvRis.Rows[i].HeaderCell.Value = squadre[i];
        }

        private void IntestazioneColonne(DataGridView dgvRis, string[] squadre)
        {

            for (int i = 0; i < squadre.Length; i++)
                dgvRis.Columns[i].HeaderText = squadre[i];
        }

        private void btnCaricaRis_Click(object sender, EventArgs e)
        {
            caricaRisultati();
        }

        private void caricaRisultati()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    x[i] = rnd.Next(1, 6);
                    y[i] = rnd.Next(1, 6);
                    if (i != j)
                    {
                        risultati[i, j] = $"{x[i]} - {y[i]}";
                        dgvRis.Rows[i].Cells[j].Value = risultati[i, j];
                    }
                }
            }
        }

      
            private void btnPunteggio_Click(object sender, EventArgs e)
            {
                string squadra = Interaction.InputBox("Inserisci la squadra da cercare").ToUpper();

                int cont = 0;
                bool esci = false;

                while (!esci && cont < rows)
                {
                    if (squadre[cont] == squadra)
                    {
                        esci = true;
                    }
                    else
                    {
                        cont++;
                    }
                }

                if (!esci)
                {
                    MessageBox.Show("Squadra non trovata");
                }
                else
                {
                    MessageBox.Show("Squadra trovata");

                    int punti = 0;

                    punti = CalcolaPunti(cont);

                    MessageBox.Show($"La squadra {squadre[cont]} ha totalizzato {punti} punti");
                }
            }
            private int CalcolaPunti(int index)
            {
                string x = "";
                string y = "";
                int punti = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (index != j)
                    {
                        x = risultati[index, j].Substring(0, 1);
                        y = risultati[index, j].Substring(2, 1);
                        if (x.CompareTo(y) > 0)
                        {
                            punti += 3;
                        }
                        else if (x == y)
                        {
                            punti += 1;
                        }

                    }
                }
                //Considera Righe
                for (int i = 0; i < rows; i++)
                {
                    if (index != i)
                    {
                        x = risultati[i, index].Substring(0, 1);
                        y = risultati[i, index].Substring(2, 1);

                        if (x.CompareTo(y) > 0)
                        {
                            punti += 3;
                        }
                        else if (x == y)
                        {
                            punti += 1;
                        }
                    }
                }

                return punti;
            }
        }


}


