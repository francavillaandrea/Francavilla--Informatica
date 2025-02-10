using System;

public class Vettori
{
    private const int LUNG = 100;

    public static int LeggiPositivoMinore(int valMax)
    {
        int num;
        do
        {
            Console.WriteLine($"Inserisci un numero tra 0 e {valMax}: ");
            num = int.Parse(Console.ReadLine());
        } while (num > valMax || num < 0);

        return num;
    }

    public static void CaricaVett(int[] vett, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Inserisci il {i + 1}^ numero: ");
            vett[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void CaricaVettCasuali(int[] v, int n, int nMin, int nMax)
    {
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            v[i] = rand.Next(nMin, nMax + 1);
        }
    }

    public static void VisualizzaVett(int[] v, int dim)
    {
        for (int i = 0; i < dim; i++)
        {
            Console.Write(v[i] + " ");
        }
        Console.WriteLine();
    }

    public static int NonOrdDisg2(float[] v, int n, int x)
    {
        int tro = -1;
        int i = 0;
        while (i < n && tro == -1)
        {
            if (x == v[i])
                tro = i;
            else
                i++;
        }
        return tro;
    }

    public static bool NonOrdDisg(int[] v, int n, int x)
    {
        int i = 0;
        bool tro = false;
        while (i < n && !tro)
        {
            if (x == v[i])
                tro = true;
            else
                i++;
        }
        return tro;
    }

    public static int OrdDisg1(int[] v, int n, int x)
    {
        int tro = -1;
        int i = 0;
        bool continua = true;
        while (i < n && tro == -1 && continua)
        {
            if (x == v[i])
                tro = i;
            else if (v[i] > x)
                continua = false;
            else
                i++;
        }
        return tro;
    }

    public static int OrdDisg2(int[] v, int n, int x)
    {
        int tro = -1;
        int i = 0;
        while (i < n && tro == -1)
        {
            if (x == v[i])
                tro = i;
            else if (v[i] > x)
                i = n;
            else
                i++;
        }
        return tro;
    }

    public static int NonOrdNonDisg(int[] v, int n, int x)
    {
        int nx = 0;
        for (int i = 0; i < n; i++)
        {
            if (x == v[i])
            {
                Console.WriteLine($"Elemento trovato in posizione {i}");
                nx++;
            }
        }
        return nx;
    }

    public static int OrdNonDisg1(int[] v, int n, int x)
    {
        int nx = 0;
        int i = 0;
        bool continua = true;
        while (i < n && continua)
        {
            if (x == v[i])
            {
                Console.WriteLine($"L'elemento trovato in posizione {i}");
                nx++;
                i++;
            }
            else if (v[i] > x)
                continua = false;
            else
                i++;
        }
        return nx;
    }

    public static int OrdNonDisg2(int[] v, int n, int x)
    {
        int nx = 0;
        int i = 0;
        while (i < n)
        {
            if (x == v[i])
            {
                Console.WriteLine($"L'elemento trovato in posizione {i}");
                nx++;
                i++;
            }
            else if (v[i] > x)
                i = n;
            else
                i++;
        }
        return nx;
    }

    public static int RicercaBinariaNonRicorsiva(int[] v, int n, int x)
    {
        int p = 0;
        int u = n - 1;
        int tro = -1;
        while (p <= u && tro == -1)
        {
            int m = (p + u) / 2;
            if (v[m] == x)
                tro = m;
            else if (v[m] < x)
                p = m + 1;
            else
                u = m - 1;
        }
        return tro;
    }

    public static void Scambio(ref int x, ref int y)
    {
        int t = x;
        x = y;
        y = t;
    }

    public static void ScambioReali(ref float x, ref float y)
    {
        float t = x;
        x = y;
        y = t;
    }

    public static void ScambioCaratteri(ref char x, ref char y)
    {
        char t = x;
        x = y;
        y = t;
    }

    public static void SelectionSort(int[] v, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int imin = i;
            for (int j = i + 1; j < n; j++)
            {
                if (v[imin] > v[j])
                    imin = j;
            }
            if (imin != i)
                Scambio(ref v[i], ref v[imin]);
        }
    }

    public static void ScambioStringhe(ref string s1, ref string s2)
    {
        string temp = s1;
        s1 = s2;
        s2 = temp;
    }

    public static void SelectionSortCaratteri(string[] v, int n, int[] vAlunni)
    {
        for (int i = 0; i < n - 1; i++)
        {
            int imin = i;
            for (int j = i + 1; j < n; j++)
            {
                if (string.CompareTo(v[imin], v[j]) > 0)
                    imin = j;
            }
            if (imin != i)
            {
                ScambioStringhe(ref v[i], ref v[imin]);
                Scambio(ref vAlunni[i], ref vAlunni[imin]);
            }
        }
    }
}
