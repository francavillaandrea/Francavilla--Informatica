#include <stdio.h>
#include <stdlib.h>
void main ()
{
    int dado1, dado2, ind;
    srand(time(NULL));
    do{                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             //NEIK è UN OBESOLEG
        dado1=rand()%6+1;
        dado2=rand()%6+1;
        printf("%d %d", dado1, dado2);
        ind++;
    }while (dado1!=dado2);
    printf("Ci sono voluti %d lanci per ottenere i dadi uguali", ind;
    return 0;
}
