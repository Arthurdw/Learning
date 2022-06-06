// ©Arthurdw | Learning

#include <stdio.h>

int main() {

    // Round numbers:
    short aa = 81;                      // A round number! (From -32,768 to 32,767)
    unsigned short ab = 81;             // A round number! (From 0 to 65,535)

    int ba = 81;                        // A round number! (From -2,147,483,648 to +2,147,483,647)
    unsigned int bb = 81;               // A positive round number! (From 0 to 4,294,967,295)

    long ca = 81;                       // A round number! (From -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
    unsigned long cb = 81;              // A round number! (From 0 to 18,446,744,073,709,551,615)

    // Decimals:
    float da = 1.f / 81;                // A decimal which has 6 decimal places! (From 1.2E-38 to 3.4E+38)

    double ea = 1.0 / 81;               // A decimal which has 15 decimal places! (From 2.3E-308 to 1.7E+308)
    long double eb = 1.0 / 81;          // A decimal which has 19 decimal places! (From 3.4E-4932 to 1.1E+4932)

    // Characters:
    char fa = 'A';                      // An ASCII value represented by its value. (From -128 to 127 or 0 to 255)
    unsigned char fb = 'A';             // An ASCII value represented by its value. (From 0 to 255)
    signed char fc = 'A';               // An ASCII value represented by its value. (From -128 to 127)
    char ff[] = "Arthur";               // A collection (Array) of characters, which can form a sentence or word.

    // Arrays:
    int ga[] = {1, 2};                  // A collection (Array) with the size of 2 which contains 2 characters.
                                        // On index 0 we have 1 and on index 1 we have 2. (In this case)
                                        // This collection (Array) its type is from the integer data type, this means
                                        // that all rules that are applied in the integer data type are applied to each
                                        // value that is in this collection (Array). We can make a collection (Array)
                                        // for each data type.

    return 0;
}
