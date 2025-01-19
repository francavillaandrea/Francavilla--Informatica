#include <stdio.h>
void main ()
{
int n,d,r,s=0,t;
do
{
    printf("Inserire il valore iniziale\n");
    scanf("%d",&n);
    printf("\n");
}
while(n<0);
t=n;
for(int k=1;k<=t;k++)
{
  for(int i=1;i<=t;i++)
{

    r=n%i;
    if(r==0)
    {
        s=s+i;
    }

}
}
if(s==n)
{
    printf("%d\t",n);
}
n=n-1;
s=0;


return 0;
}



