#include <stdio.h>

int main() {
    float cost1, cost2, cost3, cost4, cost5;
    float maxCost, minCost;

    printf("Inserisci il costo del primo smartphone: ");
    scanf("%f", &cost1);
    printf("Inserisci il costo del secondo smartphone: ");
    scanf("%f", &cost2);
    printf("Inserisci il costo del terzo smartphone: ");
    scanf("%f", &cost3);
    printf("Inserisci il costo del quarto smartphone: ");
    scanf("%f", &cost4);
    printf("Inserisci il costo del quinto smartphone: ");
    scanf("%f", &cost5);

    maxCost = cost1;
    minCost = cost1;

    if (cost2 > maxCost) maxCost = cost2;
    if (cost3 > maxCost) maxCost = cost3;
    if (cost4 > maxCost) maxCost = cost4;
    if (cost5 > maxCost) maxCost = cost5;

    if (cost2 < minCost) minCost = cost2;
    if (cost3 < minCost) minCost = cost3;
    if (cost4 < minCost) minCost = cost4;
    if (cost5 < minCost) minCost = cost5;

    printf("Il costo piu' alto e': %.2f\n", maxCost);
    printf("Il costo piu' basso e': %.2f\n", minCost);

    return 0;
}
