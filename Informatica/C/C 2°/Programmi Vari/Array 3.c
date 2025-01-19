#include <stdio.h>
int main()
{
int list1[5]; //si dichiara un array da 20 elementi
//L'utente scrive in ogni elemento un valore da tastierda
for(int i=0;i<5;i++)//for(int i=1;i<20;i++)
{printf("Inserisci il %d\xf8 elemento all'indirizzo %d\n",i+1, i);
    scanf("%d", &list1[i]);
}
for(int i=0;i<5;i++)
{
printf("%d ",list1[i]);
 }
return 0;
}


