using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N21P52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int max = int.MinValue; // Carico il minor numero rappr. in int
            //Console.WriteLine("MIN: " + int.MinValue + " - MAX: " + 
            //                                            int.MaxValue);
            Console.Write("Inserisci il numero di valori: ");
            if (int.TryParse(Console.ReadLine(), out n) && (n > 0))
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("Inserisci valore " +
                                            i.ToString() + ": ");
                    if (int.TryParse(Console.ReadLine(), out x))
                    {
                        if (x > max)
                            max = x;
                    }
                } // fine for 
                Console.WriteLine("Il valore massimo trovato è " 
                                            + max.ToString());
            }
            else
            {
                Console.WriteLine("Errore input");
            }
            Console.WriteLine("Programma terminato...");
            Console.ReadKey();
        }
    }
}
