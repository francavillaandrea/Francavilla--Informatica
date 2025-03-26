using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n26pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, f;

            do
                Console.Write("Inserisci n: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            f = 1;
            Console.Write("f(" + n.ToString() + ")=");
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                if(i!=n)
                    Console.Write(i.ToString()+"*");
                else
                    Console.Write(i.ToString()+"=");
            }              
            Console.WriteLine(f.ToString());
            Console.WriteLine("Fine programma");
            Console.ReadKey();
        }
    }
}
