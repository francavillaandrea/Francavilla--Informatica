using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individuatore_Poligoni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, n, p;
            Console.WriteLine("Inserisci il numero di lati");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci il valore dei lati");
            l=Convert.ToInt32(Console.ReadLine());
            if (n >= 3 && n <= 6 && l > 0)
            {
                switch (n)
                {
                    case 3: Console.WriteLine("Il poligono è un triangolo"); break;
                    case 4: Console.WriteLine("Il poligono è un quadrato"); break;
                    case 5: Console.WriteLine("Il poligono è un pentagono"); break;
                    case 6: Console.WriteLine("Il poligono è un esagono"); break;
                }
                p = n * l;
                Console.Write("Il perimetro è " + p.ToString());
                Console.ReadKey();

            }
            else
                Console.WriteLine("Errore di input");
            Console.ReadKey();


        }
    }
}
