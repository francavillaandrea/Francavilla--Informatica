#include <stdio.h>
#include <stdlib.h>
void main()
{
    int n;
    srand(time(NULL));
    n=rand()%21+1;
    printf("%d", n);
    return 0;

}
