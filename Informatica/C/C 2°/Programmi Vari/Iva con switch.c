#include <stdio.h>
void main()
{
    int iva1=4, iva2=5, iva3=10, iva4=22, tipo_prodotti;
    float imponibile,prezzo_tot,prezzo,quantita, diva;
    do
    {
     printf("Reinserisci il valore\n");
     scanf("%d", &tipo_prodotti);
    }
    while (tipo_prodotti>4);
    printf("inserisci il numero corrispondente alla tipologia del prodotto\n 1- Frutta,verdura,latticini\n 2- Trasporti, dispositivi medici, alimenti di prima infanzia\n 3- Altri alimenit, energia, medicinali\n 4- altri prodotti\n");
    scanf("%d", &tipo_prodotti);
    printf("Inserisci il prezzo del prodotto\n");
    scanf("%f", &prezzo);
    printf("Quanto hai comprato di quel prodotto?\n");
    scanf("%f", &quantita);
    switch(tipo_prodotti){
    case 1:
        imponibile=quantita*prezzo;
        diva=(iva1*imponibile)/100;
        prezzo_tot=imponibile+diva;
        printf("L'imponibile \x82 %f, il valore dell'iva \x82 %f, il prezzo totale \x82 %f", imponibile, diva, prezzo_tot);
        break;
    case 2:
        imponibile=quantita*prezzo;
        diva=(iva2*imponibile)/100;
        prezzo_tot=imponibile+diva;
        printf("L'imponibile \x82 %f, il valore dell'iva \x82 %f, il prezzo totale \x82 %f", imponibile, diva, prezzo_tot);
        break;
    case 3:
        imponibile=quantita*prezzo;
        diva=(iva3*imponibile)/100;
        prezzo_tot=imponibile+diva;
        printf("L'imponibile \x82 %f, il valore dell'iva \x82 %f, il prezzo totale \x82 %f", imponibile, diva, prezzo_tot);
        break;
    case 4:
        imponibile=quantita*prezzo;
        diva=(iva4*imponibile)/100;
        prezzo_tot=imponibile+diva;
        printf("L'imponibile \x82 %f, il valore dell'iva \x82 %f, il prezzo totale \x82 %f", imponibile, diva, prezzo_tot);
        break;

    }

}
