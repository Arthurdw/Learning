#include <stdio.h>
// #include <string.h>

int main() {
    char items[4][20];  // Better way to store the 3 variables.
    // strcpy_s(items[0], sizeof("test"), "test");
    printf("Roses are {color}\n{plural-noun} are blue\nI love {celebrity}\n");
    printf("Enter a color:");
    scanf("%s", items[0]);
    printf("Enter a plural noun:");
    scanf("%s", items[1]);
    printf("Enter a celebrity:");
    scanf("%s%s", items[2], items[3]);
    printf("Roses are %s\n%s are blue\nI love %s%s\n", items[0], items[1], items[2], items[3]);

    // char color[20], plural_noun[20], celebrityF[20], celebrityL[20];

    // printf("Roses are {color}\n{plural-noun} are blue\nI love {celebrity}\n");
    // printf("Enter a color:");
    // scanf("%s", color);
    // printf("Enter a plural noun:");
    // scanf("%s", plural_noun);
    // printf("Enter a celebrity:");
    // scanf("%s%s", celebrityF, celebrityL);
    // printf("Roses are %s\n%s are blue\nI love %s%s\n", color, plural_noun, celebrityF, celebrityL);
    return 0;
}
