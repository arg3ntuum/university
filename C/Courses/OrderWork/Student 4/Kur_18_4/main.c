#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include <ctype.h>
#include <math.h>
#define	N 50
#define TIRE puts("----------------------------------------------------------------")
#define TABLE puts("|  #  |     Дата     |     Код мiста     |  Час  |    Тариф    |")
typedef struct {
	int data[3];
	char codeTown[N];
	int timeOfCall;
	char tarif[N];
} Calls;
void reWrite(char massive1[], char massive2[]) {
	for (int i =0; i < N ;i++)
		massive1[i] = massive2[i];
}
Calls initCall(FILE* data) {
	Calls call;
	fscanf_s(data, "%s ", call.codeTown, N);
	fscanf_s(data, "%d ", &call.data[0]);
	fscanf_s(data, "%d ", &call.data[1]);
	fscanf_s(data, "%d ", &call.data[2]);
	fscanf_s(data, "%d ", &call.timeOfCall);
	fscanf_s(data, "%s ", call.tarif, N);
	return call;
}
Calls* initArray(int dimension, char dataName[]) {
	Calls* massive = (Calls*)malloc(dimension * sizeof(Calls));
	if (massive == NULL)
		return NULL;
	int vubor = 0;
	FILE* data;
	fopen_s(&data, dataName, "r");
	if (!data) {
		puts("Невдалося вiдкрити файл.\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		massive[i] = initCall(data);
	fclose(data);
	return massive;
}
void displayCalls(Calls call, int i) {
	printf("|%4d.|  %2d.%2d.%4d  | %17s | %2d хв | %11s |\n", i + 1, call.data[0], call.data[1], call.data[2],
		call.codeTown, call.timeOfCall, call.tarif);
	TIRE;
}
void displayArray(Calls* massive, int dimension) {
	TIRE;
	TABLE;
	TIRE;
	for (int i = 0; i < dimension; i++) {
		displayCalls(massive[i], i);
	}
}
void foundTopTown(Calls* massive, int dimension, int month, char realBestTown[]) {
	char bestTown[N] = { 0 };
	int counter = 0, counterTop = 0;
	reWrite(bestTown, massive[0].codeTown);

	for (int i = 0;i < dimension;i++) {
		counter = 0;
		for (int j = 0; j < dimension; j++) {
			if ((strcmp(massive[i].codeTown, massive[j].codeTown) == 0) && massive[i].data[1] == month)
				counter += massive[j].timeOfCall;
			if (counter > counterTop) {
				counterTop = counter;
				reWrite(bestTown, massive[i].codeTown);
			}
		}
	}
	if (counterTop != 0)
		reWrite(realBestTown, bestTown);
	else reWrite(realBestTown, "Немає такого");
}
int chooseMonth() {
	int month = 0, error = 0;
	char monthAnaliz[N] = { 0 };
	do {
		error = 0;
		printf("Уведiть номер мiсяця для аналiзу:");
		scanf_s("%s", monthAnaliz, N - 1);
		for (int i = 0; i < strlen(monthAnaliz); i++)
			if (atoi(monthAnaliz) == 0 && !(('0' <= monthAnaliz[i]) && (monthAnaliz[i] <= '9')))
				error = 1;
		if (error == 1)
			printf("Уведiть корректне число!\n");
		else month = atoi(monthAnaliz);
	} while (!(month >= 1 && month <=12));
	return month;
}
void topTown(Calls* massive, int dimension) {
	system("cls");
	int month = chooseMonth();
	char bestTown[N] = { 0 };
	foundTopTown(massive, dimension, month, bestTown);
	if (month <= 9)
		printf("Головне мiсто 0%d мiсяця: %s\n", month, bestTown);
	else printf("Головне мiсто %d мiсяця: %s\n", month, bestTown);
	system("pause");
	system("cls");
}
int foundDays(int date[]) {
	return date[2] * 365 + date[1] * 30 + date[0];
}
void sortByDate(Calls* massive, int dimension) {
	Calls temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (foundDays(massive[j].data) < foundDays(massive[j - 1].data)) {
				temp = massive[j];
				massive[j] = massive[j - 1];
				massive[j - 1] = temp;
			}
}
void sortByCodeTown(Calls* massive, int dimension) {
	Calls temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (strcmp(massive[j].codeTown, massive[j - 1].codeTown) < 0) {
				temp = massive[j];
				massive[j] = massive[j - 1];
				massive[j - 1] = temp;
		}
}
void checkFile(char fileName[]) {
	setlocale(LC_ALL, "Russian");
	FILE* data;
	fopen_s(&data, fileName, "rb+");
	if (!data) {
		printf("Файла %s не знайдено!\n", fileName);
		exit(0);
	}
	else {
		printf("Файл %s пiдключено успiшно!\n", fileName);
		fclose(data);
	}
}
int changeSize(int dimension) {
	int sizeStruct = 0;
	do {
		printf("Уведiть розмiр масиву, що потрiбно створити: ");
		scanf_s("%d", &sizeStruct);
		if (sizeStruct > dimension)
			printf("Розмiр не повинен перевищувати кiлькiсть структур у файлi '%d'!\n" , dimension);
		else if(sizeStruct <= 0)
			puts("Розмiр не повинен бути нижче або дорiвнювати 0!", dimension);
	} while (!(sizeStruct > 0 && sizeStruct <= dimension));
	return sizeStruct;
}
void choiseDateForFound(int dateFound[]) {
	do {
		printf("Уведiть дату пошуку(наприклад, 24.12.2001): ");
		scanf_s("%d.%d.%d", &dateFound[0], &dateFound[1], &dateFound[2]);
		if (dateFound[0] >= 1 && dateFound[0] <= 31 && dateFound[1] >= 1 && dateFound[1] <= 12 && dateFound[2] >= 1)
			break;
		else puts("Уведіть корректні дані!");
	} while (1);
}
void choiseLine(Calls* massive, int dimension, int dateFound[]) {
	TIRE;
	TABLE;
	TIRE;
	for (int i = 0, nomer = 0; i < dimension; i++) {
		if ((massive[i].data[0] == dateFound[0]) && (massive[i].data[1] == dateFound[1]) && (massive[i].data[2] == dateFound[2]))
			displayCalls(massive[i], nomer++);
	}
}
void choiseBinareFoundUp(Calls* massive, int dimension, int dateFound[], int center, int nomer) {
	for (int i = center; i < dimension;i++)
		if (foundDays(massive[i].data) == foundDays(dateFound))
			displayCalls(massive[i], nomer++);
}
void choiseBinareFoundDown(Calls* massive, int dimension, int dateFound[], int center, int nomer) {
	for (int i = center; i >= 0; i--)
		if (foundDays(massive[i].data) == foundDays(dateFound)) 
			displayCalls(massive[i], nomer++);
}
void choiseBinare(Calls* massive, int dimension, int dateFound[]) {
	int center = round(dimension / 2); //Центр структур звонков
	static nomer = 0;
	TIRE;
	TABLE;
	TIRE;
	sortByDate(massive, dimension);
	//Дата центр меньше искомой даты
	if (foundDays(massive[center].data) < foundDays(dateFound)) 
		choiseBinareFoundUp(massive, dimension, dateFound, center, nomer);
	//Дата центр больше искомой даты
	else if (foundDays(massive[center].data) > foundDays(dateFound))
		choiseBinareFoundDown(massive, dimension, dateFound, center, nomer);
	//Дата центр приравнивается искомой даты
	else if (foundDays(massive[center].data) == foundDays(dateFound)) {
		if (dimension == 1)
			displayCalls(massive[0], nomer++);
		else if (dimension == 2)
			for (int i = 0; i < dimension; i++)
				if (foundDays(massive[i].data) == foundDays(dateFound))
					displayCalls(massive[i], nomer++);
		else if (dimension >= 3) {
			//Дата центр равна искомой дате И ТОЛЬКО
			if ((foundDays(massive[center].data) == foundDays(dateFound)) && (foundDays(massive[center - 1].data) != foundDays(dateFound)) && (foundDays(massive[center + 1].data) != foundDays(dateFound)))
				displayCalls(massive[center], nomer);
			//Дата центр равна искомой дате и меньше
			else if ((foundDays(massive[center].data) == foundDays(dateFound)) && (foundDays(massive[center - 1].data) == foundDays(dateFound)) && (foundDays(massive[center + 1].data) != foundDays(dateFound)))
				choiseBinareFoundDown(massive, dimension, dateFound, center, nomer);
			//Дата центр равна искомой дате и больше
			else if ((foundDays(massive[center].data) == foundDays(dateFound)) && (foundDays(massive[center - 1].data) != foundDays(dateFound)) && (foundDays(massive[center + 1].data) == foundDays(dateFound))) 
				choiseBinareFoundUp(massive, dimension, dateFound, center, nomer);
			//Дата центр равна искомой дате и больше и меньше
			else if ((foundDays(massive[center].data) == foundDays(dateFound)) && (foundDays(massive[center - 1].data) == foundDays(dateFound)) && (foundDays(massive[center + 1].data) == foundDays(dateFound)))
				choiseLine(massive, dimension, dateFound);
		}	
	}
}
void choise(Calls* massive, int dimension) {
	int choose = 0, dateFound[3] = {0};
	choiseDateForFound(dateFound);
	do {
		printf("Меню пошуку\n1.Лiнiйний пошук за датою\n2.Бiнарний пошук за датою\n0.Exit\nВаш вибiр: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			choiseLine(massive, dimension, dateFound);
		else if (choose == 2)
			choiseBinare(massive, dimension, dateFound);
	} while (choose != 0);
}
void saveCall(Calls call, FILE* data) {
	fprintf(data, "%s ", call.codeTown);
	fprintf(data, "%d ", call.data[0]);
	fprintf(data, "%d ", call.data[1]);
	fprintf(data, "%d ", call.data[2]);
	fprintf(data, "%d ", call.timeOfCall);
	fprintf(data, "%s\n", call.tarif);
}
void save(Calls* massive, int dimension, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	if (!data) {
		puts("Файл не был открыт\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		saveCall(massive[i], data);
	fprintf(data, "- 0 0 0 0 -\n");
	fclose(data);
}
int check(char fileName[]) {
	int i;
	Calls call;
	FILE* data;
	fopen_s(&data, fileName, "r");//чтение
	if (!data) {
		puts("Файл не был открыт\n");
		exit(1);
	}
	for (i = 0;; i++) {
		fscanf_s(data, "%s ", call.codeTown, N);
		fscanf_s(data, "%d ", &call.data[0]);
		fscanf_s(data, "%d ", &call.data[1]);
		fscanf_s(data, "%d ", &call.data[2]);
		fscanf_s(data, "%d ", &call.timeOfCall);
		fscanf_s(data, "%s ", call.tarif, N);
		if (call.data[0] == 0 && call.data[1] == 0 && call.data[2] == 0 && call.timeOfCall == 0)
			break;
	}
	fclose(data);
	return i;
}
//Главная функция 
void main(int argc, char* argv[]) {
	
	setlocale(LC_ALL, "Rus"); //Локализация
	char dataName[N] = { 0 };
	if (argc == 2) {
		printf("БД була передана через аргументи при запуску!\n");
		reWrite(dataName, argv[1]);
		memcpy(dataName, argv[1], N);
		checkFile(dataName);
		
	}
	else {
		printf("Уведiть назву файлу пiдзагруження: ");
		scanf_s("%s", dataName, N - 1);
		checkFile(dataName);
	}
	system("pause");
	system("cls");
	int dimension = check(dataName), choose = 0, changes = 0;
	Calls* massiveStruct = initArray(dimension, dataName);
	do {
		if (changes == 1) {
			dimension = changeSize(check(dataName));
			massiveStruct = initArray(dimension, dataName);
			changes = 0;
		}

		puts("\tМ Е Н Ю\
		 \n1.Перелiк;\
		 \n2.Змiна розмiру масиву;\
		 \n3.Сортування за мiстом;\
		 \n4.Сортування за датою;\
		 \n5.Мiсто 'розмовлялка';\
		 \n6.Пошук;\
		 \n0.Exit;\
		 \nВаш вибiр: ");
		scanf_s("%d", &choose);
			 if (choose == 1)
			displayArray(massiveStruct, dimension);
		else if (choose == 2)
			changes = 1;
		else if (choose == 3)
			sortByCodeTown(massiveStruct, dimension);
		else if (choose == 4)
			sortByDate(massiveStruct, dimension);
		else if (choose == 5)
			topTown(massiveStruct, dimension);
		else if (choose == 6)
			choise(massiveStruct, dimension);
	} while (choose != 0);
	save(massiveStruct, dimension, dataName);
	free(massiveStruct); //Освобождение памяти
}
/*
* При виконанні завдання необхідно:

+1. Ім’я файлу задається в командному рядку. 
+Якщо воно там не було за-дано, то після відповідного запиту вводиться користувачем.

+2. Використовувати динамічне виділення пам’яті (розмір масиву задаєть-ся користувачем після відповідного запиту). 
+Після використання масиву слід обов’язково звільнити пам’ять.

+3. Пошук інформації здійснювати двома методами — лінійним та бінар-ним.

+4. Вихідну інформацію виводити у вигляді таблиці і записувати до файлу.

+5. Інформацію для пошуку слід вводити з клавіатури.

+Є інформація про міжміські телефонні розмови: дата, код міста, трива-лість розмови (в хвилинах), тариф.
+Знайти місто, з яким у вересні розмовляли найчастіше 
+упорядкувати коди міст за зростанням методом бульбашки (Bubble sort). 
+Організувати пошук телефонних розмов за датою
*/