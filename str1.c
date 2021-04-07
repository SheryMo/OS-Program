#include <stdio.h>
int foo(int n)
{
    char text[2048];
    if(n==0)
        return 0;
    else{
        int i=0;
        for(i; i<2048; i++)
            text[i] = '\0';
        printf("text_%d=0x%x, pid=%d\n", n, text, getpid());
        sleep(5);
        foo(n-1);
    }
}
int main(int argc, char **argv)
{
    foo(6);
    return 0;
}