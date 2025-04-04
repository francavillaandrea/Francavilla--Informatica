using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21P52Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int max = int.MinValue;

            do
            {
                Console.Write("Inserisci il numero totale di valori: ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));

            for (int i = 1; i <= n; i++)
            {
                do
                {
                    Console.Write("Inserisci valore " + i.ToString() + ": "); 
                }
                while (!int.TryParse(Console.ReadLine(), out x));
                if (x > max)
                    max = x; 
            } // fine for 
            Console.WriteLine("Il valore massimo trovato è " + max.ToString());

            Console.WriteLine("Programma terminato...");
            Console.ReadKey();
        }
    }
}
