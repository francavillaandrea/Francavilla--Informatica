using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EsericiziProva
{
    internal class ClsVettori
    {
        static Random rnd = new Random();
        internal static void calcolaMediaVettore(int[] v)
        {
            double somma = 0;
            for (int i = 0; i < v.Length; i++)
                somma += v[i];
            MessageBox.Show($"Il valore della media del vettore è {somma / v.Length}");
        }

        internal static void caricaVettore(int[] v, int min, int max)
        {
            for (int i = 0; i < v.Length; i++)
            { 
                v[i] = rnd.Next(min, max + 1);
        
            }
        }

        internal static void visualizzaVettore(int[] v, DataGridView dgv)
        {
            for (int j = 0; j < v.Length; j++)
            {
                dgv.Rows[0].Cells[j].Value = v[j].ToString();
            }
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }

        internal static void cercaElementoVettore(int[] v, int x)
        {
            int i = 0;
            while (v[i] != x && i != v.Length - 1)
                i++;
            if (v[i] == x)
                MessageBox.Show("Ho trovato l'elemento");
            else
                MessageBox.Show("Elemento non trovato");
        }

        internal static void cercaMaxVettore(int[] v)
        {
            int max = int.MinValue;
            for (int i = 0; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            MessageBox.Show($"Il max del vettore è {max} ");
        }

        internal static void cercaPrimi3(int[] v)
        {
            int p = 0, s = 0, t = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > p)
                {
                    t = s;
                    s = p;
                    p = v[i];
                }
                else
                {
                    if (v[i] > s)
                    {
                        t = s;
                        s = v[i];
                    }
                    else
                    {
                        if (v[i] > t)
                            t = v[i];
                    }
                }
            }
            MessageBox.Show("Il primo valore è {primo}, il secondo valore è {secondo} infine il terzo è {terzo}");
        }


        internal static void sommaVettori(int[] a1, int[] a2, DataGridView dgvRis)
        {
           
            int riporto = 0;
            int somma;
            for (int i = a1.Length - 1; i >= 0; i--)
            {
                somma = a1[i] + a2[i] + riporto;
                if (somma > 9)
                {
                    riporto = 1;
                    dgvRis.Rows[0].Cells[i + 1].Value = (somma - 10).ToString();
                }
                else
                {
                    riporto = 0;
                    dgvRis.Rows[0].Cells[i + 1].Value = somma.ToString();
                }
            }
            dgvRis.Rows[0].Cells[0].Value = riporto.ToString();


        }

        internal static void verificaVettoreSpeculare(int[] v)
        {
            int i = 0;
            int j = v.Length - 1;

            while (v[i] == v[j] && i != v.Length / 2)
            {
                i++;
                j--;
            }
            if (v[i] == v[j])
                MessageBox.Show("Vettore speculare");
            else
                MessageBox.Show("Vettore NON speculare");
        }

        internal static void sommaVettore(int[] v)
        {
            int somma = 0;
            for(int i = 0; i < v.Length; i++)
            {
                somma += v[i];
            }
            MessageBox.Show($"La somma dei valori del vettore è {somma}");
        }

        internal static void OrdinaVettore(int[] v)
        {
            Array.Sort(v);
        }

        internal static void copiaVettore(int[] v, int[] aus)
        {
            for(int i = 0;i < v.Length;i++)
            {
                aus[i] = v[i];
            }
        }

        internal static void Media2Vettori(int[] v, int[] aus)
        {
            throw new NotImplementedException();
        }
    }
}
