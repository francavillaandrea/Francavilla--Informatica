using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmi_Fondamentalii
{
    internal class AlgoritmiFond
    {
        internal static void BubSort()
        {
            string[] v = {
            "Rossi", "Bianchi", "Verdi", "Russo", "Gallo",
            "Costa", "Conti", "Giordano", "Ferrari", "Esposito",
            "Bruno", "Ricci", "Marini", "Lombardi", "Barbieri",
            "Moretti", "Fabbri", "De Luca", "Grassi", "Orlando"
        };
            int n = v.Length;
            int i = -1;
            string aus; // Per gestione scambi 
            bool scambio;
            do
            {

                i++;
                scambio = false;
                for (int j = n - 2; j >= i; j--)
                {
                    if (v[j].CompareTo(v[j + 1]) > 0)
                    {
                        aus = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = aus;
                    }
                }
            } while (i != n - 2 && scambio);
        }

        internal static void SelSort()
        {
            string[] v = {
            "Rossi", "Bianchi", "Verdi", "Russo", "Gallo",
            "Costa", "Conti", "Giordano", "Ferrari", "Esposito",
            "Bruno", "Ricci", "Marini", "Lombardi", "Barbieri",
            "Moretti", "Fabbri", "De Luca", "Grassi", "Orlando"
        };
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


        internal static void mergeNoTappo()
        {
            throw new NotImplementedException();
        }

        internal static void mergeTappo()
        {
            throw new NotImplementedException();
        }

        internal static void ricBin()
        {
            string[] v = new string[] { "Barbieri", "Bertolini", "Bianchi", "Caruso", "Conti", "Coppola", "Costa", "Corsi", "De Luca", "D'Angelo", "Esposito", "Fabbri", "Ferrari",
                                "Gallo", "Giordano", "Lombardi", "Leone", "Mancini", "Migliorini","Mariani", "Martini", "Moretti", "Napolitano", "Pellegrini", "Perri",
                                "Ricci", "Romano", "Russo", "Rossi", "Santoro", "Vitali"};
            stampaVettore("Ricerca binaria su insieme ORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int sup = 0;
            int inf = v.Length - 1;
            int metà;

            do
            {
                metà = (inf + sup) / 2;
                if (v[metà] != x)
                {
                    if (v[metà].CompareTo(x) > 0)
                        inf = metà - 1;
                    else
                        sup = metà + 1;
                }
            }
            while (v[metà] != x && sup <= inf);
            if (v[metà] == x)
                Console.WriteLine("Cognome trovato in pos." + metà.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }

        internal static void ricSeq1()
        {
            string[] v = new string[] { "Rossi", "Gallo", "Devirgilio", "Melandri", "Fabbri", "Chiera" };
            stampaVettore("Ricerca seq. su insieme DISORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            while (v[i] != x && i != v.Length - 1)
                i++;
            if (v[i] == x)
                Console.WriteLine("Cognome trovato in pos." + i.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }

        internal static void ricSeq2()
        {
            string[] v = new string[] { "Rossi", "Gallo", "Devirgilio", "Gallo", "Rossi", "Chiera" };
            stampaVettore("Ricerca seq. su insieme DISORDINATO e CON DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            bool trovato = false;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == x)
                    Console.WriteLine("Cognome trovato in pos." + i.ToString());
            }
            if (!trovato)
                Console.WriteLine("Cogome non trovato");
        }

        internal static void ricSeq3()
        {
            string[] v = new string[] { "Bianchi", "DevirgilioGallo", "Fabbri", "Gallo", "Melandri", "Varese" };
            stampaVettore("Ricerca seq. su insieme ORDINATO e SENZA DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            while (v[i].CompareTo(x) < 0 && i != v.Length - 1)//bisogna usare .CompareTo per confrontare 2 stringhe se non sono == o !=
                i++;
            if (v[i] == x)
                Console.WriteLine("Cognome trovato in pos." + i.ToString());
            else
                Console.WriteLine("Cognome non trovato");
        }

        internal static void ricSeq4()
        {
            string[] v = new string[] { "Barbero", "Chiera", "Chiera", "Chiera", "Fabri", "Vaschetta" };
            stampaVettore("Ricerca seq. su insieme ORDINATO e CON DUPLICATI", v);
            Console.Write("Inserisci il cognome da cercare: ");
            string x = Console.ReadLine();

            int i = 0;
            bool trovato = false;
            bool superato = false;
            while (!superato && i <= v.Length - 1)
            {
                if (v[i] == x)
                {
                    Console.WriteLine("Cognome trovato in pos." + i.ToString());
                    trovato = true;
                    i++;
                }
                else
                {
                    if (v[i].CompareTo(x) > 0) //v[i]>x
                        superato = true;
                    else
                        i++;
                }
                if (!trovato)
                    Console.WriteLine("cognome non trovato");
            }
        }

        internal static void stampaVettore(string msg, string[] v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < v.Length; i++)
                Console.WriteLine(v[i]);
        }

        internal static void quickSort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);

            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;

        }
    }
}

