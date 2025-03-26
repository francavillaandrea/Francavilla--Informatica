using System;

namespace SimulazioneOrdinamenti
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
        public static void ordinaPerSelezione(int[] v, ref int confronti, ref int scambi)
        {
            int n = v.Length;
            int posmin;
            int aus;

            confronti = 0;
            scambi = 0;
            for (int i = 0; i <= n - 2; i++)
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
    }
}
