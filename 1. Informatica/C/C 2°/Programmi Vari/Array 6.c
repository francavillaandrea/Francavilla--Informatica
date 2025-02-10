#include <stdio.h>
void main()
{
    int size=5;
    int list[size], list2[size];
    for(int i=0; i<size;i++)
    {
        printf("Inserisci il %d\xf8 elemento dell'array", i+1);
        scanf("%d", &list[i]);
    }
    printf("\n\n");
    for(int i=0;i<size;i++)
        list2[i]=list[i];
    for(int i=0; i<size;i++)
      printf("Il %d\xf8 elemento del primo array \x82: %d--del secondo array \x82 :%d\n", i+1,list[i],list2[i]);
    return 0;
    }
