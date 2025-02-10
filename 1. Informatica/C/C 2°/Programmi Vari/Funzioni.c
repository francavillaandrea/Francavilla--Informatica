#include <stdio.h>
int n_giorni(int);//DICHIARAZIONE DELLA FUNZIONE
int
void main()
{
int giorno, mese, max, somma=0;
do{
   printf("Inserisci il mese \n");
    scanf("%d",&mese);
}while(mese<1||mese>12);
//(max=n_giorni(mese);//RICHIAMO DELLA FUNZIONE
do
{
    printf("Introduci il giorno\n");
    scanf("%d", &giorno);
}while(giorno<1||giorno>n_giorni(mese));
for (int i=1;i<mese;i++)
    {
        somma+=n_giorni(i);
    }
    somma+=giorno;
    printf("Il giorno %d/%d \x82 il giorno %d dall'inizio dell'anno\n", giorno, mese, somma);
return 0;
}
int n_giorni(int x) //DEFINIZIONE DELLA FUNZIONE
{
    int n;
    switch(x)
    {
    case 2:
        n=28;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        n=30;
        break;
    default:
        n=31;
    }
 return n;
}
