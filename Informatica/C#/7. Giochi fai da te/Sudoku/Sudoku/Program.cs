using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] s = {{8,4,5,1,2,0,7,3,9},
                        {7,0,9,5,0,4,0,6,2 },
                        {3,0,2,9,8,7,0,5,4 },
                        {0,3,6,0,0,5,2,8,0 },
                        {4,8,1,6,9,2,0,7,3 },
                        {0,5,7,3,1,8,4,9,6 },
                        {1,7,0,2,6,0,3,4,5 },
                        {5,9,3,7,4,1,6,0,8 },
                        {6,0,4,8,5,0,9,1,0 }};
            int zeri = contaZeri(s);
            stampaSudoku(s);
            Console.WriteLine();
            Console.ReadKey();
            risolviSudoku(s, zeri);
            Console.WriteLine("SUDOKU RISOLTO!!!");
            Console.ReadKey();
        }

        private static void risolviSudoku(int[,] s, int zeri)
        {
            int i = 0, j = 0;
            int n;  //numero da inserire in pos i,j
            do
            {
                cercaZero(s, ref i, ref j);
                //se ritorna 0 vuol dire che nella riga
                //ci sono più scelte
                n = controllaRiga(s, i);
                if (n == 0)
                {
                    //se ritorna 0 vuol dire che nella colonna
                    //ci sono più scelte
                    n = controllaColonna(s, i, j);
                    if (n == 0)
                    {
                        //se ritorna 0 vuol dire che nella quadrato
                        //3 x 3 ci sono più scelte
                       n = controllaQuadrato(s, i, j);
                    }
                }
                if (n != 0)
                {
                    s[i, j] = n;
                    zeri--;
                    stampaSudoku(s);
                    Console.WriteLine();
                    Console.ReadKey();
                }
            } while (zeri != 0);
        }

        private static int controllaQuadrato(int[,] s, int i, int j)
        {
            int n = 0;
            int cont = 0;
            int somma = 0;

            for (int k = 0; k < 9; k++)
            {
                somma += s[i, j];
                if (s[i, j] == 0)
                    cont++;
            }

            if (cont == 1) //ho trovato solo 1 zero, quello in pos i,j 
                //devo trovare il numero che manca
                n = 45 - somma;
            return n;
        }

        private static int controllaColonna(int[,] s, int i, int j )
        {
            int n = 0;
            int cont = 0;
            int somma = 0;

            for (int k = 0; k < 9; k++)
            {
                somma += s[i, j];
                if (s[i, j] == 0)
                    cont++;
            }

            if (cont == 1) //ho trovato solo 1 zero, quello in pos i,j 
                //devo trovare il numero che manca
                n = 45 - somma;
            return n;
        }

        private static int controllaRiga(int[,] s, int i)
        {
            int n = 0;
            int cont = 0;
            int somma = 0;

            for (int j = 0; j < 9; j++)
            {
                somma += s[i, j];
                if (s[i, j] == 0)
                    cont++;
            }

            if (cont == 1) //ho trovato solo 1 zero, quello in pos i,j 
                //devo trovare il numero che manca
                n = 45 - somma;
            return n;
        }

        private static void cercaZero(int[,] s, ref int i, ref int j)
        {
            //ritorna le coordinate dello 0 trovato
            bool esci = false;

            while (!esci && i <= 8)
            {
                if (s[i, j] == 0)
                    esci = true;
                else
                {
                    if (j == 8)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
        }

        private static int contaZeri(int[,] s)
        {
            int cont = 0;
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (s[i, j] == 0)
                        cont++;
            return cont;
        }

        static void stampaSudoku(int[,] s)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(s[i, j].ToString().PadRight(2));
                Console.WriteLine();
            }
        }
    }
}
