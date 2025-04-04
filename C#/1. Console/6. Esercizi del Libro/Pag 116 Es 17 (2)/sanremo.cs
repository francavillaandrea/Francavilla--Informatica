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

        public static void es5(string[] canzoni, string[] cantanti, int[] punteggi)
        {
            es4(canzoni, cantanti, punteggi);
            Console.ReadKey();
            titolo("Primo/i in classifica");
            cercaPrimo(cantanti, punteggi);
        }

        private static void cercaPrimo(string[] cantanti, int[] punteggi)
        {
            int max = punteggi[0];
            int i = 0;

            while (punteggi[i] == max && i != punteggi.Length - 1)
                Console.WriteLine(cantanti[i++]);
        }

        public static void es4(string[] canzoni, string[] cantanti, int[] punteggi)
        {
            carica_punteggi(punteggi);
            stampaElencoConPunteggi(canzoni, cantanti, punteggi);
            stampaClassifica(canzoni, cantanti, punteggi);
        }

        private static void stampaClassifica(string[] canzoni, string[] cantanti, int[] punteggi)
        {
            ordina_punteggi(canzoni, cantanti, punteggi);
            stampaElencoConPunteggi(canzoni, cantanti, punteggi);
        }

        private static void ordina_punteggi(string[] canzoni, string[] cantanti, int[] punteggi)
        {
            int posmin;

            for (int i = 0; i <= cantanti.Length - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= cantanti.Length - 1; j++)
                    if (punteggi[posmin] < punteggi[j])
                        posmin = j;
                if (posmin != i)
                {
                    scambio_int(ref punteggi[i], ref punteggi[posmin]);
                    scambio(ref cantanti[i], ref cantanti[posmin]);
                    scambio(ref canzoni[i], ref canzoni[posmin]);
                }
            }
        }

        private static void stampaElencoConPunteggi(string[] canzoni, string[] cantanti, int[] punteggi)
        {
            titolo("Elenco CANZONI - CANTANTI - PUNTEGGI");
            for (int i = 0; i < canzoni.Length; i++)
                Console.WriteLine(canzoni[i].PadRight(35) +
                    cantanti[i].PadRight(30) + punteggi[i].ToString());
        }

        private static void carica_punteggi(int[] punteggi)
        {
            Random rnd = new Random();
            for (int i = 0; i < punteggi.Length; i++)
                punteggi[i] = rnd.Next(1, 11);
        }

        public static void es3(string[] canzoni, string[] cantanti)
        {
            ordina_cantanti(canzoni, cantanti);
            stampaElenco(canzoni, cantanti);
            string[] singer = new string[cantanti.Length];
            int[] cnt = new int[cantanti.Length];
            int j = 0; //indice per i vettori ausiliari
            //USO IL METODO DEL TAPPO
            //aggiungo un TAPPO al fondo del vettore dei cantanti
            Array.Resize(ref cantanti, cantanti.Length + 1);
            cantanti[cantanti.Length - 1] = "Zz";
            titolo("Numero canzoni per cantante");
            int cont = 1;
            for (int i = 0; i < cantanti.Length - 1; i++)
                if (cantanti[i] == cantanti[i + 1])
                    cont++;
                else //ROMPO LA CHIAVE
                {
                    singer[j] = cantanti[i];
                    cnt[j++] = cont;
                    cont = 1;
                }
            //Tolgo il TAPPO
            Array.Resize(ref cantanti, cantanti.Length - 1);
            //ridimensiono i vettori ausiliari
            Array.Resize(ref singer, j);
            Array.Resize(ref cnt, j);
            ordina_cnt(singer, cnt);
            stampaNumeroCanzoni(singer, cnt);
        }

        private static void stampaNumeroCanzoni(string[] singer, int[] cnt)
        {
            titolo("Elenco CANTANTI - N° CANZONI");
            for (int i = 0; i < singer.Length; i++)
                Console.WriteLine(singer[i].PadRight(35) + cnt[i].ToString());
        }

        private static void ordina_cnt(string[] cantanti, int[] cnt)
        {
            int posmin;

            for (int i = 0; i <= cantanti.Length - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= cantanti.Length - 1; j++)
                    if (cnt[posmin] < cnt[j])
                        posmin = j;
                if (posmin != i)
                {
                    scambio_int(ref cnt[i], ref cnt[posmin]);
                    scambio(ref cantanti[i], ref cantanti[posmin]);
                }
            }
        }

        private static void scambio_int(ref int a, ref int b)
        {
            int aus = a;
            a = b;
            b = aus;
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