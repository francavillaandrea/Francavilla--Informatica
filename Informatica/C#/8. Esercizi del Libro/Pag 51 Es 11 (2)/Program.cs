using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n11pag51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int m, c, d, u;

            Console.Write("Inserisci n: ");
            //controllo che l'input sia proprio un int
            //int.tryparse restituisce un boolean
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n >= 1 && n <= 9999)
                {
                    //uso operatori DIV e MOD
                    //SOLO tra operandi int
                    m = n / 1000;
                    n = n % 1000;
                    c = n / 100;
                    n = n % 100;
                    d = n / 10;
                    u= n % 10;
                    Console.WriteLine("Migliaia: " + m.ToString());
                    Console.WriteLine("Centinaia: " + c.ToString());
                    Console.WriteLine("Decine: " + d.ToString());
                    Console.WriteLine("Unità: " + u.ToString());
                }
                else
                    Console.WriteLine("Valore non valido!");
            }
            else
                Console.WriteLine("Input errato");
            Console.WriteLine("Fine programma...");
            Console.ReadKey();
        }
    }
}
