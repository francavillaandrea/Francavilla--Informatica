using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassaggioParametri
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 45;
            int b = 88;
            Console.WriteLine("PRIMA DEL RICHIAMO x VALORE --> a: " + a.ToString() + " - b: " + b.ToString());
            scambio_valore(a, b);
            Console.WriteLine("DOPO IL RICHIAMO x VALORE --> a: " + a.ToString() + " - b: " + b.ToString());
            Console.ReadKey();
            Console.WriteLine("PRIMA DEL RICHIAMO x REFERENZA --> a: " + a.ToString() + " - b: " + b.ToString());
            scambio_referenza(ref a, ref b);
            Console.WriteLine("DOPO IL RICHIAMO x REFERENZA --> a: " + a.ToString() + " - b: " + b.ToString());
            Console.ReadKey();
            
        }

        

        private static void scambio_valore (int x, int y) //PF trasmessi per VALORE
        {
            int aus;

            aus = x;
            x = y;
            y = aus;
            Console.WriteLine("ALLA FINE DEL STP x VALORE --> x: " + x.ToString() + " - y: " + y.ToString());
        }
        private static void scambio_referenza(ref int x, ref int y) //PF trasmessi per REFERENZA
        {
            int aus;

            aus = x;
            x = y;
            y = aus;
            Console.WriteLine("ALLA FINE DEL STP x REFERENZA --> x: " + x.ToString() + " - y: " + y.ToString());
        }
    }
}
