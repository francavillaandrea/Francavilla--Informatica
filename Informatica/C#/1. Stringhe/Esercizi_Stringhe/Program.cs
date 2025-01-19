using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
                switch(scelta.ToUpper())
                {
                    case "A":
                        // Contare il numero di vocali presenti in una stringa 
                        // ricevuta in ingresso
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();
                        totVocaliS1 = contaVocaliTris(s1);
                        Console.WriteLine("Totale delle vocali di '" + s1 + "' " +
                            "è " + totVocaliS1.ToString()); 
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
                            Console.WriteLine("'" + s1 + "' contiene più vocali di '" + s2 + "'");
                        else if (totVocaliS1 < totVocaliS2)
                            Console.WriteLine("'" + s2 + "' contiene più vocali di " + s1 + "'");
                        else
                            Console.WriteLine("'" + s1 + "' contiene lo stesso numero di " +
                                "vocali di '" + s2 + "'");
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
                        //s1.CompareTo(s2)
                        // 0 se s1 = s2 
                        // <0 se s1 alfabeticamente più piccola di s2 
                        // >0 se s1 alfabeticamente più grande di s2 
                        Console.WriteLine(ordinaStringa(s1));
                        Console.WriteLine(ordinaStringa(s2));
                        Console.WriteLine(ordinaStringa(s3));
                        break;
                    case "D":
                        // Invertire il contenuto di una stringa s1 copiando il 
                        // contenuto all'interno di una stringa s2 
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Stringa invertita > " + invertiStringa(s1));
                        break;
                    case "E":
                        // s1 = "34204"
                        // out= "3334444224444"
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();
                        Console.WriteLine("Conversione > " + convertiSNumerico(s1));
                        break;

                    case "J":
                        // Cancellare i caratteri corrispondenti alle vocali
                        // che compaiono in una stringa in input
                        Console.Write("Inserisci stringa > ");
                        s1 = Console.ReadLine();

                        Console.WriteLine("Stringa senza vocali > " + rimuoviVocali(s1)); 
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

        private static string rimuoviVocali(string s)
        {
            string vocali = "AaEeIiOoUu";
            string ret = "";

            for(int i=0; i<s.Length; i++)
            {
                if (!vocali.Contains(s[i]))
                    ret = ret + s[i]; 
            }
            return ret;
        }

        private static string convertiSNumerico(string s)
        {
            // s = "34204"
            // out= "3334444224444"
            string ret = "";
            int numero; // salvo la conversione numerica del carattere 

            for(int i=0; i<s.Length; i++)
            {
                // IsDigit(char) => Analizza il carattere e restituisce false 
                // se numerico 
                if (char.IsDigit(s[i]))
                {
                    // Tolgo 48 o '0' (vedi tabella ASCII) 
                    numero = Convert.ToInt32(s[i] - 48); // -'0');
                    for (int j = 0; j < numero; j++)
                        ret = ret + numero.ToString(); 
                }
            }
            return ret; 
        }

        private static string invertiStringa(string s)
        {
            string s2 = "";
            // s1 = "CIAO" Len: 4 (indici: 0-3) 
            // s2 = "OAIC"
            for (int i = s.Length - 1; i >= 0; i--)
                s2 = s2 + s[i]; 
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

            for(int i=0; i<s.Length; i++)
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
            Console.WriteLine("F. Es 66 pag. 86???");
            Console.WriteLine("G. Es 67 pag. 86");
            Console.WriteLine("H. Es 68 pag. 86");
            Console.WriteLine("I. Es 69 pag. 86");
            Console.WriteLine("J. Es 70 pag. 86");
            Console.WriteLine("Q. Esci");
            Console.Write("Scelta > ");
           // sc = Console.ReadLine();
            return Console.ReadLine();
        }
    }
}
