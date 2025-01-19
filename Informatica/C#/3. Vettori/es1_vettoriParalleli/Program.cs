using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es1_vettoriParalleli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = new string[] {"Barberis","Barberis","Cambieri","Cane",
                "Cebotari","Cebotari","Cebotari","Ferrero" };
            string[] nomi = new string[] {"Lorenzo","Cosmin","Luca","Mattia",
                "Cristopher","Maxim","Miriam","Valentino" };
            string[] classi = new string[] {"2A","2A","1A","3A",
                "1A","3A","2A","2A" };
            stampaVettori(cognomi, nomi, classi);
            Console.ReadKey();
            es1(cognomi, nomi, classi);
            Console.ReadKey();
            es2(cognomi, nomi, classi);
            Console.ReadKey();
            es3(cognomi, nomi, classi);
            Console.ReadKey();
        }

        private static void es3(string[] cognomi, string[] nomi, string[] classi)
        {
            //cercare studenti con cognome in input
            //ric.seq. caso 4 insieme ordinato e con ripetizioni
            //ROTTURA DI CHIAVE
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            bool trovato = false;
            bool superato = false;
            int i = 0;

            while (!superato && i<=cognomi.Length-1)
            {
                if(cognomi[i]==cognome)
                {
                    Console.WriteLine(nomi[i] + " " + classi[i]);
                    trovato = true;
                    i++;
                }
                else
                {
                    if (cognomi[i].CompareTo(cognome) >= 0)
                        superato = true;
                    else
                        i++;
                }
            }
            if (!trovato)
                Console.WriteLine("Cognome non trovato");
        }

        private static void es2(string[] cognomi, string[] nomi, string[] classi)
        {
            //cercare classe di uno studente con cognome in input
            //ric.seq. caso 3 insieme ordinato e senza ripetizioni
            Console.Write("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            int i = 0;

            while (cognomi[i].CompareTo(cognome)<0 && i != cognomi.Length - 1)
                i++;
            if (cognomi[i].Equals(cognome))
                Console.WriteLine(classi[i]);
            else
                Console.WriteLine("Cognome non trovato");
        }

        private static void es1(string[] cognomi, string[] nomi, string[] classi)
        {
            //cercare studenti classe in input
            //ric.seq. caso 2 insieme disordinato e con ripetizioni
            Console.Write("Inserisci la classe: ");
            string classe=Console.ReadLine();
            bool trovato = false;

            for (int i = 0; i < classi.Length; i++)
                if (classi[i]==classe)
                {
                    trovato=true;
                    Console.WriteLine(cognomi[i]+ " " + nomi[i]);
                }
            if (!trovato)
                Console.WriteLine("Classe non trovata");
        }

        private static void stampaVettori(string[] cognomi, string[] nomi, string[] classi)
        {
            for (int i = 0; i < cognomi.Length; i++)
                Console.WriteLine(cognomi[i]+ "  "+ nomi[i]+ " "+ classi[i]);
        }
    }
}
