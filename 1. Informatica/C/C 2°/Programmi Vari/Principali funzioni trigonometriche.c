#include <math.h>
#include <stdio.h>
#define USER_MATH_DEFINES
float conv_rad(float);
void main()
{float ang, ris,n,potenza;
char scelta;
printf("Inserisci la lettera corrispondente alla funzione trigonometrica desiderata\n");
printf("S-- Seno\nC-- Coseno\nT-- Tangente\nR-- Radice quadrata\nP-- Potenza\n");
scanf("%c",&scelta);
switch(scelta)
{
  case 'S':
    printf("inserisci l'angolo\n");
    scanf("%f",&ang);
    ris=sin(conv_rad(ang));
    printf("Il seno dell'angolo di %f gradi cio\x82 %f radianti \x82: %f ",ang,conv_rad(ang),ris);
    break;
case 'C':
    printf("inserisci l'angolo\n");
    scanf("%f",&ang);printf("inserisci l'angolo\n");
    scanf("%f",&ang);
    ris=cos(conv_rad(ang));
    printf("Il coseno dell'angolo di %f gradi cio\x82 %f radianti \x82: %f ",ang,conv_rad(ang),ris);
    break;
case 'T':
    printf("inserisci l'angolo\n");
    scanf("%f",&ang);
    ris=tan(conv_rad(ang));
    printf("La tangente dell'angolo di %f gradi cio\x82 %f radianti \x82: %f ",ang,conv_rad(ang),ris);
    break;
case 'R':
    printf("inserisci il valore\n");
    scanf("%f", &n);
    ris=sqrt(n);
    printf("la radice quadrata di %f \x82 %f", n, ris);
    break;
case 'P':
    printf("Inserisci un numero\n");
    scanf("%f", &n);
    printf("Inserisci il numero a cui vuoi elevare il numero precedente\n");
    scanf("%f", &potenza);
    ris=pow(n,potenza);
    printf("%f alla %f \x82 %f", n,potenza,ris);
    break;
}
}
float conv_rad(float x)
{
    float rad;
    rad=x*M_PI/180;
    return rad;
}
