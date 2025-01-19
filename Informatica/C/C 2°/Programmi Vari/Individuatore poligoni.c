#include <stdio.h>
void main()
{
    int n;
    printf("___________________________________________________________________________________________________________\n");
    printf("Quanti lati ha il tuo poligono? \n");
    scanf("%d", &n);
    if (n <2 || n >8){
        printf("Non puoi mettere valori minori o uguali a 1 o maggiori di 8 scemotto\n");
    }
    else if (n==3){
        printf("Il tuo poligono da %d lati \x82 un triangolo\n", n);
    }
    else if (n==4){
        printf("Il tuo poligono da %d lati \x82 un quadrato \ rettangolo\n", n);
    }
    else if (n==5){
        printf("Il tuo poligono da %d lati \x82 un pentangono\n", n);
    }
    else if (n==6){
        printf("Il tuo poligono da %d lati \x82 un esagono\n", n);
    }
    else if (n==7){
        printf("Il tuo poligono da %d lati \x82 un ettagono\n", n);
    }
    else
        printf("Il tuo poligono da %d lati \x82 un ottagono\n", n);
    printf("___________________________________________________________________________________________________________");
    return 0;

    }


