using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VettoriInizio3B
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int n; //numero di elementi del vettore

            n = inserisciIntero("Inserisci la lunghezza del vettore: ", 1);
            int[] a = new int[n]; //vettore di n posizioni
            int[] b = new int[n];

            //caricaVettoreManuale("Caricamento manuale del vettore a: ", a); //richiamo del metodo con parametro attuale
            caricaVettoreCasuale("Caricamento casuale del vettore a", a); //P.A.
            stampaVettore("Stampa del vettore a: ", a); //P. ATTUALI
            caricaVettoreCasuale("Caricamento casuale del vettore b", b); //P.A.
            stampaVettore("Stampa del vettore b: ", b); //P. ATTUALI
            //calcolaMedia(a); //P.A.
            //cercaMax(a); //P.A.
            prodottoScalare(a, b); //P.A.
            Console.ReadKey();
        }

        private static void prodottoScalare(int[] a, int[] b)
        {
            int ps = 0;
            string s = "PS=";
            for (int i = 0; i < a.Length; i++)
            {
                ps = ps + (a[i] * b[i]);
                if (i == a.Length - 1)
                    s = s + "("+a[i].ToString() + "*" + b[i].ToString() + ")=";
                else
                    s = s + "("+a[i].ToString() + "*" + b[i].ToString() + ")+";
            }
            Console.WriteLine(s + ps.ToString());
        }

        private static void caricaVettoreCasuale(string msg, int[] v) //P.F.
        {
            //caricamento casuale del vettore
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(1, 10);
        }

        private static void cercaMax(int[] v) //P.F.
        {
            int max = v[0];

            for (int i = 1; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            Console.WriteLine("Il massimo è " + max.ToString());
        }

        private static void calcolaMedia(int[] v) //P.F.
        {
            double somma = 0;

            for (int i = 0; i < v.Length; i++)
                somma += v[i];
            Console.WriteLine("La media vale " + (somma / v.Length).ToString());
        }

        private static void stampaVettore(string msg, int[] v) //P. FORMALI
        {
            //visualizzo contenuto vettore
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
                Console.Write(v[i].ToString() + " ");
            Console.WriteLine();
        }

        private static void caricaVettoreManuale(string msg, int[] v) //firma del metodo con il parametro formale
        {
            //caricamento del vettore
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
                v[i] = inserisciIntero("Inserisci elemento pos." + i.ToString() +
                    " : ", 1);
        }

        // Parametri FORMALI string msg(messaggio da stampare), int min(valore minimo accettato)
        private static int inserisciIntero(string msg, int min) //FIRMA DI UN METODO
        {
            int n; // Variabile LOCALE
            do
                Console.Write(msg);
            while (!int.TryParse(Console.ReadLine(), out n) || n < min);
            return n;
        }
    }
}
