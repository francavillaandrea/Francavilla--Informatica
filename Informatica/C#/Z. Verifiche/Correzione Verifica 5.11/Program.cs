using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Compito3B_INF
{
    class Program
    {
        //INSERIRE COGNOME NOME e CLASSE
        static void Main(string[] args)
        {
            Console.WriteLine("Compito in classe di Informatica");
            Console.WriteLine("Francavilla Andrea 3^B Inf");
            int[] a = { 5, 7, 3, 6 };
            int[] b = { 2, 3, 2, 4 }; 

            esercizio1(a, b);
            int[] d = { 5, 5, 7, 7, 7, 3, 3, 6, 6, 6, 6 };
            esercizio2(d);

            Console.ReadKey();
        }

        private static void esercizio1(int[] v ,int[] x) // P.F
        {
            int d = 0;	
	        int[] c = new int[d];
            int cont = 0;
            for (int i = 0; i < x.Length; i++)
            {
                d += x[i];
            }
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i]; j++)
                    c[cont++] = v[i];
            }
            stampaVettore("stampa del vettore c: ", c);
        }
        private static void esercizio2(int[] a)
        {
            int cont = 0;
            int j = 0;
            int i = 0;
            int[] b = new int[10];
            int[] c = new int[10];
            for (i = 0;i<a.Length;i++)
            {
                if (a[i] == a[i+1])
                    cont++;
                else
                {
                    b[j] = a[i];
                    c[j++] = cont;
                    cont = 1;
                }
            }
            b[j] = a[i];
            c[j++] = cont;
            stampaVettore("Stampa vettore risultato a > ", a);
            stampaVettore("Stampa vettore risultato b > ", b);
            stampaVettore("Stampa vettore risultato c > ", c);
            Console.ReadKey();

        }
        private static void stampaVettore(string msg, int[] v)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i].ToString() + " ");
            Console.WriteLine();
        }
    }
}
