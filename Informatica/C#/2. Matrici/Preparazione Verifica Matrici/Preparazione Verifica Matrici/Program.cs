using System;

namespace Preparazione_Verifica_Matrici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[5,5];
            ClsMatrici.caricaMatrice(m);
            int r, c;
            do
                Console.Write("Inserisci il numero di righe: ");

            while (!int.TryParse(Console.ReadLine(), out r) || r < 0);
            do
                Console.Write("Inserisci il numero di colonne: ");

            while (!int.TryParse(Console.ReadLine(), out c) || c < 0);
            int[,] a = new int[r, r]; //righe==colonne --> matrice QUADRATA
            int[,] b = new int[r, c]; //righe!=colonne --> matrice RETTANGOLARE
            int scelta = 0;
            do
            {
                Console.Clear();
                scelta = disegnaMenù();
                switch (scelta)
                {
                    case 1:
                        ClsMatrici.stampaMatrice(m, "Matrice:");
                        break;
                    case 2:
                        ClsMatrici.sopraDSsolo0(m);
                        break;
                    case 3:
                        ClsMatrici.sommaElementiSopraDS(m);
                        break;
                    case 4:
                        ClsMatrici.sottoDSsolo0(m);
                        break;
                    case 5:
                        ClsMatrici.sommaElementiSottoDS(m);
                        break;
                    case 6:
                        ClsMatrici.tuttiUgualiSopraDP(m);
                        break;
                    case 7:
                        ClsMatrici.tuttiUgualiSottoDP(m);
                        break;
                    case 8:
                        ClsMatrici.ricercaXTriangoloSottoDP(m);
                        break;
                    case 9:
                        ClsMatrici.ricercaXTriangoloSopraDP(m);
                        break;
                    case 10:
                        ClsMatrici.sommaElementiSottoDP(m);
                        break;
                    case 11:
                        ClsMatrici.sommaElementiSopraDP(m);
                        break;
                    case 12:
                        ClsMatrici.matriceConPrimaUltimaRigaDi1(m);
                        break;
                    case 13:
                        ClsMatrici.matriceConCroce(m);
                        break;
                    case 14:
                        ClsMatrici.matriceUnitaria(m);
                        break;
                    case 15:
                        ClsMatrici.matriceNulla(m);
                        break;
                    case 16:
                        ClsMatrici.matriceTuttiElementiUguali(m);
                        break;
                    case 17:
                        ClsMatrici.caricaCorniceSequenza(m);
                        ClsMatrici.stampaMatrice(m, "Matrice con Cornice:");
                        break;
                    case 18:
                        ClsMatrici.caricaMatriceSequenzaContraria(m);
                        ClsMatrici.stampaMatrice(m, "Matrice con Sequenza Contraria:");
                        break;
                    case 19:
                        ClsMatrici.caricaMatriceSequenza(m);
                        ClsMatrici.stampaMatrice(m, "Matrice con Sequenza:");
                        break;
                    case 20:
                        double media = ClsMatrici.mediaMatrice(m);
                        Console.WriteLine("Media Matrice: " + media.ToString());
                        break;
                    case 21:
                        int conteggio = ClsMatrici.contaX(m);
                        Console.WriteLine("Conteggio di X: " + conteggio.ToString());
                        break;
                    case 22:
                        int sommaColonna = ClsMatrici.sommaColonnaJ(m);
                        Console.WriteLine("Somma Colonna: " + sommaColonna.ToString());
                        break;
                    case 23:
                        int sommaRiga = ClsMatrici.sommaRigaI(m);
                        Console.WriteLine("Somma Riga: " + sommaRiga.ToString());
                        break;
                    case 24:
                        int sommaCornice = ClsMatrici.sommaCornice(m);
                        Console.WriteLine("Somma Cornice: " + sommaCornice.ToString());
                        break;
                    case 25:
                        int sommaDS = ClsMatrici.sommaDS(m);
                        Console.WriteLine("Somma Diagonale Secondaria: " + sommaDS.ToString());
                        break;
                    case 26:
                        int sommaDP = ClsMatrici.sommaDP(m);
                        Console.WriteLine("Somma Diagonale Principale: " + sommaDP.ToString());
                        break;
                    case 27:
                        int max = ClsMatrici.maxMatrice(m);
                        Console.WriteLine("Massimo della Matrice: " + max.ToString());
                        break;
                    case 28:
                        ClsMatrici.caricaMatrice(a);
                        ClsMatrici.stampaMatrice(a, "Matrice A quadrata");
                        break;
                    case 29:
                        ClsMatrici.caricaMatrice(b);
                        ClsMatrici.stampaMatrice(b, "Matrice B rettangolare");
                        break;
                    case 30:
                        Console.WriteLine("Fine Programma...");
                        break;
                    default:
                        Console.WriteLine("Opzione non valida. Riprova.");
                        break; 
                }
            } while (scelta != 0);
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

        private static int disegnaMenù()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Stampa Matrice");
            Console.WriteLine("2. Sopra DS solo 0");
            Console.WriteLine("3. Somma Elementi Sopra DS");
            Console.WriteLine("4. Sotto DS solo 0");
            Console.WriteLine("5. Somma Elementi Sotto DS");
            Console.WriteLine("6. Tutti Uguali Sopra DP");
            Console.WriteLine("7. Tutti Uguali Sotto DP");
            Console.WriteLine("8. Ricerca X Triangolo Sotto DP");
            Console.WriteLine("9. Ricerca X Triangolo Sopra DP");
            Console.WriteLine("10. Somma Elementi Sotto DP");
            Console.WriteLine("11. Somma Elementi Sopra DP");
            Console.WriteLine("12. Matrice con Prima e Ultima Riga di 1");
            Console.WriteLine("13. Matrice con Croce");
            Console.WriteLine("14. Matrice Unitaria");
            Console.WriteLine("15. Matrice Nulla");
            Console.WriteLine("16. Matrice con Tutti Elementi Uguali");
            Console.WriteLine("17. Carica Cornice Sequenza");
            Console.WriteLine("18. Carica Matrice Sequenza Contraria");
            Console.WriteLine("19. Carica Matrice Sequenza");
            Console.WriteLine("20. Media Matrice");
            Console.WriteLine("21. Conta X");
            Console.WriteLine("22. Somma Colonna J");
            Console.WriteLine("23. Somma Riga I");
            Console.WriteLine("24. Somma Cornice");
            Console.WriteLine("25. Somma DS");
            Console.WriteLine("26. Somma DP");
            Console.WriteLine("27. Max Matrice");
            Console.WriteLine("28. Stampa Matrice Quadrata");
            Console.WriteLine("29. Stampa Matrice Rettangolare");
            Console.WriteLine("30. Esci");

            return inserisciInputIntero("Inserisci un numero", 0);
        }
    }
}
