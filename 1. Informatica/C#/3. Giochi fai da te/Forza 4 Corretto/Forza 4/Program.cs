using Forza_4;
using System;

namespace Forza_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] campo; // Matrice campo da gioco 
            char giocatoreCorrente; // X o O per giocatori 
            int colonna; // Colonna inserimento gettone da parte del giocatore di turno
            int riga; // Salvo riga dove il gettone è stato posizionato
            bool vittoria; // Registro se c'è vittoria da parte di un giocatore 
            bool campoPieno; // Se non c'è vittoria 
            do
            {

                campo = new char[6, 7];
                giocatoreCorrente = 'X';
                ClsF4.inizializzaCampo(campo); // Inizial. matrice con valore char predefinito
                ClsF4.mostraCampo(campo); // Grafica: visualizzo griglia di gioco e gettoni pos.
                // Inizio partita 
                do
                { // Iterazione per inserimento gettone e controlli vari... 
                    vittoria = false;
                    campoPieno = false;
                    do
                    {
                        Console.Write("Giocatore " + giocatoreCorrente + ", " +
                                    "scegli colonna (0-6) > ");
                    } while (!int.TryParse(Console.ReadLine(), out colonna) ||
                                colonna < 0 || colonna > 6);

                    if (campo[0, colonna] == '.') // Controllo colonna valida
                    { // N.B. Posso posizionare il gettone 
                        // Posiziono gettone 
                        riga = ClsF4.posizionaGettone(campo, giocatoreCorrente, colonna);
                        // Ora ho le coordinate della pos. del gettone salvate in riga/colonna
                        ClsF4.mostraCampo(campo);
                        // Verificare vittoria 
                        vittoria = ClsF4.controllaVittoria(campo, riga, colonna, giocatoreCorrente);
                        campoPieno = ClsF4.verificaCampo(campo);
                        giocatoreCorrente = (giocatoreCorrente == 'X') ? 'O' : 'X';

                    }
                    else
                        Console.WriteLine("Colonna piena. Riprova.");

                } while (!vittoria && !campoPieno);

                giocatoreCorrente = (giocatoreCorrente == 'X') ? 'O' : 'X';
                if (vittoria)
                    Console.WriteLine("VINCE GIOCATORE " + giocatoreCorrente);
                Console.ReadKey();
            } while (true); // Gestione nuova partita 
        }
    }
}
