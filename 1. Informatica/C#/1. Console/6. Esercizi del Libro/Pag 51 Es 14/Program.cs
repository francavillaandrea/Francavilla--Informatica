using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_14_Pag_51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n_gg, p, a, pa;
            Console.WriteLine("Inserisci il prezzo della multa");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci dopo quanti giorni è stata pagata la multa");
            n_gg = Convert.ToInt32(Console.ReadLine());
            if (n_gg>0 || p>0)
            {
                if (n_gg<7)
                {
                    Console.WriteLine("L'ammontare della multa è " + p.ToString());
                    Console.ReadKey();
                }else if (n_gg >= 7 && n_gg < 13)
                {
                    a = (p * 10) / 100;
                    pa = a + p;
                    Console.WriteLine("L'ammontare della multa dopo l'aggiunta del 10% è " + pa.ToString());
                    Console.ReadKey();
                }
                else if (n_gg >= 14)
                {
                    a = (p * 30) / 100;
                    pa = a + p;
                    Console.WriteLine("L'ammontare della multa dopo l'aggiunta del 30% è " + pa.ToString());
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
