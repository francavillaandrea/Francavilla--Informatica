using System;
using System.Security.AccessControl;

class Program
{
    static Random rnd = new Random();
    static void Main(string [] args)
    {
        int righe = 3;
        int[,] matrice = CaricaCasuale(righe);
        stampaMatrice(matrice);
        Console.WriteLine(MatriceUnitaria(matrice) ? "La matrice è unitaria." : "La matrice non è unitaria.");
        Console.ReadKey();



        for (int i = 0; i < 999; i++)
            Main(args);
    }

    private static void stampaMatrice(int[,] matrice)
    {
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                Console.Write(matrice[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] CaricaCasuale(int righe)
    {

        int[,] matrice = new int[righe, righe];

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < righe; j++)
            {
                matrice[i, j] = rnd.Next(0, 2);
            }
        }

        return matrice;
    }
    static bool MatriceUnitaria(int[,] matrice)
    {
        int righe = matrice.GetLength(0);
        int colonne = matrice.GetLength(1);

        if (righe != colonne) return false;

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                if (i == j && matrice[i, j] != 1) 
                    return false; 
                if (i != j && matrice[i, j] != 0) 
                    return false; 
            }
        }
        return true;
    }
}
