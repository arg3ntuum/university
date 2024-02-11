#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>
#include <windows.h>
#include <time.h>
#define K 50

void userWriteMatrix(int** matrix, int N) {
	char temp[K];
	int error = 0;
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
		{
			do {
				error = 0;
				printf("Mасив[%d][%d]: ", i, j);
				scanf_s("%s", &temp, K - 1);
				for (int k = 0; k < strlen(temp); k++)
					if (atoi(temp) == 0 && !(('0' <= temp[k]) && (temp[k] <= '9')))
						error = 1;
				if (error == 1)
					printf("Вводить нужно только числа!\n");
				else {
					matrix[i][j] = atoi(temp);
					break;
				}
			} while (1);
		}
}

void autoWriteMatrix(int** matrix, int N) {
	srand(time(NULL));
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
			matrix[i][j] = rand() % 21 - 10;
}

void out(int** matrix, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf("%4d", matrix[i][j]);
		puts("");
	}
}

void proccesing(int** matrix, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0, k = 0; j < N; j++)
			if (matrix[i][j] % 2 == 0 && matrix[i][j] >=0){
				k = N - j - 1;
				matrix[i][j] = matrix[i][k];
			}
	}
}

int takeMode() {
	int choise = 0;
	do {
		printf("Выберите способ загрузки чисел в массив: \
			  \n1.С помощью пользователя;\
		      \n2.С помощью компьютера;\
			  \nВаш выбор: ");
		scanf_s("%d", &choise);
	} while (choise != 1 && choise != 2);
	return choise;
}

int takeN() {
	int N = 0;
	do {
		printf("Выберите размер массива N x N(6 <= N <= 10): ");
		scanf_s("%d", &N);
	} while (!(6 <= N && N <= 10));
	return N;
}

void main() {
	setlocale(LC_ALL, "Rus");
	int N = 0, choise = 0;

	N = takeN();
	choise = takeMode();
	
	int** matrix = (int**)malloc(N * sizeof(int*));
	for (int i = 0; i < N; i++)
		matrix[i] = (int*)malloc(N * sizeof(int));

	if (choise == 1)
		userWriteMatrix(matrix, N); 
	else autoWriteMatrix(matrix, N);

	printf("\tМаcсив ДО:\n");
	out(matrix, N); 

	proccesing(matrix, N);

	printf("\tМаcсив ПОСЛЕ:\n");
	out(matrix, N);
	free(matrix); //Очищення пам'яті
}
/*
При виконанні 2-го завдання необхідно:
1.	Передбачити функцію для ручного введення елементів масиву.
2.	Передбачити функцію для автоматичного заповнення масиву А даними через використання генератору випадкових чисел.
3.	Передбачити обробку помилок під час введення даних та особливі випадки.

20.	Замінити всі додатні парні числа на числа, які сформовані їх записами в оберненому порядку.
*/