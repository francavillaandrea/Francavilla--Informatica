using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Benvenuto nel gioco horror!");
        Console.Write("Per favore, inserisci il tuo nome: ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nCiao {playerName}, sei un ragazzo ossessionato dai computer.");
        Console.WriteLine("Una sera invernale, durante un temporale, ti ritrovi intrappolato nel tuo computer.");
        Console.WriteLine("Sei diventato il processo figlio di un computer e una creatura orribile chiamata 'Sistem Exit' è all'inseguimento!");
        Console.WriteLine("Devi prendere delle decisioni per cercare di scappare.");

        bool gameRunning = true;

        while (gameRunning)
        {
            Console.WriteLine("\nCosa vuoi fare?");
            Console.WriteLine("1. Scappare dalla creatura");
            Console.WriteLine("2. Affrontare la creatura");
            Console.WriteLine("3. Cercare un modo per uscire dal computer");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FinalDeath(playerName);
                    gameRunning = false;
                    break;
                case "2":
                    FinalConfrontation(playerName);
                    gameRunning = false;
                    break;
                case "3":
                    FinalEscape(playerName);
                    gameRunning = false;
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    break;
            }
        }
    }

    static void FinalDeath(string playerName)
    {
        Console.WriteLine($"\n{playerName} ha cercato di scappare, ma 'Sistem Exit' lo ha catturato.");
        Console.WriteLine("La creatura si avvicina e ti annienta!");
        Console.WriteLine("…");
        Console.WriteLine("Un manifesto di scomparsa appare nel tuo quartiere.");
        Console.WriteLine($"\"Scomparso: {playerName}, ultime notizie avvistato davanti al computer. Contattare la polizia se avvistato.\"");
    }

    static void FinalConfrontation(string playerName)
    {
        Console.WriteLine($"\n{playerName} ha deciso di affrontare 'Sistem Exit'.");
        Console.WriteLine("Purtroppo, la creatura era troppo potente. La lotta è stata breve e terribile.");
        Console.WriteLine("La tua vita è finita, e 'Sistem Exit' vince.");
        Console.WriteLine("…");
        Console.WriteLine("Il processo padre ti osserva con indifferenza.");
    }

    static void FinalEscape(string playerName)
    {
        Console.WriteLine($"\n{playerName} ha trovato un modo per uscire dal computer.");
        Console.WriteLine("Hai completato un rituale per liberarti!");
        Console.WriteLine($"Finalmente sei libero, {playerName}. Ma il tuo viaggio è stato costoso.");
        Console.WriteLine("Tuttavia, non tutto è finito.");
        Console.WriteLine("In un momento di debolezza, ti dirigi verso il processo padre e ti impicchi.");
        Console.WriteLine("…");
        Console.WriteLine("Il processo padre, vedendoti, non può fare a meno di seguire il tuo esempio e si impicca a sua volta.");
    }
}
