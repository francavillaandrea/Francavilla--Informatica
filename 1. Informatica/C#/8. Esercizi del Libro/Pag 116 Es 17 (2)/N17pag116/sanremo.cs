using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n17pag116
{
    class sanremo
    {
        public static void es1(string[] canzoni, string[] cantanti)
        {
            Console.Write("Inserisci il cantante: ");
            string cantante = Console.ReadLine();

            bool trovato = false;
            titolo("Canzoni del cantante " + cantante);
            for (int i = 0; i < cantanti.Length; i++)
                if (cantanti[i] == cantante)
                {
                    Console.WriteLine(canzoni[i]);
                    trovato = true;
                }
            if (!trovato)
                Console.WriteLine("Cantante non trovato");
        }

        private static void titolo(string msg)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void stampaElenco(string[] canzoni, string[] cantanti)
        {
            titolo("Elenco CANZONI - CANTANTI");
            for (int i = 0; i < canzoni.Length; i++)
                Console.WriteLine(canzoni[i].PadRight(35) + cantanti[i]);
        }

        public static void es2(string[] canzoni, string[] cantanti)
        {
            ordina_cantanti(canzoni, cantanti);
            stampaElenco(canzoni, cantanti);
            Console.Write("Inserisci il cantante: ");
            string cantante = Console.ReadLine();
            int i = 0;
            bool trovato = false;
            bool superato = false;

            titolo("Canzoni del cantante " + cantante);
            while (!superato && i <= cantanti.Length - 1)
            {
                if (cantanti[i] == cantante)
                {
                    Console.WriteLine(canzoni[i]);
                    trovato = true;
                    i++;
                }
                else
                {
                    if (cantanti[i].CompareTo(cantante) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            if (!trovato)
                Console.WriteLine("Cantante non trovato");
        }

        public static void es3(string[] canzoni, string[] cantanti)
        {
            ordina_cantanti(canzoni, cantanti);
            stampaElenco(canzoni, cantanti);
            //string[] singer = new string[cantanti.Length];
            //int[] cnt = new int[cantanti.Length];
            //int j = 0; //indice per i vettori ausiliari
            //uso il metodo del TAPPO

            titolo("Numero canzoni per cantante");
            int cont = 1;
            for (int i = 0; i < cantanti.Length - 1; i++)
                if (cantanti[i] == cantanti[i + 1])
                    cont++;
                else //ROMPO LA CHIAVE
                {
                    Console.WriteLine(cantanti[i].PadRight(30) +
                        cont.ToString());
                    cont = 1;
                }
            Console.WriteLine(cantanti[cantanti.Length - 1].PadRight(30) +
                        cont.ToString());
        }

        private static void ordina_cantanti(string[] canzoni, string[] cantanti)
        {
            int posmin;

            for (int i = 0; i <= cantanti.Length - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= cantanti.Length - 1; j++)
                    if (cantanti[posmin].CompareTo(cantanti[j]) > 0)
                        posmin = j;
                if (posmin != i)
                {
                    scambio(ref canzoni[i], ref canzoni[posmin]);
                    scambio(ref cantanti[i], ref cantanti[posmin]);
                }
            }
        }

        private static void scambio(ref string s1, ref string s2)
        {
            string aus = s1;
            s1 = s2;
            s2 = aus;
        }
    }
}
