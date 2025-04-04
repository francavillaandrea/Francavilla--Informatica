using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MenuVettori3B
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int scelta;
            int[] a;
            int[] b;
            int n;
            
            do
            {
                Console.Clear();
                scelta = disegnaMenu();
                Console.ResetColor();

                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Fine programma");
                        break;
                    case 1:
                        Console.WriteLine("Media di un vettore");
                        n = inserisciInputIntero("Inserisci lunghezza vettore ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        Console.WriteLine("La media vale: " + calcolaMedia(a).ToString("f2"));
                        break;
                    case 2:
                        Console.WriteLine("Cerca MAX di un vettore");
                        n = inserisciInputIntero("Inserisci lunghezza vettore ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 100 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        Console.WriteLine("Il massimo è" + cercaMax(a).ToString());
                        break;
                    case 3:
                        Console.WriteLine("Prodotto scalare");
                        n = inserisciInputIntero("Inserisci lunghezza dei vettori ", 1);
                        a = new int[n];
                        b = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        caricaVettoreCasuale(b, "Caricamento casuale del vettore b:", 1, 10 + 1);
                        stampaVettore(b, "Stampa vettore b: ");
                        Console.WriteLine(prodottoScalare(a, b).ToString());
                        break;
                    case 4:
                        Console.WriteLine("Prodotto vettoriale");
                        n = inserisciInputIntero("Inserisci lunghezza dei vettori ", 1);
                        a = new int[n];
                        b = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        caricaVettoreCasuale(b, "Caricamento casuale del vettore b:", 1, 10 + 1);
                        stampaVettore(b, "Stampa vettore b: ");
                        prodottoVettoriale(a, b);
                        break;
                    case 5:
                        Console.WriteLine("Inverti vettore");
                        n = inserisciInputIntero("Inserisci lunghezza dei vettori ", 1);
                        a = new int[n];
                        b = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        invertiAinB(a, b);
                        stampaVettore(b, "Stampa vettore b: ");
                        break;
                    case 6:
                        Console.WriteLine("Inserti vettore su stesso");
                        Console.WriteLine("Inverti vettore");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        invertivettorestesso(a);
                        stampaVettore(a, "Stampa vettore a: ");
                        break;
                    case 7:
                        Console.WriteLine("Cerca il valore massimo e il valore minimo di un vettore");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        Console.WriteLine("Il massimo è: " + cercaMax(a));
                        Console.WriteLine("Il minimo è: " + cercaMin(a));
                        break;
                    case 8:
                        Console.WriteLine("Verifica se il vettore è ordinato in modo crescente");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        //a = new int[] { 10, 7, 9, 11}; //caricamento statico del vettore 
                        stampaVettore(a, "Stampa vettore a: ");
                        if (verificaOrdineCrescente(a))
                        {
                            Console.WriteLine("Il vettore è ordinato in modo crescente");
                        }
                        else
                        {
                            Console.WriteLine("Il vettore non è ordinato in ordine crescente");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Conta OCCORENZE di x");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        int x = inserisciInputIntero("Inserisci il valore da cercare: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        Console.WriteLine(x.ToString() + " compare " + contaOccorenze(x, a).ToString() + " volte");
                        stampaVettore(a, "Stampa vettore a: ");
                        break;
                    case 10:
                        Console.WriteLine("Contare positivi e negativi in vettore");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", -10, 10 + 1);
                        contaPoseNeg(a);
                        stampaVettore(a, "Stampa vettore a: ");
                        break;
                    case 11:
                        Console.WriteLine("Verifica elementi tutti uguali in un vettore");
                        n = inserisciInputIntero("Inserisci lunghezza del vettore a ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a:", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        if (verificaUguali(a))
                        {
                            Console.WriteLine("Gli elementi sono tutti uguali");
                        }
                        else
                        {
                            Console.WriteLine("Gli elementi non sono tutti uguali");
                        }
                        break;
                    case 12:
                        Console.WriteLine("Compara medie");
                        n = inserisciInputIntero("Inserisci la lughezza dei vettori a e b", 1);
                        a = new int[n];
                        b = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        caricaVettoreCasuale(b, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(b, "Stampa vettore a: ");
                        if (calcolaMedia(a) == calcolaMedia(b))
                        {
                            Console.WriteLine("Le medie sono uguali");
                        }
                        else
                            Console.WriteLine("Le medie sono diverse");
                        break;
                    case 13:
                        Console.WriteLine("Vettori speculari");
                        n = inserisciInputIntero("Inserisci la lughezza dei vettori a: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        speculari(a);
                        break;
                    case 14:
                        Console.WriteLine("Copiare elementi");
                        n = inserisciInputIntero("Inserisci la lughezza dei vettori a e b", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        b = new int[n];
                        caricaVettoreCasuale(b, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(b, "Stampa vettore a: ");
                        famoloStrano(a, b);
                        break;
                    case 15:
                        Console.WriteLine("Copia valori Pari in testa e i Dispari in coda");
                        n = inserisciInputIntero("Inserisci la lughezza dei vettori a: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        caricaPDTC(a);
                        break;
                    case 16:
                        Console.WriteLine("Copia valori Pari e Dispari in e nuovi vettori PARI e DISPARI");
                        n = inserisciInputIntero("Inserisci la lughezza del vettori a: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        creaVettoriPariDispari(a);
                        break;
                    case 17:
                        Console.WriteLine("Cerca i primi 3 MAX del vettore senza ripetizioni");
                        n = inserisciInputIntero("Inserisci la lughezza del vettori a: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 1000);
                        stampaVettore(a, "Stampa vettore a: ");
                        cercaPrimi3Max(a);
                        break;
                    case 18:
                        Console.WriteLine("Cerca i primi 3 MAX del vettore con ripetizioni");
                        n = inserisciInputIntero("Inserisci la lughezza del vettori a: ", 1);
                        a = new int[n];
                        caricaVettoreCasuale(a, "Caricamento casuale del vettore a: ", 1, 10 + 1);
                        stampaVettore(a, "Stampa vettore a: ");
                        cercaPrimi3MaxConRipetizioni(a);
                        break;
                    case 19:
                        Console.WriteLine("Caricare un vettore manualmente ordinato crescente");
                        n = inserisciInputIntero("Inserisci la lughezza del vettore a: ", 1);
                        a = new int[n];
                        caricaVettoreManualeOrdinato(a, "Caricamento manuale ordinato crescente del vettore a: ", 1, 100 + 1);
                        stampaVettore(a, "Stampa vettore a ordinato crescente: ");
                        break;
                    case 20:
                        Console.WriteLine("Caricare un vettore manualmente ordinato crescente");
                        n = inserisciInputIntero("Inserisci la lughezza del vettore a: ", 1);
                        a = new int[n];
                        caricaVettoreManualeOrdinatoBis(a, "Caricamento manuale ordinato crescente del vettore a: ", 1, 100 + 1);
                        stampaVettore(a, "Stampa vettore a ordinato crescente: ");
                        break;
                    case 21:
                        Console.WriteLine("Caricare un vettore manualmente ordinato crescente");
                        n = inserisciInputIntero("Inserisci la lughezza del vettore a: ", 1);
                        a = new int[n];
                        caricaVettoreCasualeOrdinato(a, "Caricamento casuale ordinato crescente del vettore a: ", 1, 100 + 1);
                        stampaVettore(a, "Stampa vettore a ordinato crescente: ");
                        break;
                    case 22:
                        Console.WriteLine("Caricare un vettore casualmente con valori diversi");
                        n = inserisciInputIntero("Inserisci la lughezza del vettore a: ", 1);
                        a = new int[n];
                        caricaVettoreCasualeElementiDiversi(a, "Caricamento di un vettore casuale con valori diversi ", 1, 100 + 1);
                        stampaVettore(a, "Stampa vettore a con valori tutti diversi: ");
                        break;
                    case 23:
                        es1();
                        break;
                    case 24:
                        es2();
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Premi un tasto per continuare...");
                Console.ReadKey();
                Console.ResetColor();
            } while (scelta != 0);
        }

        private static void es2()
        {
            int[] a = { 3, 3, 1, 1, 1, 1, 8, 8 };
            int[] b = new int[10]; 
            int[] c = new int[10];
            int cnt = 1;
            int j = 0;
            int i; 
            for( i=0; i<a.Length-1; i++)
            {
                if (a[i] == a[i+1])
                {
                    cnt++; 
                }
                else
                {
                    b[j] = a[i];
                    c[j++] = cnt;
                    cnt = 1; 
                }
            }
            b[j] = a[i];
            c[j++] = cnt;
            stampaVettore(a, "A"); 
            stampaVettore(b, "B"); 
            stampaVettore(c, "C"); 
        }

        private static void es1()
        {
            int[] a = { 5, 2, 3, 4 };
            int[] b = { 4, 3, 2, 1 };
            int[] c;
            int somma = 0; 
            int h = 0;
            for (int i = 0; i < a.Length; i++)
                somma += a[i];
            
            c = new int[somma]; 

            for(int i=0; i<a.Length; i++)
            {
                for(int j=0; j < a[i]; j++)
                {
                    c[h++] = b[i]; 
                }
            }
            stampaVettore(c, "Risultato"); 
        }

        private static void caricaVettoreCasualeElementiDiversi(int[] v, string msg, int min, int max) //P.F.
        {
            Console.WriteLine(msg);
        }

        private static void caricaVettoreCasualeOrdinato(int[] v, string msg, int min, int max)
        {
            Console.WriteLine(msg);
            v[0] = random.Next(min, max);
            for (int i = 1; i < v.Length; i++)
                v[i] = random.Next(v[i - 1], max);
        }

        private static void caricaVettoreManualeOrdinatoBis(int[] v, string msg, int min, int max)
        {
            Console.WriteLine(msg);
            v[0] = inserisciInputIntero("Inserisci elemento pos.0: ", 1);
            for (int i = 1; i < v.Length; i++)
                v[i] = inserisciInputIntero("Inserisci elemento pos." + i.ToString() + ": ", v[i - 1]);
        }
        private static void caricaVettoreManualeOrdinato(int[] v, string msg, int min, int max)
        {
            Console.WriteLine(msg);
            v[0] = inserisciInputIntero("Inserisci elemento pos.0: ", 1);
            for (int i = 1; i < v.Length; i++)
                do
                {
                    v[i] = inserisciInputIntero("Inserisci elemento pos." + i.ToString() + ": ", 1);
                } 
                while (v[i] < v[i-1]);
        }
        private static void cercaPrimi3MaxConRipetizioni(int[] v)
        {
            int p = 0, s = 0, t = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] != p && v[i] != s && v[i] != t)
                {
                    if (v[i] > p)
                    {
                        t = s;
                        s = p;
                        p = v[i];
                    }
                    else
                    {
                        if (v[i] > s)
                        {
                            t = s;
                            s = v[i];
                        }
                        else
                        {
                            if (v[i] > t)
                                t = v[i];
                        }

                    }
                }
            }//fine for
            Console.WriteLine("Primo: " + p.ToString());
            Console.WriteLine("Secondo: " + s.ToString());
            Console.WriteLine("Terzo: " + t.ToString());
        }

        private static void cercaPrimi3Max(int[] v)
        {
            int p = 0, s = 0, t = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if(v[i]>p)
                {
                    t = s;
                    s = p;
                    p = v[i];
                }
                else
                {
                    if(v[i]>s)
                    {
                        t = s;
                        s = v[i];
                    }
                    else
                    {
                        if (v[i] > t)
                            t = v[i];
                    }
                }
            }//fine for
            Console.WriteLine("Primo: " + p.ToString());
            Console.WriteLine("Secondo: " + s.ToString());
            Console.WriteLine("Terzo: " + t.ToString());
        }

        private static void creaVettoriPariDispari(int[] v)
        {
            int[] pari = new int[v.Length];
            int[] dispari = new int[v.Length];
            int ip = 0;
            int id = 0;

            for (int i = 0; i < v.Length; i++)
                if (v[i] % 2 == 0)
                    pari[ip++] = v[i];
                else
                    dispari[id++] = v[i];
            stampaVettore(pari, "Stampa vettore dei pari");
            stampaVettore(dispari, "Stampa vettore dei dispari");
        }

        private static void caricaPDTC(int[] v)
        {
            int ip = 0;
            int id = v.Length - 1;
            int[] b=new int[v.Length];
            for (int i=0; i<v.Length;i++)
                if (v[i]%2 == 0)
                    b[ip++] = v[i];
                else
                    b[id--] = v[i];
            stampaVettore(b, "Vettore risultante: ");

        }

        private static void famoloStrano(int[] a, int[] b)
        {
            int[] c= new int [a.Length];
            int cont = 0;
            for (int i = 0;i<a.Length; i++)
            {
                if(a[i] == b[i])
                {
                    c[cont] = a[i];
                    cont++;
                }
            }
            stampaVettore(c,"Stampa del vettore c");
          }

        private static int disegnaMenu() // funzione perchè restituisce un intero
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("MENU");
            Console.WriteLine("");
            Console.WriteLine("1: Media di un vettore");
            Console.WriteLine("2: Cerca MAX di un vettore");
            Console.WriteLine("3: Prodotto scalare");
            Console.WriteLine("4: Prodotto vettoriale");
            Console.WriteLine("5: Inverti vettore");
            Console.WriteLine("6: Inverti vettore su stesso");
            Console.WriteLine("7: Cerca il valore massimo e il valore minimo di un vettore");
            Console.WriteLine("8: Verifica se il vettore è ordinato in modo crescente");
            Console.WriteLine("9: Contare OCCORRENZE di x in vettore ");
            Console.WriteLine("10: Contare positivi e negativi in vettore");
            Console.WriteLine("11: Verifica elementi tutti uguali in un vettore");
            Console.WriteLine("12: Compara medie");
            Console.WriteLine("13: Vettori speculati");
            Console.WriteLine("14: Copiare in un vettore c gli elementi uguali e nella stessa posizione nei vettori A e B");
            Console.WriteLine("15: Copiare in un vettore in testa gli elementi pari e in coda gli elementi dispari");
            Console.WriteLine("16: Copiare in 2 vettori PARI e DISPARI i valori di un vettore");
            Console.WriteLine("17: Cercare i primi 3 VALORI MAX in un vettore senza ripetizioni");
            Console.WriteLine("18: Cercare i primi 3 VALORI MAX in un vettore con ripetizioni");
            Console.WriteLine("19: Caricare un vettore manualmente ORDINATO CRESCENTE");
            Console.WriteLine("20: Caricare un vettore manualmente ORDINATO CRESCENTE_SOLO_FOR");
            Console.WriteLine("21: Caricare un vettore casualmente ORDINATO CRESCENTE");
            Console.WriteLine("22: Caricare un vettore casualmente TUTTI VALORI DIVERSI");
            Console.WriteLine("23: Es1 Compito in classe");
            Console.WriteLine("24: Es2 Compito in classe");
            Console.WriteLine("0: ESCI");

            return inserisciInputIntero("Fai la tua scelta > ", 0);


        }

        private static int inserisciInputIntero(string msg, int min)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            int n;
            do
            {
                Console.Write(msg);
            } while (!int.TryParse(Console.ReadLine(), out n) || n < min);

            Console.ResetColor();
            return n;
        }

        private static void stampaVettore(int[] v, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(msg);

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + "  ");
            }

            Console.ResetColor();
            Console.WriteLine();
        }

        private static void caricaVettoreCasuale(int[] v, string msg, int min, int max)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);

            for (int i = 0; i < v.Length; i++)
            {
                v[i] = random.Next(min, max);
            }

            Console.ResetColor();
        }

        private static void caricaVettoreManuale(int[] v, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            for (int i = 0; i < v.Length; i++)
            {

                v[i] = inserisciInputIntero("Inserisci elemento pos. " + i.ToString() + " : ", 1);
            }

            Console.ResetColor();
        }

        private static double calcolaMedia(int[] v)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            double somma = 0;

            for (int i = 0; i < v.Length; i++)
            {
                somma += v[i];
            }

            Console.ResetColor();
            return somma / v.Length;
        }

        private static int cercaMax(int[] v)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int max = v[0];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > max)
                    max = v[i];
            }
            Console.ResetColor();
            return max;
        }

        private static int cercaMin(int[] v)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int min = v[0];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                    min = v[i];
            }
            Console.ResetColor();
            return min;
        }

        private static string prodottoScalare(int[] a, int[] b)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            int ps = 0;
            string s = "PS=";
            for (int i = 0; i < a.Length; i++)
            {
                ps = ps + (a[i] * b[i]);
                if (i == a.Length - 1)
                    s = s + "(" + a[i].ToString() + "*" + b[i].ToString() + ")=";
                else
                    s = s + "(" + a[i].ToString() + "*" + b[i].ToString() + ")+";
            }
            s += ps.ToString();
            Console.ResetColor();
            return s;
        }


        private static void prodottoVettoriale(int[] a, int[] b)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i] * b[i];
            }

            stampaVettore(c, "Stampa vettore c: ");

            Console.ResetColor();
        }

        private static bool verificaOrdineCrescente(int[] a)
        {
            int i = 0;

            while (a[i] <= a[i + 1] && i != a.Length - 2)
                i++;

            if (i == a.Length - 2)
                return true;
            else
                return false;
        }

        private static void invertivettorestesso(int[] v)
        {
            int temp;
            for (int i = 0; i < v.Length / 2; i++)
            {
                temp = v[i];
                v[i] = v[v.Length - 1 - i];
                v[v.Length - 1 - i] = temp;
            }
        }

        private static void invertiAinB(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - 1 - i] = a[i];
            }
        }

        private static int contaOccorenze(int x, int[] v)
        {
            int cont = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] == x)
                {
                    cont++;
                }


            }
            return cont;
        }

        private static void contaPoseNeg(int[] v)
        {
            int pcont = 0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] >= 0)
                {
                    pcont++;
                }
            }
            Console.WriteLine("Positivi: " + pcont.ToString());
            Console.WriteLine("Negativi: " + (v.Length - pcont).ToString());
        }

        private static bool verificaUguali(int[] v)
        {
            int i = 1;

            while (v[0] == v[i] && i != v.Length - 1)
            {
                i++;
            }
            if (i == v.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void speculari(int[] v)
        {
            int pal
                   = 0;
            for (int i = 0; i < v.Length / 2; i++)
            {
                if (v[i] == v[v.Length - 1 - i])
                {
                    pal++;
                }

            }
            if (pal == v.Length / 2)
            {
                Console.WriteLine("L'array è speculare");
            }
            else
            {
                Console.WriteLine("L'array non è speculare");
            }


        }
    }
}
