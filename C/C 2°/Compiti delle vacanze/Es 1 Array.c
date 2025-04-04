#include <stdio.h>

int main() {
    int A[100], B[100], C[200];
    int nA, nB, nC, i, j, k, isPresent;

    printf("Inserisci il numero di elementi dell'array A: ");
    scanf("%d", &nA);
    printf("Inserisci gli elementi dell'array A:\n");
    for (i = 0; i < nA; i++) {
        scanf("%d", &A[i]);
    }

    printf("Inserisci il numero di elementi dell'array B: ");
    scanf("%d", &nB);
    printf("Inserisci gli elementi dell'array B:\n");
    for (i = 0; i < nB; i++) {
        scanf("%d", &B[i]);
    }

    nC = 0;
    for (i = 0; i < nA; i++) {
        C[nC] = A[i];
        nC++;
    }

    for (i = 0; i < nB; i++) {
        isPresent = 0;
        for (j = 0; j < nA; j++) {
            if (B[i] == A[j]) {
                isPresent = 1;
                break;
            }
        }
        if (!isPresent) {
            C[nC] = B[i];
            nC++;
        }
    }

    printf("L'array risultante C dall'unione di A e B è:\n");
    for (i = 0; i < nC; i++) {
        printf("%d ", C[i]);
    }
    printf("\n");

    return 0;
}
