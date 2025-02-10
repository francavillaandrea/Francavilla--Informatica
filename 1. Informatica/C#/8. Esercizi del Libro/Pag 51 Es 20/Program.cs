using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_20_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXG = 15;
            int ng;
            double m = 0; //Valore della multa iniziale a 0
            Console.WriteLine("Quanti giorni è durato il prestito?");
            if (int.TryParse(Console.ReadLine(), out ng) && (ng >= 0))
            {
                if (ng < MAXG)
                {
                    Console.WriteLine("Il socio non deve pagare nessuna multa perchè ha riconsegnato il libro entro 15 giorni");
                    Console.ReadKey();
                }
                else
                {
                    m = (float) (ng - MAXG) * 0.20;
                    Console.WriteLine("Il socio dovrà pagare una multa di " + m.ToString()+ " Euro.");
                    Console.ReadKey();
                }
            }else
            {
                Console.WriteLine("Errore di input");
                Console.ReadKey();
            }
        }
    }
}
