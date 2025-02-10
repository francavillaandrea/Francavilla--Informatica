#include <stdio.h>

int main() {
    int N = 10;
    int A[N];
    int i, isPalindrome = 1;

    printf("Inserisci 10 elementi nel vettore:\n");
    for (i = 0; i < N; i++) {
        scanf("%d", &A[i]);
    }

    for (i = 0; i < N / 2; i++) {
        if (A[i] != A[N - 1 - i]) {
            isPalindrome = 0;
            break;
        }
    }

    if (isPalindrome) {
        printf("Il vettore è palindromo.\n");
    } else {
        printf("Il vettore non è palindromo.\n");
    }

    return 0;
}
