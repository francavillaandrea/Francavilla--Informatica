using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_23_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Inserisci un numero");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);


            if (n%2 == 0)
            {
                for (int i = 2; i <= n; i+=2)
                {
                    Console.WriteLine("Il numero è " + i.ToString());
                    
                }
                
            }else
            {
                for (int i = 2; i <=n; i+=2)
                { 
                    Console.WriteLine("Il numero è " + i.ToString());

                }
            }
            Console.ReadKey();
                

            
        }
        
    }
}
