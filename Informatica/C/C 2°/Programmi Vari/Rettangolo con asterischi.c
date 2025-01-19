#include <stdio.h>
void main()
{
    int b,h, i, i2;
    do
    {
      printf("Introduci il valore della base del rettangolo");
    scanf("%d", &b);
    printf("Introduci il valore dell'altezza del rettangolo");
    scanf("%d", &h);
    }while(b<=0 || h<=0);
    for(i=1;i<=h;i++)
    {
        for(i2=1;i2<=b;i2++)
            printf("* ");
        printf("\n");
    }
return 0;
}

