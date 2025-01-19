using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5pag44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, q, r;

            Console.Write("Inserisci il dividendo intero positivo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il divisore intero positivo: ");
            b = Convert.ToInt32(Console.ReadLine());
            //non controllo vincoli di integrità
            q = 0;
            while (a >= b)
            {
                a = a - b;
                q = q + 1;
            }
            r = a;
            Console.WriteLine("Quoziente: " + q.ToString() +
                " Resto: " + r.ToString());
            Console.WriteLine("Fine programma...");
            Console.ReadKey();
        }
    }
}
