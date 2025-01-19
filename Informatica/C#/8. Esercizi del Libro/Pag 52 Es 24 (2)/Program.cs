using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n24pag52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            do
                Console.Write("Inserisci n1: ");
            while (!int.TryParse(Console.ReadLine(), out n1) || n1 <= 0);
            do
                Console.Write("Inserisci n2: ");
            while (!int.TryParse(Console.ReadLine(), out n2) || n2 <= n1);
            if (n1 % 2 == 0)
                n1++;
            for (int i = n1; i <= n2; i += 2)
                Console.WriteLine(i.ToString());
            Console.WriteLine("Fine programma");
            Console.ReadKey();
        }
    }
}
