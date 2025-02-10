using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltoBasso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // Per generare casuali 
            const int MAX_TENTATIVI = 5; // Massimo tentativi disponibili 
            int ns, t; // ns => Numero Segreto | t => Tentativo 
            int cnt; // Contatore tentativi 

            ns = rnd.Next(1, 101); // Genero un valore compreso tra 1 e 100
            cnt = 0; 
            do
            {
                do
                {
                    Console.Write("Inserisci tentativo: ");
                }
                while (!int.TryParse(Console.ReadLine(), out t));
                cnt++;
                if (t == ns)
                {
                    Console.WriteLine("HAI VINTO IN " + cnt.ToString() 
                                    + " TENTATIVI!");
                }
                else
                {
                    if (t > ns)
                        Console.WriteLine("ALTO");
                    else
                        Console.WriteLine("BASSO");
                }
            }
            while (t != ns && cnt < MAX_TENTATIVI);
           
            if (cnt >= MAX_TENTATIVI)
                Console.WriteLine("Tentativi esauriti: HAI PERSO!");

            Console.WriteLine("Programma terminato...");
            Console.ReadKey();
        }
    }
}
