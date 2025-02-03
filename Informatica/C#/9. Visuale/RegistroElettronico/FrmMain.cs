using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string[] int_materie = { "ITA", "STO", "MAT", "ING", "INF",
                                "SIS", "TPS", "TEL" };
        int[,] voti;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            settaDGV();
            generaVoti();
            StampaMatriceinDgv();
        }

        private void StampaMatriceinDgv()
        {
            for (int i = 0; i < voti.GetLength(0); i++)
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = voti[i, j].ToString();
                    if (voti[i, j] == 5)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    else if (voti[i, j] < 5)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Green;
                }
        }

        private void generaVoti()
        {
            for (int i = 0; i < voti.GetLength(0); i++)
                for (int j = 0; j < voti.GetLength(1); j++)
                    voti[i, j] = rnd.Next(1, 11);
        }

        private void settaDGV()
        {
            int i;
            // Istanza della matrice 
            voti = new int[cognomi.Length, int_materie.Length];
            dgv.RowCount = voti.GetLength(0);
            dgv.ColumnCount = voti.GetLength(1);
            dgv.ReadOnly = true;

            /* Intestazione delle colonne */
            for (i = 0; i < int_materie.Length; i++)
                dgv.Columns[i].HeaderText = int_materie[i];
            dgv.Columns[i].HeaderText = "Media";
            i++;
            dgv.Columns[i].HeaderText = "Esito";
            i++;
            dgv.Columns[i].HeaderText = "Recupero";

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
    }
}
