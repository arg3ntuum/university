#include <stdio.h>
#include <locale.h>
#include <time.h>
#include <windows.h>
#define K 50

//Ввести данные с клавиатуры
void userWriting(int** massive, int N) {
	char temp[K];
	int check = 0;
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
		{
			do {
				check = 0;
				printf("Massive[%d][%d] = ", i, j);
				scanf_s("%s", &temp, K - 1);
				for (int a = 0; a < strlen(temp); a++)
					if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
						check = 1;
				if (check == 1)
					printf("Не є числом!\n");
				else {
					massive[i][j] = atoi(temp);
					break;
				}
			} while (1);
		}
}

//Ввести данные с помощью компъютера
void machineWriting(int** massive, int N) {
	srand(time(NULL));
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
			massive[i][j] = rand() % 21 - 10;
}

//Найти сумму
int sum(int** massive, int N) {
	int massive_leader_diagonal = 0, summa = 0;
	for (int i = 0; i < N; i++) {
		massive_leader_diagonal = i;//место нахождение елемента в главной диагонали
		for (int j = 0; j < N; j++)
			if (i % 2 == 1 && j > i)
				summa += massive[i][j];
	}
	return summa;
}

//Вывод
void massiveView(int** massive, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf("%5d", massive[i][j]);
		puts("");
	}
}

//Выбрать режим введения
int choiseWriting() {
	int choise = 0;
	do {
		printf("Выберите режим заполнения матрицы данными: \
			  \n1.Пользовательский;\
		      \n2.Автоматический;\
			  \nВаш выбор: ");
		scanf_s("%d", &choise);
	} while (choise != 1 && choise != 2);//условие должно быть true, тогда цикл работает. Если пользователь ввел корректные данные, то осуществляется стоп и возвращение из функции
	return choise;
}

//Выбор размера массива
int size() {
	int N = 0;
	do {
		printf("Выберите размер массива N x N(6 <= N <= 10): ");
		scanf_s("%d", &N);
	} while (!(6 <= N && N <= 10));//условие должно быть true, тогда цикл работает. Если пользователь ввел корректные данные, то осуществляется стоп и возвращение из функции
	return N;
}

void main() {
	setlocale(LC_ALL, "Rus"); //Локализация
	int N = size(), choose =  choiseWriting();

	//Создадим динамический массив
	int** massive = (int**)malloc(N * sizeof(int*));
	for (int i = 0; i < N; i++)
		massive[i] = (int*)malloc(N * sizeof(int));
	
	if (choose == 1)
		userWriting(massive, N); //Пользователь заполняет матрицу
	else machineWriting(massive, N); //Программа заполняет матрицу

	printf("\tМасив:\n");
	massiveView(massive, N); //Вывод массива

	printf("\n\nCума елементiв, що стоять над головною дiагоналлю у рядках, що починаються з парного числа дорiвнює: %d\n\n", sum(massive, N));

	free(massive); //Очистить память
}
/*
При виконанні 2-го завдання необхідно:
1.	Передбачити функцію для ручного введення елементів масиву.
2.	Передбачити функцію для автоматичного заповнення масиву А даними через використання генератору випадкових чисел.
3.	Передбачити обробку помилок під час введення даних та особливі випадки.
29.	Знайти суму елементів, що стоять над головною діагоналлю у рядках, що починаються з парного числа.
*/