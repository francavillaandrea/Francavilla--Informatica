using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Cruciverba
{
    public partial class frmMain : Form
    {
        int[,] a;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(Interaction.InputBox("Inserisci il numero di righe"));
            int c = Convert.ToInt32(Interaction.InputBox("Inserisci il numero di colonne"));
            int n = Convert.ToInt32(Interaction.InputBox("Inserisci il numero di caselle nere"));
            settaDgv(r, c);
            a= new int[r+2,c+2]; //metto cornice
            mettiCaselleNere(r+2,c+2,n);
            mettiNumeri(r+2,c+2);
            visualDgv(r,c);
        }

        private void mettiNumeri(int r, int c)
        {
            int cont = 1;
            for (int i = 1;i<r-1;i++)
                for (int j = 1;j<c-1;j++)
                {
                    if (a[i,j]!=-1) //potrei numerare la casella
                    {
                        if ((a[i,j-1]==-1 && a[i,j+1]==0) ||
                                (a[i-1,j]==-1 && a[i+1,j]==0))
                        {
                            a[i, j] = cont++;
                        }
                    }
                }
        }

        private void visualDgv(int r, int c)
        {
            this.WindowState = FormWindowState.Maximized;
            dgv.Dock = DockStyle.Fill;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
            for (int i = 0; i < r ; i++)
                for (int j = 0; j < c ; j++)
                {
                    if (a[i+1, j+1] == -1)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Black;
                    else if (a[i + 1,j+1] == 0)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                    else
                        dgv.Rows[i].Cells[j].Value = a[i + 1, j + 1].ToString();
                }
            //dgv.AutoResizeRows();
            //dgv.AutoResizeColumns();
            foreach (DataGridViewRow row in dgv.Rows)
                row.Height = 30; // Imposta l'altezza di tutte le righe a 30 pixel
            foreach (DataGridViewColumn column in dgv.Columns)
                column.Width = 30; // Imposta l'altezza di tutte le righe a 30 pixel

        }

        private void mettiCaselleNere(int r, int c, int n)
        {
            int x, y;
            Random rnd= new Random();
            //scorro cornice alta e cornice bassa
            for (int j = 0; j < c; j++)
            {
                a[0, j] = -1;
                a[r-1,j]=-1;
            }
            //scorro cornice dx e cornice sx
            for (int i = 0; i < r; i++)
            {
                a[i, 0] = -1;
                a[i, c - 1] = -1;
            }
            //metto caselle nere
            for(int i = 0;i < n; i++)
            {
                do
                {
                    x = rnd.Next(1, r - 1);
                    y = rnd.Next(1, c - 1);
                }
                while (a[x,y]!=0);
                a[x, y] = -1;
            }
        }

        private void settaDgv(int r, int c)
        {
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            dgv.ClearSelection();
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            


        }
    }
}
