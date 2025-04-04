#include <stdio.h>
void main()
{
    int h, i, i2;
    do
{
    printf("Introduci il valore dell'altezza del triangolo");
    scanf("%d", &h);
    }while(h<=0);
    for(i=1;i<=h;i++)
    {
        for(i2=1;i2<=h-i;i2++)
            printf("  ");
        for(i2=1;i2<=i*2-1;i2++)
            printf("* ");
        printf("\n");
    }
return 0;
}


