#include <stdio.h>
#include <locale.h>
#include <time.h>
#define K 50

//Введення користувачем елементів матриці
void user_in_put(int** massive, int N) {
	char temp[K];
	int pomilka = 0;
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
		{
			do {
				pomilka = 0;
				printf("Massive[%d][%d]: ", i, j);
				scanf_s("%s", &temp, K - 1);
				for (int a = 0; a < strlen(temp); a++)
					if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
						pomilka = 1;
				if (pomilka == 1)
					printf("Це не число!\n");
				else {
					massive[i][j] = atoi(temp);
					break;
				}
			} while (1);
		}
}

//Рандомне заповнення матриці
void auto_in_put(int** massive, int N) {
	srand(time(NULL));
	for (int i = 0; i < N; i++)  
		for (int j = 0; j < N; j++) 
			massive[i][j] = rand() % 21 - 10;
}

//Вивід матриці
void out_matrix(int** massive, int N) {
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++)
			printf("%4d", massive[i][j]);
		printf("\n");
	}
}

void out_vektor(int* massive, int N) {
	for (int i = 0; i < N; i++) {
		printf("Вектор %d = %3d", i, massive[i]);
		printf("\n");
	}
}

//Вибрати режим введення
int сhoose_rezum_vvedennya() {
	int choose = 0;
	do {
		printf("Виберiть режим запису матрицi: \
			  \n1.Користувачем;\
		      \n2.Комп'ютером;\
			  \nВаш вибiр: ");
		scanf_s("%d", &choose);
	} while (choose != 1 && choose != 2);
	return choose;
}

//Розмірність масиву
int size() {
	int N = 0;
	do {
		printf("Виберiть розмiр масиву N x N(6 <= N <= 10): ");
		scanf_s("%d", &N);
	} while (!(6 <= N && N <= 10));
	return N;
}

//Головна функція
void main() {
	setlocale(LC_ALL, "Rus"); //Локалізація
	int N = 0, choose = 0;

	N = size();

	system("cls"); // Очищення консолі
	
	choose = сhoose_rezum_vvedennya();
	
	//Створення динамічного масиву
	int** massive = (int**)malloc(N * sizeof(int*));
	for (int i = 0; i < N; i++)
		massive[i] = (int*)malloc(N * sizeof(int));
	
	int* vektor = (int*)malloc(N * sizeof(int));
	if (choose == 1)
		user_in_put(massive, N); //Введення матриці користувачем
	else auto_in_put(massive, N); //Автоматичне заповнення матриці

	system("cls"); // Очищення консолі
	printf("\tМасив:\n");
	out_matrix(massive, N); //Показ масиву

	int min, max;
	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			if (j == 0) {
				min = massive[i][0];
				max = massive[i][0];
			}
			else if (min > massive[i][j])
				min = massive[i][j];
			else if (max < massive[i][j])
				max = massive[i][j];
		}
		vektor[i] = max - min;
	}

	printf("\tВектор:\n");
	out_vektor(vektor, N);

	free(massive); //Очищення пам'яті
}
/*
При виконанні 2-го завдання необхідно:
1.	Передбачити функцію для ручного введення елементів масиву.
2.	Передбачити функцію для автоматичного заповнення масиву А даними через використання генератору випадкових чисел.
3.	Передбачити обробку помилок під час введення даних та особливі випадки.

24.	Сформувати вектор з різниць найбільших та найменших значень елементів рядків.
*/