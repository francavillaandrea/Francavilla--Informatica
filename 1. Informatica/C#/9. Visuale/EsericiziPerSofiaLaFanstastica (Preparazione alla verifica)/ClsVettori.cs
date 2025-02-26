using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace EsericiziProva
{
    internal class ClsVettori
    {
        static Random rnd = new Random();
        internal static void CaricaVett(int[] v, int n)
        {
            n = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore"));
            v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 11);
            }
        }

        internal static void StampaVett(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}
