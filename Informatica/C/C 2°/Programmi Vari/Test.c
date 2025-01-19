#include <stdio.h>

int main() {
    int num1, num2, risultato = 0;

    // Richiesta del primo numero
    do {
        printf("Inserisci il primo numero positivo: ");
        scanf("%d", &num1);
        if (num1 <= 0) {
            printf("Il numero deve essere maggiore di zero. Riprova.\n");
        }
    } while (num1 <= 0);

    // Richiesta del secondo numero
    do {
        printf("Inserisci il secondo numero positivo: ");
        scanf("%d", &num2);
        if (num2 <= 0) {
            printf("Il numero deve essere maggiore di zero. Riprova.\n");
        }
    } while (num2 <= 0);

    // Calcolo della moltiplicazione utilizzando il metodo delle somme successive
    for (int i = 0; i < num2; i++) {
        risultato += num1;
    }

    // Stampare il risultato
    printf("Il risultato della moltiplicazione è: %d\n", risultato);

    return 0;
}
