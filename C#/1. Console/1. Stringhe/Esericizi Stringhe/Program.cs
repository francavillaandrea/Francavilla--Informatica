using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Esercizi_Stringhe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string scelta; // Gestione menù
            string s1, s2, s3;
            int totVocaliS1, totVocaliS2;

            do
            {
                scelta = visualizzaMenu();
                Console.Clear();
                switch (scelta.ToUpper())
                {
                    case "A":
                        // Contare il numero di vocali presenti in una stringa 
                        // ricevuta in ingresso
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();
                        totVocaliS1 = contaVocaliTris(s1);
                        Console.WriteLine("Stringa senza vocali " + s1 + totVocaliS1.ToString());
                        break;
                    case "B":
                        // Verificare quale delle due string in input 
                        // contiene il maggior numero di vocali 
                        Console.Write("Inserisci stringa 1 > ");
                        s1 = Console.ReadLine();
                        Console.Write("Inserisci stringa 2 > ");
                        s2 = Console.ReadLine();
                        totVocaliS1 = contaVocali(s1);
                        totVocaliS2 = contaVocali(s2);

                        if (totVocaliS1 > totVocaliS2)
                            Console.WriteLine("Stringa senza vocali " + s1 + s2 + "'");
                        else if (totVocaliS1 < totVocaliS2)
                            Console.WriteLine("'" + s2 + "' contiene più vocali di " + s1 + "'");
                        else
                            Console.WriteLine("Stringa senza vocali " + s1 + s2 + "'");
                        break;
                    case "C":
                        // ordinare alfabeticamente 3 stringhe in ordine crescente
                        // visualizzando il risultato dell'ordinamento 
                        Console.Write("Inserisci stringa 1 > ");
                        s1 = Console.ReadLine();
                        Console.Write("Inserisci stringa 2 > ");
                        s2 = Console.ReadLine();
                        Console.Write("Inserisci stringa 3 > ");
                        s3 = Console.ReadLine();
                        //if (s1.CompareTo(s2) < 0 && s1.CompareTo(s3) < 0)
                        //    Console.WriteLine(s1); 
                        //else
                        //{
                        //    if (s1.CompareTo(s2) > 0 && s2.CompareTo(s3) > 0)
                        //        Console.WriteLine(s2);
                        //    if (s1.CompareTo(s3) > 0)
                        //    {
                        //        Console.WriteLine(s3);
                        //        Console.WriteLine(s1);
                        //    }
                        //    // continua... 
                        //}
                        Console.WriteLine(ordinaStringa(s1));
                        Console.WriteLine(ordinaStringa(s2));
                        Console.WriteLine(ordinaStringa(s3));
                        break;
                    case "D":
                        Console.Write("Inserisci una stringa > ");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Stringa invertita > " + invertiStringa(s1));
                        break;
                    case "E":
                        Console.WriteLine("Inserisci stringa >");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Conversione > "+ convertiSNumerico(s1));
                        break;
                    case "F":
                        Console.WriteLine("Inserisci una stringa");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Stringa invertita " + invertiStringhe(s1));
                        break;
                    case "G":
                        Console.WriteLine("Inserisci una stringa");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Inserisci una stringa");
                        s2 = Console.ReadLine();
                        Console.WriteLine(contaRip(s1,s2));
                        break;
                    case "H":
                        Console.WriteLine("Inserisci una stringa");
                        s1 = Console.ReadLine();
                        Console.WriteLine(Raddoppia_Vocali(s1));
                        break;
                    case "I":
                        break;
                    case "J":
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Stringa senza vocali " + cancellaVocali(s1));
                        break;

                    case "Q":
                        Console.WriteLine("Arrivederci...");
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta.ToLower() != "q");
        }

        private static string Raddoppia_Vocali(string s1)
        {
            string ret = ""; 
            string vocali = "aeiouAEIOU"; 

            for (int i = 0; i < s1.Length; i++)
            {
                char s2 = s1[i];

                if (vocali.Contains(s2)) 
                {
                    ret += s2.ToString() + s2; 
                }
                else
                {
                    ret += s2; 
                }
            }

            return ret; 
        }


        private static string contaRip(string s1, string s2)
        {
            int j = 0;
            string ret = "";
            int cont=0;
            while(s1.IndexOf(s2, j) != -1) 
            {
                cont++;
                int oleg = s1.IndexOf(s2, j);
                j += s2.Length;
            }
            if (cont != 0)
                Console.WriteLine("La stringa s1 e presente "+ cont.ToString()+" volte");
            else
                Console.WriteLine("La stringa s1 non è presente nella stinga s2");
            return ret;
        }

        private static string invertiStringhe(string s1)
        {
           string ret = "";
            int j = s1.Length - 1;
           char [] v = s1.ToCharArray();
           for (int i = 0;i<s1.Length;i++)
           {
                v[i] = s1[j];
                j--;
           }
            stampaVettore(v,"Il vettore invertito è ");
            return ret;
        }

        private static string cancellaVocali(string s1)
        {
            string ret = " ";
            string vocali = "aeiouAEIOU";

            for (int i = 0; i < s1.Length; i++)
                if (!vocali.Contains(s1[i]))
                    ret = ret + s1[i];
            return ret;
        }

        private static object convertiSNumerico(string s1)
        {
            string ret = "";
            int numero;
            for (int i=0; i<s1.Length;i++)
            {
                if (char.IsDigit(s1[i]))
                {
                    numero = Convert.ToInt32(s1[i]-48);
                    for (int j = 0; j < numero; j++)
                        ret = ret + numero.ToString();
                }

            }
            return ret;
        }

        private static string invertiStringa(string s1)
        {
            string s2= " ";
            for (int i = s1.Length-1; i>=0; i--)
                s2 =s2 +s1[i];
            return s2;
        }

        private static string ordinaStringa(string s)
        {
            char[] vCaratteri = s.ToCharArray();
            string ret = "";
            Array.Sort(vCaratteri);

            for (int i = 0; i < vCaratteri.Length; i++)
                ret += vCaratteri[i];
            //return new string(vCaratteri); 
            return ret;
        }

        private static int contaVocali(string s)
        {
            int totV = 0; // Contatore vocali 

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i].ToString().ToLower())
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        totV++;
                        break;
                }
            }
            return totV;
        }
        private static int contaVocaliBis(string s)
        {
            int totV = 0; // Contatore vocali 

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].ToString().ToLower() == "a" ||
                    s[i].ToString().ToLower() == "e" ||
                    s[i].ToString().ToLower() == "i" ||
                    s[i].ToString().ToLower() == "o" ||
                    s[i].ToString().ToLower() == "u")
                    totV++;
            }
            return totV;
        }
        private static int contaVocaliTris(string s)
        {
            int totV = 0; // Contatore vocali 
            string vocali = "aeiouAEIOU";

            for (int i = 0; i < s.Length; i++)
                if (vocali.Contains(s[i]))
                    totV++;
            return totV;
        }

        private static string visualizzaMenu()
        {
            // string sc; 
            Console.Clear();
            Console.WriteLine("::: Esercizi stringhe :::");
            Console.WriteLine("A. Es 61 pag. 86");
            Console.WriteLine("B. Es 62 pag. 86");
            Console.WriteLine("C. Es 63 pag. 86");
            Console.WriteLine("D. Es 64 pag. 86");
            Console.WriteLine("E. Es 65 pag. 86");
            Console.WriteLine("F. Es 66 pag. 86");
            Console.WriteLine("G. Es 67 pag. 86");
            Console.WriteLine("H. Es 68 pag. 86");
            Console.WriteLine("I. Es 69 pag. 86");
            Console.WriteLine("J. Es 70 pag. 86");
            Console.WriteLine("Q. Esci");
            Console.Write("Scelta > ");
            // sc = Console.ReadLine();
            return Console.ReadLine();
        }
        private static void stampaVettore(char[] v, string msg)
        {
            Console.WriteLine(msg);

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "  ");
            }

            Console.WriteLine();
        }
    }
}
