using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Verifica_Barbero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] piloti = {
                "Senna", "Prost", "Schumacher", "Hamilton", "Vettel",
                "Verstappen", "Alonso", "Raikkonen", "Leclerc", "Perez",
                "Rosberg", "Button", "Hakkinen", "Hill", "Lauda",
                "Fangio", "Clark", "Hunt", "Villeneuve", "Mansell",
                "Piquet", "Ricciardo", "Gasly"
            };
            string[] scuderie = { "McLaren", "Ferrari", "Ferrari", "Mercedes", "Red Bull", "Red Bull", "Alpine",
                        "Ferrari", "Ferrari", "Red Bull", "Mercedes", "McLaren", "McLaren", "Williams", "Ferrari",
                        "Mercedes", "Lotus", "Ferrari", "McLaren", "Williams", "Benetton", "Renault", "AlphaTauri" };
            string scelta;

            do
            {
                scelta = visualizzaMenu();
                Console.Clear();
                switch (scelta.ToLower())
                {
                    case "a":
                        //Ordina i vettori, visualizza i vettori ordinati e visualizza i piloti di una scuderia in input
                        Correzione.ordina(scuderie, piloti);
                        Correzione.stampaVettore(piloti, scuderie);
                        Correzione.visualizzaPiloti(piloti, scuderie);
                        break;
                    case "b":
                        Correzione.ordina(scuderie, piloti);
                        Correzione.nPiloti(scuderie, piloti);
                        break;
                    case "c":
                        Correzione.Gara(scuderie, piloti);
                        break;
                    case "q":
                        Console.WriteLine("Prova terminata...");
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ReadKey();
            } while (scelta.ToLower() != "q");

        }

        private static string visualizzaMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("::: Verifica Array Paralleli :::");
            Console.ResetColor();
            Console.WriteLine("a. Visualizza piloti di una scuderia in input");
            Console.WriteLine("b. Conta per ogni scuderia il numero di piloti");
            Console.WriteLine("c. Genera gara automobilistica");
            Console.WriteLine("q. Termina");
            Console.Write("Scelta > ");
            return Console.ReadLine();
        }
    }
}

