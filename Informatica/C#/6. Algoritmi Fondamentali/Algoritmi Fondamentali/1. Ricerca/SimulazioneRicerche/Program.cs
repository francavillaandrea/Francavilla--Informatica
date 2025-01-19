using System;
using System.Diagnostics;

namespace SimulazioneRicerche
{
    internal class Program
    {
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            int[] a; // Insieme di ricerca. Ordinato e senza ripetizioni
            int ultimo, x;
            bool trovato;

            Stopwatch swSeq = new Stopwatch();
            Stopwatch swBin = new Stopwatch();

            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine("CONFRONTO ALGORITMI DI RICERCA IN TICKS");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("N.".PadRight(15) + "SEQUENZIALE".PadRight(20) +
                                        "BINARIA".PadRight(20));
            Console.ResetColor();
            Console.WriteLine("".PadRight(55, '-'));

            a = new int[1000];
            ricercaSequenziale(a, 50);
            ricercaBinaria(a, 50);

            for (int i = 1000000; i <= 10000000; i = i + 1000000)
            {
                a = new int[i];
                ultimo = caricaVettOrdinatoSenzaRipetizioni(a);
                x = rnd.Next(1, ultimo + 1); // Elemento da cercare

                // Avvio ricerca sequenziale
                swSeq.Reset();
                swSeq.Start();
                trovato = ricercaSequenziale(a, x);
                swSeq.Stop();

                // Avvio ricerca binaria
                swBin.Reset();
                swBin.Start(); 
                ricercaBinaria(a, x);
                swBin.Stop();

                //if (trovato)
                //    Console.ForegroundColor = ConsoleColor.Green; 
                //else
                //    Console.ForegroundColor = ConsoleColor.Red;
                // Con operatore ternario 
                Console.ForegroundColor = (trovato == true) ? ConsoleColor.Green : ConsoleColor.Red;

                Console.WriteLine(i.ToString().PadRight(15) + 
                                swSeq.ElapsedTicks.ToString().PadRight(20) +
                                swBin.ElapsedTicks.ToString().PadRight(20));
                Console.ResetColor(); 
            }
            Console.ReadKey();
        }

        private static void ricercaBinaria(int[] v, int x)
        {
            int sup = 0;
            int inf = v.Length - 1;
            int metà;
            do
            {
                metà = (inf + sup) / 2;
                if (v[metà] != x)
                {
                    if (v[metà] > x)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            }
            while (v[metà] != x && sup <= inf);
        }
        private static bool ricercaSequenziale(int[] v, int x)
        {
            int i = 0;
            while (v[i] < x && i != v.Length - 1)
                i++;

            return (v[i] == x); 
        }

        private static int caricaVettOrdinatoSenzaRipetizioni(int[] v)
        {
            v[0] = rnd.Next(1, 5);
            for (int i = 1; i < v.Length; i++)
                v[i] = rnd.Next(v[i-1] + 1, v[i-1] + 5);
            return v[v.Length - 1];
        }
    }
}
