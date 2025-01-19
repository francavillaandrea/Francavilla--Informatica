using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forza_4
{
    class Program
    {
        const int RIGHE = 6;
        const int COLONNE = 7;
        static char[,] tabellone = new char[RIGHE, COLONNE];
        static bool turnoGiocatore = true; // True per Rosso, False per Giallo

        static void Main(string[] args)
        {
            InizializzaTabellone();

            while (true)
            {
                MostraTabellone();
                int colonna = ScegliColonna();
                if (!InserisciGettone(colonna))
                {
                    Console.WriteLine("Colonna piena. Riprova.");
                    continue;
                }

                if (ControllaVittoria())
                {
                    MostraTabellone();
                    Console.WriteLine("Il giocatore " + (turnoGiocatore ? "Rosso" : "Giallo") + " ha vinto!");
                    break;
                }

                if (TabellonePieno())
                {
                    MostraTabellone();
                    Console.WriteLine("Pareggio!");
                    break;
                }

                turnoGiocatore = !turnoGiocatore;
            }
        }

        static void InizializzaTabellone()
        {
            for (int i = 0; i < RIGHE; i++)
                for (int j = 0; j < COLONNE; j++)
                    tabellone[i, j] = '?';
        }

        static void MostraTabellone()
        {
            Console.Clear();
            Console.WriteLine(string.Join(" ", new string[COLONNE].Select((_, i) => (i + 1).ToString()).ToArray()));
            Console.WriteLine(new string('-', COLONNE * 2));

            for (int i = 0; i < RIGHE; i++)
            {
                for (int j = 0; j < COLONNE; j++)
                {
                    Console.ForegroundColor = tabellone[i, j] == 'R' ? ConsoleColor.Red : (tabellone[i, j] == 'G' ? ConsoleColor.Yellow : ConsoleColor.Gray);
                    Console.Write(tabellone[i, j] + " ");
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        static int ScegliColonna()
        {
            int colonna;
            while (true)
            {
                Console.Write("Scegli una colonna (1-7): ");
                if (int.TryParse(Console.ReadLine(), out colonna) && colonna >= 1 && colonna <= COLONNE)
                    return colonna - 1;
                Console.WriteLine("Input non valido. Riprova.");
            }
        }

        static bool InserisciGettone(int colonna)
        {
            for (int i = RIGHE - 1; i >= 0; i--)
            {
                if (tabellone[i, colonna] == '?')
                {
                    tabellone[i, colonna] = turnoGiocatore ? 'R' : 'G';
                    return true;
                }
            }
            return false;
        }

        static bool ControllaVittoria()
        {
            for (int i = 0; i < RIGHE; i++)
                for (int j = 0; j < COLONNE; j++)
                    if (tabellone[i, j] != '?' &&
                        (ControllaDirezione(i, j, 0, 1) || ControllaDirezione(i, j, 1, 0) || ControllaDirezione(i, j, 1, 1) || ControllaDirezione(i, j, 1, -1)))
                        return true;
            return false;
        }

        static bool ControllaDirezione(int riga, int colonna, int dRiga, int dColonna)
        {
            char iniziale = tabellone[riga, colonna];
            for (int i = 1; i < 4; i++)
            {
                int nuovaRiga = riga + i * dRiga;
                int nuovaColonna = colonna + i * dColonna;
                if (nuovaRiga < 0 || nuovaRiga >= RIGHE || nuovaColonna < 0 || nuovaColonna >= COLONNE || tabellone[nuovaRiga, nuovaColonna] != iniziale)
                    return false;
            }
            return true;
        }

        static bool TabellonePieno()
        {
            for (int j = 0; j < COLONNE; j++)
                if (tabellone[0, j] == '?')
                    return false;
            return true;
        }
    }
}

