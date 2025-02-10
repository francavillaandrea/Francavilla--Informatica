#include <stdio.h>
#include <stdlib.h>
int main()
{
    int size,max,min;
    int array[10];
    srand(time(NULL));
    size =10;
    for(int i=0;i<size;i++)
    {
        array[i]=rand()%51+50;
        printf("%d\n");
    }for (int i=0;i<size;i++)
    {
        if (i==1)
        {
            min = array[0];
            max=array[0];
        }if (array[i]>max)
        {
         max=array[i];
        }else if(array[i<min])
        {
            min=array[i];
        }
    }
    printf("Numero Massimo:%d\nNumero Minimo:%d", max,min);
    return 0;

}
