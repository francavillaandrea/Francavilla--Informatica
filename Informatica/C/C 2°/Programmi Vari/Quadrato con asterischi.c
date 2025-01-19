#include <stdio.h>
void main()
{
    int l, i, i2;
    do
    {
      printf("Introduci il valore del lato del quadrato");
    scanf("%d", &l);
    }while(l<=0);

    for(i=1;i<=l;i++)
    {
        for(i2=1;i2<=l;i2++)
            printf("* ");
        printf("\n");
    }
return 0;
}
