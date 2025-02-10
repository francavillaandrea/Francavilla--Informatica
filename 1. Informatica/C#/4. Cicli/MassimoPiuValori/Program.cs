using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassimoPiuValori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int max;

            Console.Write("Inserisci primo valore: ");
            // scanf("%d", &a);
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci secondo valore: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci terzo valore: ");
            c = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Inserisci quarto valore: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (a > b)
                max = a;
            else
                max = b;
            if (c > max)
                max = c;
            if (d > max)
                max = d;
            // printf("Il numero più grande è %d\n", max);
            Console.WriteLine("Il numero più grande è " + max.ToString());
            // printf("Fine Programma\n"); 
            Console.WriteLine("Fine Programma...");
            /*
             "Blocco" la console fino a quando
              l'utente non preme un tasto
             */
            Console.ReadKey(); 
        }
    }
}
