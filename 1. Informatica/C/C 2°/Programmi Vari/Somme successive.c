#include <stdio.h>

void main()
{
    float n1, n2, n3, n4, somma;
    printf("Inserisci 4 valori\n");
    scanf("%f", &n1);
    scanf("%f", &n2);
    scanf("%f", &n3);
    scanf("%f", &n4);
    if(n1>0)
        somma=n1;
    if(n2>0)
        somma=somma+n2;
    if(n3>0)
        somma=somma+n3;
    if(n4>0)
        somma=somma+n4;
    printf("La somma dei valori positivi \x82 %f", somma);
    return 0;
}
