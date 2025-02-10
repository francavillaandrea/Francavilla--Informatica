#include <stdio.h>
#include <stdlib.h>
#define size 40
int f_casuale(int, int);
void stampa(int[], int);
void main()
{
    int casuale[size], ripetizioni[10];
    int index, estratta;
    srand(time(0));
    for(int i=0; i<10; i++)
        ripetizioni[i]=0;
    for(int i=0; i<size; i++)
    {
        casuale[i]=f_casuale(1,10);
    }
    for(int i=0; i<size; i++)
    {
      do{
        estratta=f_casuale(1,10);
        }while(ripetizioni[estratta-1]==4);
    casuale[i]=estratta;
    ripetizioni[estratta-1]++;
    }
   stampa(casuale, size );
   printf("\n******\n");
  stampa(ripetizioni,10);
   printf("\n******\n");
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
void stampa(int list[], int lung)
{
    for(int i=0;i<lung;i++)
        printf("%d\n", list[i]);
    return 0;
}
