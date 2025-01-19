#include <stdio.h>
void main()
{
int in;
int list1[20]; //si dichiara un array da 20 elementi
//scriviamo in ogni elemento il valore del suo index
for(int i=0;i<20;i++)//for(int i=1;i<20;i++)
    list1[i]=i;
             //list1[i-1]=i-1;
for(int i=0;i<20;i++)
{
  in++;
    printf("%d. %d\t\n",in,list1[i]);
}
return 0;
}


