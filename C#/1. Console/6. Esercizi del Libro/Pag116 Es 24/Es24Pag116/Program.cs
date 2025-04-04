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
            Es24Pag116.ClsCani.stampaElenco(razze, cani);
        }
    }
}
