
#include <stdio.h>
void main()
{
    int n=0, nmax=-621642612695195195195191451561651846515418181561, v;
    do
    {
    printf("Quanti numeri vuoi inserire?\n");
    scanf("%d",&n);
    }while(n<=0);
    for(int i=1;i<=n;i++)
    {
           printf("Metti il %d numero\n", i);
        scanf("%d", &v);
    if(v>nmax){
            nmax=v;
        }
        else if (v<nmax)
        {
            v=n;
        }

    }
    printf("il numero massimo tra i numeri inseriti \x82 %d", nmax);
    return 0;
}
