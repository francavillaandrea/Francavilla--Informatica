using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroElettronico
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random(); 
        string[] cognomi = { "Barberis", "Bedreag", "Cambieri", 
            "Cane", "Casalis", "Cebotari", "Dellaferrera", "Ferrero", 
            "Francavilla", "Gatto", "Genta", "Ingaramo", "Manunta", 
            "Marciuc", "Milojkov", "Monte", "Oricco", "Ressia", "Revello",
            "Riso", "Roveta", "Salinitri", "Ufe" };
        string[] int_materie = { "Italiano", "Storia", "Matematica", "Inglese", "Informatica", 
                                "Sistemi", "Tpsi", "Telecomunicazioni" };
        int[,] voti; 

        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDgv(); // configurazione datagridview
            generaVoti(); // caricamento matrice con nuove valutazioni
            stampaVoti();  // stampa matrice voti in datagridview
            calcolaMedia(voti.GetLength(1)); // Calcolo media e stampo colonna 
            calcolaEsito(voti.GetLength(1)+1); // Visualizzo colonna esito (promosso, rimandato...) 
            visualizzaMatIns(voti.GetLength(1) + 2); // Visualizzo materie insuff SOLO per rimandati
            caricaCombo();
        }

        private void caricaCombo()
        {
            for (int i = 0; i < int_materie.Length; i++)
            {
                cmb1.Items.Add(int_materie[i]);
            }
        }

        private void visualizzaMatIns(int h)
        {
            string matIns; 

            for(int i=0; i<voti.GetLength(0); i++)
            {
                matIns = "";
                if (dgv.Rows[i].Cells[h-1].Value == "RIMANDATO")
                { // Procedo con la ricerca delle materie insuff.
                    for(int j=0; j <voti.GetLength(1); j++)
                    {
                        if (voti[i, j] < 6)
                        {
                            matIns += int_materie[j] + " "; 
                        }
                    }
                    dgv.Rows[i].Cells[h].Value = matIns;
                }
            }
        }

        private void calcolaEsito(int h)
        {
            int cntIns; // Contatore materie insuff.

            for(int i=0; i<voti.GetLength(0); i++)
            {
                cntIns = 0; 
                for(int j=0; j<voti.GetLength(1); j++)
                {
                    if (voti[i, j] < 6) 
                        cntIns++;
                }
                if(cntIns > 3)
                {
                    dgv.Rows[i].Cells[h].Value = "BOCCIATO";
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Red; 
                }
                else if(cntIns == 0)
                {
                    dgv.Rows[i].Cells[h].Value = "PROMOSSO";
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Green;
                }
                else
                {
                    dgv.Rows[i].Cells[h].Value = "RIMANDATO";
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Gold;

                }
            }
        }

        private void calcolaMedia(int h)
        {
            float media;

            for(int i=0; i<voti.GetLength(0); i++)
            {
                media = 0; 
                for(int j=0; j<voti.GetLength(1); j++)
                {
                    media += voti[i, j]; 
                }
                media = (float)media / voti.GetLength(1);
                dgv.Rows[i].Cells[h].Value = media.ToString("F2");
                // CENTRO CONTENUTO COLONNA h
                dgv.Columns[h].DefaultCellStyle.Alignment = 
                                DataGridViewContentAlignment.MiddleCenter;
                // Colorazione
                if (media >= 6)
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Green;
                else if (media < 5)
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Red;
                else
                    dgv.Rows[i].Cells[h].Style.ForeColor = Color.Gold;

            }
        }

        private void stampaVoti()
        {
            for(int i=0; i<voti.GetLength(0); i++)
            {
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = voti[i, j].ToString();

                    // Colorazione valutazioni 
                    if (voti[i, j] == 5)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                    else if (voti[i, j] < 5)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.White;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                    }
                }
            }
        }
        private void generaVoti()
        {
            for (int i = 0; i < voti.GetLength(0); i++)
                for (int j = 0; j < voti.GetLength(1); j++)
                    voti[i, j] = rnd.Next(4, 11); 
        }

        private void settaDgv()
        {
            int i; 
            // Istanza della matrice 
            voti = new int[cognomi.Length, int_materie.Length];
            dgv.RowCount = voti.GetLength(0);
            dgv.ColumnCount = voti.GetLength(1) + 3;
            dgv.ReadOnly = true;

            /* Intestazione delle colonne */
            for (i = 0; i < int_materie.Length; i++)
                dgv.Columns[i].HeaderText = int_materie[i];

            dgv.Columns[i].HeaderText = "MEDIA";
            i++;
            dgv.Columns[i].HeaderText = "ESITO";
            i++;
            dgv.Columns[i].HeaderText = "RECUPERO";
            /* Intestazione delle righe */
            for (i = 0; i < cognomi.Length; i++)
                dgv.Rows[i].HeaderCell.Value = cognomi[i];

            dgv.ClearSelection(); // Rimuove selezione di default (0, 0) 

            // Istruzioni per resize 
            dgv.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode =
                            DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.RowHeadersWidthSizeMode =
                            DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            string materia = cmb1.Text;
            int colMat = 0;
            float media = 0;
            while (int_materie[colMat] != materia)
            {
                colMat++;
            }
            for(int i = 0;i<voti.GetLength(0);i++)
            {
                media += voti[i, colMat];
            }
            media = (float)media / voti.GetLength(0);
            MessageBox.Show("La media della materia " + materia + " è " + media.ToString("F2"));
        }
    }
}
