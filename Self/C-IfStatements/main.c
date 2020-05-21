#include <stdio.h>

int biggest(int num1, int num2, int num3);  // Returns the biggest value

int main() {
    printf("%d\n", biggest(10, 20, 30));
    printf("%d\n", biggest(30, 10, 20));
    printf("%d", biggest(20, 30, 10));
    return 0;
}

int biggest(int num1, int num2, int num3) {
    // if (num1 < num2 && num2 > num3) return num2;
    // else if (num1 < num3) return num3;
    // else return num1;
    return num1 < num2 && num2 > num3 ? num2 : num1 < num3 ? num3 : num1;
}
