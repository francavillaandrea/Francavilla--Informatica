using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EseDatagridview
{
    public partial class FrmMain : Form
    {
        const int C = 10;
        const int R = 10;
        int[,] m; 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            m = new int[R, C]; 

            dgv.ColumnCount = C;
            dgv.RowCount = R;

            // Disabilito intestazione riga e colonna 
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            
            // Solo in lettura 
            dgv.ReadOnly = true;

            // Disabilito possibilità di ridimensionare celle 
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false; 
            
            caricaMatrice(m);
            stampaMatriceInDgv(m, dgv);
        }

        private void caricaMatrice(int[,] m)
        {
            for(int i=0; i<m.GetLength(0); i++)
            {
                for(int j=0; j<m.GetLength(1); j++)
                {
                    m[i, j] = i * j; 
                }
            }
        }
        private void stampaMatriceInDgv(int[,] m, DataGridView dgv)
        {
            for(int i=0; i<m.GetLength(0); i++)
            {
                for(int j=0; j<m.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = m[i, j].ToString(); 
                }
            }
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();

        }
    }
}
