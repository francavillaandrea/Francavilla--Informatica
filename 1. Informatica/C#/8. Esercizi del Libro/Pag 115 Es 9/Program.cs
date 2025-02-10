using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n9pag115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studenti = { "Esempi", "Rossi", "Bianchi", "Verdi", 
                "Ferrari", "Esposito", "Ricci", "Conti", "Fontana", "Greco", 
                "Lombardi", "Barbieri", "Moretti", "Santoro", "Marino", 
                "Bruno", "Gallo", "Giordano", "Ferri", "Mancini" };
            string[] città = { "Roma", "Milano", "Napoli", "Torino", 
                "Palermo", "Firenze", "Bologna", "Genova", "Venezia", 
                "Verona", "Roma", "Napoli", "Firenze", "Bologna", 
                "Milano", "Palermo", "Genova", "Torino", "Verona", 
                "Venezia" };
            Console.Write("Inserisci la città: ");
            string city = Console.ReadLine();
            Console.WriteLine("Il numero di studenti della " +
                "città "+ city + " è: "+ 
                es1_CittàNonOrdinateConDuplicati(studenti, città, city).ToString());
            Console.ReadKey();
            ordina_città(studenti, città);
            Console.WriteLine("Il numero di studenti della " +
                "città " + city + " è: " +
                es2_CittàOrdinateConDuplicati(studenti, città, city).ToString());
            Console.ReadKey();
        }

        private static int es2_CittàOrdinateConDuplicati(string[] studenti, string[] città, string city)
        {
            int i = 0;
            bool superato = false;
            int n = città.Length;
            int cont = 0;

            while (!superato && i <= n - 1)
            {
                if(città[i]==city)
                {
                    cont++;
                    i++;
                }
                else
                {
                    if (città[i].CompareTo(city) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            return cont;
        }

        private static void ordina_città(string[] studenti, string[] città)
        {
            int posmin;
            int n = città.Length;

            for (int i = 0; i <= n-2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                    if (città[posmin].CompareTo(città[j]) > 0)
                        posmin = j;
                if (posmin != i)
                { //VETTORI PARALLELI!!!!
                    scambio(ref città[i], ref città[posmin]);
                    scambio(ref studenti[i], ref studenti[posmin]);
                }            
            }
        }

        private static void scambio(ref string s1, ref string s2)
        {
            string aus;

            aus = s1;
            s1 = s2;
            s2 = aus;     
        }

        private static int es1_CittàNonOrdinateConDuplicati(string[] studenti, string[] città, string city)
        {
            int cont = 0;

            for (int i = 0; i < città.Length; i++)
                if (città[i] == city)
                    cont++;
            return cont;
        }
    }
}
