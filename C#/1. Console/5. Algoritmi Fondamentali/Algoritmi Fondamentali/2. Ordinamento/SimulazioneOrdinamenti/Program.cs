using System;
using System.Diagnostics;

namespace SimulazioneOrdinamenti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int[] b;
            int n = 100;
            int scambiSel = 0, confrontiSel = 0;
            int scambiBub = 0, confrontiBub = 0, passiBub = 0; 
            Stopwatch swSel = new Stopwatch();
            Stopwatch swBub = new Stopwatch();
            /* Istruzioni necessarie per la corretta lettura dei tempi */
            a = new int[n];
            b = new int[n];
            ClsVettori.caricaVettRnd(a, 1, 1000);
            Array.Copy(a, b, a.Length);
            ClsVettori.ordinaPerSelezione(a, ref confrontiSel, ref scambiSel);
            ClsVettori.ordinaPerScambio(b, ref passiBub, ref confrontiBub, ref scambiBub);
            /* -------------------------------------------------------- */
            for (int i=0; i<3; i++)
            {
                a = new int[n];
                b = new int[n];

                ClsVettori.caricaVettRnd(a, 1, 1000);
                Array.Copy(a, b, a.Length); // Copio il contenuto del vettore A in vettore B 

                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine(("Ordinamento " + n.ToString() 
                                    + " elementi").PadLeft(30) 
                                    + "SELEZIONE".PadLeft(20) 
                                    + "SCAMBIO".PadLeft(15));
                Console.WriteLine("-".PadLeft(65, '-'));
                Console.ResetColor(); 
                swSel.Reset(); 
                swSel.Start();
                ClsVettori.ordinaPerSelezione(a, ref confrontiSel, ref scambiSel);
                swSel.Stop();

                swBub.Reset();
                swBub.Start();
                ClsVettori.ordinaPerScambio(b, ref passiBub, ref confrontiBub, ref scambiBub);
                swBub.Stop();

                Console.WriteLine(("Numero di passi").PadLeft(30)
                                    + (n-1).ToString().ToString().PadLeft(20)
                                    + passiBub.ToString().PadLeft(15));
                Console.WriteLine(("Numero di confronti").PadLeft(30)
                                    + confrontiSel.ToString().PadLeft(20)
                                    + confrontiBub.ToString().PadLeft(15));
                Console.WriteLine(("Numero di scambi").PadLeft(30)
                                    + scambiSel.ToString().PadLeft(20)
                                    + scambiBub.ToString().PadLeft(15));
                Console.WriteLine(("Tempo impiegato").PadLeft(30)
                                    + swSel.ElapsedTicks.ToString().PadLeft(20)
                                    + swBub.ElapsedTicks.ToString().PadLeft(15));
                n = n * 10; 
            }
            Console.ReadKey();
        }
    }
}
