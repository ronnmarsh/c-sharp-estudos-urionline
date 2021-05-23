#include<stdio.h>
#include<stdlib.h>
#include<string.h>

int main(){

    //variáveis
    char inicio[8];
    
    fgets(inicio,8,stdin);
    
    char* parte = strtok(inicio, " ");

    printf("%s", parte);


    return 0;
}