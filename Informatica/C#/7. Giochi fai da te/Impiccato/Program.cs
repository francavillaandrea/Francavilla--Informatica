using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impiccato
{
    internal class Program
    {
        static Random rnd = new Random(); 
        static void Main(string[] args)
        {
            string[] parole = {
                "cane", "gatto", "libro", "tavolo", "giorno",
                "scuola", "strada", "sole", "mare", "casa",
                "festa", "musica", "verde", "rosso", "blu",
                "pioggia", "vento", "nuvola", "ombrello", "bicchiere",
                "felice", "felicità", "viaggio", "riso", "spiaggia",
                "montagna", "parco", "amico", "felino", "animale",
                "notte", "stella", "magia", "sogno", "profumo",
                "fiori", "parola", "ponte", "città", "luna",
                "rosa", "felicità", "mente", "dolce", "melodia",
                "sorriso", "amore", "chitarra", "pietra", "ventura"
                };
            char gioca; // Var. per gestire nuova partita 
            string segreto; // Memorizzo stringa estratta (da indovinare) 
            int tentativiErrati; // Memorizzo numero di tentativo 
            char[] lettereIndovinate; // Memorizzo caratteri già indovinati nella posizione corretta
            char lettera; // Input carattere tentativo 
            string colorata; 

            do
            {
                // Carico parola segreta 
                segreto = parole[rnd.Next(0, parole.Length)];
                tentativiErrati = 0;
                lettereIndovinate = new char[segreto.Length];  // '\0' - Tutto il vettore viene 
                                                               // inizializzato con il carattere \0
                do
                {
                    // Grafica 
                    Console.Clear();
                    colorata = mascheraParola(lettereIndovinate); 
                    Console.Write("Parola da indovinare: ");
                    for(int i=0; i<colorata.Length; i++)
                    {
                        if (colorata[i] != '-')
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(colorata[i]);
                    }
                    Console.WriteLine(); 
                    Console.ResetColor();
                    
                    Console.WriteLine("Tentativi errati: " + tentativiErrati.ToString());
                    disegnaImpiccato(tentativiErrati);

                    Console.Write("Inserisci una lettera: ");
                    lettera = Console.ReadKey().KeyChar; // leggo carattere appena premo tasto

                    if (segreto.Contains(lettera))
                    {
                        for(int i =0; i<segreto.Length; i++)
                        {
                            if (segreto[i] == lettera)
                                lettereIndovinate[i] = segreto[i]; // oppure  = "lettera"
                        }
                    }
                    else
                        tentativiErrati++;
                    
                    Console.ReadKey();
                }
                while (tentativiErrati < 6 && !vittoria(lettereIndovinate));
                //while (tentativiErrati < 6 && !segreto.Equals(new string(lettereIndovinate)));
                // PARTITA TERMINATA 
                Console.Clear();
                if (segreto.Equals(new string(lettereIndovinate)))
                {
                    Console.WriteLine("Parola da indovinare: " + mascheraParola(lettereIndovinate));
                    
                    disegnaImpiccato(tentativiErrati);
                    Console.WriteLine("Complimenti! Hai indovinato");
                }
                else
                {
                    Console.WriteLine("Peccato! Hai perso. La parola segreta era: " + segreto);
                    disegnaImpiccato(tentativiErrati);
                }
                do
                {
                    Console.Write("Vuoi giocare di nuovo? (y/n) > ");
                }
                while (!char.TryParse(Console.ReadLine(), out gioca) || 
                            (gioca != 'y' && gioca !='n'));
            }
            while (gioca == 'y');

            Console.ReadKey();
        }

        private static bool vittoria(char[] lettereIndovinate)
        {
            int i = 0;

            while (i < lettereIndovinate.Length && lettereIndovinate[i] != '-')
                i++;

            return (i == lettereIndovinate.Length);
        }

        private static void disegnaImpiccato(int tentativiErrati)
        {
            Console.WriteLine("  ----");
            Console.WriteLine(" |    |");
            switch(tentativiErrati)
            {
                case 0:
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    break;
                case 1:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |");
                    Console.WriteLine(" |");
                    break;
                case 2:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |    |");
                    Console.WriteLine(" |");
                    break;
                case 3:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |   /|");
                    Console.WriteLine(" |");
                    break;
                case 4:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |   /|\\"); // Per visualizzare in modo corretto il car. '\'
                    Console.WriteLine(" |");
                    break;
                case 5:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |   /|\\"); // Per visualizzare in modo corretto il car. '\'
                    Console.WriteLine(" |   /");
                    break;
                case 6:
                    Console.WriteLine(" |    O");
                    Console.WriteLine(" |   /|\\"); // Per visualizzare in modo corretto il car. '\'
                    Console.WriteLine(" |   / \\");
                    break;
            }
            Console.WriteLine("_|___"); // Base patibolo
        }

        private static string mascheraParola(char[] lettereIndovinate)
        {
            string ret = ""; 
            for(int i=0; i<lettereIndovinate.Length; i++)
            {
                if (lettereIndovinate[i] == '\0')
                    lettereIndovinate[i] = '-';
                ret += lettereIndovinate[i]; 
            }
            return ret; 
        }
    }
}
