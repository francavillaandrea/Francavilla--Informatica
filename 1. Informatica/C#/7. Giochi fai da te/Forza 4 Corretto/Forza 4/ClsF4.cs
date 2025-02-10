using System;

namespace Forza_4
{
    internal class ClsF4
    {
        internal static bool controllaVittoria(char[,] campo, int i, int j,
                                             char giocatoreCorrente)
        {
            bool vittoria = false;
            int pos_i = i, pos_j = j;
            int cnt = 0;

            // Controllo VERTICALE 
            while (i < campo.GetLength(0) && campo[i, j] == giocatoreCorrente)
            {
                cnt++;
                i++;
            }
            if (cnt == 4)
                vittoria = true;
            else
            { // Controllo ORIZZONTALE 
                cnt = 0;
                i = pos_i;
                j = pos_j;

                // conta destra 
                while (j < campo.GetLength(1) && campo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    j++;
                }
                j = pos_j - 1;
                // conta sinistra 
                while (j >= 0 && campo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    j--;
                }
                if (cnt >= 4)
                    vittoria = true;
                else
                { // Controllo DIAGONALE
                    // Diagonale principale 
                    cnt = 0;
                    i = pos_i; j = pos_j;
                    // in basso a dx 
                    while (j < campo.GetLength(1) && i < campo.GetLength(0)
                                        && campo[i, j] == giocatoreCorrente)
                    {
                        i++;
                        j++;
                        cnt++;
                    }
                    i = pos_i - 1;
                    j = pos_j - 1;
                    while (j >= 0 && i >= 0
                                && campo[i, j] == giocatoreCorrente)
                    {
                        i--;
                        j--;
                        cnt++;
                    }
                    if (cnt >= 4)
                        vittoria = true;
                    else
                    {  // Diagonale secondaria
                        cnt = 0;
                        i = pos_i; j = pos_j;
                        while (j >= 0 && i < campo.GetLength(0)
                                            && campo[i, j] == giocatoreCorrente)
                        {
                            i++;
                            j--;
                            cnt++;
                        }
                        i = pos_i - 1;
                        j = pos_j + 1;
                        while (j < campo.GetLength(1) && i >= 0
                                    && campo[i, j] == giocatoreCorrente)
                        {
                            i--;
                            j++;
                            cnt++;
                        }
                        if (cnt >= 4)
                            vittoria = true;
                    }
                }
            }
            return vittoria;
        }

        internal static void inizializzaCampo(char[,] campo)
        {
            for (int i = 0; i < campo.GetLength(0); i++)
            {
                for (int j = 0; j < campo.GetLength(1); j++)
                    campo[i, j] = '.';
            }
        }

        internal static void mostraCampo(char[,] campo)
        {
            Console.Clear();

            // Stampo la parte superiore del bordo 
            Console.WriteLine("  -".PadRight(29, '-'));

            for (int i = 0; i < campo.GetLength(0); i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < campo.GetLength(1); j++)
                {
                    if (campo[i, j] == 'X')
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (campo[i, j] == 'O')
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write(campo[i, j]);
                    Console.ResetColor();
                    Console.Write(" | ");
                }
                Console.WriteLine();
                Console.WriteLine("  -".PadRight(29, '-')); // linea separazione tra righe
            }
        }

        internal static int posizionaGettone(char[,] campo, char giocatoreCorrente,
                                            int colonna)
        {
            int i = campo.GetLength(0) - 1;

            while (campo[i, colonna] != '.') // i >= 0: so già che c'è spazio per il gettone
                i--;

            campo[i, colonna] = giocatoreCorrente;
            return i;  // Restituisco indice riga su cui è stato posizionato il gett.
        }

        internal static bool verificaCampo(char[,] campo)
        {
            int j = 0;

            while (j < campo.GetLength(1) && campo[0, j] == '.')
                j++;
            return j < campo.GetLength(1);
        }
    }
}
