#include <stdio.h>
#include <stdlib.h>
void stampa(int[], int, int);
int cerca(int[],int, int);
void main()
{
    int size=5, estratto;
    int array_casuale[size];
    srand(time(0));
    for(int j=1;j<10;i++)
    {
        for(int i=0;i<size;i++)
        {
            do{
                estratto=rand()%90+1;
            }while(cerca(array_casuale,estratto,i)==1);
            array_casuale[i]=estratto;
        }
        stampa(array_casuale, size, j);
        printf("\n");
    }
    return 0;
}

int cerca(int array[], int x,  int max)
{
    int n=0;
    for(int i=0; i<max;i++)
        if (array[i]==x)
            n=1;
return n;
}

void stampa(int array[], int max, int k)
{
    printf("I valori estratti per la &d\xf8 ruota di ", k);
    switch(k)
    {
        case 1:
    }
}
