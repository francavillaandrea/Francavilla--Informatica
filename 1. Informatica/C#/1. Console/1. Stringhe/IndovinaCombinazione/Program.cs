using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndovinaCombinazione
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            char scelta; // Gestione scelta menù 
            bool gioca, vittoria;
            // N.B. new int[0] istanza senza dimensionamento
            int[] comb = new int[0]; // Dichiaro array per memorizzare combinazione segreta
            int[] diff = new int[] { 3, 4, 5 };// Caricamento statico array 
            int contTent; // Salvo il numero di tentativi disponibili 
            int[] tentativo = new int[0]; // Dichiaro array per memorizzare il tentativo utente
            
            do
            {
                scelta = visualizzaMenu();
                gioca = false; 

                switch(scelta)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        // Vuole giocare 
                        gioca = true;
                        // Teniamo conto del valore decimale dei caratteri ASCII
                        // a = 97 b = 98 c = 99 
                        comb = new int[diff[scelta-'a']]; // Istanza del vettore
                        tentativo = new int[comb.Length]; // Istanza del vettore
                        generaCombinazione(comb);
                        break;
                }
                if(gioca)
                { // Inizio della partita 
                    contTent = 5;
                   
                    do
                    {
                        stampaGioco(comb, tentativo);
                        Console.WriteLine("TENTATIVI RESIDUI " + contTent.ToString());
                        effettuaTentativo(tentativo);
                        contTent--; // Decremento il contatore dei tenativi 
                        vittoria = analisaVittoria(comb, tentativo); 
                        
                    }
                    while (contTent != 0 && !vittoria);

                    stampaGioco(comb, tentativo);
                    if (!vittoria)
                    {
                        Console.WriteLine("PECCATO, HAI PERSO!");
                        Console.Write("La combinazione segreta era: ");
                        for (int i = 0; i < comb.Length; i++)
                            Console.Write(comb[i].ToString() + " ");
                    }
                    else
                        Console.WriteLine("BRAVO, HAI VINTO!!!");
                    Console.ReadKey();
                }
            }
            while (gioca);
            Console.WriteLine("Programma terminato");
            Console.ReadKey(); 
        }

        private static bool analisaVittoria(int[] comb, int[] tentativo)
        {
            int i = 0;
            while (i < comb.Length && comb[i] == tentativo[i] )
                i++;

            return (i == comb.Length); 
        }

        private static void effettuaTentativo(int[] tentativo)
        {
            for(int i=0; i<tentativo.Length; i++)
            {

                do
                {
                    Console.Write("Cella " + i.ToString() + ": ");
                }
                while (!int.TryParse(Console.ReadLine(), out tentativo[i])
                            || (tentativo[i] < 1 || tentativo[i] > 4));
            }
        }

        private static void stampaGioco(int[] comb, int[] tentativo)
        {
            Console.Clear();
            // Stampa X colorata 
            Console.Write("|"); 
            for(int i = 0;  i < comb.Length; i++)
            {
                if (comb[i] == tentativo[i])
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" X ");
                Console.ResetColor();
                Console.Write("|"); 
            }
            // Stampa Riga
            stampaRiga(comb.Length);
            // Stampa Contenuto tentativo
            Console.Write("|");
            for(int i=0; i< tentativo.Length; i++)
                Console.Write(" " + tentativo[i].ToString() + " |");
            // Stampa Riga
            stampaRiga(comb.Length);
        }

        private static void stampaRiga(int n)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write("----");
            Console.WriteLine("-");
        }

        private static void generaCombinazione(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(1, 5); 
        }

        private static char visualizzaMenu()
        {
            char sc;

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- INDOVINA COMBINAZIONE ---");
            Console.ResetColor();
            Console.WriteLine("a. Difficoltà semplice (3 cifre)");
            Console.WriteLine("b. Difficoltà media (4 cifre)");
            Console.WriteLine("c. Difficoltà difficile (5 cifre)");
            Console.WriteLine("*. Esci");
            do
            {
                Console.Write("Scelta > ");
            } while (!char.TryParse(Console.ReadLine(), out sc));
            return sc; 
        }
    }
}
