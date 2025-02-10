#include <stdio.h>
void main()
{
    float voto;
    do
    {
      printf("Inserisci un voto\n");
        scanf("%f",&voto);
    } while (voto<=0 || voto>10);   
    if (voto>=6)
    printf("Il voto %f \x82 sufficiente", voto);
    else 
    printf("Il voto %f \x82 insufficiente", voto);
    return 0;

}