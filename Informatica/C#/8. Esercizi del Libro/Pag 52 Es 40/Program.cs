using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_40_pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, nl = 0;
            inserisciNintero("Inserisci n:", 1);
            inserisciNintero("Inserisci il numero di volte da tirare il dado", 1);
            for (int i = 0; i<=n; i++)
            {
                n = Rnd.Next(1, n+1);
                Console.WriteLine(n.ToString());
            }
            Console.ReadKey();
        }

        private static int inserisciNintero(string msg, int min) //firma di un metodo
        {
            int n;
            do
                Console.Write(msg);
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= min));
            return n;

        }
    }
}
