using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneScrutinio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cognomi = { "Barberis", "Bedreag", "Cambieri", "Cane", "Casalis",
                                "Cebotari", "Dellaferrera", "Ferrero", "Francavilla",
                                "Gatto", "Genta", "Ingaramo", "Manunta", "Marciuc",
                                "Milojkov", "Monte", "Oricco", "Ressia", "Revello",
                                "Riso", "Roveta", "Salinitri", "Ufe" };
            string[] materie = { "ITA", "STO", "MAT", "INF", "SIS", "TPSIT" };
            int[,] voti;
            string scelta;

            voti = new int[cognomi.Length, materie.Length];

            do
            {
                scelta = visualizzaMenu();
                Console.Clear();

                switch (scelta.ToLower())
                {
                    case "a":
                        ClsScrutinio.caricaVoti(voti);
                        Console.WriteLine("Voti caricati...");
                        break;
                    case "b":
                        ClsScrutinio.visualizzaScrutinio(cognomi, materie, voti);
                        break;
                    case "c":
                        break;
                    case "q":
                        Console.WriteLine("Arrivederci");
                        break;
                    default:
                        Console.WriteLine("Opzione non è disponibile");
                        break;
                }
                Console.ReadKey();
            } while (scelta.ToLower() != "q");
        }

        private static string visualizzaMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("::: GESTIONE SCRUTINIO :::");
            Console.ResetColor();
            Console.WriteLine("-".PadRight(30, '-'));
            Console.WriteLine("A. Carica valutazioni studenti");
            Console.WriteLine("B. Visualizza scrutinio");
            Console.WriteLine("C. Cerca studente migliore");
            Console.WriteLine("D. Cerca studente peggiore (barberis)");
            Console.WriteLine("E. Cerca materia con meno insufficienze");
            Console.WriteLine("f. Cerca materia con più insufficienze");
            Console.WriteLine("Q. Esci");
            Console.Write("Scelta > ");

            return Console.ReadLine();
        }
    }
}
