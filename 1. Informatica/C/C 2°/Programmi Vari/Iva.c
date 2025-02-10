#include <stdio.h>
int main()
{
    int tipologia;
    float prezzo,quantita;
    float prezzofinale,imponibile,iva;
    float somma_totale_pazzurda;
    float iva_totale;
    float imponibile_totale;
   do{
        do{
            printf("Introduci la quantita:");//qui abbiamo fatto l'azione
            scanf("%f",&quantita);//qui abbiao fatto l'azione
        }while(quantita < 0);
        do
        {
            printf("Introduci il prezzo:");
            scanf("%f",&prezzo);
        }
        while (prezzo<0);
     do
     {
        printf ("il valore 1 corripnde ai seguenti prodotti (frutta,verdura,latte e derivati - 4%\n)");//abbiamo consegnato all'utente una det.tipologia di numero utilizzando un numero
        printf ("il valore 2 corripnde ai seguenti prodotti (trasporti,dispositivi medici,alimenti prima infanzia - 5%\n)");
        printf ("il valore 3 corripnde ai seguenti prodotti (altri alimenti,energia,medicinali - 10%\n)");
        printf ("il valore 4 corripnde ai seguenti prodotti (altri prodotti - 22%\n)");
        printf ("quale \x82 il prodotto da te selezionato ?");//gli abbiamo chiesto la tipologia di prodotto selezionato
        scanf("%d",&tipologia);
     }
        while ((tipologia<1)||(tipologia>4));
        imponibile = quantita * prezzo;//abbiamo moltiplicato la quantita per il prezzo per poter trovare l'imponibile
        if (tipologia==1)//abbiamo svolto questo programma con l'uso di IF anche si poteva fare con lo SWITCH
        {
            iva=imponibile*4/100;//abbiamo moltplicato l'imponibile per la percentuale e diviso per 100
            prezzofinale=iva+imponibile;//abbiamo determinato il prezzo finale sommando iva e l'imponibile
            printf("il totale \x82 di %f\n",prezzofinale);//abbiamo dato all'utente il prezzo finale
        }
    else if (tipologia==2)
        {
            iva=imponibile*5/100;
            prezzofinale=iva+imponibile;
            printf("il totale \x82 di %f\n",prezzofinale);
        }
            else if (tipologia==3)
        {
            iva=imponibile*10/100;
            prezzofinale=iva+imponibile;
            printf("il totale \x82 di %f\n",prezzofinale);
        }
    else if (tipologia==4)
        {
            iva=imponibile*22/100;
            prezzofinale=iva+imponibile;
            printf("il totale \x82 di %f\n",prezzofinale);
        }
    else{
        printf("imput error\n");//abbiamo messo input error in caso di errore da parte dell'utente (come per esmpio la selezione di una tipologia non esistente)
    }
    somma_totale_pazzurda += prezzofinale;
    iva_totale += iva;
    imponibile_totale += imponibile;
    printf("L'imponibile totale \x82 %f mentre l'iva totale \x82 di %f, invece la somma totale \x82 di %f\n", imponibile_totale, iva_totale,somma_totale_pazzurda);
   }

   while(quantita != 0);
return 0;
}
