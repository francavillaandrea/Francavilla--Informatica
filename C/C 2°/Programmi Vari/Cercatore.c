#include<stdio.h>
void cerca(int [], int, int);
void main()
{
    int size=10,v,cont=0;
    int array[size];
    srand(time(0));
    for(int i=0;i<size;i++)
    {
       array[i]=rand()%50+50;
       printf("%d\n",array[i]);
    }
     printf("Inserisci il numero per sapere se \x82 presente nell'array ");
    scanf("%d",&v);
    cerca(array,size, v);
}
void cerca(int list[], int lung, int x)
{
    int cont;
    for(int i=0;i<lung;i++)
    {
        if(list[i]==x)
        {
            printf("Il numero %d \x82 presente nell'array",x);
            cont=cont+1;
        }
    }
    if(cont==0)
        printf("Questo valore non \x82 presente nell'array");
    return 0;

}
