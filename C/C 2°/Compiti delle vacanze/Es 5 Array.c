#include <stdio.h>

int main() {
    int N, i, j;
    
    printf("Inserisci il numero di colonne giocate (N): ");
    scanf("%d", &N);

    int winningColumn[13], playedColumns[N][13], correctResults[N];

    printf("Inserisci i 13 risultati della colonna vincente:\n");
    for (i = 0; i < 13; i++) {
        scanf("%d", &winningColumn[i]);
    }

    for (i = 0; i < N; i++) {
        printf("Inserisci i 13 risultati della colonna giocata %d:\n", i + 1);
        for (j = 0; j < 13; j++) {
            scanf("%d", &playedColumns[i][j]);
        }
    }

    for (i = 0; i < N; i++) {
        correctResults[i] = 0;
        for (j = 0; j < 13; j++) {
            if (playedColumns[i][j] == winningColumn[j]) {
                correctResults[i]++;
            }
        }
    }

    for (i = 0; i < N; i++) {
        printf("Colonna giocata %d ha %d risultati esatti\n", i + 1, correctResults[i]);
    }

    return 0;
}
