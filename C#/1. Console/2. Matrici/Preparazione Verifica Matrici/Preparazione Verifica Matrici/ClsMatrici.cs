using System;

namespace Preparazione_Verifica_Matrici
{
    internal class ClsMatrici
    {
        public static void sopraDSsolo0(int[,] m)
        {
            bool esci = false;
            int r = m.GetLength(0);
            int i = 0;
            int j = 0;
            while (!esci && i <= r - 2)
            {
                if (m[i, j] != 0)
                {
                    esci = true;
                }
                else
                {
                    if (j == r - 2 - i)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (!esci)
            {
                Console.WriteLine("tutti 0");
            }
            else
                Console.WriteLine("Elementi != 0");
        }

        public static void sommaElementiSopraDS(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);
            for (int i = 0; i < r - 2; i++)
                for (int j = 0; j < r - 2 - i; j++)
                    somma += m[i, j];
            Console.WriteLine("la somma degli elementi sopra la DS è:" + somma.ToString());
        }

        public static void sottoDSsolo0(int[,] m)
        {
            bool esci = false;
            int r = m.GetLength(0);
            int i = 1;
            int j = r - i;
            while (!esci && i <= r - 1)
            {
                if (m[i, j] != 0)
                {
                    esci = true;
                }
                else
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = r - 1;
                    }
                    else
                        j++;
                }
            }
            if (!esci)
            {
                Console.WriteLine("tutti 0");
            }
            else
                Console.WriteLine("Elementi != 0");
        }

        public static void sommaElementiSottoDS(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);
            for (int i = 0; i < r - 1; i++)
                for (int j = r - i; j < r - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("la somma degli elementi sotto la DS è:" + somma.ToString());
        }

