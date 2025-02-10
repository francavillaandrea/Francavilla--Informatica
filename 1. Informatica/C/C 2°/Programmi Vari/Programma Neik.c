#include <stdio.h>

void main()
{
    int eta;
    char nome[20];
    char a;

    printf("Ciao come ti chiami brutto essere non identificato?");
    scanf("%s", &nome);

    printf("Quanti anni hai brutto essere piu' o meno identificato?");
    scanf("%d", &eta);

    printf("Ciao %s di anni %d \n", nome, eta);

    valuta_eta(eta);
    return 0;

}
void valuta_eta(int age)
{
    if(age<18)
    {
        printf("Sei nu minorenne");
    }
    else if(age==18)
    {
        printf("Sei appena maggiorenne");
    }
    else{
        printf("Sei proprio grande");
    }
}
