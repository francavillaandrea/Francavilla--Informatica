#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main() {
    int N, i;
    
    printf("Inserisci la dimensione dei vettori (N): ");
    scanf("%d", &N);

    int A[N], B[N];

    srand(time(NULL));

    for (i = 0; i < N; i++) {
        do {
            A[i] = rand() % 101;
        } while (A[i] % 2 != 0);

        do {
            B[i] = rand() % 101;
        } while (B[i] % 2 == 0);
    }

    printf("Vettore A (valori pari): ");
    for (i = 0; i < N; i++) {
        printf("%d ", A[i]);
    }
    printf("\n");

    printf("Vettore B (valori dispari): ");
    for (i = 0; i < N; i++) {
        printf("%d ", B[i]);
    }
    printf("\n");

    return 0;
}
