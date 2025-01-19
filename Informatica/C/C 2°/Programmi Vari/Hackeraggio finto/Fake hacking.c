#include <stdio.h>
#include <windows.h>

int main()
{
    int x;
    HANDLE output = GetStdHandle(STD_OUTPUT_HANDLE);
    do{
        SetConsoleTextAttribute(output, FOREGROUND_GREEN|FOREGROUND_INTENSITY);
         printf("001101110110010010100100100000110011");-
        scanf("%d", &x);
    } while(x<=0);

   return 0;
}
