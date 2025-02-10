#include <stdio.h>

int main() {
    int N, i, j;
    
    printf("Inserisci il numero di colonne giocate (N): ");
    scanf("%d", &N);

    int ColonneVincenti[13], colonneGiocate[N][13], Risultati[N];

    printf("Inserisci i 13 risultati della colonna vincente:\n");
    for (i = 0; i < 13; i++) {
        scanf("%d", &ColonneVincenti[i]);
    }

    for (i = 0; i < N; i++) {
        printf("Inserisci i 13 risultati della colonna giocata %d:\n", i + 1);
        for (j = 0; j < 13; j++) {
            scanf("%d", &colonneGiocate[i][j]);
        }
    }

    for (i = 0; i < N; i++) {
        Risultati[i] = 0;
        for (j = 0; j < 13; j++) {
            if (colonneGiocate[i][j] == ColonneVincenti[j]) {
                Risultati[i]++;
            }
        }
    }

    for (i = 0; i < N; i++) {
        printf("Colonna giocata %d ha %d risultati esatti\n", i + 1, Risultati[i]);
    }

    return 0;
}
