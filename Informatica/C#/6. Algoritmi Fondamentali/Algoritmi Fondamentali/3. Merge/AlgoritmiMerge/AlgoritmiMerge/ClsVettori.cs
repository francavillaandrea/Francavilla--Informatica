using System;
using System.ComponentModel.Design.Serialization;

namespace AlgoritmiMerge
{
    internal class ClsVettori
    {
        static Random rnd = new Random();
        public static void ordinaPerScambio(int[] v, ref int passi,
                                            ref int confronti, ref int scambi)
        {
            int n = v.Length;
            int i = -1;
            int aus; // Per gestione scambi 
            bool scambio;

            passi = 0;
            confronti = 0;
            scambi = 0;
            do
            {
                passi++;
                i++;
                scambio = false;
                for (int j = n - 2; j >= i; j--)
                {
                    confronti++;
                    if (v[j] > v[j + 1])
                    {
                        aus = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aus;
                        scambio = true;
                        scambi++;
                    }
                }
            } while (i != n - 2 && scambio);
        }

        internal static void merge(int[] a, int[] b) //PF
        {
            int i = 0; // Indice vettore a 
            int j = 0; // Indice vettore b 
            int k = 0; // Indice del vettore risultante c
            int[] c = new int[a.Length + b.Length];
            int n, m = 0;
            do
            {
                k++;
                if (a[i] > b[j])
                    c[k] = b[j++];
                else
                {
                    if (a[i] == b[j])
                    {
                        c[k] = a[i++];
                        j++;
                    }
                    else
                        c[k] = a[i++];
                }
            } while (i<=n-1 && j<= m-1);

            if (i > n - 1)
                for (int h = j; h <= m - 1; h++)
                    c[++k] = b[h];
            else
                for (int h = i; h <= n - 1; h++)
                    c[++k] = a[h];
            Array.Resize(ref c, k + 1);
            stampaVett(c, "vettore risultante merge 1");
        }
        internal static void mergeTappo(int[] a, int[] b) //PF
        {
            int[] c = new int[a.Length + b.Length];
            Array.Resize(ref a, a.Length + 1);
            a[a.lenght - 1] = int.MaxValue; // Tappo
            Array.Resize(ref b, b.Length + 1);
            int n = a.Length;
            int m = b.Length;
            b[b.lenght - 1] = int.MaxValue; // Tappo
            int i = 0; // Indice vettore a 
            int j = 0; // Indice vettore b 
            
            for (int k = 0;k<=n+m-3;k++)
            {
                if (a[i] > b[j])
                    c[k] = b[j++];
                else
                    c[k] = a[i++];                
            }
            stampaVett(c, "Stampa del risultante c con metodo del tappo");
        }

        public static void ordinaPerSelezione(int[] v, ref int confronti, ref int scambi)
        {
            int n = v.Length;
            int posmin;
            int aus;

            confronti = 0;
            scambi = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                posmin = i;
                for (int j = (i + 1); j <= n - 1; j++)
                {
                    confronti++;
                    if (v[posmin] > v[j])
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = v[i];
                    v[i] = v[posmin];
                    v[posmin] = aus;
                    scambi++;
                }
            }
        }

        public static void stampaVett(int[] v, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i].ToString() + " ");
            Console.WriteLine();
        }

        public static void caricaVettRnd(int[] v, int min, int max)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(min, max + 1);
        }

        public static void caricaVettRndOrdNoRip(int[] v)
        {
            v[0] = rnd.Next(1, 5);
            for (int i = 1; i < v.Length; i++)
                v[i] = rnd.Next(v[i - 1] + 1, v[i - 1] + 5);
        }
    }
}
