#include<stdio.h>
void main()
{
    int size=10,v,cont=0;
    int list[size];
    srand(time(0));
    for(int i=0;i<size;i++)
    {
       list[i]=rand()%50+51;
    }
    printf("Inserisci il numero per sapere se \x82 presente nell'array");
    scanf("%d",&v);
    for(int i=0;i<size;i++)
    {
        if(list[i]==v)
        {
            printf("Il numero %d \x82 presente nell'array",v);
            cont=cont+1;
        }
    }
    if(cont==0)
        printf("Questo valore non \x82 presente nell'array");

}
