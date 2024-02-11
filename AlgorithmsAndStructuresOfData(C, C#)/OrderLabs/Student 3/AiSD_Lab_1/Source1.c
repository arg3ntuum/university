#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <string.h>

#define K 50
#define SIZE 6
void client_input(int** massive, int N) {
    char temp[K];
    int pomilka = 0;
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
        {
            do {
                pomilka = 0;
                printf("Матриця[%d][%d] = ", i, j);
                scanf_s("%s", &temp, K - 1);
                for (int a = 0; a < strlen(temp); a++)
                    if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
                        pomilka = 1;
                if (pomilka == 1)
                    printf("Можна лише числа!\n");
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

    int massive[SIZE] = {9, 3 ,4, 6, 3, 6};
    int* pointer_massive;

    static float matrix[] = { 34, 99 };
    float* pointer_matrix;

    //2.1
    puts("\n2.1");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %i\n", i, massive[i]);

    //2.2
    puts("\n2.2");
    puts("\nЗаповнити масив даних: ");

    for (int i = 0; i < SIZE; i++)
        scanf_s("%i", &massive[i]);

    //2.3
    puts("\n2.3");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %i\n", i, massive[i]);

    //2.4
    puts("\n2.4");
    pointer_massive = massive;
    printf("Адрес вказiвника - %p\n", pointer_massive);
    printf("Адрес масиву - %p\n", massive);
    printf("Те що у вказiвнику:\n");
    for (int i = 0; i < SIZE; i++)
        printf("%d. %i\n", i, *(pointer_massive + i));

    //2.5
    puts("\n2.5");
    pointer_massive = massive;
    for (int i = 0; i < SIZE; i++)
        printf("%d. %i\n", i, *(pointer_massive + i));

    //2.6
    puts("\n2.6");
    for (int i = 0; i < 2; i++)
        printf("%d. %f\n", i, matrix[i]);

    puts("\nЗаповнiть масив даними(2 елемента й 1 число-пiдтвердження): ");
    for (int i = 0; i < 2; i++)
        scanf_s("%f\n", &matrix[i]);

    for (int i = 0; i < 2; i++)
        printf("%d. %f\n", i, matrix[i]);

    getchar();
    //2.7
    puts("\n2.7");
    int size = 2;
    float* pointer_matrix_ = (float*)malloc(size * sizeof(float));
    float matrix_m[2];
    for (int i = 0; i < size; i++)
        pointer_matrix_[i] = 0;

    for (int i = 0; i < sizeof(pointer_matrix_) / sizeof(*(pointer_matrix_ + 1)); i++)
        printf("%d. %f\n", i, pointer_matrix_[i]);

    puts("\nЗаповнiть масив даними(2 елемента й 1 число-пiдтвердження): ");
    for (int i = 0; i < size; i++)
    {
        float num = 0;
        scanf_s("%f\n", &num);
        *(pointer_matrix_ + i) = num;
        matrix_m[i] = num;
    }

    puts("\nBказiвник масив: ");
    for (int i = 0; i < size; i++)
        printf("%i. %f\n", i, *(pointer_matrix_ + i));

    puts("\nМасив просто: ");

    for (int i = 0; i < size; i++)
        printf("%i. %f\n", i, matrix_m[i]);

    //2.8
    puts("\n2.8");
    free(pointer_matrix_);
    getchar();
    int N = 2;

    int** matrix_2d = (int**)malloc(N * sizeof(int*));
    for (int i = 0; i < N; i++)
        matrix_2d[i] = (int*)malloc(N * sizeof(int));
    client_input(matrix_2d, N);
    out_matrix(matrix_2d, N);
    free(matrix_2d);

    //2.9
    puts("\n2.9");
    char matrix_3[2][3][2];
    char something[] = "something";
    for (int i = 0; i < 2; i++)
        for (int j = 0; j < 3; j++)
            for (int k = 0; k < 2; k++)
                matrix_3[i][j][k] = something[i + j + k];
    printf("Елемент трьовимiрного масиву по iндексу: %c", matrix_3[1][2][1]);

    //2.10
    puts("\n2.10");
    printf("Елемент трьовимiрного масиву по вказiвнику: %c", *(*(*(matrix_3 + 1) + 2) + 1));

    //2.11
    puts("\n2.11");
    char * matrix_3point =  &matrix_3;
    //matrix_3point 
    // printf("\naddress pointer = %p\naddress matrix = %p", matrix_3point, matrix_3);//
    char* num = ((1 * 3 + 2 * 2 + 1) * sizeof(char));
    printf("Елемент трьовимiрного масиву по вказiвнику через вказiвник: %c",
        *(matrix_3point + 1 * 3 + 2 * 2 + 4
            ));//*(matrix_3point + 1 * 3 + 2 * 2 + 1)


    puts("");
}
//matrix_3[2][3][2];
//matrix_3[1][2][1]