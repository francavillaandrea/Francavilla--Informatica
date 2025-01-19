#include <stdio.h>
#include <stdlib.h>
void main ()
{
    int dado1, dado2, ind;
    srand(time(NULL));
    while (dado1!=dado2)
    {
        dado1=rand()%6+1;
        dado2=rand()%6+1;
        printf("%d,%d\n", dado1, dado2);
        ind++;
     }
    printf("Ci sono voluti %d lanci per ottenere i dadi uguali", ind);
    return 0;
}
