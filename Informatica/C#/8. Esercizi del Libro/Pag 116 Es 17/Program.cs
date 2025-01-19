
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_17_Pag_116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] canzoni = new string[]
            {"Volare", "Azzurro", "Almeno tu nell'universo", "La solitudine", "Con te partirò", "Felicità", "Vita spericolata", "Il cielo in una stanza", "Questo piccolo grande amore", "Nel blu dipinto di blu", "Laura non c'è", "Sarà perché ti amo", "Caruso", "Non me lo so spiegare", "Il mio canto libero", "Ti scatterò una foto", "Se telefonando", "Gli uomini non cambiano", "T'appartengo", "Maledetta primavera", "I migliori anni della nostra vita", "Eppure sentire (un senso di te)", "Penso positivo", "Bella", "Certe notti", "Perdere l'amore", "Ti sento", "Senza una donna", "L'essenziale", "La donna cannone"};
            string[] cantanti = new string[]
                {"Domenico Modugno", "Adriano Celentano", "Mia Martini", "Laura Pausini", "Andrea Bocelli", "Al Bano e Romina Power", "Vasco Rossi", "Gino Paoli", "Claudio Baglioni", "Domenico Modugno", "Nek", "Ricchi e Poveri", "Lucio Dalla", "Tiziano Ferro", "Lucio Battisti", "Tiziano Ferro", "Mina", "Mia Martini", "Ambra Angiolini", "Loretta Goggi", "Renato Zero", "Elisa", "Jovanotti", "Jovanotti", "Ligabue", "Massimo Ranieri", "Matia Bazar", "Zucchero", "Marco Mengoni", "Francesco De Gregori"};
            es1(canzoni, cantanti);
        }

        private static void es1(string[] canzoni, string[] cantanti)
        {
            Console.WriteLine("Inserisci il cantante di cui vuoi sapere le canzoni");
            string x = Console.ReadLine();
            int i = 0;
            while (canzoni[i] != x && i == (canzoni.Length - 1))
                i++;
            if (canzoni[)

        }
    }
}
