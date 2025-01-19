#include <stdio.h>
#include <stdlib.h>
int f_casuale(int, int);
void main()
{
    int size = 20, presente = 0, aux, list[size];
    srand(time(0));
    for (int i = 0; i < size; i++)
    {
        do
        {
            aux = f_casuale(0, 19);
            presente = 0;
            for (int j = 0; j < i; j++)
                if (aux == list[j])
                    presente = 1;
        } while (presente == 1);
        list[i] = aux;
    }
    for (int i; i < size; i++)
        printf("%d ", list[i]);
}
int f_casuale(int min, int max)
{
    int a, b, n;
    b = min;
    a = max - min + 1;
    n = rand() % a + b;
    return n;
}
