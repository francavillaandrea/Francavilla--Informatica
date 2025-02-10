#include <stdio.h>
#include <stdlib.h>
int f_casuale(int,int);
void print_array(int[],int);
void main()
{   int size=5;
    int array[size];
    int presente=0,x;
    srand(time(NULL));
    for(int k=0;k<9;k++)//for(int i=0;i<9;i++) non puoi usare sempre i se i cicli sono uno dentro l'altro
    {
      for(int i=0;i<size;i++)
    {
       do{
        presente=0;//mancava senza dopo il primo non esce sempre
       x=f_casuale(1,90);
       for (int j;j<j;j++)//for (int i;i<size;i++) attenzione i esiste già
       {
           if(array[j]==x)
           {
               presente=1;//presente==1;
           }
       }
    }while(presente==1);//while(presente=1); //confronto == assegnazione =

    array[i]= x;
    }
    printf("I valori della %d\xf8 ruota sono:\n",k+1);//mancava
    print_array(array, size);
        printf("\n");//mancava
    }

}
int f_casuale(int min, int max)
{
    int a, b, n;
    a=min;
    b=max-min+1;
     n=rand()%b+a;//n=rand()%a+b;
    return n;
}
void print_array(int array[],int size)
{

    for (int i=0; i<size;i++)
    {
        printf("%d\t", array[i]);//printf("%d ", array[i]); //era richiesta la tabulazione
    }
    return 0;
}

