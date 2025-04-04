using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VettoriMatriciVisuale
{
    internal class clsMatrici
    {
        static Random rnd= new Random();
        internal static void CaricaMatrice(int[,] m, int min, int max)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i,j]=rnd.Next(min, max +1);
            }
        }

        internal static void coloraColonne(int[,] m, DataGridView dgv)
        {

        }

        internal static void coloraDP(int[,] m, DataGridView dgv)
        {
            dgv.ClearSelection();
            for (int i = 0; i < m.GetLength(0); i++)
                dgv.Rows[i].Cells[i].Style.BackColor = Color.Red;
        }

        internal static void coloraRighe(int[,] m, DataGridView dgv)
        {
            dgv.ClearSelection();
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if(i%2==0)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;

        }

        internal static void coloraRigheSopraDP(int[,] m, DataGridView dgv)
        {
            

        }

        internal static void coloraTriangoliDP(int[,] m, DataGridView dgv)
        {
            dgv.ClearSelection();
            for (int i = 0;i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i > j)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    else if (i < j)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;

                }
        }

        internal static void coloraTriangoliDS(int[,] m, DataGridView dgv)
        {
            dgv.ClearSelection();
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (j== m.GetLength(0)-1-i)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    else if (j < m.GetLength(0) - 1 - i)
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    else
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                }
        }

        internal static void sommaSottoDP(int[,] m)
        {
            int somma = 0;
            for (int i = 1; i <= m.GetLength(0) - 1; i++)
                for (int j = 0; j <= i - 1; j++)
                    somma += m[i, j];
            MessageBox.Show("La somma vale: " + somma.ToString());
        }

        internal static void tuttiUguali(int[,] m)
        {
            int r=m.GetLength(0);
            int c=m.GetLength(1);
            bool uguali = true;
            int i = 0;
            int j = 1;
            while (uguali && i<=r-1)
            {
                if (m[i, j] != m[0, 0])
                    uguali = false;
                else
                {
                    if (j == c - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (uguali)
                MessageBox.Show("Tutti uguali");
            else
                MessageBox.Show("Diversi");
        }

        internal static void visualizzaMatrice(int[,] m, DataGridView dgv)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    dgv.Rows[i].Cells[j].Value= m[i,j].ToString();
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
    }
}
