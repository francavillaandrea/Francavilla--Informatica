using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n24pag116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cani = {
            "Fido", "Rex", "Luna", "Bella", "Charlie",
            "Rocky", "Max", "Mia", "Buddy", "Daisy",
            "Oscar", "Molly", "Jack", "Lilly", "Zoe",
            "Leo", "Simba", "Chloe", "Cooper", "Sally"};
            string[] razze = {
            "Labrador", "Bulldog", "Beagle", "Barboncino", "Bulldog",
            "Bulldog", "Chihuahua", "Carlino", "Husky Siberiano", "Bassotto",
            "Labrador", "Bulldog", "Beagle", "Bulldog", "Carlino",
            "Barboncino", "Pastore Tedesco", "Bulldog", "Chihuahua", "Bassotto"};
            clsCani.ordinaCani(cani);
            clsCani.ordinaRazze(razze);
            clsCani.stampaElenco(cani,razze);
            Console.ReadKey();
            Console.Write("Inseririsci il nome del cane: ");
            string cane = Console.ReadLine();
            clsCani.ricercaBinaria(cani,cane);
            Console.ReadKey();
            Console.Write("Inseririsci la razza: ");
            string razza = Console.ReadLine();
            clsCani.ContaCaniRazza(razze, razza);
            Console.ReadKey();
            clsCani.contaCaniPerOgniRazza(razze);
            Console.ReadKey();
            clsCani.cercaRazzaConPiùCani(razze);
            Console.ReadKey();
        }
    }
}
