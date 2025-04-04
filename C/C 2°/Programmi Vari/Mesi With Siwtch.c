#include <stdio.h>
void main()
{
    int mese;
    printf("___________________________________________________________________________________________________________\n");
    printf("Digita il mese\n");
    scanf("%d", &mese);
    switch (mese)
    {
    case 2:
        printf("ha 28 ggg\n");
        break;
    case 4:
        printf("ha 30gg\n");
        break;
    case 6:
        printf("Ha 30 giorni\n");
        break;
    case 10:
        printf("Ha 31 giorni\n");
        break;
    case 11:
        printf("Ha 30 giorni\n");
        break;
        default:
        printf("non \x82 un mese");
    }
    printf("___________________________________________________________________________________________________________");
    return 0;

    }
    //30:Aprile Giugno Stemmebre Novembre 28:Febbraio 31:Gennaio Marzo Maggio Luglio Agosto Ottobre Dicembre
    //1,3,5,7,8,10,12 ha 31 giorni 4,6,9,11 hanno 30gg

