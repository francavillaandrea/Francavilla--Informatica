#include <stdio.h>
#define size 10
void main()
{char carattere;
int lunghezza, palindromo=0,i;
char parola[size];
printf("Inserisci una parola seguita da *\n");
do{
 scanf("%c", &carattere);
if (carattere=='*')
  lunghezza=i;
 else
  {parola[i]=carattere;
 i++;}
}while (carattere!='*'&&i<size);
printf("\n");
for(int j=0;j<=lunghezza/2;j++)
    {
    printf("%c\t%c\n", parola[j], parola[lunghezza-1-j]);
    if(parola[j]!=parola[lunghezza-1-j])
    palindromo=1;
    }
if (palindromo==0)
    printf("La parola \x82 palindroma");
else
    printf("la parola non \x82 palindroma");
return 0;}
