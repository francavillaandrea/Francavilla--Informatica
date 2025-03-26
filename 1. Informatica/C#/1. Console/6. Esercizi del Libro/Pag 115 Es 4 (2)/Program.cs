using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4pag115
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
            stampa_elenco(cognomi, nomi, "ELENCO DA ORDINARE");
            Console.ReadKey();
            //ordina_selezione(cognomi, nomi);
            ordina_scambio(cognomi, nomi);
            stampa_elenco(cognomi, nomi, "ELENCO ORDINATO");
            Console.ReadKey();
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci il nome: ");
            string nome = Console.ReadLine();
            ricerca_binaria(cognomi, nomi, cognome, nome);
            Console.ReadKey();
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
                for (int j = cognomi.Length-2;  j >= i;  j--)
                {
                    s1 = cognomi[j] + nomi[j];
                    s2 = cognomi[j + 1] + nomi[j + 1];
                    if(s1.CompareTo(s2) > 0)
                    {
                        scambio(ref cognomi[j],ref cognomi[j + 1]);
                        scambio(ref nomi[j], ref nomi[j + 1]);
                        scambiato = true;
                    }
                }
            } 
            while (i!=cognomi.Length-2 && scambiato);
        }

        private static void ricerca_binaria(string[] cognomi, string[] nomi, string cognome, string nome)
        {
            int sup = 0;
            int inf = cognomi.Length - 1;
            int metà;
            string x = cognome + nome;
            string s = "";

            do
            {
                metà = (inf + sup) / 2;
                s = cognomi[metà] + nomi[metà];
                if(s!=x)
                {
                    if (s.CompareTo(x) > 0)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            } 
            while (s!=x && sup<=inf);
            if (s == x)
                Console.WriteLine(cognome + " " + nome +
                    " trovato in posizione: " + metà.ToString());
            else
                Console.WriteLine(cognome + " " + nome +
                    " non trovato");
        }

        private static void ordina_selezione(string[] cognomi, string[] nomi)
        {
            int posmin;
            string s1="", s2="";

            for (int i = 0; i <= cognomi.Length - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= cognomi.Length-1; j++)
                {
                    s1 = cognomi[posmin] + nomi[posmin];
                    s2 = cognomi[j] + nomi[j];
                    if (s1.CompareTo(s2) > 0)
                        posmin = j;
                }
                if(posmin!=i)
                {
                    scambio(ref cognomi[i], ref cognomi[posmin]);
                    scambio(ref nomi[i], ref nomi[posmin]);
                }
            }
        }
        private static void scambio(ref string s1, ref string s2)
        {
            string aus;

            aus = s1;
            s1 = s2;
            s2 = aus;
        }

        private static void stampa_elenco(string[] cognomi, string[] nomi, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < cognomi.Length; i++)
                Console.WriteLine(cognomi[i] + " " + nomi[i]);
        }
    }
}
