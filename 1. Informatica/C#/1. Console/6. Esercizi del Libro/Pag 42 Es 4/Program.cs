using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n4pag42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n_coppie = 0;
            int n_tris = 0;
            int n_lanci = 0;
            int d1, d2, d3;
            do
            {
                d1 = rnd.Next(1, 7);
                d2 = rnd.Next(1, 7);
                d3 = rnd.Next(1, 7);
                Console.WriteLine("dado1: " + d1.ToString() +
                    " dado2: " + d2.ToString() +
                    " dado3: " + d3.ToString());
                n_lanci++;
                if (d1 == d2 && d2 == d3)
                    n_tris++;
                else
                {
                    if (d1 == d2 || d2 == d3 || d3 == d1)
                        n_coppie++;
                }
            }
            while (d1 != 6 || d2 != 6 || d3 != 6);
            Console.WriteLine("lanci: " + n_lanci.ToString() +
                    " coppie: " + n_coppie.ToString()+
                    " tris: " + n_tris.ToString());
            Console.WriteLine("Programma terminato...");
            Console.ReadKey();
        }
    }
}
