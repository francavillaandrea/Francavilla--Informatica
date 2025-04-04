#include <stdio.h>

void main()
{
    int lato=0, area=0;
    printf("_________________Calcolo Area________________________\n");
    printf("Quant'\x82  il lato di questo quadrato\n");
    scanf("%d", &lato);
    area= lato*lato;
    printf("L'area del quadrato di lato %d \x82 %d \n", lato, area);
    printf("_____________________________________________________");
        return 0;
}

