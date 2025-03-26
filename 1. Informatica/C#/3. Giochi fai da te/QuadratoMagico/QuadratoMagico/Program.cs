using System;

namespace QuadratoMagico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] qm = new int[,]
            {
                { 2, 7, 6 },
                { 9, 5, 1 },
                { 4, 3, 8 },
            };
            stampaMatrice(qm, "QUADRATO MAGICO");
            if (magico(qm))
                Console.WriteLine("Il quadrato è magico");
            else
                Console.WriteLine("Il quadrato non è magico");
            Console.ReadKey();
        }

        private static bool magico(int[,] qm)
        {
            bool magic = true;
            int x = sommaDP(qm);
            if (x != sommaDS(qm))
                magic = false;
            else
            {
                if (!controllaRighe(qm, x))
                    magic = false;
                else
                {
                    if (!controllaColonne(qm, x))
                        magic = false;
                }
            }
            return magic;
        }

        private static bool controllaRighe(int[,] m, int x)
        {
            int i = 0;
            bool magic = true;
            do
            {
                if(sommaRiga(m, i) != x)
                    magic = false; 
                else
                    i++;
                
            } while (i != 3 && !magic);
            return true;
        }

        private static bool controllaColonne(int[,] m, int x)
        {
            int j = 0;
            bool magic = true;
            do
            {
                if (sommaColonna(m, j) != x)
                    magic = false;
                else
                    j++;

            } while (j != 3 && !magic);
            return true;
        }

        private static int sommaRiga(int[,] m, int i)
        {
            int somma = 0;
            for (int j = 0; j < m.GetLength(1); j++)
                somma += m[i, j];
            return somma;
        }
        private static int sommaColonna(int[,] m, int j)
        {
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j];
            return somma;
        }
        private static int sommaDS(int[,] m)
        {
            int somma = 0;
            int j = m.GetLength(0) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j--];
            return somma;
        }

        private static int sommaDP(int[,] m)
        {
            int somma = 0;

            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, i];
            return somma;
        }

        private static void stampaMatrice(int[,] m, string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j].ToString().PadRight(3));
                Console.WriteLine();
            }
        }
    }
}
