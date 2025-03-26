using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneScrutinio
{
    public class ClsScrutinio
    {
        static Random rnd = new Random();
        public static void caricaVoti(int[,] voti)
        {
            for (int i = 0; i < voti.GetLength(0); i++)
                for (int j = 0; j < voti.GetLength(1); j++)
                    voti[i, j] = rnd.Next(4, 11);
        }

        public static void visualizzaScrutinio(string[] cognomi, string[] materie, int[,] voti)
        {
            double somma;
            int cntIns;
            string matIns;
            double[] medieMat = new double[materie.Length];

            creaIntestazione(materie);

            for (int i = 0; i < voti.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(cognomi[i].PadRight(20));
                Console.ResetColor();
                somma = 0; // 
                cntIns = 0;
                matIns = "";
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    somma += voti[i, j]; // Sommatoria voti 
                    if (voti[i, j] < 6)
                    {
                        cntIns++;
                        matIns += materie[j] + " ";
                    }

                    if (voti[i, j] < 5)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (voti[i, j] >= 6)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(voti[i, j].ToString().PadRight(10));
                }
                // Calcolo e coloro media 
                if ((somma / materie.Length) < 5.5)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if ((somma / materie.Length) >= 6)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;
                // Stampo Media 
                Console.Write((somma / materie.Length).ToString("F2").PadRight(10));
                // Calcolo e stampo esito
                if (cntIns > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("BOCCIATO".PadRight(15));
                }
                else if (cntIns == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("PROMOSSO".PadRight(15));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("RIMANDATO".PadRight(15));
                }
                // Fine stampa esito 
                // Stampa elenco materie da riparare 
                if (cntIns <= 3)
                    Console.Write(matIns.PadRight(30));
                // Fine stampa elenco materie da riparare 
                Console.ResetColor();
                Console.WriteLine();
                disegnaLinea(130);
            }
        }

        private static void creaIntestazione(string[] materie)
        {
            // Intestazione 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ALUNNA/O".PadRight(20));
            for (int i = 0; i < materie.Length; i++)
                Console.Write(materie[i].PadRight(10));

            Console.Write("MEDIA".PadRight(10)); // MEDIA
            Console.Write("ESITO".PadRight(15)); // ESITO (AMMESSO, BOCCIATO, RIMANDATO)
            Console.Write("MATERIE DA RIPARARE".PadRight(30));
            Console.WriteLine();
            Console.ResetColor();
            disegnaLinea(130);
            // Fine intestazione 
        }

        private static void disegnaLinea(int n)
        {
            Console.WriteLine("-".PadRight(n, '-'));
        }
    }
}