        public static void tuttiUgualiSopraDP(int[,] m)
        {
            bool esci = false;
            int i = 1;
            int j = 0;
            int r = m.GetLength(0);
            int x = m[i, j];
            while (!esci && i <= r - 2)
            {
                if (m[i, j] != x)
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 1;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Valore diversi sotto la DP");
            else
                Console.WriteLine("Valori uguali sotto la DP");
        }

        public static void tuttiUgualiSottoDP(int[,] m)
        {
            bool esci = false;
            int i = 1;
            int j = 0;
            int r = m.GetLength(0);
            int x = m[i, j];
            while (!esci && i <= r - 1)
            {
                if (m[i, j] != x)
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Valore diversi sotto la DP");
            else
                Console.WriteLine("Valori uguali sotto la DP");
        }

        public static void ricercaXTriangoloSottoDP(int[,] m)
        {
            int i = 1;
            int j = 0;
            bool esci = false;
            int r = m.GetLength(0);

            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (!esci && i <= r - 1)
            {
                if (m[i, j] == x)
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Trovato pos: " + i.ToString() + " - " + j.ToString());
            else
                Console.WriteLine("Non trovato");
        }

        public static void ricercaXTriangoloSopraDP(int[,] m)
        {
            int i = 0;
            int j = 1;
            bool esci = false;
            int r = m.GetLength(0);

            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (!esci && i <= r - 2)
            {
                if (m[i, j] == x)
                    esci = true;
                else
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Trovato pos: " + i.ToString() + " - " + j.ToString());
            else
                Console.WriteLine("Non trovato");
        }

        public static void sommaElementiSottoDP(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 1; i <= r - 1; i++)
                for (int j = 0; j <= i - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma dei valori sotto DP è: " + somma.ToString());
        }

        public static void sommaElementiSopraDP(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 0; i <= r - 2; i++)
                for (int j = i + 1; j <= r - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma dei valori sopra DP è: " + somma.ToString());
        }

        public static void matriceConPrimaUltimaRigaDi1(int[,] m)
        {
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            while (!esci && i <= r - 1)
            {
                if (i == 0 || i == r - 1)
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(c, ref i, ref j);
                    else
                        esci = true;
                }
                else
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(c, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice con prima e ultima riga != 1");
            else
                Console.WriteLine("Matrice con prima e ultima riga di 1");
        }

        public static void matriceConCroce(int[,] m)
        {
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (i == r / 2 || j == r / 2)
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
                else
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice SENZA croce");
            else
                Console.WriteLine("Matrice CON croce");
        }

        public static void matriceUnitaria(int[,] m)
        {
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (i == j)
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
                else
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice NON unitaria");
            else
                Console.WriteLine("Matrice unitaria");
        }

        public static void proseguiVisitaMatrice(int r, ref int i, ref int j)
        {
            if (j == r - 1)
            {
                i++;
                j = 0;
            }
            else
                j++;
        }

        public static void matriceNulla(int[,] m)
        {
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (m[i, j] == 0)
                    proseguiVisitaMatrice(r, ref i, ref j);
                else
                    esci = true;
            }
            if (esci)
                Console.WriteLine("Matrice NON nulla");
            else
                Console.WriteLine("Matrice nulla");
        }

        public static void matriceTuttiElementiUguali(int[,] m)
        {
            bool esci = false;
            int x = m[0, 0];
            int i = 0, j = 1;
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            while (!esci && i <= r - 1)
            {
                if (m[i, j] == x)
                    proseguiVisitaMatrice(c, ref i, ref j);
                else
                    esci = true;
            }
            if (esci)
                Console.WriteLine("Matrice con elementi diversi");
            else
                Console.WriteLine("Matrice con elementi uguali");
        }

        public static void caricaCorniceSequenza(int[,] m)
        {
            int x = 1;
            int i, j;
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            for (j = 0; j < c; j++)
                m[0, j] = x++;
            for (i = 1; i < r - 1; i++)
                m[i, c - 1] = x++;
            for (j = c - 1; j >= 0; j--)
                m[r - 1, j] = x++;
            for (i = r - 2; i >= 1; i--)
                m[i, 0] = x++;
        }

        public static void caricaMatriceSequenzaContraria(int[,] m)
        {
            int cont = m.Length;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = cont--;
        }

        public static void caricaMatriceSequenza(int[,] m)
        {
            int cont = 1;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = cont++;
        }

        public static void caricaMatrice(int[,] m)
        {
            Random rnd = new Random();
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = rnd.Next(0, 11);
        }

        public static void stampaMatrice(int[,] m, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
        }

        public static double mediaMatrice(int[,] m)
        {
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    somma += m[i, j];

            return (double)somma / m.Length;
        }

        public static int contaX(int[,] m)
        {
            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int cont = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] == x)
                        cont++;

            return cont;
        }

        public static int sommaColonnaJ(int[,] m)
        {
            Console.Write("Inserisci j: ");
            int j = Convert.ToInt32(Console.ReadLine());
            int somma = 0;

            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j];

            return somma;
        }

        public static int sommaRigaI(int[,] m)
        {
            Console.Write("Inserisci i: ");
            int i = Convert.ToInt32(Console.ReadLine());
            int somma = 0;

            for (int j = 0; j < m.GetLength(1); j++)
                somma += m[i, j];

            return somma;
        }

        public static int sommaCornice(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            for (int j = 0; j < c; j++)
                somma += m[0, j];
            for (int i = 1; i < r - 1; i++)
                somma += m[i, c - 1];
            for (int j = c - 1; j >= 0; j--)
                somma += m[r - 1, j];
            for (int i = r - 2; i >= 1; i--)
                somma += m[i, 0];

            return somma;
        }

        public static int sommaDS(int[,] m)
        {
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, i];

            return somma;
        }

        public static int sommaDP(int[,] m)
        {
            int somma = 0;
            int j = m.GetLength(1) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j--];
            Console.ReadKey();
            return somma;
            
        }

        public static int maxMatrice(int[,] m)
        {
            int max = m[0, 0];
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] > max)
                        max = m[i, j];

            return max;
        }
    }
}
