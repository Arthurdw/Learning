#include <stdio.h>

int main() {
    double num1, num2;

    printf("Enter the first number:");
    scanf_s("%lf", &num1);
    printf("Enter the second number:");
    scanf_s("%lf", &num2);

    printf("Here are the results:\n"
           "Addition: %f\nSubtraction: %f\nMultiplication: %f\nDivision: %f",
           num1 + num2, num1 - num2, num1 * num2, num1 / num2);

    return 0;
}
