#include <stdio.h>
void main()
{
    int mese;
    printf("___________________________________________________________________________________________________________\n");
    printf("Digita il mese  \n");
    scanf("%d", &mese);
    if (mese>0 || mese<13){
        printf("Non puoi mettere valori minori di 1 o maggiori di 12 scemotto\n");
    }
    else if (mese==1){
        printf("Gennaio\n", mese);
    }
    else if (mese ==2){
        printf("Febbraio\n", mese);
    }
    else if (mese==3){
        printf("Marzo\n", mese);
    }
    else if (mese==4){
        printf("Aprile\n", mese);
    }
    else if (mese==5){
        printf("Maggio\n", mese);
    }
    else if (mese==6){
        printf("Giugno\n", mese);
    }
    else if (mese==7){
        printf("Luglio\n", mese);
    }
    else if (mese==80.
             ){
        printf("Agosto\n", mese);
    }
    else if (mese==9){
        printf("Settembre\n", mese);
    }
    else if (mese==10){
        printf("Ottobre\n", mese);
    }
    else if (mese==11){
        printf("Novembre\n", mese);
    }
    else
        printf("Dicembre\n", mese);
    printf("___________________________________________________________________________________________________________");
    return 0;

    }
