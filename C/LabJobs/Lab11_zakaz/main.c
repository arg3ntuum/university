#include <stdio.h>
#include <string.h>
#include <locale.h>
#include <stdlib.h>
#include <time.h>
#define RAVNO puts("=========================================")
#define F 50
#define Y 10
/*

Завдання 1. Задано квадратну матрицю А розмірністю M*N.
В одновимірний масив В запишіть елементи матриці А, які є мінімальними в рядках.

Завдання 2. Дано десять будь-яких прізвищ. Розташуйте їх в
алфавітному порядку. Розв’яжіть задачу без сортування самих
рядків, а використовуючи лише масив вказівників.

Завдання 3. Напишіть програму, яка визначає, де знаходиться
введений рядок Q у заданому рядку S (на початку, в середині чи
наприкінці). Рядки S та Q слід вводити через командний рядок.
*/
//Случайное число в диапозоне
int quest1_getRandNum(int min, int max) {
	return rand() % (max - min + 1) + min;
}
int quest1_processing(int* massive, int N){
	int min = 0;
	for (int i = 0; i < N; i++){
		if (i == 0)
			min = *(massive +i );
		else if (min > *(massive + i))
			min = *(massive + i);
	}
	return min;
}
void quest1_userInput(int** massive, int M, int N) {
	char temp[F] = { 0 };
	puts("Введите целые числа--->");
	for (int i = 0; i < M; i++)  //  цикл по рядках
		for (int j = 0; j < N; j++)  // цикл по стовпцях
		{
			printf("Massive[%d][%d] = ", i, j);
			scanf_s("%s", &temp, F - 1);
			*(*(massive + i) + j) = atoi(temp);
		}
}
void quest1_autoInput(int** massive, int M, int N) {
	for (int i = 0; i < M; i++)  // цикл по строкам
		for (int j = 0; j < N; j++)  // цикл по столбцам
			*(*(massive +i )+j) = quest1_getRandNum(-10, 10); //заполнение массива матрицы случайным числом в диапозоне (-10; 10)
}
void quest1() {
	int N = 0, M = 0, choose = 0;
	RAVNO;
	srand(time(NULL));
	printf("\nВведите размерность двумерного массива M x N(динамическое распределение памяти):");
	printf("\nВведите M: ");
	scanf_s("%d", &M);
	printf("\nВведите N: ");
	scanf_s("%d", &N);

	//Дінамічне виділення пам'яті
	int* massiveMIN = (int*)malloc(M * sizeof(int));
	int** massive = (int**)malloc(M* sizeof(int*));
	if (massive == NULL) {
		printf("\nНе инициализированная память");
		return 0;
	}
	for (int i = 0; i < M; i++)
		*(massive +i) = (int*)malloc(N * sizeof(int));
	for (int i = 0; i < M; i++)
		if (*(massive + i) == NULL) {
			printf("\nНе инициализированная память в одном из елементов");
			return 0;
		}
	do {
		printf("\nВыберите режим работы программы:\n1.Ввод от пользователя.\n2.Автоматическое введение.\nВаш выбор: ");
		scanf_s("%d", &choose);
	} while (choose != 1 && choose != 2);
	if (choose == 1)
		quest1_userInput(massive, M, N);
	else if (choose == 2)
		quest1_autoInput(massive, M, N);
	//перебор
	for (int i = 0; i < M;i++) {
		*(massiveMIN + i) = quest1_processing(massive[i], N);
	}
	puts("");
	for (int i = 0; i < M; i++) {  // цикл по строкам
		for (int j = 0; j < N; j++)  // цикл по столбцам
			printf("%4d", *( *(massive + i) + j));
		printf("\n");
	}
	//вывод ответа
	for (int i = 0; i < M; i++) {
		printf("\nМинимальное значение в строке %d = %d", i, *(massiveMIN + i));
	}
	puts("");
}
void quest2() {
	int choose = 0;
	char surname[Y][F] =
	{
		{"Ivanov"},
		{"Smirnov"},
		{"Kuznecov"},
		{"Popov"},
		{"Vasilev"},
		{"Petrov"},
		{"Cokolov"},
		{"Mihaylov"},
		{"Zaycev"},
		{"Bogdanov"}
	};
	do {
		printf("\nВыберите режим работы программы:\n1.Ввод от пользователя.\n2.Автоматическое введение.\nВаш выбор: ");
		scanf_s("%d", &choose);
	} while (choose != 1 && choose != 2);
	if (choose == 1)
	{
		puts("Введите фамилии--->");
		for (int i = 0; i < Y; i++) { //  цикл по рядках
			printf("Фамилия[%d] = ", i);
			scanf_s("%s", &*(surname +i), F - 1);
		}
	}
	puts("Список фамилий:");
	for (int i = 0; i < Y; i++)
		printf("\nФамилия[%d] = %s;",i, *(surname + i));
	puts("");
	void* temp;
	char* ptrSurname[Y] = { 
		*surname,
		* (surname + 1),
		* (surname + 2),
		* (surname + 3),
		* (surname + 4),
		* (surname + 5),
		* (surname + 6),
		* (surname + 7),
		* (surname + 8),
		* (surname + 9),
	};
	
	//Sort
	for (int i = 0; i <= Y; i++)
		for (int j = Y - 1; j > i; j--)
			if (strcmp(*(ptrSurname+j), *(ptrSurname + j - 1)) < 0) {
				temp = *(ptrSurname + j);
				*(ptrSurname + j) = *(ptrSurname + j - 1);
				*(ptrSurname + j - 1) = temp;
			}
	printf("\n\nОтсортированный массив:");
	for (int i = 0; i < Y; i++)
		printf("\nФамилия[%d] = %s;", i, *( ptrSurname+i));
	puts("");
}
void quest3()
{
	RAVNO;
	char str1[F] = { 0 }, str2[F] = { 0 };
	int n = 0;

	printf("\nВведите строку проверки:");
	getchar();
	gets(str1, F);

	printf("\nВведите искомую строку:");
	gets(str2, F);

	for (char* ptr = strstr(str1, str2); ptr != 0; ptr = strstr(ptr + 1, str2))
		n = ptr - str1 + 1;
	printf("n = %d", n);
	if (n == 0)
		printf("Ненайдено строки.\n");
	else if (n == 1)
		printf("В начале строки найдено вхождение в позиции %d.\n", n);
	else if (str1[n + strlen(str2)] == '\0')
		printf("В конце строки найдено вхождение в позиции %d.\n", n);
	else printf("В середине строки найдено вхождение в позиции %d.\n", n);
	
}
int main(int argc, char* argv[])
{
	setlocale(LC_ALL, "Rus");
	//C:\Users\tftfj\source\repos\Lab11_zakaz\Debug\Lab11_zakaz.exe z2
	int choose = 0;
	do {
		RAVNO;
		printf("Введите номер задания, которое хотите проверить:(1, 2, или 3).\nВведите 0 для завершения.\n");
		scanf_s("%d", &choose);
		if (choose == 0)
			break;
		else if (choose == 1)
			quest1();
		else if (choose == 2)
			quest2();
		else if (choose == 3)
			quest3();
	} while (1);
	/*for (int i = 1;i < argc;i++)
		for (int j = 0; j <	F; j++)
		{
			if (argv[i][j] == 'z' && argv[i][j + 1] == '1')
				choose = 1;
			else if (argv[i][j] == 'z' && argv[i][j + 1] == '2')
				choose = 2;
			else if (argv[i][j] == 'z' && argv[i][j + 1] == '3')
				choose = 3;
		}
	if (choose == 1)
		quest1();
	else if (choose == 2)
		quest2();
	else if (choose == 3)
		quest3();*/
	
	RAVNO;
	puts("Окончание работы.");
	RAVNO;
	return 0;
}