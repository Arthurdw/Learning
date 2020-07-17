#include <stdio.h>

int main() {
    // Normal expression:
    int num = 1;
    printf("%d\n", num);
    num = 2;
    printf("%d\n", num);

    // Constant expression: (Can't be changed)
    const int NUMBER = 1;
    printf("%d\n", NUMBER);
    // NUMBER = 2; -- > Gives error
    printf("%d\n", NUMBER);

    return 0;
}
