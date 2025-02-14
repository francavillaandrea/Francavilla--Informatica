using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Francavilla_Recupero_Trimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dopo aver stampato il contenuto dei vettori su 3 colonne:
            //1.ordinare i 3 vettori in base alla provincia e per ogni provincia contare il numero di cittadini;
            //2.ordinare i 3 vettori in base alla provincia e contare il totale di F di una provincia ricevuta in ingresso al programma.

            string[] cittadini = { "Rossi", "Gallo", "Ferrari", "Colombo", "Mancini", "Martini", "Bianco", "Conte", "Gentile", "Pellegrini" };
            char[] sesso = { 'M', 'M', 'F', 'F', 'M', 'F', 'F', 'F', 'M', 'M' };
            string[] province = { "TO", "MI", "FI", "FI", "MI", "TO", "TO", "FI", "MI", "MI" };
           
            ClsRecupero.ordinaProvincia(cittadini, province, sesso);
            ClsRecupero.stampaVettori(cittadini, province, sesso);
            ClsRecupero.contaNProvincia(province);
            ClsRecupero.contaFProvincia(province, sesso);
            Console.ReadKey();
            //ClsRecupero.ordinaProvincia();
        }
    }
}
