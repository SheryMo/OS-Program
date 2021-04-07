#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
int main(int argc,char *argv[])
{
    char buffer[12000];
    int fd = open("/usr/root/list.txt", O_RDWR, 0644);
    int size = read(fd, buffer, sizeof(buffer));
    char s[] = "Linux Programmer!\n";
    int sizee = write(fd,s,sizeof(s));
    return 0;
}
