#include <stdio.h>

int main() {
    int dividendo, divisore, risultato = 0;
    do {
        printf("Inserisci il dividendo positivo: ");
        scanf("%d", &dividendo);
        if (dividendo <= 0) {
            printf("Il dividendo deve essere maggiore di zero. Riprova.\n");
        }
    } while (dividendo <= 0);
    do {
        printf("Inserisci il divisore positivo: ");
        scanf("%d", &divisore);
        if (divisore <= 0) {
            printf("Il divisore deve essere maggiore di zero. Riprova.\n");
        }
    } while (divisore <= 0);

    while (dividendo >= divisore) {
        dividendo -= divisore;
        risultato++;
    }
    printf("Il quoziente della divisione \x82: %d\n", risultato);

    return 0;
}
