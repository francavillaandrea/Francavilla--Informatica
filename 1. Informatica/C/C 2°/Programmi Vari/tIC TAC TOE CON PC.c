#include <stdio.h>
#include <stdlib.h>
#include <time.h>

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

int mossa_valida(int riga, int colonna) {
    return (riga >= 1 && riga <= 3 && colonna >= 1 && colonna <= 3 && griglia[riga - 1][colonna - 1] == ' ');
}

void mossa_computer() {
    int riga, colonna;
    printf("Turno del computer (O):\n");

    // Strategia del computer: cerca di vincere o bloccare il giocatore
    // Prova a vincere
    for (riga = 1; riga <= 3; riga++) {
        for (colonna = 1; colonna <= 3; colonna++) {
            if (mossa_valida(riga, colonna)) {
                griglia[riga - 1][colonna - 1] = 'O';
                if (controlla_vittoria('O')) {
                    return;
                }
                griglia[riga - 1][colonna - 1] = ' ';
            }
        }
    }

    // Se non può vincere, cerca di bloccare il giocatore
    for (riga = 1; riga <= 3; riga++) {
        for (colonna = 1; colonna <= 3; colonna++) {
            if (mossa_valida(riga, colonna)) {
                griglia[riga - 1][colonna - 1] = 'X';
                if (controlla_vittoria('X')) {
                    griglia[riga - 1][colonna - 1] = 'O';
                    return;
                }
                griglia[riga - 1][colonna - 1] = ' ';
            }
        }
    }

    // Se non può vincere né bloccare, fa una mossa casuale
    do {
        riga = rand() % 3 + 1;
        colonna = rand() % 3 + 1;
    } while (!mossa_valida(riga, colonna));

    griglia[riga - 1][colonna - 1] = 'O';
}

int main() {
    int riga, colonna;
    char giocatore = 'X';
    srand(time(NULL));
    inizializza_griglia();

    printf("Benvenuto al gioco del Tris!\n");

    while (1) {
        stampa_griglia();

        if (giocatore == 'X') {
            printf("Giocatore %c, inserisci riga (1-3) e colonna (1-3): ", giocatore);
            scanf("%d %d", &riga, &colonna);
            if (!mossa_valida(riga, colonna)) {
                printf("Mossa non valida, riprova.\n");
                continue;
            }
        } else {
            mossa_computer();
        }

        griglia[riga - 1][colonna - 1] = giocatore;

        if (controlla_vittoria(giocatore)) {
            printf("Il giocatore %c ha vinto!\n", giocatore);
            break;
        } else if (griglia[0][0] != ' ' && griglia[0][1] != ' ' && griglia[0][2] != ' ' &&
                   griglia[1][0] != ' ' && griglia[1][1] != ' ' && griglia[1][2] != ' ' &&
                   griglia[2][0] != ' ' && griglia[2][1] != ' ' && griglia[2][2] != ' ') {
            printf("Pareggio!\n");
            break;
        } else {
            giocatore = (giocatore == 'X') ? 'O' : 'X';
        }
    }

    return 0;
}
