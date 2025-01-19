#include <stdio.h>
void main()
{
    int n,d,r,s=0,t;
    do{
    printf("Inserisci un numero\n");
    scanf("%d", &n);
    printf("\n");
    }while(n<=0);
    t=n;
    for(int k=1;k<=t;k++){
        for(int i=1;i<=t; i++){
            r=n%i;
            if(r==0)
            {
                if(i==n)
                {

                }
                else
                {
                d=i;
                s=s+d;
                }
            }
        }
    }
if (s==n)
{
    printf("%d\t",n);
}
n--;
s=0;
printf("somma:%d",s);
return 0;
}
