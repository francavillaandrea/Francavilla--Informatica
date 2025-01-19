#include <stdio.h>
#include <stdlib.h>
int f_casuale(int, int);
void main()
{
    srand(time(NULL));
    int size=40;
    int array1[size], array2[10];
    for(int j=0; j<10; j++)
        array2[j]=0;

    for(int i=0; i<size; i++)
    {
        array1[i]=f_casuale(1,10);
    }
    for(int i=0; i<size; i++)
    {
        for(int j=1; j<=10; j++)
        if (array1[i]==j)
            array2[j-1]=array2[j-1]+1;

    }
    for(int i=0; i<size; i++)
    {
        printf("%d  ", array1[i]);
    }
    printf("\n\n\n");
    for(int j=0; j<10; j++)
    {
       printf("il numero %d \x82 presente %d volte\n",j+1,array2[j]);
    }

     return 0;

}
int f_casuale(int min, int max)
{
    int a, b, n;
    b=min;
    a=max-min+1;
    n=rand()%a+b;
    return n;
}

