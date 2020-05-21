#include <stdio.h>

int main() {
    // Pointers is the memory address of a variable.

    // Display our pointers:
    int exampleInt = 123;
    printf("Memory address for exampleInt: %p\n", &exampleInt);

    int * pExampleInt = &exampleInt;  // Create our pointer variable
    printf("Memory address for exampleInt: %p\n", pExampleInt);
    printf("Memory address for the pointer for exampleInt: %p\n", &pExampleInt);

    // Dereference pointers:
    printf("Data from the memory address %p using dereference: %d", &exampleInt, *&exampleInt);


    // Conclusion:
    // & --> Pointer        | Retrieves the memory address of the variable.
    // * --> Dereference    | Retrieves the stored value from a memory address.

    return 0;
}
