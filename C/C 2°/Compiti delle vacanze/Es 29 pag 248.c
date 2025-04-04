#include <stdio.h>

int main() {
    int giornoDellAnno, giorno, mese;

    printf("Inserisci un numero intero compreso tra 1 e 365: ");
    scanf("%d", &giornoDellAnno);

    if (giornoDellAnno <= 31) {
        mese = 1;
        giorno = giornoDellAnno;
    } else if (giornoDellAnno <= 59) {
        mese = 2;
        giorno = giornoDellAnno - 31;
    } else if (giornoDellAnno <= 90) {
        mese = 3;
        giorno = giornoDellAnno - 59;
    } else if (giornoDellAnno <= 120) {
        mese = 4;
        giorno = giornoDellAnno - 90;
    } else if (giornoDellAnno <= 151) {
        mese = 5;
        giorno = giornoDellAnno - 120;
    } else if (giornoDellAnno <= 181) {
        mese = 6;
        giorno = giornoDellAnno - 151;
    } else if (giornoDellAnno <= 212) {
        mese = 7;
        giorno = giornoDellAnno - 181;
    } else if (giornoDellAnno <= 243) {
        mese = 8;
        giorno = giornoDellAnno - 212;
    } else if (giornoDellAnno <= 273) {
        mese = 9;
        giorno = giornoDellAnno - 243;
    } else if (giornoDellAnno <= 304) {
        mese = 10;
        giorno = giornoDellAnno - 273;
    } else if (giornoDellAnno <= 334) {
        mese = 11;
        giorno = giornoDellAnno - 304;
    } else {
        mese = 12;
        giorno = giornoDellAnno - 334;
    }

    printf("Il giorno corrispondente è: %d/%d\n", giorno, mese);

    return 0;
}
