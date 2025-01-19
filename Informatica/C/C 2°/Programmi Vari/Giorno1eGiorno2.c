#include <stdio.h>
int n_gg(int mese);
void main()
{
    int mese1, mese2, giorno1, giorno2;
    do{
     printf("Inserisci il primo mese");
     scanf("%d", &mese1);
    }while(mese1<1||mese1>12);
    n_gg(mese1);
    do
{
    printf("Introduci il primio giorno\n");
    scanf("%d", &giorno1);
}while(giorno1<1||giorno1>n_gg(mese1));
for (int i=1;i<mese;i++)
    {
        somma+=n_giorni(i);
    }
    somma+=giorno;
    printf("Il giorno %d/%d \x82 il giorno %d dall'inizio dell'anno\n", giorno, mese, somma);
return 0;


}
