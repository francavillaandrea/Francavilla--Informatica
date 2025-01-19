#include <stdio.h>
#include <stdlib.h>
int f_casuale(int,int);
int main()
{
    int scelta;
    srand(time(NULL));
    printf("scegli i limiti del numero casuale\n");
    do{
       printf("1-- Fra 50 e 100\n2-- fra 0 e 100\n3-- fra 1 e 150\n");
    scanf("%d", &scelta);
    }while(scelta<1 || scelta>3);

    for( int i=0; i<=20;i++)
        switch(scelta)
    {
        case 1: printf("%d\n", f_casuale(50,100));break;
        case 2: printf("%d\n", f_casuale(0,100));break;
        case 3: printf("%d\n", f_casuale(1,150));break;
    }
return 0;
}
int f_casuale(int min,int max)
{
    int a, b, n;
    b=min;
    a=+max-min+1;
    n=rand()%a+b;
return n;
}

