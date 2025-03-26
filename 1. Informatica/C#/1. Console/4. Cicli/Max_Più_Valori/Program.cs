using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Più_Valori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int max;

            Console.Write("Inserisci il primo valore: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il secondo valore: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il terzo valore: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserisci il quarto valore: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (a>b)
                max=a;
            else 
                max=b;
            if(c >d)
                max = c;
            else 
                max=d;
            Console.WriteLine("Il valore maggiore è " + max.ToString());

            Console.WriteLine("Fine Codice...");
            /*
              Ferma la console fino 
            a quando l'utente 
            non preme un tasto qualsiasi
            */
            Console.ReadKey(); 
        }
    }
}
