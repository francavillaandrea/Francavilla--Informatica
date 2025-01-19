#include <stdio.h>

char griglia[3][3];

void inizializza_griglia() {
    int i, j;
    for (i = 0; i < 3; i++) {
        for (j = 0; j < 3; j++) {
            griglia[i][j] = ' ';
        }
    }
}

void stampa_griglia() {
    int i, j;
    for (i = 0; i < 3; i++) {
        for (j = 0; j < 3; j++) {
            printf(" %c ", griglia[i][j]);
            if (j < 2) printf("|");
        }
        printf("\n");
        if (i < 2) printf("---+---+---\n");
    }
}

int controlla_vittoria(char simbolo) {
    int i;

    // Controllo righe e colonne
    for (i = 0; i < 3; i++) {
        if ((griglia[i][0] == simbolo && griglia[i][1] == simbolo && griglia[i][2] == simbolo) ||
            (griglia[0][i] == simbolo && griglia[1][i] == simbolo && griglia[2][i] == simbolo)) {
            return 1;
        }
    }

    // Controllo diagonali
    if ((griglia[0][0] == simbolo && griglia[1][1] == simbolo && griglia[2][2] == simbolo) ||
        (griglia[0][2] == simbolo && griglia[1][1] == simbolo && griglia[2][0] == simbolo)) {
        return 1;
    }

    return 0;
}

int main() {
    int riga, colonna;
    char giocatore = 'X';
    inizializza_griglia();

    printf("Benvenuto al gioco del Tris!\n");

    while (1) {
        stampa_griglia();
        printf("Giocatore %c, inserisci riga (1-3) e colonna (1-3): ", giocatore);
        scanf("%d %d", &riga, &colonna);

        if (griglia[riga][colonna] == ' ') {
            griglia[riga][colonna] = giocatore;

            if (controlla_vittoria(giocatore)) {
                printf("Il giocatore %c ha vinto!\n", giocatore);
                break;
            } else if (griglia[1][1] != ' ' && griglia[1][2] != ' ' && griglia[1][3] != ' ' &&
                       griglia[2][1] != ' ' && griglia[2][2] != ' ' && griglia[2][3] != ' ' &&
                       griglia[3][1] != ' ' && griglia[3][2] != ' ' && griglia[3][3] != ' ') {
                printf("Pareggio!\n");
                break;
            } else {
                giocatore = (giocatore == 'X') ? 'O' : 'X';
            }
        } else {
            printf("Casella già occupata, riprova.\n");
        }
    }

    return 0;
}

