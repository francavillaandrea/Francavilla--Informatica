#include <stdio.h>
void main()
{
int nmax,ni;
printf("Inserici il numero massimo di cui vuoi avere la tabellina \n");
scanf("%d", &nmax);
printf("Inserici il numero minimo di cui vuoi avere la tabellina \n");
scanf("%d", &ni);
 for(int i=ni;i<=nmax;i++)
 {for(int l=ni;l<=nmax;l++)

 {printf("%d\t", l*i);
 }
   printf("\n");

 }
 return 0;
}
