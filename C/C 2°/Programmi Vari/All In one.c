#include <stdio.h>
void quadrato();
void rettangolo();
void triangolo();
void rombo();
void main()
{
    char scelta;
    do
    {
      printf("Quale figura vuoi disegnare\n");
    printf("Q --- quadrato\nR --- rettangolo\nT --- triangolo\nr --- rombo\n");
    scanf("%c", &scelta);
    }while(scelta!='Q'&& scelta!='R' && scelta!='T' && scelta!='r');
    switch(scelta)
    {
    case 'Q':
        quadrato();
        break;
    case 'R':
        rettangolo();
        break;
    case 'T':
        triangolo();
        break;
    case 'r':
        rombo();
        break;
    }
return 0;
}
 void quadrato()
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
return l, i, i2;
 }
 void rettangolo()
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
return b,h, i, i2;
 }
 void triangolo()
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
return h, i, i2;
 }
 void rombo()
{
    int lato;
    do
    {
        printf("Inserisci il lato: ");
        scanf("%d",&lato);
    }while(lato<1);
    for (int i=1;i<=lato;i++)
        {
        for (int j=1;j<=lato-i;j++)
            printf("  ");
        for (int j=1;j<=2*i-1;j++)
            printf("* ");
        printf("\n");
        }
    for (int i=lato-1;i>=1;i--)
        {
        for (int j=1;j<=lato-i;j++)
            printf("  ");
        for (int j=1;j<=2*i-1;j++)
            printf("* ");
        printf("\n");
        }
}

