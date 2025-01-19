#include <stdio.h>

int progressivo(int);

int main()
{
    printf("Sono passati %d giorni.", progressivo(1) - progressivo(2));

    return 0;
}
int progressivo(int nmese)
{
    int mese, giorno, g_mese, somma =0, nmax = 0;
    do{
        printf("Inserire il %d mese:\n", nmese);
        scanf("%d", &mese);
    }while(mese > 12 || mese < 1);

    if(mese == 2)
        nmax = 28;
    else if(mese == 4 || mese == 6 || mese == 9 || mese == 11)
        nmax = 30;
    else{
        nmax = 31;
    }
    do{
        printf("Inserire il %d giorno:\n", nmese);
        scanf("%d", &giorno);
    }while(giorno > nmax || giorno < 1);

    for(int i = 1; i <= mese-1; i++){
        if(i == 2){
            g_mese = 28;
        }else{
            if(i == 4 || i == 6 || i == 9 || i == 11){
                g_mese = 30;
            }else{
                g_mese = 31;
            }
        }
        somma += g_mese;
    }
    return somma+giorno;
