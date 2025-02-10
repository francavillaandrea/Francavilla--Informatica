using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_09122024
{
    
    class ClsFrancavilla
    {
        static Random rnd = new Random();
        internal static void ordina(string[] v)//PF
        {
            int n = v.Length;
            int posmin;
            string aus;
            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = (i + 1); j <= n - 1; j++)
                {

                    if (v[posmin].CompareTo(v[j]) > 0)
                        posmin = j;
                }
                if (posmin != i)
                {
                    aus = v[i];
                    v[i] = v[posmin];
                    v[posmin] = aus;
                }
            }
        }

        internal static void stampaVettore(string[] piloti, string[] scuderie)
        {
            Console.ResetColor();
            for (int i = 0; i < piloti.Length; i++)
            {
                Console.Write(piloti[i] + " ");
                Console.WriteLine(scuderie[i]);
            }



        }

        internal static void visualizzaPiloti(string[] piloti, string[] scuderie)
        {
            Console.Write("Inserisci la scuderia di cui vuoi sapere i piloti ");
            string x = Console.ReadLine();
            int i = 0;
            bool trovato = false;
            bool superato = false;
            while (!superato || i < scuderie.Length - 1)
            {
                if (scuderie[i] == x)
                {
                    Console.Write("Scuderia trovato in pos." + i.ToString());
                    trovato = true;
                    Console.WriteLine(piloti[i]);
                    i++;
                    
                }
                else
                {
                    if (scuderie[i].CompareTo(x) > 0)
                        superato = true;
                    else
                        i++;
                }
            }
            if (!trovato)
                Console.WriteLine("Scuderia non trovata");
        }

        internal static void Gara(string[] scuderie, string[] piloti)
        {
           
           for (int i = 1; i<10;i++)
            {
                int Classifica = rnd.Next(0, piloti.Length);
                int[] val = new int[10];
                val[i] = Classifica;
                Console.WriteLine(i.ToString() + "°>" + piloti[Classifica] + "          " + scuderie[Classifica]);
            }
        }

        internal static void nPiloti(string[] scuderie, string[] piloti)
        {
            int cont = 0;
            for (int i = 0; i < scuderie.Length - 1; i++)
            {
                cont++;
                if (scuderie[i] != scuderie[i + 1])
                {
                    Console.WriteLine(scuderie[i] + " " + cont.ToString());
                    cont = 0;

                }
            }
            cont++;
            Console.WriteLine(scuderie[scuderie.Length - 1] + " " + cont.ToString());

        }
    }
}

