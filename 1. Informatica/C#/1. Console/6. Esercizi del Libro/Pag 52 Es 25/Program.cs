using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_25__Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nn, s = 0, n, r = 0, m = 0; ;
            do
            {
                Console.Write("Di quanti numeri vuoi fare la media aritmetica?");
                nn = Convert.ToInt32(Console.ReadLine());
            } while ( nn < 0);
            for (int i = 1; i <= nn ; i++)
            {
                Console.Write("Inserisci il "+ i.ToString()+ "° numero");
                n= Convert.ToInt32(Console.ReadLine());
                s = s + n;
            }
            m = s / nn;
            r = s % nn;
            Console.WriteLine("Il risultato della media matematica tra i " + nn.ToString() + " numeri dati in input è " + m.ToString() + " con resto "+ r.ToString());
            Console.ReadKey();
            
        }
    }
}
