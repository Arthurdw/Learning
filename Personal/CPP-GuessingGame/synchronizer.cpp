/* 
 * ©Arthurdw - 2020
 * A little C++ project to learn the basics of C++.
 */
#include <iostream>
#include <ctime>

void WriteIntroductionStory()
{
    std::cout << "Hey there! Welcome to the synchronizer, your one job is to make sure our codes match yours!\n";
    std::cout << "If you're wondering how you got here... well nevermind that, you should only be thinking on how to get out of here!\n";
    std::cout << "Good luck!\n\n";
}

bool CanPass(int SumNumbers, int ProductNumbers, int SumPlayerGuesses, int ProductPlayerGuesses)
{
    return SumPlayerGuesses == SumNumbers && ProductPlayerGuesses == ProductNumbers;
}

bool PlayGame(int LevelDifficulty)
{
    if (LevelDifficulty == 1)
        WriteIntroductionStory();
    else
        std::cout << "Okay, that was great! Here's another one, you are now on level " << LevelDifficulty << "\n\n";

    // Declare our base numbers:
    const int FirstNumber = (rand() % LevelDifficulty) + LevelDifficulty;
    const int SecondNumber = (rand() % LevelDifficulty) + LevelDifficulty;
    const int ThirdNumber = (rand() % LevelDifficulty) + LevelDifficulty;

    // Use our base numbers to calculate further:
    const int SumNumbers = FirstNumber + SecondNumber + ThirdNumber;
    const int ProductNumbers = FirstNumber * SecondNumber * ThirdNumber;

    // Display our hints:
    std::cout << "You have to enter the correct code to continue!\n";
    std::cout << "+ There are 3 numbers in the code! (SPLIT USING SPACES OR NEWLINE)\n";
    std::cout << "+ Those numbers add up to: " << SumNumbers << "\n";
    std::cout << "+ The product of those numbers is: " << ProductNumbers << "\n\n";

    // Retrieve our player guesses from the character input:
    int FirstPlayerGuess, SecondPlayerGuess, ThirdPlayerGuess;
    std::cin >> FirstPlayerGuess >> SecondPlayerGuess >> ThirdPlayerGuess;

    // Calculate our guesses:
    int SumPlayerGuesses = FirstPlayerGuess + SecondPlayerGuess + ThirdPlayerGuess;
    int ProductPlayerGuesses = FirstPlayerGuess * SecondPlayerGuess * ThirdPlayerGuess;

    if (CanPass(SumNumbers, ProductNumbers, SumPlayerGuesses, ProductPlayerGuesses))
    {
        std::cout << "Good, you passed!\n";
        if (LevelDifficulty == 1)
            std::cout << "But this is just the beginning...\n";
    }
    else
    {
        std::cout << "Hmm, seems like our codes don't match!\n";
        std::cout << "**RESTARTING PROJECT SYNCHRONIZER**\n\n";
    }
    return CanPass(SumNumbers, ProductNumbers, SumPlayerGuesses, ProductPlayerGuesses);
}

int main()
{
    srand(time(NULL));
    int LevelDifficulty = 1;
    int const MaxDifficulty = 10;
    while (LevelDifficulty <= MaxDifficulty)
    {
        if (PlayGame(LevelDifficulty))
            LevelDifficulty++;
        else
            LevelDifficulty = 1;

        std::cin.clear();
        std::cin.ignore();
    }
    std::cout << "Great, you're free to go now!";
    return 0;
}
