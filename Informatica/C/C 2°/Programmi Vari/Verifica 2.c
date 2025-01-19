#include <stdio.h>

int calcolafattoriale(int n) {
    int risultato = 1;
    if (n != 0 && n != 1) {
        for (int i = 2; i <= n; i++) {
            risultato *= i;
        }
    }
    return risultato;
}

int verificaNprimo(int n) {
    int primo = 1;
    if (n <= 1)
        primo = 0;
    else {
        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                primo = 0;
                break;
            }
        }
    }
    return primo;
}

int sommatoriaFattorialiPari(int n) {
    int somma = 0;
    for (int i = 2; i <= n; i += 2) {
        somma += calcolafattoriale(i);
    }
    return somma;
}

int main() {
    int numero;
    printf("Inserisci un numero intero positivo (compreso lo zero): ");
    scanf("%d", &numero);

    int scelta;
    printf("Scegli un'operazione:\n");
    printf("1. Calcolo del fattoriale di %d\n", numero);
    printf("2. Verifica se %d \x82 un numero primo\n", numero);
    printf("3. Sommatoria dei fattoriali dei numeri pari compresi tra 0 e %d\n", numero);
    scanf("%d", &scelta);

    int risultato = 0;

    switch (scelta) {
        case 1:
            risultato = calcolafattoriale(numero);
            printf("Il fattoriale di %d \x82: %d\n", numero, risultato);
            break;
        case 2:
            risultato = verificaNprimo(numero);
            if (risultato)
                printf("%d \x82 un numero primo.\n", numero);
            else
                printf("%d non \x82 un numero primo.\n", numero);
            break;
        case 3:
            risultato = sommatoriaFattorialiPari(numero);
            printf("La sommatoria dei fattoriali dei numeri pari compresi tra 0 e %d \x82: %d\n", numero, risultato);
            break;
        default:
            printf("Scelta non valida.\n");
    }

    return 0;
}
