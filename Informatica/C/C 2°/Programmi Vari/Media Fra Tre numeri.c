#include <stdio.h>
void main()
{
    float n1=0, n2=0, n3=0, media=0;
    printf("_________________Calcolo Media________________________\n");
    printf("Dimmi il primo numero di cui vuoi fare la media\n");
    scanf("%f", &n1);
    printf("Dimmi il second numero di cui vuoi fare la media\n");
    scanf("%f", &n2);
    printf("Dimmi il terzo numero di cui vuoi fare la media\n");
    scanf("%f", &n3);
    media = (n1+n2+n3)/3;
    printf("la media tra i numeri '%f,%f,%f \x82 %f\n",n1,n2,n3,media);
    printf("_____________________________________________________");
    return 0;
}
