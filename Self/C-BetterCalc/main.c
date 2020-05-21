#include <stdio.h>

int main() {
    char operator;
    double num1, num2;

    printf("Enter a number:");
    scanf("%lf", &num1);
    printf("Enter a operator:");
    scanf(" %c", &operator);
    printf("Enter a second number:");
    scanf("%lf", &num2);

    if (operator == '+') printf("Result: %f", num1 + num2);
    else if (operator == '-') printf("Result: %f", num1 - num2);
    else if (operator == '*') printf("Result: %f", num1 * num2);
    else if (operator == '/') printf("Result: %f", num1 / num2);
    else printf("Invalid operator!");

    return 0;
}
