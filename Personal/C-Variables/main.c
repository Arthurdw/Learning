// ©Arthurdw | Learning C

#include <stdio.h>

int main() {
    char userName[] = "Arthur";      // Stores a collection of characters
    int userAge = 16;                // Stores an integer;
    printf("Hello, I'm %s and I'm %d years old!\n", userName, userAge);     // Lets display it now!

    // Lets now change the age variable.
    userAge = userAge + 20;
    printf("In 20 years I will be %d years old!", userAge);

    return 0;
}
