using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_cicli_3B
{
    internal class Program
    {
        static bool stampa = true; //variabile GLOBALE
        static void Main(string[] args)
        {
            int scelta;

            do
            {
                disegnaMenu();
                do //input della scelta
                    Console.Write("Fai la tua scelta > ");
                while (!int.TryParse(Console.ReadLine(), out scelta));
                Console.Clear();
                switch (scelta)
                {
                    case 0:
                        Console.WriteLine("Fine programma...");
                        break;
                    case 1:
                        int max = ricercaMassimo();
                        Console.WriteLine("Il massimo è: " + max.ToString());
                        break;
                    case 2:
                        Console.WriteLine(calcolaFattoriale().ToString());
                        break;
                    case 3:
                        calcolaFattoriali();
                        break;
                    case 4: // Calcola MEDIA di n valori in input
                        Console.WriteLine("La media è: " + calcolaMedia().ToString());
                        break;
                    case 5:
                        convertiDECBIN();
                        break;
                    case 6:
                        convertBINDEC();
                        break;
                    case 7:
                        calcolaPotenza();
                        break;
                    case 8:
                        convertiDECHEX();
                        break;
                    case 9: //voglio confrontare 2 medie per vedere se il risultato è uguale
                        if (calcolaMedia() == calcolaMedia())
                            Console.WriteLine("Medie uguali");
                        else
                            Console.WriteLine("Medie diverse");
                        break;
                    case 10:
                        divisoriInteri();
                        break;
                    case 11:
                        numeroPerfetto();
                        break;
                    case 12:
                        numeriPerfetti();
                        break;
                    case 13:
                        numeroPrimo();
                        break;
                    case 14:
                        numeriPrimi();
                        break;
                    case 15:
                        Fibonacci();
                        break;
                    case 16:
                        n_simoFibonacci();
                        break;
                    case 17:
                        numeriTriangolari();
                        break;
                    case 18:
                        numeroDeficienteAbbondante();
                        break;
                    case 19:
                        numeriAmichevoli();
                        break;
                    case 20:
                        coppieAmichevoli();
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta != 0);
        }

        private static void coppieAmichevoli()
        {
            for (int n1 = 1; n1 <= 11000; n1++)
                for (int n2 = 1; n2 <= 11000; n2++)
                    Amichevoli(n1, n2);
        }

        private static void Amichevoli(int n1, int n2)
        {
            if (n1 != n2)
                if (sommafattori(n1) == n2 && sommafattori(n2) == n1)
                {
                    if(stampa == true)
                    {
                        Console.WriteLine(n1.ToString() + " - " +
                       n2.ToString() + " sono amichevoli");
                        stampa = false;
                    }
                    else
                        stampa = true;         
                }            
        }

        private static void numeriAmichevoli()
        {
            //I parametri che passo durante il richiamo di un metodo
            //si chiamano parametri ATTUALI
            int n1 = inserisciIntero("Inserisci n1: ", 1); //RICHIAMO DI UN METODO
            int n2 = inserisciIntero("Inserisci n2: ", 1);

            //n1 e n2 sono PARAMETRI ATTUALI che verranno sostituiti 
            //al parametro FORMALE duranre il richiamo del metodo
            if (sommafattori(n1) == n2 && sommafattori(n2) == n1)
                Console.WriteLine("Amichevoli");
            else
                Console.WriteLine("Non amichevoli");
        }

        //n è un parametro FORMALE che verrà sostituito
        //dal parametro ATTUALE durante il richiamo del metodo
        //n è un identificatore generico
        private static int sommafattori(int n) //FIRMA del metodo
        {
            int somma = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    somma += i;
            return somma;
        }

        private static void numeroDeficienteAbbondante()
        {
            int n = inserisciIntero("Inserisci n: ", 1);
            int somma = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    somma += i;
            if (somma == n)
                Console.WriteLine("Il numero è perfetto");
            else
            {
                if (somma < n)
                    Console.WriteLine("Il numero è deficiente");
                else
                    Console.WriteLine("Il numero è abbondante");
            }
        }

        private static void numeriTriangolari()
        {
            int n = inserisciIntero("Inserisci il numero di terne triangolari: ", 1);
            int a = 1, b = 2, c = 3;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a.ToString() + " - " +
                    b.ToString() + " - " + c.ToString());
                a = c;
                b++;
                c = a + b;
            }
        }
        private static void n_simoFibonacci()
        {
            int n = inserisciIntero("Quale valore di Fibonacci vuoi? ", 1);
            int a = 0, b = 1; //termini noti della successione
            int c;
            for (int i = 1; i < n; i++)
            {
                c = a + b; //genero nuovo termine successione
                a = b; //traslo i termini
                b = c;
            }
            Console.WriteLine(a.ToString());
        }

        private static void Fibonacci()
        {
            int n = inserisciIntero("Quanti valori di Fibonacci vuoi? ", 1);
            int a = 0, b = 1; //termini noti della successione
            int c;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a.ToString()); //elaboro il termine
                c = a + b; //genero nuovo termine successione
                a = b; //traslo i termini
                b = c;
            }
        }

        private static void numeriPrimi()
        {
            int i;
            Console.Write("1 - 2");
            for (int n = 3; n <= 1000; n += 2)
            {
                i = 3;
                while (n % i != 0 && i <= n / 2)
                    i += 2;
                if (n % i != 0)
                    Console.Write(" - " + n.ToString());
            }
        }

        private static void numeroPrimo()
        {
            int i;
            int n = inserisciIntero("Inserisci n: ", 1);
            if (n % 2 == 1)
            {
                i = 3;
                while (n % i != 0 && i <= n / 2)
                    i += 2;
                if (n % i == 0)
                    Console.WriteLine("Non primo");
                else
                    Console.WriteLine("Primo");
            }
            else
                Console.WriteLine("Non primo");
        }

        private static void numeriPerfetti()
        {
            int somma;
            string s;
            for (int n = 6; n <= 34000000; n++)
            {
                somma = 1;
                s = "1+";
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0)
                    {
                        somma += i;
                        s = s + i.ToString() + "+";
                    }
                if (somma == n)
                {
                    s = s.Substring(0, s.Length - 1);
                    Console.WriteLine(s + "=" + n.ToString());
                }
            }
        }

        private static void numeroPerfetto()
        {
            int n = inserisciIntero("Inserisci n: ", 1);
            int somma = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    somma += i;
            if (somma == n)
                Console.WriteLine("Il numero è perfetto");
            else
                Console.WriteLine("Il numero NON è perfetto");
        }

        private static void divisoriInteri()
        {
            int n = inserisciIntero("Inserisci n: ", 1);
            Console.WriteLine("1");
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    Console.WriteLine(i.ToString());
            Console.WriteLine(n.ToString());
        }

        private static void calcolaPotenza()
        {
            int pot, b, e;

            b = inserisciIntero("Inserisci la base: ", 0);
            e = inserisciIntero("Inserisci l'esponente: ", 0);

            pot = 1;
            for (int i = 1; i <= e; i++)
                pot = pot * b;
            Console.WriteLine("pow(" + b.ToString() + "," +
                e.ToString() + ")=" + pot.ToString());
        }

        private static void convertiDECHEX()
        {
            int n, r;
            string esadecimale = "";
            string ch = "";

            n = inserisciIntero("Inserisci numero decimale da convertire in esadecimale: ", 0);

            do
            {
                r = n % 16;
                switch (r)
                {
                    case 10:
                        ch = "A";
                        break;
                    case 11:
                        ch = "B";
                        break;
                    case 12:
                        ch = "C";
                        break;
                    case 13:
                        ch = "D";
                        break;
                    case 14:
                        ch = "E";
                        break;
                    case 15:
                        ch = "F";
                        break;
                    default:
                        ch = r.ToString();
                        break;

                }
                // L'operatore + in questo caso concatena le strighe
                esadecimale += ch;
                n = n / 16;
            }
            while (n != 0);

            Console.WriteLine(esadecimale.Reverse().ToArray());
        }

        private static void convertBINDEC()
        {
            int somma, esponente;
            string binario;

            Console.Write("Inserisci binario: ");
            binario = Console.ReadLine();

            // .Length => restiuisce lunghezza della stringa
            esponente = binario.Length - 1;
            somma = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                // Analizzando un carattere per volta della stringa 
                // dobbiamo confrontarlo con il carattere 1 racchiuso tra 
                // apici singoli 
                if (binario[i] == '1')
                    // Pow(base, esponente) => è un metodo della libreria 
                    // Math per fare l'elevamento a potenza.
                    // Visto che restiuisce un double lo trasformo in intero 
                    // facendo un cast (int) 
                    somma += (int)Math.Pow(2, esponente);
                esponente--;
            }
            Console.WriteLine("Il decimale corrisponente è " + somma.ToString());
        }

        private static double calcolaMedia()
        {
            int n, somma, x;

            Console.WriteLine("N25 P52");
            n = inserisciIntero("Inserisci totale valori di cui calcolare la media: ", 1);

            somma = 0;
            for (int i = 1; i <= n; i++)
            {
                x = inserisciIntero("Inserisci valore: ", 1);
                somma = somma + x; // somma += x;
            }
            return (double)somma / n;
            // Eseguo cast sulla var. somma per trasformarla temporaneamente in 
            // Double, in modo da ottenere un risultato decimale 
            // Alternativa: dichiaro var. somma di tipo Double 
            //Console.WriteLine("La media è " + ((double)somma / n).ToString("F2")); 
            // ToString("F2") => Per restituire due cifre dopo la virgola
        }

        private static void convertiDECBIN()
        {
            int n, r;
            string binario = "";

            Console.WriteLine("N27 P52");
            n = inserisciIntero("Inserisci numero decimale da convertire in binario: ", 0);

            do
            {
                r = n % 2;
                // L'operatore + in questo caso concatena le strighe
                binario = binario + r.ToString();
                n = n / 2;
            }
            while (n != 0);

            Console.WriteLine(binario.Reverse().ToArray());
        }
        private static void calcolaFattoriali()
        {
            int f, numero;

            numero = inserisciIntero("Inserisci il numero n di fattoriali desiderati: ", 1);

            for (int n = 0; n <= numero; n++)
            {
                f = 1;
                Console.Write("f(" + n.ToString() + ")=");
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    if (i != n)
                        Console.Write(i.ToString() + "*");
                    else
                        Console.Write(i.ToString() + "=");
                }
                Console.WriteLine(f.ToString());
            }
        }

        private static int calcolaFattoriale()
        {
            int n, f;
            Console.WriteLine("N26 P52");
            n = inserisciIntero("Inserisci il valore di cui vuoi calcolare il fattoriale :", 0);

            f = 1;
            Console.Write("f(" + n.ToString() + ")=");
            for (int i = 1; i <= n; i++)
            {
                f *= i;
                if (i != n)
                    Console.Write(i.ToString() + "*");
                else
                    Console.Write(i.ToString() + "=");
            }
            return f;
            //Console.WriteLine(f.ToString());
        }

        private static int ricercaMassimo()
        {
            int n, x;
            int max = int.MinValue;
            Console.WriteLine("N21 P52");
            n = inserisciIntero("Inserisci il numero di valori: ", 1);

            for (int i = 1; i <= n; i++)
            {
                x = inserisciIntero("Inserisci valore: ", int.MinValue);
                if (x > max)
                    max = x;
            } // fine for 
            return max;
            //Console.WriteLine("Il valore massimo trovato è "
            //                          + max.ToString());
        }

        // Parametri FORMALI string msg(messaggio da stampare), int min(valore minimo accettato)
        private static int inserisciIntero(string msg, int min) //FIRMA DI UN METODO
        {
            int n; // Variabile LOCALE
            do
                Console.Write(msg);
            while (!int.TryParse(Console.ReadLine(), out n) || n < min);
            return n;
        }

        private static void disegnaMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1: Cerca il MAX di n valori in input");
            Console.WriteLine("2: Calcola il FATTORIALE di n in input");
            Console.WriteLine("3: Calcola n (in input) FATTORIALI");
            Console.WriteLine("4: Calcola MEDIA di n valori in input");
            Console.WriteLine("5: Converti DEC in BIN");
            Console.WriteLine("6: Converti BIN in DEC");
            Console.WriteLine("7: Calcola POTENZA");
            Console.WriteLine("8: Converti DEC in HEX");
            Console.WriteLine("9: Confronto tra MEDIE");
            Console.WriteLine("10: Visualizza DIVISORI interi di n");
            Console.WriteLine("11: Verifica numero PERFETTO");
            Console.WriteLine("12: Visualizza numeri PERFETTI");
            Console.WriteLine("13: Verifica numero PRIMO");
            Console.WriteLine("14: Visualizza numeri PRIMI");
            Console.WriteLine("15: FIBONACCI");
            Console.WriteLine("16: Visualizza n-simo termine FIBONACCI");
            Console.WriteLine("17: Visualizza n terne numeri TRIANGOLARI");
            Console.WriteLine("18: Verifica se n è DEFICIENTE o ABBONDANTE");
            Console.WriteLine("19: Verifica se n1 e n2 sono AMICHEVOLI");
            Console.WriteLine("20: Visualizza coppie AMICHEVOLI");
            Console.WriteLine();
            Console.WriteLine("0: ESCI");
        }
    }
}
