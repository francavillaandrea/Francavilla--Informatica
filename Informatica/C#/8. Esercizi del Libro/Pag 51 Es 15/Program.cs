using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_15_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pr , s, ps;
            Console.WriteLine("Inserisci un prezzo");
            pr = Convert.ToInt32(Console.ReadLine());
            if ( pr <= 0)
            {
                Console.WriteLine("Errore di Input");
                Console.ReadKey();
            }
            if (pr <100)
            {
                ps = (pr * 5) / 100;
                s = pr - ps;
            }
            else if (pr>=100 && pr<300)
            {
             ps = (pr * 10) / 100;
            s = pr - ps;
            }       
            else 
                ps=(pr*20)/100;
            s = pr - ps;
            Console.WriteLine("Il prezzo finale è "+ s.ToString());
            Console.ReadKey();
                
        }
    }
}
