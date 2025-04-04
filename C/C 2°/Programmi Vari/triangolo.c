#include <stdio.h>

void main()
{
    int base=0, altezza=0;
    float area=0;
    printf("_________________Calcolo Area________________________\n");
    printf("Inserisci la base del triangolo\n");
    scanf("%d", &base);
    printf("Inserisci l'altezza del triangolo\n");
    scanf("%d", &altezza);
    area= (base*altezza)/2;
    printf("L'area del trinagolo di base %d e di altezza %d \x82 %f\n",base,altezza,area);
    printf("_____________________________________________________");
    return 0;
}
