using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N20P51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXG = 15; // Costante intera
            int g;
            double m = 0;  // Valore della multa iniz. a 0 

            Console.Write("Inserisci il numero di giorni: ");
           // g = Convert.ToInt32(Console.ReadLine());
            if (int.TryParse(Console.ReadLine(), out g) && (g >= 0))
            {
                if ( g >= MAXG)
                    m = (g - MAXG) * 0.20;
                
                Console.WriteLine("Multa calcolata: " + m.ToString() +
                                    " Euro");
            }
            else
            {
                Console.WriteLine("Errore input..."); 
            }
            Console.WriteLine("Programma terminato...");
            Console.ReadKey(); 
        }
    }
}
