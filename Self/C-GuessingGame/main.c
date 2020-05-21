#include <stdio.h>

int main() {
    int guess = 0, guesses = 0;

    while (guess != 5 && guesses < 3) {
        printf("What do you think the secret number is?\n");
        scanf("%d", &guess);
        guesses++;
    }
    printf(guesses < 3 ? "You win!" : "You lost!");
    return 0;
}
