using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_21_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int max = int.MinValue;
            Console.WriteLine("Inserisci il numero di valori");
            if (int.TryParse(Console.ReadLine(), out n) && (n>0))
            {
                for (int i = 1; i<=n; i++)
                {
                    Console.WriteLine("Inserisci il primo valore "+ i.ToString() + ":");
                    if(int.TryParse(Console.ReadLine(),out x))
                    {
                        if (x > max)
                            max = x; 
                    }
                }
                Console.WriteLine(" Il valore massimo trovato è "+max.ToString());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Errore di input");
                Console.ReadKey();
            }
        }
    }
}
