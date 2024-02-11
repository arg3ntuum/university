#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>
#include "AiSD_L1.h"
#define K 50
void client_input(int** massive, int N) {
    char temp[K];
    int pomilka = 0;
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
        {
            do {
                pomilka = 0;
                printf("Мatrix[%d][%d] = ", i, j);
                scanf_s("%s", &temp, K - 1);
                for (int a = 0; a < strlen(temp); a++)
                    if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
                        pomilka = 1;
                if (pomilka == 1)
                    printf("Вводите только числа!\n");
                else {
                    massive[i][j] = atoi(temp);
                    break;
                }
            } while (1);
        }
}
void out_matrix(int** massive, int N) {
    for (int i = 0; i < N; i++) {
        for (int j = 0; j < N; j++)
            printf("%4d", massive[i][j]);
        puts("");
    }
}
int main()
{
    setlocale(LC_ALL, "Rus"); //Язык

    char massive[6] = {'9', '9' ,'9' ,'9' ,'9' };
    char* pointer_massive;

    static long matrix[] = {10, 234};
    long* pointer_matrix;

    float matrix_3[2][3][2];
    float*** matrix_3point;
    //2.1
    puts("\n2.1");
    for (int i = 0; i < strlen(massive); i++)
        printf("%d. %c\n", i, massive[i]);

    //2.2
    puts("\n2.2");
    puts("\nЗаполните массив данными: ");

    for (int i = 0; i < strlen(massive); i++)
        scanf_s("%c", &massive[i]);
    
    //2.3
    puts("\n2.3");
    for (int i = 0; i < strlen(massive); i++)
        printf("%d. %c\n", i, massive[i]);

    //2.4
    puts("\n2.4");
    pointer_matrix = massive;
    printf("Адресс указателя - %p\n", pointer_matrix);
    printf("Адресс массива - %p\n", massive);
    printf("Содержимое указателя - %s\n", pointer_matrix);

    //2.5
    puts("\n2.5");
    pointer_massive = massive;
    for (int i = 0; i < strlen(massive); i++)
        printf("%d. %c\n", i, *(pointer_massive + i));

    //2.6
    puts("\n2.6");
    for (int i = 0; i < sizeof(matrix) / sizeof(matrix[0]); i++)
        printf("%d. %i\n", i, matrix[i]);

    puts("\nЗаполните массив данными(вводите два числа, третье дял подтверждения): ");
    for (int i = 0; i < sizeof(matrix) / sizeof(matrix[0]); i++)
        scanf_s("%i ", &matrix[i]);

    for (int i = 0; i < sizeof(matrix) / sizeof(matrix[0]) ; i++)
        printf("%d. %i\n", i, matrix[i]);

    //2.7
    puts("\n2.7");
    int size = 2;
    long *pointer_matrix_ = (long*)malloc(size * sizeof(long));
    long matrix_m[2];
    for (int i = 0; i < size; i++)
        pointer_matrix_[i] = 0;

    for (int i = 0; i < sizeof(pointer_matrix_) / sizeof(long); i++)
        printf("%d. %i\n", i, pointer_matrix_[i]);

    puts("\nЗаполните массив данными(вводите два числа, третье дял подтверждения): ");
    for (int i = 0; i < size; i++)
    {
        long num = 0;
        scanf_s("%ld ", &num);
        *(pointer_matrix_ + i) = num;
        matrix_m[i] = num;
    }

    puts("\nУказатель массив: ");
    for (int i = 0; i < size; i++)
        printf("%i. %ld\n", i, *(pointer_matrix + i));

    puts("\nМассив обычный: ");

    for (int i = 0; i < size; i++)
        printf("%i. %ld\n", i, matrix_m[i]);

    //2.8
    puts("\n2.8");
    free(pointer_matrix_);

    int N = 2 ;
    int** matrix_2d = (int**)malloc(N * sizeof(int*));
    for (int i = 0; i < N; i++)
        matrix_2d[i] = (int*)malloc(N * sizeof(int));
    client_input(matrix_2d, N);
    out_matrix(matrix_2d, N);
    free(matrix_2d);
    
    //2.9
    puts("\n2.9");
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 3; j++)
            for (int k = 0; k < 2; k++)
                matrix_3[i][j][k] = (float)i + j + k;
    printf("Елемент трехмерного массива по индексу: %f", matrix_3[1][2][1]);

    //2.10
    puts("\n2.10");
    printf("Елемент трехмерного массива по указателю: %f", *(* (*(matrix_3 + 1) + 2) + 1) );

    //2.11
    puts("\n2.11");
    matrix_3point = &matrix_3;
    printf("Елемент трехмерного массива по указателю через указатель: %f", *(matrix_3point + 1 * 3 + 2 * 2 + 1));
    puts("");
}
//printf("Num in 3D array by new pointer: %d\n", *(matrix_3point + 1 * 3 + 2 * 2 + 1));
//    float matrix_3[2][3][2];
//      matrix_3[1][2][1]