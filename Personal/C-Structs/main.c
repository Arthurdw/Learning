#include <stdio.h>
#include <string.h>

struct Student {
    char name[50];
    char major[50];
    int age;
    double gpa;
};

int main() {
    struct Student student1;
    student1.age = 22;
    student1.gpa = 3.2;
    strcpy(student1.name, "Jeffry");
    strcpy(student1.major, "Computer Science");

    struct Student student2;
    student2.age = 18;
    student2.gpa = 4.6;
    strcpy(student2.name, "Johnny");
    strcpy(student2.major, "Cyber Crime");

    printf("%s | %d years old - studies %s (%f)\n", student1.name, student1.age, student1.major, student1.gpa);
    printf("%s | %d years old - studies %s (%f)\n", student2.name, student2.age, student2.major, student2.gpa);

    return 0;
}
