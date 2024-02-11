#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include <math.h>
#define	N 50
#define TIRE  puts("---------------------------------------------------------------------------------------------------------")
#define TABLE puts("|  #  |    Группа    |     Вид  занятия     |  День недели  | Название предмета | Фамилия преподавателя |")
typedef struct {
	char group[N];
	int day;
	int view;
	char name_subject[N];
	char surname[N];
} NP;
void checkFiles(char file[]) {
	FILE* data;
	fopen_s(&data, file, "rb+");
	if (!data) {
		printf("Файл %s не был найден!\n", file);
		exit(0);
	}
	else {
		printf("Файл %s был загружен! Можете приступать к работе!\n", file);
		fclose(data);
	}
}
void saveTo(char a[], char b[]) {
	for (int i = 0; i < N; i++)
		a[i] = b[i];
}
int check(char file[]) {
	int i;
	NP np;
	FILE* data;
	fopen_s(&data, file, "r");//чтение
	if (!data) {
		puts("Файл не был открыт.\n");
		exit(1);
	}
	for (i = 0;; i++) {
		fscanf_s(data, "%s ", np.group, N);
		fscanf_s(data, "%d ", &np.day);
		fscanf_s(data, "%d ", &np.view);
		fscanf_s(data, "%s ", np.name_subject, N);
		fscanf_s(data, "%s ", np.surname, N);
		if (np.day == 0 && np.view == 0)
			break;
	}
	fclose(data);
	return i;
}
NP initNP(FILE* data) {
	NP np;
	fscanf_s(data, "%s ", np.group, N);
	fscanf_s(data, "%d ", &np.day);
	fscanf_s(data, "%d ", &np.view);
	fscanf_s(data, "%s ", np.name_subject, N);
	fscanf_s(data, "%s ", np.surname, N);
	return np;
}
NP* initArr(int dimension, char dataName[]) {
	NP* massive = (NP*)malloc(dimension * sizeof(NP));
	if (massive == NULL)
		return NULL;
	int vubor = 0;
	FILE* data;
	fopen_s(&data, dataName, "r");
	if (!data) {
		puts("Файл не был открыт.\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		massive[i] = initNP(data);
	fclose(data);
	return massive;
}
void displayNP(NP np, int i) {
	printf("|%3d. | %12s | ", i + 1, np.group);
	switch (np.view) {
	case 1: printf(" Лекционное занятие "); break;
	case 2: printf("Практическое занятие"); break;
	case 3: printf("Лабораторное занятие"); break;
	}
	printf(" | ");
	switch (np.day) {
	case 1: printf(" Понедельник "); break;
	case 2: printf("   Вторник   "); break;
	case 3: printf("    Среда    "); break;
	case 4: printf("   Четверг   "); break;
	case 5: printf("   Пятница   "); break;
	case 6: printf("   Суббота   "); break;
	case 7: printf(" Воскресенье "); break;
	}
	printf(" | %17s | %21s |\n", np.name_subject, np.surname);
	TIRE;
}
void displayAll(NP* massive, int dimension) {
	TIRE;
	TABLE;
	TIRE;
	for (int i = 0; i < dimension; i++)
		displayNP(massive[i], i);
}
int chooseSize(int dimension) {
	int size = 0;
	do {
		printf("Для изменения размера структуры введите ее новое значение: ");
		scanf_s("%d", &size);
		if (size > dimension)
			printf("Размер не может быть выше чем число '%d'!\n", dimension);
		else if (size <= 0)
			puts("Размер не может быть меньше нуля или равно нулю!", dimension);
	} while (!(size > 0 && size <= dimension));
	return size;
}
void saveNP(NP NP, FILE* data) {
	fprintf(data, "%s ", NP.group);
	fprintf(data, "%d ", NP.day);
	fprintf(data, "%d ", NP.view);
	fprintf(data, "%s ", NP.name_subject);
	fprintf(data, "%s ", NP.surname);
}
void saveArr(NP* massive, int dimension, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	if (!data) {
		puts("Файл не был открыт.\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		saveNP(massive[i], data);
	fprintf(data, "- 0 0 - -\n");
	fclose(data);
}
void noPractise(NP* massive, int dimension) {
	int checkToWrite = 0, first = 0, check = 0;

	for (int i = 0, nomer = 1; i < dimension; i++) {
		for (int j = 0; j < dimension; j++) {
			if (strcmp(massive[i].surname, massive[j].surname) == 0 && (massive[i].view == 2 || massive[j].view == 2)) {
					checkToWrite = 1;
			}
				
		}
		if (checkToWrite != 1) {
			if (first == 0) {
				puts("Фамилии преподавателей, что не проводят практику:");
				first = 1;
			}
			printf("%d. %s;\n", nomer++, massive[i].surname);

		}
		checkToWrite = 0;
	}
	if (first == 0)
		puts("Все преподаватели проводят практику.");
}
void swap(NP *a, NP *b) {
	NP temp = *a;
	*a = *b;
	*b = temp;
}
void quicksort(NP* massive, int length) {
	int i, piv = 0;
	if (length <= 1)
		return;

	for (i = 0; i < length; i++) {
		if (strcmp(massive[i].surname, massive[length - 1].surname) < 0)
			swap(&massive[i], &massive[piv++]);
	}

	swap(&massive[piv], &massive[length - 1]);

	quicksort(massive, piv++);
	quicksort(massive + piv, length - piv);
}
void lineFound(NP* massive, int dimension, char groupFind[]) {
	int first = 0;
	for (int i = 0, nomer = 0; i < dimension; i++) {
		if (strstr(massive[i].group, groupFind)) {
			if (first == 0) {
				TIRE;
				TABLE;
				TIRE;
				first = 1;
			}
			displayNP(massive[i], nomer++);
		}
	}
}
void BinareWhileUp(NP* massive, int dimension, char groupFind[], int center, int nomer) {
	for (int i = center; i < dimension; i++)
		if (strstr(massive[i].group, groupFind)) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayNP(massive[i], nomer++);
		}
}
void BinareWhileDown(NP* massive, int dimension, char groupFind[], int center, int nomer) {
	for (int i = center; i >= 0; i--)
		if (strstr(massive[i].group, groupFind)) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayNP(massive[i], nomer++);
		}
}
void sortGroup(NP* massive, int dimension) {
	NP temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (strcmp(massive[j].group, massive[j - 1].group) < 0) {
				temp = massive[j];
				massive[j] = massive[j - 1];
				massive[j - 1] = temp;
			}
}
void Binare(NP* massive, int dimension, char groupFind[]) {
	int center = round(dimension / 2);
	static nomer = 0;
	sortGroup(massive, dimension);
	if (strcmp(massive[center].group, groupFind) < 0)
		BinareWhileUp(massive, dimension, groupFind, center, nomer);
	else if (strcmp(massive[center].group, groupFind) > 0)
		BinareWhileDown(massive, dimension, groupFind, center, nomer);
	else if (strcmp(massive[center].group, groupFind) == 0) {
		if (dimension == 1) {
			TIRE;
			TABLE;
			TIRE;
			displayNP(massive[0], nomer++);
		}
		else if (dimension == 2) {
			nomer++;
			lineFound(massive, dimension, groupFind);
		}
		else if (dimension >= 3) {
			if (strcmp(massive[center].group, groupFind) == 0 && strcmp(massive[center - 1].group, groupFind) != 0 && strcmp(massive[center].group, groupFind) != 0) {
				TIRE;
				TABLE;
				TIRE;
				displayNP(massive[0], nomer++);
			}
			else if (strcmp(massive[center].group, groupFind) == 0 && strcmp(massive[center - 1].group, groupFind) == 0 && strcmp(massive[center + 1].group, groupFind) != 0)
				BinareWhileDown(massive, dimension, groupFind, center, nomer);
			else if (strcmp(massive[center].group, groupFind) == 0 && strcmp(massive[center - 1].group, groupFind) != 0 && strcmp(massive[center + 1].group, groupFind) == 0)
				BinareWhileUp(massive, dimension, groupFind, center, nomer);
			else if (strcmp(massive[center].group, groupFind) == 0 && strcmp(massive[center - 1].group, groupFind) == 0 && strcmp(massive[center + 1].group, groupFind) == 0) {
				nomer++;
				lineFound(massive, dimension, groupFind);
			}
		}
	}
}
int checkGroup(char groupFind[], NP* massive, int dimension) {
	int checking = 1;
	for (int i = 0; i < dimension; i++)
		if (strcmp(massive[i].group, groupFind) == 0)
			checking = 0;
	return checking;
}
int choiseGroup(char groupFind[], NP* massive, int dimension) {
	char group[N] = { 0 };
	printf("Введите группу для поиска: ");
	scanf_s("%s", group, N - 1);
	saveTo(groupFind, group);
	return checkGroup(group, massive, dimension);
}
void choise(NP* massive, int dimension) {
	char group[N] = { 0 };
	int choose = 0, checking = choiseGroup(group, massive, dimension);
	do {
		printf("Выберите способ поиска по группе:\n1.Линейный поиск;\n2.Бинарный поиск;\n0.Выход;\nВаш выбор: ");
		scanf_s("%d", &choose);
		if (choose == 1 && checking == 0)
			lineFound(massive, dimension, group);
		else if (choose == 2 && checking == 0)
			Binare(massive, dimension, group);
		else if (checking != 0)
			puts("Ничего не найдено!");
	} while (choose != 0);
}
void main(int argc, char* argv[]) {
	setlocale(LC_ALL, "Rus");
	char dataName[N] = {0};
	if (argc == 2) {
		printf("Файл передали через аргумент!\n");
		saveTo(dataName, argv[1]);
		checkFiles(dataName);
	}
	else {
		printf("Чтобы подгрузить базу данных, введите его название(например, data.txt): ");
		scanf_s("%s", dataName, N - 1);
		checkFiles(dataName);
	}
	int dimension = check(dataName), choose = 0;
	NP* massiveStruct = initArr(dimension, dataName);
	do {
		puts("\tМ Е Н Ю\
		 \n1.Список всех занятий;\
		 \n2.Изменить размер массива структур;\
		 \n3.Сортировка по фамилии (Quick Sort);\
		 \n4.Поиск по группе;\
		 \n5.Узнать фамилии преподавателей, что не проводят практику;\
		 \n0.Выход;\
		 \nВаш выбор: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			displayAll(massiveStruct, dimension);
		else if (choose == 2) {
			dimension = chooseSize(check(dataName));
			massiveStruct = initArr(dimension, dataName);
		}
		else if (choose == 3)
			quicksort(massiveStruct, dimension);
		else if (choose == 4)
			choise(massiveStruct, dimension);
		else if (choose == 5)
			noPractise(massiveStruct, dimension);
	} while (choose != 0);
	saveArr(massiveStruct, dimension, dataName);
	free(massiveStruct);
}
/*
		+1.	Ім’я файлу задається в командному рядку. Якщо воно там не було задано, то після відповідного запиту вводиться користувачем.
		+2.	Використовувати динамічне виділення пам’яті (розмір масиву задається користувачем після відповідного запиту). 
		+Після використання масиву слід обов’язково звільнити пам’ять.
		3.	Пошук інформації здійснювати двома методами — лінійним та бінарним.
		+4.	Вихідну інформацію виводити у вигляді таблиці і записувати до файлу.
		5.	Інформацію для пошуку слід вводити з клавіатури.

		+16.	Є інформація про навчальний процес: 
		+номер групи (наприклад, КІ-19-1), 
		+день тижня,
		+вид заняття (лекція, практика чи лабораторні роботи), 
		+назва пред-мета, 
		+прізвище викладача. 
		+Знайти прізвища викладачів, які не проводять прак-тичних занять. 
		+Упорядкувати інформацію за прізвищем викладача методом швидкого сортування (Quick Sort). 
		+Організувати пошук за номером групи.
*/