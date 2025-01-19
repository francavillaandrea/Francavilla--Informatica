#include <stdio.h>
void main()
{
    int n;
    printf("Inserisci un numero qualsiasi\n");
    scanf("%d", &n);
    if (n%2==0){
        printf("Il numero %d è pari\n",n);
    }else
    {
        printf("Il numero %d \x82 dispari\n",n);
        printf("Il numero pari più vicino sarebbe %d", ++n);
    }
return 0;
}