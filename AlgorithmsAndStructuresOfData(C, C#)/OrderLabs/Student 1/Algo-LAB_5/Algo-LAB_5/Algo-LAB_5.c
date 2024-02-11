#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include "windows.h"
#define N 50

void SafeScanf(int* a) {
    char temp[N];
    int checker = 0;
    do {
        checker = 0;
        scanf_s("%s", &temp, N - 1);
        for (int a = 0; a < strlen(temp); a++)
            if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
                checker = 1;
        if (checker == 1)
            printf("Write please only numbers!\n");
        else {
            *a = atoi(temp);
            break;
        }
    } while (1);
}
void ClearMassive(int* massive, int size) {
    int def[] = { 6, 9 ,0, 2, 1, 4, 53 ,1, 2 };
    for (int i = 0; i < size; i++)
        *(massive + i) = def[i];
}
void RandWrite(int* massive, int size) {
    srand(time(NULL));
    for (int i = 0; i < size; i++)
        massive[i] = rand() % 100 - 200;
}
void UWrite(int* massive, int size) {
	char temp[N];
	int checker = 0;
	for (int i = 0; i < size; i++)

		do {
			checker = 0;
			printf("Мassive[%d] = ", i);
			scanf_s("%s", &temp, N - 1);
			for (int a = 0; a < strlen(temp); a++)
				if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
					checker = 1;
			if (checker == 1)
				printf("Write please only numbers!\n");
			else {
				massive[i] = atoi(temp);
				break;
			}
		} while (1);
}
void OutMassive(int* massive, int size) {
    for (int i = 0; i < size; i++)
        printf("|%4d|", massive[i]);
    printf("\n");
}
void ShellSort(int* massive, int size)
{
    int i = 0, j = 0, step = 0;
    int temp = 0;
    for (step = size / 2; step > 0; step /= 2)
        for (i = step; i < size; i++)
        {
            OutMassive(massive, size);
            Sleep(1000);
            temp = massive[i];
            for (j = i; j >= step; j -= step)
            {
                if (temp < massive[j - step])
                    massive[j] = massive[j - step];
                else break;
            }
            massive[j] = temp;
        }
}
void SelectionSort(int* massive, int size)
{
    int min = 0;
    int temp = 0;
    for (int i = 0; i < size - 1; i++)
    {
        OutMassive(massive, size);
        Sleep(1000);
        min = i;

        for (int j = i + 1; j < size; j++)
        {
            if (massive[j] < massive[min])
                min = j;
        }
        temp = massive[i];
        massive[i] = massive[min];
        massive[min] = temp;
    }
}
void main()
{
    setlocale(LC_ALL, "Rus");
    int massive[] = { 6, 9 ,0, 2, 1, 4, 53 ,1, 2 };
    int size = sizeof(massive) / sizeof(massive[0]);
    int choose = 0;
    do {
        printf("\n Menu\
                \n0. Exit; \
                \n1. Look on massive;\
                \n2. Set defoult numbers in massive;\
                \n3. Selection sort(отбором);\
                \n4. Shell sort(шелла);\
                \n5. Set random massive;\
                \n6. Set massive by user; \
                \nYour choose: ");
        SafeScanf(&choose);
        if (choose == 1)
            OutMassive(massive, size);
        else if (choose == 2)
            ClearMassive(&massive, size);
        else if (choose == 3)
            SelectionSort(&massive, size);
        else if (choose == 4)
            ShellSort(&massive, size);
        else if (choose == 5)
            RandWrite(&massive, size);
        else if (choose == 6)
            UWrite(&massive, size);
    } while (choose != 0);
}

/*
Отбором. 
Шелла. 
*/