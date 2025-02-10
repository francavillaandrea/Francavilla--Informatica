using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica3B_11_11_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cognomeVerifica = "Francavilla", nomeVerifica = "Andrea";
            string scelta;
            string output = "";
            // Esercizio 1 
            string[] vS1 = { "Claudia ", "Luigi ", "Anna ", "Paolo ", "Francesca ", "Martina ", "Riccardo ", "Stefano ", "Laura ", "Elena " }; // Claudia, francesca stefano martina
            string[] vS2 = { "Alessandro ", "Francesca ", "Carlo ", "Claudia ", "Matteo ", "Valeria ", "Stefano ", "Martina ", "Giorgio ", "Simone " };
            // Esercizio 2, 3 
            string poesia = "Silvia, rimembri ancora " +
                            "quel tempo della tua vita mortale, " +
                            "quando beltà splendea negli occhi tuoi ridenti " +
                            "e nel tuo volto ardeva il mio cuore? " +
                            "Ove sei? Perché tanto " +
                            "mi giunge il dolce suono " +
                            "del tuo nome, che mi fa pensare a te? " +
                            "Oh, Silvia, un tempo il cielo " +
                            "donò agli occhi tuoi la vita, " +
                            "ma che più? " +
                            "Perché il cielo, da quell'istante, " +
                            "negò a te il suo amore. ";

            do
            {
                scelta = visualizzaMenu(cognomeVerifica, nomeVerifica);
                switch (scelta.ToUpper())
                {
                    case "A": // Intersezione
                        
                        Console.Write("I nomi che si ripetono nelle 2 stringhe sono: ");
                        intersezione(vS1, vS2);
                        
                        break;
                    case "B": // Estrazione iniziali
                        lettereIniziali(poesia);
                        break;
                    case "C": // Conta parole in frase
                        contaparole(poesia);
                        break;
                    case "Q":
                        Console.WriteLine("Verifica terminata");
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta.ToLower() != "q");
        }

        private static void contaparole(string poesia)
        {
            string[] parti = poesia.Split(' ');
            int cont = 0;
            for(int i =0; i< poesia.Length; i++)
            {
                bool starts = poesia.StartsWith(" ");
                if (starts  == true )
                {
                    cont++; 
                }
            }
            Console.WriteLine();
        }

        private static void lettereIniziali(string poesia)
        {
            string output = "";
            char[] Vpoesia = poesia.ToCharArray();
            string [] lettere = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
            for (int i = 0;i< poesia.Length; i++)
            {
                if (poesia != " ")
                {
                    i++;
                    output += Vpoesia[i];
                }
            }
            Console.WriteLine(output);
        }

        private static void intersezione(string[] vS1, string[] vS2)
        {
            string output = "";
            
            
            for (int i = 0;i<=vS1.Length-1;i++)
            {
                
                bool contains = vS1.Contains(vS2[i]);
                

                if (contains == true )
                {
                      output+= vS2[i];
                }
                
                contains = false;

            }
            Console.WriteLine(output);
        }

        private static string visualizzaMenu(string cogn, string nome)
        {
            Console.Clear();
            Console.WriteLine($"::: Verifica di {cogn.ToUpper()} {nome.ToUpper()} :::");
            Console.WriteLine("A. Intersezione");
            Console.WriteLine("B. Estrazione iniziali");
            Console.WriteLine("C. Conta parole in frase");
            Console.WriteLine("Q. Chiudi");
            Console.Write("Scelta > ");
            return Console.ReadLine();
        }
    }
}
