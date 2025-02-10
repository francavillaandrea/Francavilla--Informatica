using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tris_3B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] tris = new char[3, 3];

            inizializzaTris(tris);
            gioca(tris);
            Console.ReadLine();
        }

        private static void gioca(char[,] tris)
        {
            //'X' per primo giocatore (true)
            //'O' per secondo giocatore
            int i, j;
            bool achitocca = true;
            int cont = 9;
            char vincitore = ' ';

            do
            {
                Console.Clear();
                visualizzaTris(tris);
                // input utente
                do
                {
                    //input cordinate
                    do
                        Console.Write("Inserisci i: ");
                    while (!int.TryParse(Console.ReadLine(), out i) || i < 0 || i > 3);
                    do
                        Console.Write("Inserisci j: ");
                    while (!int.TryParse(Console.ReadLine(), out j) || j < 0 || j > 3);
                    //fine input coordinate
                }
                while (tris[i, j] != '-');
                cont--;
                //controlo casella non occupata
                if (achitocca)
                {
                    tris[i, j] = 'X';
                    achitocca = false;
                    vincitore = vittoria(tris, 'X');
                }
                else
                {
                    tris[i, j] = 'O';
                    achitocca = true;
                    vincitore = vittoria(tris, 'O');
                }
                Console.Clear();
                visualizzaTris(tris);
                //ritorna '0' se non ho vincitore
                //ritorna 'X' o 'O' se ho vincitore
                if (vincitore == 'X' || vincitore == 'O')
                {
                    Console.WriteLine("Hai vinto!!!");
                    cont = 0;
                }

                Console.ReadKey();
            } while (cont != 0 && vincitore != '0');
            //fine gioco
            if (vincitore != 'X' && vincitore != 'O')
                Console.WriteLine("Patta");
        }

        private static char vittoria(char[,] t, char ch)
        {
            if ((t[0, 0] == ch && t[0, 1] == ch && t[0, 2] == ch) ||
                    (t[1, 0] == ch && t[1, 1] == ch && t[1, 2] == ch) ||
                    (t[2, 0] == ch && t[2, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 0] == ch && t[2, 0] == ch) ||
                    (t[0, 1] == ch && t[1, 1] == ch && t[2, 1] == ch) ||
                    (t[0, 2] == ch && t[1, 2] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 2] == ch && t[1, 1] == ch && t[2, 0] == ch))
                return ch;
            else
                return ' ';
        }

        private static void inizializzaTris(char[,] tris)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    tris[i, j] = '-';
        }

        private static void visualizzaTris(char[,] tris)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tris[i, j] == 'X')
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                    {
                        if (tris[i, j] == 'O')
                            Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(tris[i, j].ToString().PadRight(2));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}
