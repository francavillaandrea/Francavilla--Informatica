#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int N, i;
    int sumEven, sumOdd;

    printf("Inserisci la dimensione dell' array (N): ");
    scanf("%d", &N);

    srand(time(NULL));

    do {
        sumEven = 0;
        sumOdd = 0;

        printf("Array generato: ");
        for (i = 0; i < N; i++) {
            int num = rand() % 11;  
            printf("%d ", num);

            if (i % 2 == 0) {
                sumEven += num;
            } else {
                sumOdd += num;
            }
        }
        printf("\n");

        printf("Somma degli elementi in posizione pari: %d\n", sumEven);
        printf("Somma degli elementi in posizione dispari: %d\n", sumOdd);

    } while (sumEven < sumOdd);

    printf("La somma degli elementi in posizione pari è maggiore o uguale alla somma di quelli in posizione dispari.\n");

    return 0;
}
