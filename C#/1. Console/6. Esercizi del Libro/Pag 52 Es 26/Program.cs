using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_26_p_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, f = 1;
            Console.WriteLine("inserisci il numero di cui vuoi sapere il fattoriale");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Errore nell'input. L'input deve essere maggiore di 0,e non deve essere un testo");
                Console.WriteLine("reinserisci il numero di cui vuoi sapere il fattoriale");
            }
            Console.WriteLine(" F=" + n.ToString() + " *");
            for (int i = 1; i <= n; i++)
            {
             f = f * i;
                if (i !=n)
                {
                Console.WriteLine(i.ToString());
                }else
                {
                    Console.WriteLine(i.ToString()+"=");
                }
               
            }
            Console.Write(f.ToString());
            Console.WriteLine("il fattoriale di " + n.ToString() + " è: " + f.ToString());
            Console.ReadKey();

        }
    }
}
