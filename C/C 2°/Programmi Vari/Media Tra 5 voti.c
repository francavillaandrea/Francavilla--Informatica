#include <stdio.h>
float voti(int);
void main()
{ float somma, media;
for(int i=1;i<=5;i++)
   somma+=voti(i);
media=somma/5;
printf("La media \x82 %f \n ", media);
return 0;
}
float voti(int n)
{
    float v;
    do
    {
      printf("Inserisci il %d voto\n", n);
      scanf("%f", &v);
    }while(v<2 || v>10);
    return v;
}


