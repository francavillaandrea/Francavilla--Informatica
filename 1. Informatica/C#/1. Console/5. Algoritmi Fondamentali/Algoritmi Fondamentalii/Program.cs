using System;

namespace Algoritmi_Fondamentalii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scelta;
            do
            {
                scelta = Menu.menù();
                switch (scelta)
                {
                    case "A":
                        do
                        {
                            Menu.menùRic();
                            Console.ReadKey();
                            switch (scelta)
                            {
                                case "A":
                                    Console.Clear();
                                    Console.WriteLine("Linsime di ricerca è disordinato e senza ripetizioni");
                                    AlgoritmiFond.ricSeq1();
                                    break;
                                case "B":
                                    Console.Clear();
                                    Console.WriteLine("Linsime di ricerca è disordinato e con ripetizioni");
                                    AlgoritmiFond.ricSeq2();
                                    break;
                                case "C":
                                    Console.Clear();
                                    Console.WriteLine("Linsime di ricerca è ordinato e senza ripetizioni");
                                    AlgoritmiFond.ricSeq3();
                                    break;
                                case "D":
                                    Console.Clear();
                                    Console.WriteLine("Linsime di ricerca è ordinato e con ripetizioni");
                                    AlgoritmiFond.ricSeq4();
                                    break;
                                case "E":
                                    Console.Clear();
                                    Console.WriteLine("Linsieme di ricerca è ordinato e senza ripetizioni");
                                    AlgoritmiFond.ricBin();
                                    break;
                                case "Q":
                                    Console.WriteLine("Arrivederci");
                                    break;
                            }
                        } while(scelta == "Q");
                        break;
                    case "B":
                        do
                        {
                            Menu.menùOrd();
                            switch (scelta)
                            {
                                case "A":
                                    Console.Clear();
                                    AlgoritmiFond.SelSort();
                                    break;
                                case "B":
                                    Console.Clear();
                                    AlgoritmiFond.BubSort();
                                    break;
                                case "Q":
                                    Console.WriteLine("Arrivederci");
                                    break;
                            }

                        } while (scelta == "Q");

                        break;
                    case "C":
                        do
                        {
                            Menu.menùMerge();
                            switch (scelta)
                            {
                                case "A":
                                    Console.Clear();
                                    AlgoritmiFond.mergeNoTappo();
                                    break;
                                case "B":
                                    Console.Clear();
                                    AlgoritmiFond.mergeTappo();
                                    break;
                                case "Q":
                                    Console.WriteLine("Arrivederci");
                                    break;
                            }
                        } while (scelta == "Q");
                        break;
                    case "Q":
                        Console.WriteLine("Arrivederci");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            } while (scelta == "Q");


        }

    }
}
