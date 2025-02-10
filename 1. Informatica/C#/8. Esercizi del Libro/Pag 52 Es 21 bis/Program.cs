using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_21_pag_52_bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int max = int.MinValue;
            do
            {
                Console.WriteLine("Inserisci il numero totale di valori: ");
            }
            while ( !int.TryParse(Console.ReadLine(), out n) || (n <=0));
            
            for (int i = 1; i < n; i++) 
            {
                do
                {
                    Console.WriteLine("Inserisci il "+i.ToString() + " valore");
                } 
                while ( !int.TryParse(Console.ReadLine(),out x) );
                if (x > max)
                    max = x;
            }

            Console.WriteLine("Il valore più alto è "+max.ToString());
            Console.ReadKey();
        }
    }
}
