#include <stdio.h>
void main()
{
    float lato1, lato2, lato3;
    printf("******************************\n");
    printf("Dimmi i tre lati del triangolo\n");
    scanf("%f",&lato1);
    scanf("%f",&lato2);
    scanf("%f",&lato3);
    if (lato1 <0 || lato2 <0|| lato3 <0)
    {
        printf("Non puoi mettere valori minori di zero scemotto\n");
    }
     else if (lato1==lato2 && lato2==lato3 && lato1==lato3)
    {
      printf("Il triangolo di lato %f, %f, %f \x82 equilatero", lato1, lato2, lato3);
    }
    else if (lato1==lato2 && lato2!=lato3 && lato1!=lato3)
    {
        printf("Il triangolo di lato %f, %f, %f \x82  isoscele",lato1, lato2, lato3);
    }
    else
    {
       printf("Il triangolo di lato %f, %f, %f \x82  scaleno\n",lato1, lato2, lato3);
    }
    printf("******************************\n");
    return 0;
}
