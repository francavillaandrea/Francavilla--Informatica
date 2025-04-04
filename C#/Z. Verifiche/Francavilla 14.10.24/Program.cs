using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Francavilla_14._10._24
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int cont1 = 0, cont2=0, cont3=0, cont4=0, cont5=0;
            Console.WriteLine("Genero 100 valori casuali compresi tra 1 e 5 ");
            for (int i=0; i<100; i++)
            {
                int n = rnd.Next(1, 6);
                switch (n)
                {
                    case 1:
                        {
                            cont1++;
                            break;                           
                        }
                    case 2:
                        {
                            cont2++;   
                            break;
                        }
                    case 3:
                        {
                           cont3++;
                           break;
                        }
                    case 4:
                        {
                            cont4++;
                            break;
                        }
                    case 5:
                        {
                            cont5++;
                            break;
                        }
                }
            }
            Console.Write("1: ");
            n1(cont1);
            Console.Write("2: ");
            n2(cont2);
            Console.Write("3: ");
            n3(cont3);
            Console.Write("4: ");
            n4(cont4);
            Console.Write("5: ");
            n5(cont5);
            Console.ReadKey();
            // console.foreground color 
    }

        private static void n5(int cont5)
        {
            for (int i = 0; i < cont5; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        private static void n4(int cont4)
        {
            for (int i = 0; i < cont4; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        private static void n3(int cont3)
        {
            for (int i = 0; i < cont3; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        private static void n2(int cont2)
        {
            for (int i = 0; i < cont2; i++)
            {
                Console.Write("* ");

            }
            Console.WriteLine();
        }

        private static void n1(int cont1)
        {
            for (int i = 0; i < cont1; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
