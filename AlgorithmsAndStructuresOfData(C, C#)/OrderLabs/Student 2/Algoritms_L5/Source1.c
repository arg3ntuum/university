#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "windows.h"
#define N 50

void userWrite(int* massive, int size) {
    char temp[N];
    int pomilka = 0;
    for (int i = 0; i < size; i++)

        do {
            pomilka = 0;
            printf("Мatrix[%d] = ", i);
            scanf_s("%s", &temp, N - 1);
            for (int a = 0; a < strlen(temp); a++)
                if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
                    pomilka = 1;
            if (pomilka == 1)
                printf("Вводите только числа!\n");
            else {
                massive[i] = atol(temp);
                break;
            }
        } while (1);

}
void randWrite(float* massive, int size) {
    srand(time(NULL));
    for (int i = 0; i < size; i++)
        massive[i] = rand() % 301 - 150;
}
void clearMassive(float* matrix, int size) {
    float massive[] = { 6.3, 9.6 ,0.1, 0.002, 23, 4, 5 ,8 ,1, 2 };
    for (int i = 0; i < size; i++)
        *(matrix + i) = massive[i];
}
void SScanf(int* a) {
    char temp[N];
    int error = 0;
    do {
        error = 0;
        scanf_s("%s", &temp, N - 1);
        for (int a = 0; a < strlen(temp); a++)
            if (atof(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
                error = 1;
        if (error == 1)
            printf("Вводите только числа!\n");
        else {
            *a = (float)atof(temp);
            break;
        }
    } while (1);
}
void printArray(float array[], int size) {
    for (int i = 0; i < size; i++)
        printf("|%3.3g|", array[i]);
    printf("\n");
}
void swap(float* a, float* b) {
    float t = *a;
    *a = *b;
    *b = t;
}
int partition(float array[], int low, int high) {


    float pivot = array[high];


    int i = (low - 1);


    for (int j = low; j < high; j++) {
        if (array[j] <= pivot) {


            i++;


            swap(&array[i], &array[j]);
        }
    }


    swap(&array[i + 1], &array[high]);


    return (i + 1);
}
void quickSort(float array[], int low, int high, int size) {
    printArray(array, size);
    Sleep(1000);

    if (low < high) {

        int pi = partition(array, low, high);


        quickSort(array, low, pi - 1, size);


        quickSort(array, pi + 1, high, size);
    }
}
void selectionSort(float* array, int size)
{
    int min;
    float temp; 
    for (int i = 0; i < size - 1; i++)
    {
        printArray(array, size);
        Sleep(1000);
        min = i;
        
        for (int j = i + 1; j < size; j++)  
        {
            if (array[j] < array[min]) 
                min = j;       
        }
        temp = array[i];      
        array[i] = array[min];
        array[min] = temp;
    }
}
void main()
{
    setlocale(LC_ALL, "Rus");
    float massive[] = { 6.3, 9.6 ,0.1, 0.002, 23, 4, 5 ,8 ,1, 2 };
    int size = sizeof(massive) / sizeof(massive[0]);
    int choose = 0;
    do {
        printf("\n Меню\
                \n0. Exit; \
                \n1. Вывод массива;\
                \n2. Вернуть в массив значения по умолчанию;\
                \n3. Сортировка отбором;\
                \n4. Быстрая сортировка;\
                \n5. Заполнить массив рандомно;\
                \nВаш выбор: ");
        SScanf(&choose);
        if (choose == 1)
            printArray(massive, size);
        else if (choose == 2)
            clearMassive(&massive, size);
        else if (choose == 3)
            selectionSort(&massive, size);
        else if (choose == 4)
            quickSort(&massive, 0, size - 1, size);
        else if (choose == 5)
            randWrite(&massive, size);
        else if (choose == 6)
            userWrite(&massive, size);
    } while (choose != 0);
}
/*
Отбором.
Быстрая.
*/