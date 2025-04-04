#include <stdio.h>

int main() {
    int anno;

    printf("Inserisci un anno: ");
    scanf("%d", &anno);

    if ((anno % 4 == 0 && anno % 100 != 0) || (anno % 400 == 0)) {
        printf("%d è un anno bisestile.\n", anno);
    } else {
        printf("%d non è un anno bisestile.\n", anno);
    }

    return 0;
}
