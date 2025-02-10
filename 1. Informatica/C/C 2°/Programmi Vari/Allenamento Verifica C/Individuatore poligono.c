#include <stdio.h>
void main()
{
    int nlati;
    do
    {
        printf("Quanti lati ha il tuo poligono?\n");
        scanf("%d", &nlati);
    }while (nlati<3 || nlati>6);
    switch (nlati){
        case 3:
        printf("Il tuo poligono è un triangolo");
        break;
        case 4:
        printf("Il tuo poligonok è un quadrato\rettangolo");
        break;
        case 5:
        printf("Il tuo poligono è un pentagono");
        default:
        printf("Il tuo poligono è un esagono");
        break;
    }
    return 0;
}