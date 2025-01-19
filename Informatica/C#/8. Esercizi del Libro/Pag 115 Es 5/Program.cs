using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = { "Santoro", "Rossi", "Bianchi", "Verdi",
                "Ferrari", "Esposito", "Ricci", "Conti", "Fontana", "Santoro",
                "Lombardi", "Barbieri", "Moretti", "Santoro", "Marino",
                "Lombardi", "Gallo", "Giordano", "Ferri", "Mancini" };
            string[] nomi = {"Andrea", "Luca", "Marco", "Francesca", "Giulia",
                "Elena", "Matteo", "Alessandro", "Sara", "Valentina", "Simone",
                "Federico", "Chiara", "Marta", "Paolo", "Anna", "Claudia",
                "Davide", "Laura", "Giorgio"};
            string[] squadre = { "Real Madrid", "Manchester United",
                "Barcelona", "Juventus", "Bayern Munich",
                "Paris Saint-Germain", "Liverpool", "Chelsea", "AC Milan",
                "AC Milan", "Juventus", "Atletico Madrid",
                "Real Madrid", "Manchester United", "Barcelona",
                "Juventus", "Bayern Munich", "Paris Saint-Germain",
                "Juventus", "Chelsea" };
            stampa_elenco(cognomi, nomi, squadre, "ELENCO GIOCATORI DI CALCIO");
            Console.ReadKey();
            Console.Write("Inserisci la squadra: ");
            string squadra = Console.ReadLine();
            ricerca_seq(cognomi, nomi, squadre, squadra);
            Console.ReadKey();
            conta_giocatori_per_ogni_squadra(cognomi, nomi, squadre);
            Console.ReadKey();
            elencare_giocatori_per_ogni_squadra(cognomi, nomi, squadre);
            Console.ReadKey();
        }

        private static void elencare_giocatori_per_ogni_squadra(string[] cognomi, string[] nomi, string[] squadre)
        {
            ordina_squadre(cognomi, nomi, squadre);
            elenca_giocatori(cognomi, nomi, squadre);
        }

        private static void elenca_giocatori(string[] cognomi, string[] nomi, string[] squadre)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Giocatori per squadra");
            Console.ResetColor();
            string player = cognomi[0] + " " + nomi[0] + " ";
            for (int i = 1; i < squadre.Length - 1; i++)
            {
                if (squadre[i] == squadre[i + 1])
                    player += cognomi[i] + " " + nomi[i] +" ";
                else //ROMPO LA CHIAVE
                {
                    player += cognomi[i] + " " + nomi[i] + " ";
                    Console.WriteLine(squadre[i] + ": " + player);
                    player = "";// cognomi[i + 1] + " " + nomi[i + 1] + " ";
                }   
            }
            player += cognomi[squadre.Length-1] + " " + nomi[squadre.Length - 1] + " ";
            Console.WriteLine(squadre[squadre.Length - 1] + ": " + player);
        }

        private static void conta_giocatori_per_ogni_squadra(string[] cognomi, string[] nomi, string[] squadre)
        {
            ordina_squadre(cognomi, nomi, squadre);
            conta_giocatori(squadre);
        }

        private static void conta_giocatori(string[] squadre)
        {
            string[] s = new string[100];
            int[] c = new int[100];
            int j = 0; //indice per vettori locali
            int cont = 1;
            for (int i = 0; i < squadre.Length - 1; i++)
            {
                if (squadre[i] == squadre[i + 1])
                    cont++;
                else //ROMPO LA CHIAVE
                {
                    s[j] = squadre[i];
                    c[j++] = cont;
                    cont = 1;
                }
            }
            s[j] = squadre[squadre.Length-1];
            c[j++] = cont;
            //a questo punto conosco il numero di squadre
            //e vado a fare la resize dei 2 vettori locali
            //portandoli a lunghezza j
            Array.Resize(ref s, j);
            Array.Resize(ref c, j);
            ordina_conteggio_giocatori(s, c);
        }

        private static void ordina_conteggio_giocatori(string[] s, int[] c)
        {
            //selection sort DECRESCENTE in base al vettore c
            int posmax;

            for (int i = 0; i <= c.Length - 2; i++)
            {
                posmax = i;
                for (int j = i + 1; j <= c.Length - 1; j++)
                    if (c[posmax] < c[j])
                        posmax = j;
                if (posmax != i)
                { //VETTORE PARALLELI!!!
                    scambio(ref s[i], ref s[posmax]);
                    scambio_int(ref c[i], ref c[posmax]);
                }
            }
            stampa_classifica(s, c);
        }

        private static void stampa_classifica(string[] s, int[] c)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero giocatori per squadra");
            Console.ResetColor();
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i].PadRight(25) +
                    c[i].ToString());
        }

        private static void scambio_int(ref int a, ref int b)
        {
            int aus;

            aus = a;
            a = b;
            b = aus;
        }

        private static void ordina_squadre(string[] cognomi, string[] nomi, string[] squadre)
        {
            //selection sort
            int posmin;

            for (int i = 0; i <= squadre.Length - 2; i++)
            {
                posmin = i;
                for (int j = i+1; j <= squadre.Length - 1; j++)
                    if (squadre[posmin].CompareTo(squadre[j]) > 0)
                        posmin = j;
                if(posmin!=i)
                { //VETTORE PARALLELI!!!
                    scambio(ref cognomi[i], ref cognomi[posmin]);
                    scambio(ref nomi[i], ref nomi[posmin]);
                    scambio(ref squadre[i], ref squadre[posmin]);
                }
            }
        }

        private static void ricerca_seq(string[] cognomi, string[] nomi, string[] squadre, string squadra)
        {
            //ric. seq. insieme disordinato con ripetizioni
            string[] co = new string[squadre.Length];
            string[] no = new string[squadre.Length];
            int j = 0; //per i vettori locali

            for (int i = 0; i < squadre.Length; i++)
                if(squadre[i]==squadra)
                {
                    co[j] = cognomi[i];
                    no[j++] = nomi[i];
                }
            if (j == 0)
                Console.WriteLine("Squadra non trovata");
            else
            {
                Array.Resize(ref co, j);
                Array.Resize(ref no, j);
                ordina_scambio(co, no);
                stampa_elenco_cono(co, no, "Giocatori della squadra: " + squadra);
            }
        }

        private static void stampa_elenco(string[] cognomi, string[] nomi, string[] squadre, string msg)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < cognomi.Length; i++)
                Console.WriteLine(cognomi[i].PadRight(13) + nomi[i].PadRight(13)+ squadre[i]);
        }
        private static void stampa_elenco_cono(string[] cognomi, string[] nomi, string msg)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < cognomi.Length; i++)
                Console.WriteLine(cognomi[i] + " " + nomi[i]);
        }
        private static void scambio(ref string s1, ref string s2)
        {
            string aus;

            aus = s1;
            s1 = s2;
            s2 = aus;
        }
        private static void ordina_scambio(string[] cognomi, string[] nomi)
        {
            int i = -1;
            bool scambiato;
            string s1, s2;

            do
            {
                i++;
                scambiato = false;
                for (int j = cognomi.Length - 2; j >= i; j--)
                {
                    s1 = cognomi[j] + nomi[j];
                    s2 = cognomi[j + 1] + nomi[j + 1];
                    if (s1.CompareTo(s2) > 0)
                    {
                        scambio(ref cognomi[j], ref cognomi[j + 1]);
                        scambio(ref nomi[j], ref nomi[j + 1]);
                        scambiato = true;
                    }
                }
            }
            while (i != cognomi.Length - 2 && scambiato);
        }
    }
}
