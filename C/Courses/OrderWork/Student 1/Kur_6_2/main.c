#include <stdio.h>
#include <stdlib.h>
#include <locale.h>
#include <string.h>
#include <windows.h>
#include <time.h>
#define K 50

//Заполнение массива пользователем
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

//Автоматическое заполнение
void random_input(int** massive, int N) {
	srand(time(NULL));
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
			massive[i][j] = rand() % 21 - 10;
}

//Показать матрицу
void out_matrix(int** massive, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf("%4d", massive[i][j]);
		puts("");
	}
}

//Вывод вектора
void out_vektor(int* massive, int N) {
	printf("\t\tВектор наименьших в столбце по модулю:\n");
	for (int i = 0; i < N; i++) {
		printf("Вектор наименьших в столбце по модулю %d = %3d", i, massive[i]);
		printf("\n");
	}
}

//Обработка вектора
void calc_vektor(int** massive, int* vektor, int N) {
	int min;
	for (int j = 0; j < N; j++) {
		for (int i = 0; i < N; i++) {
			if (j == 0)
				min = abs(massive[i][j]);
			else if (min > abs(massive[i][j]))
				min = abs(massive[i][j]);
		}
		vektor[j] = min;
	}
}

//Cумма векторов
void sum_out(int* massive, int N) {
	puts("");
	int sum = 0;
	for (int i = 0; i < N; i++)
		sum += massive[i];
	printf("Cумма векторов = %d", sum);
	puts("");
	puts("");
}

//Выбрать режим заполнения
int choise_mode() {
	int choose = 0;
	do {
		printf("Сделайте выбор способа заполнения массива: \
			  \n1.Пользовательский;\
		      \n2.Автоматический;\
			  \nВаш выбор: ");
		scanf_s("%d", &choose);
	} while (choose != 1 && choose != 2);
	return choose;
}

//Выбрать N
int choise_N() {
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

	N = choise_N();
	choise = choise_mode();
	
	int** matrix = (int**)malloc(N * sizeof(int*));
	for (int i = 0; i < N; i++)
		matrix[i] = (int*)malloc(N * sizeof(int));
	int* vektor = (int*)malloc(N * sizeof(int));

	if (choise == 1)
		client_input(matrix, N); 
	else random_input(matrix, N);

	printf("\tМаcсив:\n");
	out_matrix(matrix, N); 

	calc_vektor(matrix, vektor, N);
	out_vektor(vektor, N);
	sum_out(vektor, N);
	
	free(matrix); //Очищення пам'яті
}
/*
При виконанні 2-го завдання необхідно:
1.	Передбачити функцію для ручного введення елементів масиву.
2.	Передбачити функцію для автоматичного заповнення масиву А даними через використання генератору випадкових чисел.
3.	Передбачити обробку помилок під час введення даних та особливі випадки.
6.	Знайти найменші за модулем елементи кожного стовпця матриці та їх координати. 
Сформувати з цих елементів вектор та визначити суму елементів вектору.
*/