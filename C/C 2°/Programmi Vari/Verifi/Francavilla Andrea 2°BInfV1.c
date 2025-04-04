#include <stdio.h>
#include <stdlib.h>
void main()
{
    int ncas,diff,ni,tent;
    srand(time(NULL));
    do
    {
      printf("Scegli la difficolta'\n 1) Facile, numero casuale tra 50 e 100\n 2) Medio, numero casuale tra 0 e 100\n 3) Difficile, numero casuale tra 1 e 150\n");
    scanf("%d", &diff);
    }while (diff<1 || diff>3);
    switch(diff)
    {
       case 1:
           ncas =rand()%51+100;
            do
           {
              printf("Scrivi il tuo numero e ti diro' se \x82 più alto o più basso");
           scanf("%d",&ni);
           if (ncas>ni){
            printf("\x82 più alto");
            tent++;
           }
            else
                printf("\x82 più basso");
           }while(ni<50 || ni>100 && ni!=ncas);
            if(ni==ncas)
                printf("Bravo hai indovinato il numero dopo %d tentativi",tent);
           break;
       case 2:
            ncas=rand()%1+100;
            {
              printf("Scrivi il tuo numero e ti diro' se \x82 più alto o più basso");
           scanf("%d",&ni);
           if (ncas>ni){
            printf("\x82 più alto");
            tent++;
           }
            else
                printf("\x82 più basso");
           }while(ni<0 || ni>10 && ni!=ncas);
            if(ni==ncas)
                printf("Bravo hai indovinato il numero dopo %d tentativi",tent);
            break;
       case 3:
            ncas=rand()%2+150;
            {
              printf("Scrivi il tuo numero e ti diro' se \x82 più alto o più basso");
           scanf("%d",&ni);
           if (ncas>ni){
            printf("\x82 più alto");
            tent++;
           }
            else
                printf("\x82 più basso");
           }while(ni<1 || ni>150 && ni!=ncas);
           if(ni==ncas)
                printf("Bravo hai indovinato il numero dopo %d tentativi",tent);
            break;
return 0;
}


