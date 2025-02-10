#include <stdio.h>
#include <string.h>

void main() {
    char frase[100], nome[10];
    int n, i;
    printf("Scrivi il nome del file: ");
    scanf("%c", &nome);
    printf("Scrivi una frase: ");
    fgets(frase, sizeof(frase), stdin);
    frase[strcspn(frase, "\n")] = '\0';
    printf("Metti il numero di volte da ripetere la frase: ");
    scanf("%d", &n);
    FILE *file = fopen("&c.txt", "w", nome[10]);
    if (file == NULL) {
        printf("Non riesco ad aprire il file .");
        return 1;
    }
    for (i = 0; i < n; i++) {
        fprintf(file, "%s\n", frase);
    }
    fclose(file);
   printf("Frase ripetuta %d volte nel file 'Gratacul.txt' nella cartella dove si trova questo file .\n", n);
    return 0;
}
