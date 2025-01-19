using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ricerche3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = null;

            ricerca_sequenziale_caso1(a);
            Console.ReadKey();
            ricerca_sequenziale_caso2(a);
            Console.ReadKey();
            ricerca_sequenziale_caso3(a);
            Console.ReadKey();
            ricerca_sequenziale_caso4(a);
            Console.ReadKey();
            ricerca_binaria(a);
            Console.ReadKey();
        }

        private static void ricerca_binaria(string[] v)
        {
            v = new string[] { "Barbieri", "Bertolini", "Bianchi", "Caruso", "Conti", "Coppola", "Costa", "Corsi", "De Luca", "D'Angelo", "Esposito", "Fabbri", "Ferrari",
                                "Gallo", "Giordano", "Lombardi", "Leone", "Mancini", "Migliorini","Mariani", "Martini", "Moretti", "Napolitano", "Pellegrini", "Perri",
                                "Ricci", "Romano", "Russo", "Rossi", "Santoro", "Vitali"};
            stampaVettore("Ricerca binaria su insieme ORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int sup = 0;
            int inf = v.Length - 1;
            int metà;

            do
            {
                metà = (inf + sup) / 2;
                if (v[metà] != x)
                {
                    if (v[metà].CompareTo(x) > 0)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            }
            while (v[metà] != x && sup <= inf);
            if (v[metà] == x)
                Console.WriteLine("Cognome trovato in pos." + metà.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }

        private static void ricerca_sequenziale_caso4(string[] v) // Insieme ordinato con ripetizioni
        {
            v = new string[] { "Barbero", "Chiera", "Chiera", "Chiera", "Fabri", "Vaschetta" };
            stampaVettore("Ricerca seq. su insieme ORDINATO e CON DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            bool trovato = false;
            bool superato = false;
            while (!superato && i <= v.Length - 1)
            {
                if (v[i] == x)
                {
                    Console.WriteLine("Cognome trovato in pos." + i.ToString());
                    trovato = true;
                    i++;
                }
                else
                {
                    if (v[i].CompareTo(x) > 0) //v[i]>x
                        superato = true;
                    else
                        i++;
                }
                if (!trovato)
                    Console.WriteLine("cognome non trovato");
            }

        }
        private static void ricerca_sequenziale_caso3(string[] v) // Insieme ordinato senza ripetizioni
        {
            v = new string[] { "Bianchi", "DevirgilioGallo", "Fabbri", "Gallo", "Melandri", "Varese" };
            stampaVettore("Ricerca seq. su insieme ORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            while (v[i].CompareTo(x) < 0 && i != v.Length - 1)//bisogna usare .CompareTo per confrontare 2 stringhe se non sono == o !=
                i++;
            if (v[i] == x)
                Console.WriteLine("Cognome trovato in pos." + i.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }

        private static void ricerca_sequenziale_caso2(string[] v) //Insieme disordinato con ripetizioni
        {
            v = new string[] { "Rossi", "Gallo", "Devirgilio", "Gallo", "Rossi", "Chiera" };
            stampaVettore("Ricerca seq. su insieme DISORDINATO e CON DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            bool trovato = false;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == x)
                    Console.WriteLine("Cognome trovato in pos." + i.ToString());
            }
            if (!trovato)
                Console.WriteLine("Cogome non trovato");


        }
        private static void ricerca_sequenziale_caso1(string[] v) //Insieme disordinato e senza ripetizioni
        {
            v = new string[] { "Rossi", "Gallo", "Devirgilio", "Melandri", "Fabbri", "Chiera" };
            stampaVettore("Ricerca seq. su insieme DISORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            while (v[i] != x && i != v.Length - 1)
                i++;
            if (v[i] == x)
                Console.WriteLine("Cognome trovato in pos." + i.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }
        private static void stampaVettore(string msg, string[] v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);
        }
    }
}
