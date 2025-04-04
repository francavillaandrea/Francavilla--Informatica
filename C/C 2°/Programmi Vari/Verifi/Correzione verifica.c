#include <stdio.h>
#include <stdlib.h>
void main()
{
    int nmin,nmax,tent,cont=0, diff,n;
    do{
       printf("Scegli la difficolta'\n 1) Facile, numero casuale tra 50 e 100\n 2) Medio, numero casuale tra 0 e 100\n 3) Difficile, numero casuale tra 1 e 150\n");
        scanf("%d", &diff);
    }while (diff<1 || diff>3);
    srand(time(0));
    switch (diff)
    {
    case 1:
        n=rand()%51+50;
        nmin=50;
        nmax=100;
    break;
    case 2:
        n=rand()%101;
        nmin=0;
        nmax=100;
    break;
    case 3:
        n=rand()%150+1;
        nmin=1;
        nmax=150;
    break;

    }
    do{
        do{
            printf("Inserisci un numero compreso tra %d e %d\n", nmin, nmax);
            scanf("%d", &tent);
        }while(tent<nmin||tent>nmax);
        cont ++;
        if (tent==n)
            printf("Hai vinto in %d tentativi\n", cont);
        else if (tent<n)
                printf("Il numero misterioso \x82 maggiore\n");
        else
            printf("Il numero misterioso \x82 minore\n");
    }while(tent!=n);
    return 0;
}
