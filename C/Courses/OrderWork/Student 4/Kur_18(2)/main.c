#include <stdio.h>
#include <locale.h>
#include <time.h>
#include <windows.h>
#include <math.h>
#define K 50
//Рандомне число в матриці в діапазоні
int randomRange(int min, int max) {
	return rand() % (max - min + 1) + min;
}

//Функція введення користувачем елементів матриці
void userInput(int** A, int N) {
	char temp[K];
	int error = 0;
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
		{
			do {
				error = 0;
				printf("Massive[%d][%d]: ", i, j);
				scanf_s("%s", &temp, K - 1);
				for (int a = 0; a < strlen(temp); a++)
					if (atoi(temp) == 0 || !('0' <= temp[a] && temp[a] <= '9'  ))
						error = 1;
				if (error == 1)
					printf("Вы ввели не целочисленное значение!\n");
				else {
					A[i][j] = atoi(temp);
					break;
				}
			} while (1);
		}
}

//Функція рандомного заповнення матриці
void autoInput(int** A, int N) {
	srand(time(NULL));
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
			A[i][j] = randomRange(-10, 10); //Запис данних у матрицю в діапазоні від (-10; 10)
}

//Функція виводу матриці
void outPut(int** A, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf("%5d", A[i][j]);
		printf("\n");
	}
}

//Функція обробки матриці
void processing(int** A, int N) {
	for (int temp, i = 0, k = N - 1; i != round(N / 2); i++, k--)
		for (int j = 0; j < N; j++) {
			temp = A[j][i];
			A[j][i] = A[j][k];
			A[j][k] = temp;
		}
}

//Вибір режиму введення
int сhooseMode() {
	int choose = 0;
	do {
		printf("Виберiть режим введення значень: \
			  \n1.Уведення користувачем;\
		      \n2.Автоматичне введення;\
			  \nВаш вибiр: ");
		scanf_s("%d", &choose);
	} while (choose != 1 && choose != 2);
	return choose;
}

//Розмірність масиву
int dimension() {
	int N = 0;
	do {
		printf("Уведiть розмiр масиву N x N(6 <= N <= 10): ");
		scanf_s("%d", &N);
	} while (!(6 <= N && N <= 10));
	return N;
}

//Головна функція
void main() {
	setlocale(LC_ALL, "Rus"); //Локалізація

	int N = dimension();
	system("cls"); // Очищення консолі
	int choose = сhooseMode();
	
	//Створення динамічного масиву
	int** A = (int**)malloc(N * sizeof(int*));
	for (int i = 0; i < N; i++)
		A[i] = (int*)malloc(N * sizeof(int));
	
	if (choose == 1)
		userInput(A, N); //Введення матриці користувачем
	else autoInput(A, N); //Автоматичне заповнення матриці

	system("cls"); // Очищення консолі
	printf("\tМасив ДО:\n");
	outPut(A, N); //Показ масиву

	processing(A, N);//Обробка масиву

	printf("\n\tМасив ПIСЛЯ:\n"); 
	outPut(A, N); //Показ масиву

	free(A); //Очищення пам'яті
}
/*
При виконанні 2-го завдання необхідно:
1.	Передбачити функцію для ручного введення елементів масиву.
2.	Передбачити функцію для автоматичного заповнення масиву А даними через використання генератору випадкових чисел.
3.	Передбачити обробку помилок під час введення даних та особливі випадки.

18.	Поміняти місцями стовпці матриці, як показано на рис. І.2 (б).
*/