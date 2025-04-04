#include <stdio.h>
void main()
{
    int n,somma;
    do{
        printf("Inserisci un numero e ti diro se \x82 perfetto, abbondante o difettivo\n");
        scanf("%d", &n);
    }while(n<=0);
    for(int i = 1; i<=n-1; i++){
        if(n%i==0)
        {
            somma =i+somma;
            printf("I divisori :%d \n", i);
        }
    }
    if(somma==n){
        printf("%d \x82 un numero perfetto\n", n);
    }else if(somma>n){
        printf("%d \x82 un numero difettivo", n);
    }else
        printf("%d \x82 un numero abbondante", n);

        return 0;
}
