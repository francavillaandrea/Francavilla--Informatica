using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace Ricorsiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Inserisci n >");

            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            bool continua = true;
            while (continua)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Fattoriale Iterativo ");
                Console.WriteLine("2. Fattoriale Ricorsivo ");
                Console.WriteLine("3. Prodotto Iterativo ");
                Console.WriteLine("4. Prodotto Ricorsivo ");
                Console.WriteLine("5. Fibonacci");
                Console.WriteLine("30. Esci");
                Console.Write("\nScegli un'opzione: ");
                int scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine(Fatt_Iterativo(n).ToString());
                        break;
                    case 2:
                        Console.WriteLine(Fatt_Ricorsivo(n).ToString());
                        break;
                    case 3:
                        int a, b;
                        do
                        {
                            Console.Write("Inserisci a >");

                        } while (!int.TryParse(Console.ReadLine(), out a) || a < 0);
                        do
                        {
                            Console.Write("Inserisci b >");

                        } while (!int.TryParse(Console.ReadLine(), out b) || b < 0);
                        Console.WriteLine(prodotto_Iterativo(a, b).ToString());
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Inserisci a >");

                        } while (!int.TryParse(Console.ReadLine(), out a) || a < 0);
                        do
                        {
                            Console.Write("Inserisci b >");

                        } while (!int.TryParse(Console.ReadLine(), out b) || b < 0);
                        Console.WriteLine(prodotto_Ricorsivo(a, b).ToString());
                        break;
                    case 5:
                        int m = 0;
                        do
                        {
                            Console.Write("Inserisci m >");

                        } while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);
                        Console.WriteLine(Fibonacci(n).ToString());
                        break;
                    case 30:
                        continua = false;
                        break;
                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break;
                }
            }
        }

        private static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return (Fibonacci(n - 1) + Fibonacci((n - 2)));
        }

        private static int prodotto_Ricorsivo(int a, int b)
        {
            if (b == 0)
                return 0;
            else
                return a + (prodotto_Ricorsivo(a, b - 1));
        }

        private static int prodotto_Iterativo(int a, int b)
        {
            int somma = 0;
            for (int i = 0; i <= b; i++)
                somma += a;
            return somma;
        }

        private static int Fatt_Ricorsivo(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * Fatt_Ricorsivo(n - 1));
        }

        private static int Fatt_Iterativo(int n)
        {
            int prodotto = 1;
            for (int i = 1; i <= n; i++)
            {
                prodotto *= i;
            }
            return prodotto;
        }
    }
}

