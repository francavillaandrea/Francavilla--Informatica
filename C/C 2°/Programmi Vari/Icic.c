#include <stdio.h>
void main()
{
    int size=5;
    int list[10];
    for(int i=0;i<size;i++)
    {
        printf("Inserici il %d\xf8 valore dell'array", i+1);
        scanf("%d", &list[i]);
    }
    for(int i=0;i<size;i++)
        printf("%d\n", list[i]);
    return 0;
}