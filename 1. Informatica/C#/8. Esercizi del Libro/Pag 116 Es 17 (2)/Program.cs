using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n17pag116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] canzoni = new string[]
            {"Volare", "Azzurro", "Almeno tu nell'universo", "La solitudine", "Con te partirò", "Felicità", "Vita spericolata", "Il cielo in una stanza", "Questo piccolo grande amore", "Nel blu dipinto di blu", "Laura non c'è", "Sarà perché ti amo", "Caruso", "Non me lo so spiegare", "Il mio canto libero", "Ti scatterò una foto", "Se telefonando", "Gli uomini non cambiano", "T'appartengo", "Maledetta primavera", "I migliori anni della nostra vita", "Eppure sentire (un senso di te)", "Penso positivo", "Bella", "Certe notti", "Perdere l'amore", "Ti sento", "Senza una donna", "L'essenziale", "La donna cannone"};
            string[] cantanti = new string[]
                {"Domenico Modugno", "Adriano Celentano", "Mia Martini", "Laura Pausini", "Andrea Bocelli", "Al Bano e Romina Power", "Vasco Rossi", "Gino Paoli", "Claudio Baglioni", "Domenico Modugno", "Nek", "Ricchi e Poveri", "Lucio Dalla", "Tiziano Ferro", "Lucio Battisti", "Tiziano Ferro", "Mina", "Mia Martini", "Ambra Angiolini", "Loretta Goggi", "Renato Zero", "Elisa", "Jovanotti", "Jovanotti", "Ligabue", "Massimo Ranieri", "Matia Bazar", "Zucchero", "Marco Mengoni", "Francesco De Gregori"};
            int[] punteggi = new int[cantanti.Length];
            sanremo.stampaElenco(canzoni, cantanti);
            sanremo.es1(canzoni, cantanti); //n17pag116
            Console.ReadKey();
            sanremo.es2(canzoni, cantanti); //n18pag116
            Console.ReadKey();
            sanremo.es3(canzoni, cantanti); //n20_21pag116
            Console.ReadKey();
            sanremo.es4(canzoni, cantanti, punteggi); //n22pag116
            Console.ReadKey();
            sanremo.es5(canzoni, cantanti, punteggi); //n23pag116
            Console.ReadKey();
        }
    }
}
