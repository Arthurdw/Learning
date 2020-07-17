#include <stdio.h>

int main() {
    int exampleInt = 123;
    char exampleChar = 'A';
    double exampleDouble = 123.123;

    printf("Memory location for exampleInt: %p\n", &exampleInt);
    printf("Memory location for exampleDouble: %p\n", &exampleDouble);
    printf("Memory location for exampleChar: %p", &exampleChar);

    return 0;
}
