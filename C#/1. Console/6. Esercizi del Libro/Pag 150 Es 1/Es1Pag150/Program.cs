using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n1pag150_Turni
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string[] studenti = { "Barberis", "Bedreag", "Cambieri", "Cane", "Casalis", "Cebotari", "Dellaferrera", "Ferrero", "Francavilla", "Gatto", "Genta", "Ingaramo", "Manunta", "Marciuc", "Milojkov", "Monte", "Oricco", "Ressia", "Revello", "Riso", "Roveta", "Salinitri", "Ufe" };
            //estratti viene inzizializzato a False in automatico
            //se False --> studente da estrarre
            //se True --> studente già estratto
            bool[] estratti = new bool[studenti.Length];
            int n;//numero studenti per turno
            do
                Console.Write("Quanti studenti per turno? ");
            while (!int.TryParse(Console.ReadLine(), out n) ||
            n < 3 | n > 5);
            int turni = studenti.Length / n; //numero di turni completi
            int estratto; //posizione dello studente estratto in estratti

            //ciclo for per ogni turno completo
            for (int i = 1; i <= turni; i++)
            {
                Console.Write("TURNO N." + i.ToString() + ": ");
                //ciclo for per ogni studente del turno completo (n)
                for (int j = 1; j <= n; j++)
                {
                    //estraggo uno studente
                    do
                        estratto = rnd.Next(0, studenti.Length);
                    while (estratti[estratto]);
                    estratti[estratto] = true;
                    Console.Write(studenti[estratto] + " ");
                }
                Console.WriteLine();
            }
            if (studenti.Length % n != 0) //ho un turno aggiuntivo
            {
                Console.Write("TURNO N." + (turni + 1).ToString() + ": ");
                for (int i = 0; i < studenti.Length; i++)
                    if (!estratti[i])
                        Console.Write(studenti[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
