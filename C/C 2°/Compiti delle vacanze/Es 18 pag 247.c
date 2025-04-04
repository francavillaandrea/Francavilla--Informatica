#include <stdio.h>

int main() {
    int mostriCatturati, mostriSfuggiti;
    int puntiTotali;

    // Input del numero di mostri catturati e sfuggiti
    printf("Inserisci il numero di mostri catturati: ");
    scanf("%d", &mostriCatturati);

    printf("Inserisci il numero di mostri sfuggiti: ");
    scanf("%d", &mostriSfuggiti);

    // Calcolo del punteggio totale
    puntiTotali = (mostriCatturati * 5) - (mostriSfuggiti * 2);

    // Stampa del punteggio totale
    printf("Il punteggio totale è: %d\n", puntiTotali);

    return 0;
}