#include <stdio.h>

int main() {
    int nums[3][4] = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
    };

    // printf("%d %d %d\n", nums[0][0], nums[1][0], nums[2][0]);
    // printf("%d %d %d\n", nums[0][1], nums[1][1], nums[2][1]);
    // printf("%d %d %d\n", nums[0][2], nums[1][2], nums[2][2]);
    // printf("%d %d %d\n", nums[0][3], nums[1][3], nums[2][3]);

    // Does the same as the statement above this:
    for (int i = 0; i < 4; i ++) {
        for (int j = 0; j < 3; j++) printf("%d ", nums[j][i]);
        printf("\n");
    }

    return 0;
}
