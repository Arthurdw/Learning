#include <stdio.h>

void sayHi();
char* getHelloWorld();
double cube(double num);
void sayHiSpecific(char name[]);

int main() {
    sayHi();
    sayHiSpecific("Arthur");
    printf("%s", getHelloWorld());
    printf("The answer for the cube(3) is %f!", cube(3.0));
    return 0;
}

void sayHi() {
    printf("Hello there!\n");
}

void sayHiSpecific(char name[]) {
    printf("Hello there %s!\n", name);
}

char* getHelloWorld() {
    return "Hello, World!\n";
}

double cube(double num) {
    return num * num * num;
}