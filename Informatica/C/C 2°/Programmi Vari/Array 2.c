#include <stdio.h>
void main()
{
int list1[20]; //si dichiara un array da 20 elementi
//scriviamo in ogni elemento il valore del suo index
for(int i=0;i<20;i++)//for(int i=1;i<20;i++)
    list1[i]=i;          //list1[i-1]=i-1;
//printiamo il primo elemento ovvero quello con index  0
printf("Il primo elemento dell'array \x82 %d\n", list1[0]);
//printiamo l'ultimo elemento ovvero quello con index  19
printf("L'ultimo elemento dell'array \x82 %d\n", list1[19]);
//printiamo il primo elemento fuori dall'array ovvero quello con index  20
printf("Il primo elemento fuori dall'array \x82 %d\n", list1[20]);
return 0;
}

