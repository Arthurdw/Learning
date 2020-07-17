// ©Arthurdw | Learning

#include <stdio.h>

int main() {
    // Just print a general piece of information:
    printf("Hello, World\n");

    // Print a (illegal) char:
    printf("Here is a quotation mark: \"");

    // Formatting:
    printf("%%");                       // Print a %.

    printf("%c", 'A');                  // Print a character.
    printf("%s", "Hello, World");       // Print a string.

    printf("%i", 123);                  // Print a integer.
    printf("%d", 123);                  // Print a decimal integer.
    printf("%o", 5);                    // Print a exponential octal number. (0-8)

    printf("%f", 123.123);              // Print a float.
    printf("%e", 123.123);              // Print a exponential floating-point number.
    printf("%u", 5);                    // Print a unsigned decimal number.

    printf("%x", 123);                  // Print a number in hexadecimal.

    return 0;
}
