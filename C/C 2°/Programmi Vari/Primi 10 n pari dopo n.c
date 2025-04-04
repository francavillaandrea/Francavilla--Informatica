#include <stdio.h>
void main(){int n,ni;do{printf("Digita il numero\n");scanf("%d", &n);}while(n<=0);if(n%2!=0){ni = n+1;}else {ni=n+2;}for(int i=ni,z=1;z<=10;i=i+2,z++){printf("%d.%d\n",z,i);}return 0;}
