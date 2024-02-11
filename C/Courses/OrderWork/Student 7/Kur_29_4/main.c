#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include <ctype.h>
#include <math.h>
#define	N 50
#define TIRE_LEADER puts("------------------------------------------------------------------------------------------------")
#define TABLE_LEADER puts("|  #  |  Прiзвище  |    Iм'я    | По-Батьковi |    Назва туру    | Зiбрано коштiв | Винагорода |")
#define TIRE puts("----------------------------------------------------------------------------------------------------------------------")
#define TABLE puts("|  #  |    Назва туру    |     Дата     |    Цiна    | Днiв |  Прiзвище  |    Iм'я    | По-Батьковi | Зiбрано коштiв |")
typedef struct {//cтруктурапро туристичні тури
	char nazva[N];//назва
	int cost;//ціна за тур
	int data[3];//дата числа масив(день.месяц.год)
	int days;//кількість днів туру
	int collectMoney;
	char PIB[3][N];
} Tour;
void writeToFirstFromSecond(char a[], char b[]) {
	for (int i = 0; i < N; i++)
		a[i] = b[i];
}
int calcDays(int date[]) { return date[2] * 365 + date[1] * 30 + date[0]; }
void checkFiles(char file[]) {
	FILE* data;
	fopen_s(&data, file, "rb+");
	if (!data) {
		printf("Файл %s не найден!\n", file);
		exit(0);
	}
	else {
		printf("Файл %s погдружен!\n", file);
		fclose(data);
	}
}
int check(char file[]) {
	int i;
	Tour tour;
	FILE* data;
	fopen_s(&data, file, "r");//чтение
	if (!data) {
		puts("Файл не открылся.\n");
		exit(1);
	}
	for (i = 0;; i++) {
		fscanf_s(data, "%s ", tour.nazva, N);
		fscanf_s(data, "%d ", &tour.cost);
		fscanf_s(data, "%d ", &tour.data[0]);
		fscanf_s(data, "%d ", &tour.data[1]);
		fscanf_s(data, "%d ", &tour.data[2]);
		fscanf_s(data, "%d ", &tour.days);
		fscanf_s(data, "%d ", &tour.collectMoney);
		fscanf_s(data, "%s ", tour.PIB[0], N);
		fscanf_s(data, "%s ", tour.PIB[1], N);
		fscanf_s(data, "%s ", tour.PIB[2], N);
		if (tour.data[0] == 0 && tour.data[1] == 0 && tour.data[2] == 0 && tour.cost == 0 && tour.days == 0 && tour.collectMoney == 0)
			break;
	}
	fclose(data);
	return i;
}
Tour initTour(FILE* data) {
	Tour tour;
	fscanf_s(data, "%s ", tour.nazva, N);
	fscanf_s(data, "%d ", &tour.cost);
	fscanf_s(data, "%d ", &tour.data[0]);
	fscanf_s(data, "%d ", &tour.data[1]);
	fscanf_s(data, "%d ", &tour.data[2]);
	fscanf_s(data, "%d ", &tour.days);
	fscanf_s(data, "%d ", &tour.collectMoney);
	fscanf_s(data, "%s ", tour.PIB[0], N);
	fscanf_s(data, "%s ", tour.PIB[1], N);
	fscanf_s(data, "%s ", tour.PIB[2], N);
	return tour;
}
Tour* initArr(int dimension, char dataName[]) {
	Tour* massive = (Tour*)malloc(dimension * sizeof(Tour));//создаем масив стуктур
	if (massive == NULL)
		return NULL;
	int vubor = 0;
	//открываем файл
	FILE* data;
	fopen_s(&data, dataName, "r");
	if (!data) {
		puts("Файл не змiг вiдкритися.\n");
		exit(1);
	}
	//создаем цикл для считывания данных
	for (int i = 0; i < dimension; i++)
		massive[i] = initTour(data);
	fclose(data);
	return massive;
}
void displayTV(Tour tour, int i) {
	printf("|%4d.| %16s |  %2d.%2d.%4d  | %6d грн | %4d | %10s | %10s | %11s | %10d грн |\n", i + 1, tour.nazva,
		tour.data[0], tour.data[1], tour.data[2], tour.cost, tour.days, tour.PIB[0], tour.PIB[1], tour.PIB[2], tour.collectMoney);
	TIRE;
}
void displayAll(Tour* massive, int dimension) {
	TIRE;
	TABLE;
	TIRE;
	for (int i = 0; i < dimension; i++)
		displayTV(massive[i], i);
}
int changeSizeStruct(int dimension) {
	int size = 0;
	do {
		printf("Введите размер создаваемого массива: ");
		scanf_s("%d", &size);
		if (size > dimension)
			printf("Размер не может быть больше '%d'!\n", dimension);
		else if (size <= 0)
			puts("Размер не может быть меньше или приравниваться к 0!", dimension);
	} while (!(size > 0 && size <= dimension));
	return size;
}
void insertionSortByData(Tour* massive, int dimension) {
	Tour key;
	int i, j;
	for (i = 1; i < dimension; i++) {
		key = massive[i];
		j = i - 1;
		while (j >= 0 && calcDays(massive[j].data)> calcDays(key.data)) {
			massive[j + 1] = massive[j];
			j = j - 1;
		}
		massive[j + 1] = key;
	}
}
void sortByDay(Tour* massive, int dimension) {
	Tour temp;
		for (int i = 0; i <= dimension; i++)
			for (int j = dimension - 1; j > i; j--)
				if (massive[j].days < massive[j - 1].days) {
					temp = massive[j - 1];
					massive[j - 1] = massive[j];
					massive[j] = temp;
				}
}
void sortPIB(Tour* massive, int dimension) {
	Tour temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (strcmp(massive[j].PIB[0], massive[j - 1].PIB[0]) < 0) {
				temp = massive[j];
				massive[j] = massive[j - 1];
				massive[j - 1] = temp;
			}
}
int chooseDay() {
	int day = 0;
	do {
		printf("Введите количество дней тура для поиска: ");
		scanf_s("%d", &day);
		if (day > 0)
			break;
		else puts("Введите правильные данные!");
	} while (1);
	return day;
}
void lineChoise(Tour* massive, int dimension, int day) {
	int first = 0;
	for (int i = 0, nomer = 0; i < dimension; i++) {
		if (massive[i].days == day) {
			if (first == 0) {
				TIRE;
				TABLE;
				TIRE;
				first = 1;
			}
			displayTV(massive[i], nomer++);
		}
	}
	if (first == 0)
		puts("Нiчого не знайдено!");
}
void choiseBinareFoundUp(Tour* massive, int dimension, int daysFound, int center, int nomer) {
	for (int i = center; i < dimension; i++)
		if (massive[i].days == daysFound)
			displayTV(massive[i], nomer++);
}
void choiseBinareFoundDown(Tour* massive, int dimension, int daysFound, int center, int nomer) {
	for (int i = center; i >= 0; i--)
		if (massive[i].days == daysFound)
			displayTV(massive[i], nomer++);
}
void choiseBinare(Tour* massive, int dimension, int daysFound) {
	int center = round(dimension / 2); //Центр структур звонков
	static nomer = 0;
	TIRE;
	TABLE;
	TIRE;
	sortByDay(massive, dimension);
	if (massive[center].days < daysFound)
		choiseBinareFoundUp(massive, dimension, daysFound, center, nomer);
	else if (massive[center].days > daysFound)
		choiseBinareFoundDown(massive, dimension, daysFound, center, nomer);
	else if (massive[center].days == daysFound) {
		if (dimension == 1)
			displayTV(massive[0], nomer++);
		else if (dimension == 2)
			for (int i = 0; i < dimension; i++) {
				if (massive[i].days == daysFound)
					displayTV(massive[i], nomer++);
			}	
		else if (dimension >= 3) {
			if ((massive[center].days == daysFound) && (massive[center - 1].days != daysFound) && (massive[center + 1].days != daysFound))
				displayTV(massive[center], nomer);
			else if ((massive[center].days == daysFound) && (massive[center - 1].days == daysFound) && (massive[center + 1].days != daysFound))
				choiseBinareFoundDown(massive, dimension, daysFound, center, nomer);
			else if ((massive[center].days == daysFound) && (massive[center - 1].days != daysFound) && (massive[center + 1].days == daysFound))
				choiseBinareFoundUp(massive, dimension, daysFound, center, nomer);
			else if (massive[center].days == daysFound && massive[center - 1].days == daysFound && massive[center + 1].days == daysFound)	
				for (int i = 0, nomer = 0; i < dimension; i++) 
					if (massive[i].days == daysFound)
						displayTV(massive[i], nomer++);
		}
	}
}
void choise(Tour* massive, int dimension) {
	int choose = 0, day = chooseDay();
	do {
		printf("Выберите способ поиска по количеству дней:\n1.Линейный;\n2.Бинарный;\n0.Exit;\nВаш выбор: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			lineChoise(massive, dimension, day);
		else if (choose == 2)
			choiseBinare(massive, dimension, day);
	} while (choose != 0);
}
int takeChoose(Tour* massive, int dimension) {
	int choose_num = 0;
	displayAll(massive, dimension);
	do {
		printf("Выберите путевку из списка за её номером: ");
		scanf_s("%d", &choose_num);
	} while (!(choose_num > 0 && choose_num <= dimension));
	choose_num--;
	return choose_num;
}
void takeTrip(Tour* massive, int dimension) {
	int choose_num = takeChoose(massive, dimension), count_trip = 0, how_much = 0;
	do {
		printf("Введите количество путевок: ");
		scanf_s("%d", &count_trip);
	} while (!(count_trip > 0));
	
	if (count_trip < 3) {
		how_much = count_trip * massive[choose_num].cost;
		printf("\nОбщая стоимость путевок: %d", how_much);
	}
	else if (count_trip >= 3 && count_trip <= 9) {
		how_much = round((count_trip * massive[choose_num].cost) * 0.95);
		printf("\nВам надана скидка 5%%. Общая стоимость путевок: %d", how_much);
	}
	else if (count_trip >= 10) {
		how_much = round((count_trip * massive[choose_num].cost) * 0.90);
		printf("\nВам надана скидка 10%%. Общая стоимость путевок: %d", how_much);
	}
	massive[choose_num].collectMoney += how_much;
}
void displayLeader(Tour tour, int dimension, int i) {
	printf("|%4d.| %10s | %10s | %11s | %16s | %10d грн | %6.4g грн |\n", i + 1, tour.PIB[0], tour.PIB[1], tour.PIB[2], tour.nazva, tour.collectMoney, tour.collectMoney * 0.042);
	TIRE_LEADER;
}
void leaderCheck(Tour* massive, int dimension, char dataFile[]) {
	sortPIB(massive, dimension);
	
	TIRE_LEADER;
	TABLE_LEADER;
	TIRE_LEADER;
	for (int i = 0; i < dimension ; i++)
		displayLeader(massive[i], dimension, i);
}
void writeTour(Tour tour, FILE* data) {
	fprintf(data, "%s ", tour.nazva);
	fprintf(data, "%d ", tour.cost);
	fprintf(data, "%d ", tour.data[0]);
	fprintf(data, "%d ", tour.data[1]);
	fprintf(data, "%d ", tour.data[2]);
	fprintf(data, "%d ", tour.days);
	fprintf(data, "%d ", tour.collectMoney);
	fprintf(data, "%s ", tour.PIB[0]);
	fprintf(data, "%s ", tour.PIB[1]);
	fprintf(data, "%s\n", tour.PIB[2]);
}
void write(Tour* massive, int dimension, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	if (!data) {
		puts("Failed to open file \n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		writeTour(massive[i], data);
	fprintf(data, "- 0 0 0 0 0 0 - - -\n");
	fclose(data);
}
void main(int argc, char* argv[]) {
	setlocale(LC_ALL, "");
	char dataName[N] = "data.txt";
	if (argc == 2) {
		printf("Файл було передано через аргумент!\n");
		writeToFirstFromSecond(dataName, argv[1]);
		checkFiles(dataName);
	}
	else {
		printf("Щоб пiгрузити файл, требе ввести його назву далi: ");
		scanf_s("%s", dataName, N - 1);
		checkFiles(dataName);
	}
	int dimension = check(dataName), choose = 0;
	Tour* massiveStruct = initArr(dimension, dataName);
	do {
		puts("\tМ Е Н Ю\
		 \n1.Список туров;\
		 \n2.Изменить размер массива;\
		 \n3.Сортировка за датой;\
		 \n4.Поиск по кол-ву дней поездки;\
		 \n5.Заказать путевки;\
		 \n6.Узнать заработок руководителей групп;\
		 \n0.Exit;\
		 \nВаш вибiр: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			displayAll(massiveStruct, dimension);
		else if (choose == 2) {
			dimension = changeSizeStruct(check(dataName));
			massiveStruct = initArr(dimension, dataName);
		}
		else if (choose == 3)
			insertionSortByData(massiveStruct, dimension);
		else if (choose == 4)
			choise(massiveStruct, dimension);
		else if (choose == 5)
			takeTrip(massiveStruct, dimension);
		else if (choose == 6)
			leaderCheck(massiveStruct, dimension, dataName);
	} while (choose != 0);
	write(massiveStruct, dimension, dataName);
	free(massiveStruct); //Освобождение памяти
}
/*
		+1.	Ім’я файлу задається в командному рядку. Якщо воно там не було задано, то після відповідного запиту вводиться користувачем.
		+2.	Використовувати динамічне виділення пам’яті (розмір масиву задається користувачем після відповідного запиту). 
		+Після використання масиву слід обов’язково звільнити пам’ять.
		+3.	Пошук інформації здійснювати двома методами — лінійним та бінарним.
		+4.	Вихідну інформацію виводити у вигляді таблиці і записувати до файлу.
		+5.	Інформацію для пошуку слід вводити з клавіатури.


								29 variant
		+Є інформація про туристичні тури: 
		+назва, ціна за тур, дата початку туру, кількість днів туру, ПІБ керівника групи. 
		При замовленні 3 путівок однією людиною діє знижка 5 %, при замовленні понад 10 путівок (для групи туристів) знижка — 10 %. 
		+Розрахувати винагороду керівників груп, якщо вони мають 4,2 % від загальної суми, яку зібрав відповідний тур.
		+Впорядкувати інформацію за датою початку туру методом вставок (Insertion sort). 
		+Організувати пошук туру за кількістю днів поїздки.
*/