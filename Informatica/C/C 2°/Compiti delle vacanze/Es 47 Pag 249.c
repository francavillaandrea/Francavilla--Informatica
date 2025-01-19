#include <stdio.h>

int main() {
    int n, i;

    printf("Inserisci un numero intero positivo: ");
    scanf("%d", &n);

    if (n <= 0) {
        printf("Il numero deve essere positivo.\n");
    } else {
        printf("I primi %d numeri rettangolari sono:\n", n);
        for (i = 1; i <= n; i++) {
            printf("%d ", i * (i + 1));
        }
        printf("\n");
    }

    return 0;
}
