using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Francavilla_Recupero_Trimestre
{
    internal class ClsRecupero
    {
        internal static void ordinaProvincia(string[] cittadini, string[] province, char[] sesso) //PF
        {
            int n = cittadini.Length;
            int posmin;
            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = (i + 1); j <= n - 1; j++)
                {

                    if (cittadini[posmin].CompareTo(cittadini[j]) > 0)
                        posmin = j;
                }
                if (posmin != i)
                {


                    string aus = cittadini[i];
                    cittadini[i] = cittadini[posmin];
                    cittadini[posmin] = aus;

                    aus = province[i];
                    province[i] = province[posmin];
                    province[posmin] = aus;

                    char AUS = sesso[i];
                    sesso[i] = sesso[posmin];
                    sesso[posmin] = AUS;

                }
            }
        }

        private static void scambioC(char[] sesso, ref int posmin, ref int i)
        {
            char aus = sesso[i];
            sesso[i] = sesso[posmin];
            sesso[posmin] = aus;
        }

        private static void scambio(string[] v, ref int posmin, ref int i)
        {
            string aus = v[i];
            v[i] = v[posmin];
            v[posmin] = aus;
        }

        internal static void stampaVettori(string[] cittadini, string[] province, char[] sesso)
        {
            for (int i = 0; i < cittadini.Length; i++)
            {
                Console.Write(cittadini[i].ToString().PadRight(15));
                Console.Write(province[i].ToString().PadRight(15));
                Console.WriteLine(sesso[i].ToString().PadRight(15));

            }
        }
        internal static void contaNProvincia(string[] province)
        {
            Console.Write("Inserisci la provincia da cercare: ");
            string x = Console.ReadLine().ToUpper();
            int cont = 0;
            int i = 0;
            bool trovato = false;
            bool superato = false;
            while (!superato && i <= province.Length - 1)
            {
                if (province[i] == x)
                {
                    Console.WriteLine("Provincia trovata in pos." + i.ToString());
                    trovato = true;
                    i++;
                    cont++;
                }
                else
                {
                    if (province[i].CompareTo(x) > 0) //v[i]>x
                        superato = true;
                    else
                        i++;
                }
                if (!trovato)
                    Console.WriteLine("Provincia non trovata");
               
            }
            Console.WriteLine("La provincia " + x + " ha " + cont.ToString() + " abitanti");
        }

        internal static void contaFProvincia(string[] province, char[] sesso)
        {
            Console.Write("Inserisci la provincia da cercare: ");
            string x = Console.ReadLine().ToUpper();
            int cont = 0;
            int i = 0;
            bool trovato = false;
            bool superato = false;
            while (!superato && i <= province.Length - 1)
            {
                if (province[i] == x)
                {
                    Console.WriteLine("Provincia trovata in pos." + i.ToString());
                    trovato = true;
                    i++;
                    if (sesso[i] == 'F')
                    {

                    }
                }
                else
                {
                    if (province[i].CompareTo(x) > 0) //v[i]>x
                        superato = true;
                    else
                        i++;
                }
                if (!trovato)
                    Console.WriteLine("Provincia non trovata");

            }
            Console.WriteLine("La provincia " + x + " ha " + cont.ToString() + " abitanti");
        }
    }

}


