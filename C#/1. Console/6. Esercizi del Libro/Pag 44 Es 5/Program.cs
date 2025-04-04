using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es5Pag45
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 0, q = 0, r = 0;
            do
            {
                Console.Write("Inserisci il Dividendo");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserisci il divisore");
                b = Convert.ToInt32(Console.ReadLine());
            } while (a <= 0 && b <= 0);
            while (a >= b)
            {
                a = a - b;
                q++;
            }
            r = a;
            Console.WriteLine("Quozioente " + q.ToString() + " resto " + r.ToString());
            Console.ReadKey();
        }
    }
}
