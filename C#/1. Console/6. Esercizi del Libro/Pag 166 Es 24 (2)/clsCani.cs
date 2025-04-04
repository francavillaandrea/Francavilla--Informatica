using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace n24pag116
{
    class clsCani
    {
        internal static void stampaElenco(string[] cani, string[] razze)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CANI".PadRight(20) + "RAZZE");
            Console.ResetColor();
            for (int i = 0; i < cani.Length; i++)
                Console.WriteLine(cani[i].PadRight(20)
                    + razze[i]);
        }

        internal static void ordinaCani(string[] cani)
        {
            //selection sort pag.103
            int posmin = 0;
            for (int i = 0; i <= cani.Length - 2; i++)
            {
                posmin = i;
                for (int j = (i + 1); j <= cani.Length - 1; j++)
                {
                    if (cani[posmin].CompareTo(cani[j]) > 0)
                    {
                        string aus = cani[posmin];
                        cani[posmin] = cani[j];
                        cani[j] = aus;

                    }
                }
            }


        }
        internal static void ordinaRazze(string[] razze)
        {
            //selection sort pag.103
            int posmin = 0;
            for (int i = 0; i < razze.Length - 1; i++)
            {
                posmin = i;
                for (int j = (i + 1); j < razze.Length; j++)
                {
                    if (razze[posmin].CompareTo(razze[j]) > 0)
                    {
                        string aus = razze[posmin];
                        razze[posmin] = razze[j];
                        razze[j] = aus;
                    }
                }
            }
        }

        internal static void ricercaBinaria(string[] cani,string cane)
        {
            int sup = 0;
            int inf = cani.Length - 1;
            int metà = 0;
            do
            {
                metà = (inf + sup) / 2;
                if (cani[metà] != cane)
                {
                    if (cani[metà].CompareTo(cane) > 0)
                        inf = metà - 1;
                    else
                        sup = metà + 1;

                }
            } while (cani[metà] != cane && sup <= inf);
            if (cani[metà] == cane)
                Console.WriteLine("Cognome trovato in pos." + metà.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }



        internal static void ContaCaniRazza(string[] razze, string razza)
        {
            //ric. seq. su insieme ordinato con ripetizioni pag.94
            int cont=0;
            for(int i = 0; i < razze.Length; i++)
            {
                if (razze[i]== razza)
                {
                    cont++;
                }
            }
            Console.WriteLine("La razza "+ razza.ToString()+ " si ripete "+ cont.ToString()+ " volte.");
        }

        internal static void contaCaniPerOgniRazza(string[] razze)
        {
            //contare il numero di canni per ogni razza
            int cont = 0;
            for(int i = 0; i < razze.Length-1;i++)
            {
                cont++;
                if (razze[i] != razze[i + 1])
                {
                    Console.WriteLine(razze[i] + " " + cont.ToString());
                    cont = 0;

                }   
            }
            cont ++;
            Console.WriteLine(razze[razze.Length-1] + " " + cont.ToString());


        }

        internal static void cercaRazzaConPiùCani(string[] razze)
        {
            //contare il numero di canni per ogni razza
            int cont = 0;
            int max = int.MinValue;
            int k = 0;
            for (int i = 0; i < razze.Length - 1; i++)
            {
                cont++;
                if (razze[i] != razze[i + 1])
                {
                    if (cont > max)
                    {
                        max = cont;
                        k = i;
                    }
                    cont = 0;

                }
            }
            cont++;
            Console.WriteLine(razze[k] + max.ToString());

        }
    }
}
