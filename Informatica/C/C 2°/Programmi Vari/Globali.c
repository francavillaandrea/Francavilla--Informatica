#include <stdio.h>
#include <windows.h>
int mihai=0;
void ira();
void main()
{
    HANDLE output = GetStdHandle(STD_OUTPUT_HANDLE);
 SetConsoleTextAttribute(output, FOREGROUND_GREEN|FOREGROUND_INTENSITY);
 int oleg=0;
    for(int vita=0; vita<3;vita++)
        {ira();
        mihai++;
        oleg++;}
    printf("Mihai:%d Oleg:%d\n", mihai, oleg);
}
void ira()
{
    int oleg=0;
    printf("Mihai:%d Oleg:%d\n", mihai, oleg);
    mihai++;
    oleg++;
}
