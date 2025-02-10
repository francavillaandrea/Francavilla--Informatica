using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza_4
{
    public partial class FrmMain : Form
    {
        const int Rows = 6 , Cols = 7 ;
        int[,] m;
        int giocatore;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblGiocatore.Text = "Premi gioca per iniziare la partita";
            settaDgv(dgv, m);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i, j;
            i = e.RowIndex;
            j = e.ColumnIndex;
            i = posizioneGettone(j);
        }

        private int posizioneGettone(int j)
        {
            int i = Rows - 1;
            while(i>=0 && m[i,j]!= 0 )
                i--;
            if( i >= 0 )
            {

            }
            return i;
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
           m = new int [Rows, Cols];
           giocatore = 1;
           lblGiocatore.Text = "Tocca al giocatore " + giocatore.ToString();
           lblGiocatore.BackColor = Color.Red;
           dgv.Enabled = true;
        }

        private void settaDgv(DataGridView dgv, int[,] m)
        {
            dgv.RowCount = Rows;
            dgv.ColumnCount = Cols;
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.ClearSelection();
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            for(int i = 0;i<Rows;i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    dgv.Rows[i].Height = 50;
                    dgv.Columns[j].Width = 50;
                }
            }
            dgv.Enabled = false;
        }
    }
}
