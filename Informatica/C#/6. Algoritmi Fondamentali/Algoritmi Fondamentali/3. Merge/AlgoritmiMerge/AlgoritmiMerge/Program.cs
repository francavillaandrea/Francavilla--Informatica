using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a, b;
            int n, m; // Lunghezza array 

            do
            {
                Console.Write("Inserisci lunghezza vettore A > ");
            } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));

            do
            {
                Console.Write("Inserisci lunghezza vettore B > ");
            } while (!int.TryParse(Console.ReadLine(), out m) || (m <= 0));

            a = new int[n];
            b = new int[m];

            ClsVettori.caricaVettRndOrdNoRip(a);
            ClsVettori.caricaVettRndOrdNoRip(b);
            ClsVettori.stampaVett(a, "Vettore A ordinato senza ripetizioni");
            ClsVettori.stampaVett(b, "Vettore B ordinato senza ripetizioni");
            ClsVettori.merge(a, b);
            Console.ReadKey();
            int[] aa = new int[] { 23, 34, 56, 89, 90, 95 };
            int[] bb = new int[] { 12, 31, 36, 58, 88};
            ClsVettori.stampaVett(aa, "Vettore A ordinato senza ripetizioni");
            ClsVettori.stampaVett(bb, "Vettore B ordinato senza ripetizioni");
            ClsVettori.mergeTappo(aa, bb);
            Console.ReadKey();
        }
    }
}
