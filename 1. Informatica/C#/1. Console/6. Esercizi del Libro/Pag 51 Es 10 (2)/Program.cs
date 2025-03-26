using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n10pag51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, l;

            Console.Write("Inserisci il numero di lati: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci la lunghezza del lato: ");
            l = Convert.ToInt32(Console.ReadLine());
            if (n >= 3 && n <= 6 && l > 0)
            {
                switch (n)
                {
                    case 3:
                        Console.WriteLine("Triangolo equilatero");
                        break;
                    case 4:
                        Console.WriteLine("Quadrato");
                        break;
                    case 5:
                        Console.WriteLine("Pentagono");
                        break;
                    case 6:
                        Console.WriteLine("Esagono");
                        break;
                }
                Console.WriteLine("Perimetro: " + (n * l).ToString());
            }
            else
                Console.WriteLine("Errore nell'input");
            Console.WriteLine("Fine programma...");
            Console.ReadKey();
        }
    }
}
