#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>

#define K 50
#define SIZE 6
int main()
{
    setlocale(LC_ALL, "Rus"); //Язык

    int massive[SIZE] = { 500, 10 ,7, 5, 3, 3 };
    int* pointer_massive;

    static char matrix[K] = "something";
    char* pointer_matrix;

    //2.1
    puts("\n2.1");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %i\n", i, massive[i]);

    //2.2
    puts("\n2.2");
    puts("\nЗаповнити масив даних: ");

    for (int i = 0; i < SIZE; i++)
        scanf_s("%d", &massive[i]);

    //2.3
    puts("\n2.3");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %d\n", i, massive[i]);

    //2.4
    puts("\n2.4");
    pointer_massive = massive;
    printf("Адрес вказiвника - %p\n", pointer_massive);
    printf("Адрес масиву - %p\n", massive);
    printf("Те що у вказiвнику:\n");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %d\n", i, *(pointer_massive + i));

    //2.5
    puts("\n2.5");
    pointer_massive = massive;
    puts("Massive: ");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %d\n", i, *(pointer_massive + i));

    printf("Уведiть %d елементiв: ", SIZE);
    for (int i = 0; i < SIZE; i++)
        scanf_s("%d", &pointer_massive[i]);
    
    puts("Massive: ");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %d\n", i, *(pointer_massive + i));

    //2.6
    puts("\n2.6");
    puts(matrix);

    puts("\nЗаповнiть масив даними: ");
    getchar();
    gets_s(matrix, K);

    puts("Записанi данi: ");
    puts(matrix);


    //2.7
    puts("\n2.7");
    int size = K;
    char* pointer_matrix_ = (char*)malloc(K * sizeof(char));
    char matrix_m[K];
    
    puts("\nЗаповнiть масив даними: ");
    gets_s(pointer_matrix_, K);

    puts("\nBказiвник масив: ");
    puts(pointer_matrix_);


    //2.8
    puts("\n2.8");
    free(pointer_matrix_);
    int N = K;

    char** matrix_2d = (int**)malloc(2 * sizeof(int*));
    for (int i = 0; i < 2; i++)
        matrix_2d[i] = (int*)malloc(N * sizeof(int));
    puts("Уведiть два слова: ");
    for (int i = 0; i < 2; i++) {
        printf("%d iтерацiя:", i);
        gets_s(matrix_2d[i], K);
    }
    
    for (int i = 0; i < 2; i++)
        puts(matrix_2d[i]);
    
    free(matrix_2d);

    //2.9
    puts("\n2.9");
    float matrix_3[2][3][2];

    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 3; j++)
            for (int k = 0; k < 2; k++)
                matrix_3[i][j][k] = i + j + k;
    printf("Елемент трьовимiрного масиву по iндексу: %f", matrix_3[1][2][1]);

    //2.10
    puts("\n2.10");
    printf("Елемент трьовимiрного масиву по вказiвнику: %f", *(*(*(matrix_3 + 1) + 2) + 1));

    //2.11
    puts("\n2.11");
    float* matrix_3point = &matrix_3;

    float* num = ((1 * 3 + 2 * 2 + 1) * sizeof(float));
    printf("Елемент трьовимiрного масиву по вказiвнику через вказiвник: %f",
        *(matrix_3point + 1 * 3 + 2 * 2 + 4
            ));


    puts("");
}