#include <stdio.h>
#include <string.h>

int main() {
    char frase[100];
    int n, i;
    printf("Inserisci una frase: ");
    fgets(frase, sizeof(frase), stdin);
    frase[strcspn(frase, "\n")] = '\0';
    printf("Inserisci il numero di volte da ripetere la frase: ");
    scanf("%d", &n);
    for (i = 0; i < n; i++) {
        printf("%s\n", frase);
    }
    return 0;
}
