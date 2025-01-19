using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ese17_N_26_Pag_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  n1,nf=1;
            do
            {
                Console.WriteLine("Inserisci il  numero");
            }
            while (!int.TryParse(Console.ReadLine(), out n1) || n1 < 0);
            Console.Write("F("+n1.ToString()+")=");
            for (int i = 1; i <= n1; i++) 
            {
                if (i==n1)
                {
                    Console.Write(i.ToString()+"=");
                }
                else
                {
                    Console.Write(i.ToString() + "*");
                }
                nf = nf * i;
            }
            Console.WriteLine(nf.ToString());
            Console.ReadKey();
        }
    }
}
