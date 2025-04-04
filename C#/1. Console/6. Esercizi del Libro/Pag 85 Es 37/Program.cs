using System;

class Program
{
    static Random rnd = new Random();
    static void Main()
    {
        int righe = 3;
        int colonne = 4;
        int[,] matrice = CaricaCasuale(righe, colonne);
        StampaMatrice(matrice);
        TuttoUguale(matrice, righe, colonne);
        Console.ReadKey();
    }

    static int[,] CaricaCasuale(int righe, int colonne)
    {

        int[,] matrice = new int[righe, colonne];

        for (int i = 0; i < righe; i++)
        {
            for (int j = 0; j < colonne; j++)
            {
                matrice[i, j] = rnd.Next(0, 2); // Valori casuali tra 0 e 1
            }
        }

        return matrice;
    }

    static void StampaMatrice(int[,] matrice)
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

    static void TuttoUguale(int[,] matrice, int righe, int colonne)
    {
        bool esci = false;
        int x = matrice[0, 0];
        int i = 0, j = 1;
        while (!esci && i <= righe - 1)
        {
            if (matrice[i, j] == x)
            {
                if (j == colonne - 1)
                {
                    i++;
                    j = 0;
                }
                else
                    j++;
            }
            else
                esci = true;
        }
        if(!esci)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Matrice uguale");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Matrice diversa");
            Console.ResetColor();
        }

    }
}
