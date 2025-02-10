#include <stdio.h>
#include <stdlib.h>
int main()
{
    int dado1, dado2, lanci;
    srand(time(NULL));
    do
    {
       dado1=rand()%6+1;
       dado2=rand()%6+1;
       printf("%d,%d\n", dado1, dado2);
       lanci++;
    }while (dado1!=dado2);
    printf("Ci sono voluti %d lanci per avere le cifre uguali", lanci);
    return 0;
    }