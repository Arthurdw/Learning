#include <stdio.h>

int main() {
    // Writing to a file:

    // ALl other content gets cleared.
    FILE * fPointerWrite = fopen("test.txt", "w");
    fprintf(fPointerWrite, "Hello, World!\n");
    fclose(fPointerWrite);

    // All other content stays, just appends to the content.
    FILE * fPointerAppend = fopen("test.txt", "a");
    fprintf(fPointerAppend, "Added Hello World!");
    fclose(fPointerAppend);

    // Reading a line from a file:
    char line1[256];
    char line2[256];
    FILE * fPointerReadLine = fopen("test.txt", "r");
    fgets(line1, 256, fPointerReadLine);
    fgets(line2, 256, fPointerReadLine);
    fclose(fPointerReadLine);
    printf("%s%s", line1, line2);

    return 0;
}
