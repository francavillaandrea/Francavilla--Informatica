using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace Barbero
{
    internal class ClsAlgoritmi
    {
        static Random rnd = new Random();
        internal static void caricaVettori(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(1, 110);
            }
        }

        internal static void stampaVettore(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().PadRight(5));
            }
            Console.WriteLine();
        }

        internal static void ricercaSequenziale1(int[] v)
        {
            int n;
            int i = 0;

            do
            {
                Console.WriteLine("Inserisci un numero (1-10) ");

            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 1 || n > 109));

            while (v[i] != n && i != (v.Length - 1))
            {
                i++;
            }

            if (v[i] == n)
            {
                Console.WriteLine("Elemento trovato in posizione " + (i + 1).ToString());
            }
            else
            {
                Console.WriteLine("Elemento non trovato");
            }

        }

        internal static void ricercaSequenziale2(int[] v)
        {
            int n;
            bool trovato = false;

            do
            {
                Console.WriteLine("Inserisci un numero (1-10) ");

            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 1 || n > 109));

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == n)
                {
                    Console.WriteLine("Elemento trovato in posizione " + (i + 1).ToString());
                    trovato = true;
                }
            }

            if (!trovato)
            {
                Console.WriteLine("Elemento non trovato");
            }
        }

        internal static void ricercaSequenziale3(int[] v)
        {
            //Ordinato elementi !=
            int n;
            int i = 0;

            do
            {
                Console.WriteLine("Inserisci un numero (1-10) ");

            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 1 || n > 109));

            while (v[i] < n && i < (v.Length))
            {
                i++;
            }
            if (v[i] == n)
            {
                Console.WriteLine("Elemento trovato in posizione " + (i).ToString());
            }
            else
            {
                Console.WriteLine("Elemento non trovato ");

            }

        }

        internal static void ricercaSequenziale4(int[] vO)
        {
            int n;
            int i = 0;
            bool trovato = false;
            bool superato = false;

            do
            {
                Console.WriteLine("Inserisci un numero (1-10) ");

            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 1 || n > 109));

            do
            {
                if (vO[i] == n)
                {
                    Console.WriteLine("Elemento trovato in posizione " + i.ToString());
                    trovato = true;
                    i++;
                }
                else
                {
                    if (vO[i] > n)
                    {
                        superato = true;
                    }
                    else
                    {
                        i++;
                    }
                }

            } while (!superato && i < (vO.Length));
            if (!trovato)
            {
                Console.WriteLine("Elemento non trovato");
            }
        }

        internal static void selectionSort(int[] v)
        {
            int n = v.Length;
            int posmin;
            int aus;
            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = (i + 1); j <= n - 1; j++)
                {

                    if (v[posmin] > (v[j]))
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = v[i];
                    v[i] = v[posmin];
                    v[posmin] = aus;
                }
            }
        }

        internal static void RicBin(int[] vD)
        {
            int n;
            {
                Console.WriteLine("Inserisci un numero (1-10) ");

            } while (!int.TryParse(Console.ReadLine(), out n) || (n < 1 || n > 109)) ;
            int sup = 0;
            int inf = vD.Length - 1;
            int metà;

            do
            {
                metà = (inf + sup) / 2;
                if (vD[metà] != n)
                {
                    if (vD[metà] > n)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            }
            while (vD[metà] != n && sup <= inf);
            if (vD[metà] == n)
                Console.WriteLine("Elemento trovato in pos." + metà.ToString());
            else
                Console.WriteLine("Elemento non trovato");
        }

        internal static void bobuSort(int[] v)
        {
            int n = v.Length;
            int i = -1;
            int aus; // Per gestione scambi 
            bool scambio;
            do
            {

                i++;
                scambio = false;
                for (int j = n - 2; j >= i; j--)
                {
                    if (v[j] > (v[j + 1]))
                    {
                        aus = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aus;
                    }
                }
            } while (i != n - 2 && scambio);
        }

        internal static void mergeNoTappo(int[] va, int[] vb)
        {
            int[] vc = new int[va.Length+vb.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            do
            {
                k++;
                if (va[i] > vb[j])
                {
                    vc[k] = vb[j];
                    j++;
                }
                else
                {
                    if(va[i] == vb[j])
                    {
                        vc[k] = va[j];
                        i++;
                        j++;
                    }
                    else
                    {
                        vc[k] = va[j];
                        i++;
                    }
                }
            } while (i<va.Length && j< vb.Length);
            if(i > (va.Length-1))
            {
                for (int h = j; h < vb.Length-1; h++)
                {
                    k++;
                    vc[k] = vb[h];
                }
            }
            else
            {
                for (int h = i; h < va.Length-1; h++)
                {
                    k++;
                    vc[k] = va[h];
                }
            }
            selectionSort(vc);
            stampaVettore(vc);
        }

       
            internal static void mergeTappo(int[] A, int[] B)
        {
            int[] C = new int[A.Length + B.Length];
            int i = 0, j = 0;

            for (int k = 0; k < (A.Length + B.Length - 1); k++)
            {
                if (A[i] > B[j])
                {
                    C[k] = B[j];
                    j++;
                }
                else
                {
                    C[k] = A[i];
                    i++;
                }
            }
      

    
}

    }
}

