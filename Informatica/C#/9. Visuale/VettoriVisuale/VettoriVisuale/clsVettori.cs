using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VettoriMatriciVisuale
{
    internal class clsVettori
    {
        static Random rnd=new Random();
        internal static void caricaVettore(int[] v)
        {
            for (int i = 0; i < v.Length; i++) 
                v[i]=rnd.Next(1,51);
        }

        internal static void cercaMaxVettore(int[] v)
        {
            int max = int.MinValue;
            for (int i = 0; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            MessageBox.Show("Il max del vettore è: " + max.ToString());
        }

        internal static void visualizzaVettore(int[] v, DataGridView dgv)
        {
            for(int j = 0;j < v.Length;j++)
                dgv.Rows[0].Cells[j].Value = v[j].ToString();
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();

        }
    }
}
