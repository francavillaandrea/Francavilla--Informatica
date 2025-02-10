#include <stdio.h>
void main()
{
    int g,m,somma=0;
    do{
       printf("Inserisci il mese\n");
    scanf("%d", &m);
    }while(m<=0 || m>12);
    switch(m)
    {
      case 1:
        do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
      case 2:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>28);
        somma=g+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
        case 3:
        do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
      case 4:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
        case 5:
        do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>30);
        somma=g+31+28+31+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
      case 6:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31+31+30;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
        case 7:
        do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>30);
        somma=g+31+28+31+31+30+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
      case 8:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31+31+30+31+30;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
        case 9:
        do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31+31+30+31+30+31;printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
      case 10:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31+31+30+31+30+31+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
    case 11:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>30);
        somma=g+31+28+31+31+30+31+30+31+31+31;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
    case 12:
         do{
          printf("Inserisci il giorno");
        scanf("%d", &g);
        }while(g<=0 || g>31);
        somma=g+31+28+31+31+30+31+30+31+31+31+30;
        printf("Il %d \x82 il %d giorno dell'anno", g, somma);
        break;
        return 0;
    }
}
