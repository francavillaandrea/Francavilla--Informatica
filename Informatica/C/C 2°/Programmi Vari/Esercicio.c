#include <stdio.h>

int main() {
    int start, end, i, sum = 0;

    // Richiesta all'utente di inserire il primo e l'ultimo numero
    printf("Inserisci il primo numero: ");
    scanf("%d", &start);
    printf("Inserisci l'ultimo numero: ");
    scanf("%d", &end);

    // Verifica se il primo numero inserito è dispari, se sì, lo incrementa di 1
    if (start % 2 != 0) {
        start++;
    }

    // Calcola la somma dei numeri pari compresi tra start ed end
    for (i = start; i <= end; i += 2) {
        sum += i;
    }

    printf("La somma dei numeri pari compresi tra %d e %d è: %d\n", start, end, sum);

    return 0;
}
