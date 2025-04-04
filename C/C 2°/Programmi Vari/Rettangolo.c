#include <stdio.h>

void main()
{
    int base=0, altezza=0, area=0;
    printf("_________________Calcolo Area________________________\n");
    printf("Inserisci la base del rettangolo\n");
    scanf("%d", &base);
    printf("Inserisici l'altezza del rettangolo\n");
    scanf("%d", &altezza);
    area=base*altezza;
    printf("L'area del rettangolo di base %d e di altezza %d \x82 %d\n",base,altezza,area);
    printf("_____________________________________________________");
    return 0;
}
