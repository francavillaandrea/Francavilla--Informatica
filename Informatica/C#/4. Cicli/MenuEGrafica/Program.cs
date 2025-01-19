using System;
using System.Threading;

namespace MenuEGrafica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta; // Carico input(scelta) dell'utente dopo stampa menù
            int lato;
            string parola; // Dichiarazione stringa 

            do
            {
                // Stampa menù
                Console.Clear();// pulisco contenuto console
                Console.BackgroundColor = ConsoleColor.White; // Sfondo
                Console.ForegroundColor = ConsoleColor.Red;  // Testo
                Console.WriteLine("--- ESERCIZI GRAFICA ---");
                Console.ResetColor(); // Resetto impostazioni di default

                Console.WriteLine("1. Caduta carattere");
                Console.WriteLine("2. Caduta parola");
                Console.WriteLine("3. Stampa quadrato");
                Console.WriteLine("4. Stampa quadrato bis");
                Console.WriteLine("5. Disegna albero");
                Console.WriteLine("6. Disegna rettangolo");
                Console.WriteLine("0. Esci");

                do
                {
                    Console.Write("Scelta > ");
                }
                while (!int.TryParse(Console.ReadLine(), out scelta));
                Console.Clear();// pulisco contenuto console
                //scelta = Convert.ToInt32(Console.ReadLine());   
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Arrivederci...");
                        break;
                    case 1: // Caduta carattere
                        // SetCursorPosition permette di spostare 
                        // il cursore in un punto x, y specificato
                        for (int i = 0; i <= 10; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("X");
                            Thread.Sleep(200);
                            Console.Clear();
                        }
                        break;
                    case 2: // Caduta parola
                        Console.Write("Inserisci parola: ");
                        parola = Console.ReadLine();
                        Console.Clear(); 
                        Console.Write(parola);

                        for(int i = 0; i < parola.Length ; i++)
                        {
                            //Console.WriteLine(parola[i]);
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.SetCursorPosition(i, j);
                                Console.Write(parola[i].ToString());
                                Thread.Sleep(200);
                            }
                        }
                        break;
                    case 3: // Stampa quadrato
                        lato = 10; 
                        // lato sx 
                        for(int i = 0; i < lato; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("*");
                            Thread.Sleep(200);
                        }
                        // lato inf
                        for(int i = 0; i < lato; i++)
                        {
                            Console.SetCursorPosition(i, lato);
                            Console.Write("*");
                            Thread.Sleep(200);
                        }
                        // Lato dx 
                        for(int i = lato; i >= 0; i--)
                        {
                            Console.SetCursorPosition(lato, i);
                            Console.Write("*");
                            Thread.Sleep(200);
                        }
                        // lato sup 
                        for (int i = lato; i >= 0; i--)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("*");
                            Thread.Sleep(200);
                        }
                        break;
                    case 4:
                        lato = 10; 
                        // Lato sx e dx 
                        for (int i = 0; i < lato; i++)
                        {
                            // lato sx 
                            Console.SetCursorPosition(0, i);
                            Console.Write("+");
                            // lato dx 
                            Console.SetCursorPosition(lato, i);
                            Console.Write("+");
                            Thread.Sleep(200); 
                        }
                        // Lato sup e inf 
                        for (int i = 0; i < lato; i++)
                        {
                            // lato sup 
                            Console.SetCursorPosition(i, 0);
                            Console.Write("+");
                            // lat inf 
                            Console.SetCursorPosition(i, lato);
                            Console.Write("+");
                            Thread.Sleep(200);
                        }
                        break;
                    case 5:
                        // Disegna albero
                        int n = 10;
                        Console.Write(new string('*', n)); // Console.Write("**********");

                        /*
                              *
                             ***
                            *****
                           *******
                          *********
                         ***********
                             |||
                             |||
                         */
                        break;
                    case 6:
                        disegnaRettangolo();
                        break;
                    default:
                        Console.WriteLine("Opzione non valida");
                        break;
                } // fine switch
                Console.ReadKey();
            } // fine do while 
            while (scelta != 0);
            // Fine programma
        }

        private static void disegnaRettangolo()
        {
            int b, h;

            do
            {
                Console.Write("Inserisci base: "); 
            } 
            while (!int.TryParse(Console.ReadLine(), out b) || (b <= 0));

            do
            {
                Console.Write("Inserisci altezza: ");
            }
            while (!int.TryParse(Console.ReadLine(), out h) || (h <= 0));
            Console.Clear();
            // Disegno colonne
            for(int j = 1; j <= h; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write("+");
                Thread.Sleep(200);

                Console.SetCursorPosition(b, j);
                Console.Write("+");
                Thread.Sleep(200);
            }
            // Disegno base
            for (int j = 1; j <= b; j++)
            {
                Console.SetCursorPosition(j, 0);
                Console.Write("+");
                Thread.Sleep(200);

                Console.SetCursorPosition(j, h);
                Console.Write("+");
                Thread.Sleep(200);
            }
        }
    }
}
