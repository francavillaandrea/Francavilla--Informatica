using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0, ris=0;
        const int ira = 2;
        do
        {
            
            Console.WriteLine("Inserisci un numero decimale:");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n < 0);
        

        if ( n == 0)
        {
            Console.WriteLine("Il numero binario è: 0");
        }
        else
        {
            Console.Write("Il numero binario è: ");
            if (n<0)
            {
                ris=(n/ira);
                Console.WriteLine(n % 2);
            }
            Console.WriteLine();
        }
        Console.ReadKey();

    }
}
