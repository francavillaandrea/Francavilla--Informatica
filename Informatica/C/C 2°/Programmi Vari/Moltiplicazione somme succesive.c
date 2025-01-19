
#include <stdio.h>

int main() {
    int num1, num2, risultato = 0;
    do {
        printf("Inserisci il primo numero positivo: ");
        scanf("%d", &num1);
        if (num1 <= 0) {
            printf("Il numero deve essere maggiore di zero. Riprova.\n");
        }
    } while (num1 <= 0);
    do {
        printf("Inserisci il secondo numero positivo: ");
        scanf("%d", &num2);
        if (num2 <= 0) {
            printf("Il numero deve essere maggiore di zero. Riprova.\n");
        }
    } while (num2 <= 0);

    for (int i = 0; i < num2; i++) {
        risultato += num1;
    }
    printf("Il risultato della moltiplicazione \x82: %d\n", risultato);

    return 0;
}

