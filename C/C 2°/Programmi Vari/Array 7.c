#include <stdio.h>
void main()
{
    int pos,valore,size=20;
    int list[size];
do
{
  printf("Inserisci la posizione in cui vuoi inserire il dato");
scanf("%d", &pos);
}while(pos<1||pos>20);
printf("Scrivi il valore da aggiungere");
scanf("%d",&valore);
for (int i=size-1;i>pos;i++)
    list[i]=list[i-1];
list[pos-1];
for (int i=0;i<size;i++)
    printf("%d\t",list[i]);
return 0;
}
