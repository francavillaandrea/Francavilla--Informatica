using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es__11_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m,c,d,u;
            Console.WriteLine("Inserisci un valore compreso tra 1 e 9999");
            if (int.TryParse(Console.ReadLine( ), out n))
            {
                if (n >= 1 && n <= 9999)
                {
                    m = n / 1000;
                    n = n % 1000;
                    c = n / 100;
                    n= n % 100;
                    d = n / 10;
                    u = n % 10;
                    Console.WriteLine("Migliaia:"+m.ToString());
                    Console.WriteLine("Centinaia:"+c.ToString());
                    Console.WriteLine("Decine:"+d.ToString());
                    Console.WriteLine("Unità:"+u.ToString());

                }
                else
                    Console.WriteLine("Valori errati");
            }
            else
                 Console.WriteLine("Errore di Input");
               
            Console.ReadKey();
              
        }
    }
}
