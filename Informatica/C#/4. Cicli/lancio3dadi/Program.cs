using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lancio3Dadi
{
    internal class Program
    {
        // Per poter estrarre valori casuali
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            int d1, d2, d3;
            // Estraggo un numero tra 1 e 6 
            // N.B. Attenzione al secondo parametro 
            d1 = rnd.Next(1, 7); 
            d2 = rnd.Next(1, 7); 
            d3 = rnd.Next(1, 7);

            Console.WriteLine("d1: " + d1.ToString()); 
            Console.WriteLine("d2: " + d2.ToString()); 
            Console.WriteLine("d3: " + d3.ToString());


            Console.WriteLine("Programma terminato..."); 
            Console.ReadKey();
        }
    }
}
