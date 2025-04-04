#include <stdio.h>
void main()
{
    int n,scelta,ris=0;
    do
    {
      printf("Inserisci un numero intero positivo: ");
    scanf("%d", &n);
    }while(n<0);
    printf("Scegli un'operazione:\n1. Calcolo del fattoriale di %d\n 2. Verifica se %d \x82 un numero primo\n3. Sommatoria dei fattoriali dei numeri pari compresi tra 0 e %d\n",n,n,n);
    scanf("%d", &scelta);
    switch (scelta) {
        case 1:
            ris = fattoriale(n);
            printf("Il fattoriale di %d \x82: %d\n", n, ris);
            break;
        case 2:
            ris = N_Primo(n);
            if (ris)
                printf("%d \x82 un numero primo.\n", n);
            else
                printf("%d non \x82 un numero primo.\n", n);
            break;
        case 3:
            ris = sommatoriaFattoriali(n);
            printf("La sommatoria dei fattoriali dei numeri pari compresi tra 0 e %d \x82: %d\n", n, ris);
            break;
        default:
            printf("Scelta non valida.\n");
    }

    return 0;
}

int fattoriale(int n) {
    int ris = 1;
    if (n != 0 && n != 1) {
        for (int i = 2; i <= n; i++) {
            ris *= i;
        }
    }
    return ris;
}

int N_Primo(int n) {
    int np = 1;
    if (n <= 1)
        np = 0;
    else {
        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                np = 0;
                break;
            }
        }
    }
    return np;
}

int sommatoriaFattoriali(int n) {
    int somma = 0;
    for (int i = 2; i <= n; i += 2) {
        somma += fattoriale(i);
    }
    return somma;
}
