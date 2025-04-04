#include <stdio.h>

void convertiInRomano(int numero) {
    while (numero >= 1000) {
        printf("M");
        numero -= 1000;
    }
    if (numero >= 900) {
        printf("CM");
        numero -= 900;
    }
    if (numero >= 500) {
        printf("D");
        numero -= 500;
    }
    if (numero >= 400) {
        printf("CD");
        numero -= 400;
    }
    while (numero >= 100) {
        printf("C");
        numero -= 100;
    }
    if (numero >= 90) {
        printf("XC");
        numero -= 90;
    }
    if (numero >= 50) {
        printf("L");
        numero -= 50;
    }
    if (numero >= 40) {
        printf("XL");
        numero -= 40;
    }
    while (numero >= 10) {
        printf("X");
        numero -= 10;
    }
    if (numero == 9) {
        printf("IX");
        numero -= 9;
    }
    if (numero >= 5) {
        printf("V");
        numero -= 5;
    }
    if (numero == 4) {
        printf("IV");
        numero -= 4;
    }
    while (numero >= 1) {
        printf("I");
        numero -= 1;
    }
}

int main() {
    int numero;

    printf("Inserisci un numero decimale tra 1 e 1000: ");
    scanf("%d", &numero);

    if (numero < 1 || numero > 1000) {
        printf("Numero fuori dal range specificato.\n");
    } else {
        printf("Il numero romano è: ");
        convertiInRomano(numero);
        printf("\n");
    }

    return 0;
}
