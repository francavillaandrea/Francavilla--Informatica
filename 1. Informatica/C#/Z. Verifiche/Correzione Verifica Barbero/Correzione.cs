using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Verifica_Barbero
{
    internal class Correzione
    {
        internal static void Gara(string[] scuderie, string[] piloti)
        {
            throw new NotImplementedException();
        }

        internal static void nPiloti(string[] scuderie, string[] piloti)
        {
            throw new NotImplementedException();
        }

        internal static void ordina(string[] scuderie, string[] piloti)
        {
            int posmin = 0;
            for (int i = 0; i < scuderie.Length-2; i++)
            {
                posmin = i;
                for(int j = 0; j < piloti.Length-1;i++)
                {
                    if (scuderie[posmin].CompareTo(piloti[j]) > 0)
                        posmin = j;
                }
                if(posmin == i)
                {
                    scambio(scuderie, posmin, i);
                    scambio(piloti, posmin, i);
                }
            }
        }

        private static void scambio(string[] v, int posmin, int i)
        {
            string aus = v[posmin];
            v[i] = v[posmin];
            v[posmin] = aus;
        }

        internal static void stampaVettore(string[] piloti, string[] scuderie)
        {
            for (int i = 0; i < piloti.Length; i++)
            {
                Console.Write(piloti[i] + " ");
                Console.WriteLine(scuderie[i]);
            }
        }

        internal static void visualizzaPiloti(string[] piloti, string[] scuderie)
        {
            Console.Write("Inserisci la scuderia di cui vuoi sapere i piloti ---->  ");
            string x = Console.ReadLine();
            int i = 0;
            bool trovato = false;
            bool superato = false;
            while(!superato && i<(scuderie.Length-1))
            {
                if (scuderie[i] != x)
                {
                    if (scuderie[i].CompareTo(x) < 0)
                        i++;
                    else 
                        superato = true;
                }
                else
                {
                    trovato = true;
                    Console.WriteLine(piloti[i]);
                    i++;
                }
            }
            if (!superato)
                Console.WriteLine("Elemento non trovato");
        }
    }
}
