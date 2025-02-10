using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi_Fondamentalii
{
    internal class Menu
    {
        public static void menùRic()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A:Ricerca Sequenziale Caso 1:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B:Ricerca Sequenziale Caso 2:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("C:Ricerca Sequenziale Caso 3:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("D:Ricerca Sequenziale Caso 4:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("E:Ricerca Binaria");
            Console.WriteLine("Q:Esci");
            Console.ResetColor();
        }

        public static string menù()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------- ALGORITMI FONDAMENTALI ----------");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A:Algoritmi di Ricerca");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B:Algoritmi di Ordinamento");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("C:Algoritmi di Merge");
            Console.ResetColor();
            Console.WriteLine("Q:Esci");
            Console.Write("-------------------------> ");
            return Console.ReadLine();


        }

        public static void menùMerge()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A:Merge senza tappo");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B:Merge con tappo");
            Console.ResetColor();
            Console.WriteLine("Q:Esci");
            Console.Write("-------------------------> ");
        }

        public static void menùOrd()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("A:Selection Sort");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("B:Bubble Sort");
            Console.ResetColor();
            Console.WriteLine("Q:Esci");
            Console.Write("-------------------------> ");
        }
    }
}
