#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include <ctype.h>
#include <math.h>
#define	N 50
#define TIRE puts("--------------------------------------------------------------------------")
#define TABLE puts("|  #  |     Дата     |     Марка     | Дiагональ |   Виробник   |  Цiна  |")
typedef struct {//cтруктура
	char virobnik[N];//изготовитель масив
	char marka[N];//марка телевизора масив
	int sizeDiagonal;//размер диагонали число
	int data[3];//дата числа масив(день.месяц.год)
	int price;//цена число
} TV;
//Записать в масив А символы B
void writeToFirstFromSecond(char a[], char b[]) {
	for (int i = 0; i < N; i++)
		a[i] = b[i];
}
//проверить файлы
void checkFiles(char file[]) {
	setlocale(LC_ALL, "Russian");
	FILE* data;
	fopen_s(&data, file, "rb+");
	if (!data) {
		printf("Файл %s ми не знайшли!\n", file);
		exit(0);
	}
	else {
		printf("Файл %s ми пiдключили!\n", file);
		fclose(data);
	}
}
//считываем флажок в структурах (- 0 0 0 0 0 -) и возвращаем ее координату.(координата = количество структур)
int foundHowMuchStructInFile(char file[]) {
	int i;
	TV tv;
	FILE* data;
	fopen_s(&data, file, "r");//чтение
	if (!data) {
		puts("Файл не змiг вiдкритися.\n");
		exit(1);
	}
	for (i = 0;; i++) {
		fscanf_s(data, "%s ", tv.virobnik, N);
		fscanf_s(data, "%d ", &tv.sizeDiagonal);
		fscanf_s(data, "%d ", &tv.data[0]);
		fscanf_s(data, "%d ", &tv.data[1]);
		fscanf_s(data, "%d ", &tv.data[2]);
		fscanf_s(data, "%d ", &tv.price);
		fscanf_s(data, "%s ", tv.marka, N);
		if (tv.data[0] == 0 && tv.data[1] == 0 && tv.data[2] == 0 && tv.sizeDiagonal == 0)
			break;
	}
	fclose(data);
	return i;
}
//считываем с файла данные в структуру
TV initTV(FILE* data) {
	TV tv;//создаем структуру в которую все запишем
	fscanf_s(data, "%s ", tv.virobnik, N);
	fscanf_s(data, "%d ", &tv.sizeDiagonal);
	fscanf_s(data, "%d ", &tv.data[0]);
	fscanf_s(data, "%d ", &tv.data[1]);
	fscanf_s(data, "%d ", &tv.data[2]);
	fscanf_s(data, "%d ", &tv.price);
	fscanf_s(data, "%s ", tv.marka, N);
	return tv;//возвращаем структуру
}
//создаем масив стуктур
TV* initArr(int dimension, char dataName[]) {
	TV* massive = (TV*)malloc(dimension * sizeof(TV));//создаем масив стуктур
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
		massive[i] = initTV(data);
	fclose(data);
	return massive;
}
//Вывод одной книги 
void displayTV(TV tv, int i) {
	printf("|%4d.|  %2d.%2d.%4d  | %13s |  %5d''  | %12s |  %5d | \n", i + 1, 
		tv.data[0], tv.data[1], tv.data[2], tv.marka, tv.sizeDiagonal, tv.virobnik, tv.price);
	TIRE;
}
//вывод масива стуктур
void displayAll(TV* massive, int dimension) {
	//вверхняя часть таблицы
	TIRE;
	TABLE;
	TIRE;
	//часть таблицы с данными. цикл по выводу масива структур
	for (int i = 0; i < dimension; i++) {
		displayTV(massive[i], i);
	}
}
//зміна розміру масиву
int changeSizeStruct(int dimension) {
	int sizeStruct = 0;
	do {
		printf("Уведiть розмiр створюваного масиву: ");
		scanf_s("%d", &sizeStruct);
		if (sizeStruct > dimension)
			printf("Розмiр не може перевищувати дане значення '%d'!\n", dimension);
		else if (sizeStruct <= 0)
			puts("Розмiр не може бути нижче або дорiвнювати 0! Це не можливо!", dimension);
	} while (!(sizeStruct > 0 && sizeStruct <= dimension));//если не больше возможного количества и больше нуля
	return sizeStruct;
}
int COUNTdays(int date[]) {return date[2] * 365 + date[1] * 30 + date[0];}//считаем кол-во дней по формуле: год * 365 + месяц * 30 + дней
int COUNTmonth(int element1, int element2) {return element1 + element2 * 12;}//считаем кол-во месяцев по формуле: год * 12 + месяц
//сортировка методом коктеля
void sortCoctailByDate(TV* massive, int dimension) {
	int left = 0, right = dimension - 1; 
	int changesTrue = 1;  
	TV temp;
	while ((left < right) && changesTrue > 0) {
		changesTrue = 0;
		for (int i = left; i < right; i++)  {
			if (COUNTdays(massive[i].data)> COUNTdays(massive[i + 1].data)) {             
				temp = massive[i];
				massive[i] = massive[i + 1];
				massive[i + 1] = temp;
				changesTrue = 1;      
			}
		}
		right--; 
		for (int i = right; i > left; i--) {
			if (COUNTdays(massive[i - 1].data) > COUNTdays(massive[i].data)) {          
				temp = massive[i];
				massive[i] = massive[i - 1];
				massive[i - 1] = temp;
				changesTrue = 1;    
			}
		}
		left++; 
	}
}
void sortDiagonal(TV* massive, int dimension) {
	TV temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (massive[j].sizeDiagonal < massive[j - 1].sizeDiagonal) {
				temp = massive[j - 1];
				massive[j - 1] = massive[j];
				massive[j] = temp;
			}
}
//выбор месяца
void chooseMonth(int downLim[], int massive[]) {
	int month[2] = { 0 };
	do {
		if (downLim[0] == 0)
			printf("Уведiть нижнє обмеження (мiсяць, рiк, 09.2003): ");
		else printf("Уведiть верхнє обмеження (мiсяць, рiк, 09.2003): ");
		scanf_s("%d.%d", &month[0], &month[1]);
	} while (!(month[0] >= 1 && month[0] <=12 && month[0] >= downLim[0] && month[1] > 0 && month[1] >= downLim[1] ));
	//запись выбранного
	massive[0] = month[0];
	massive[1] = month[1];
}
//выбор марки
void chooseMarka(char markFunk[], TV* massive, int dimension)
{
	char marka[N] = { 0 };
	int error = 0;
	do {
		printf("Уведiть назву марки: ");
		scanf_s("%s", marka, N - 1);
		for (int i = 0; i < dimension; i++) 
			if (strcmp(massive[i].marka, marka) == 0)//если одинаковые
				error = 1;
		if (error == 0)
			puts("Марку не знайдено!");
	} while (error == 0);
	writeToFirstFromSecond(markFunk, marka);//запись
}
//поиск тв за месяц
void foundTVforMonth(TV* massive, int dimension) {
	int clearmassive[2] = { 0, 0 }, dataDown[2] = { 0 }, dataUp[2] = { 0 }, matrixMonth = 0, maxMonth = 0, minMonth = 0, check = 0, num = 0;
	chooseMonth(clearmassive, dataDown);
	chooseMonth(dataDown, dataUp);
	char marka[N] = { 0 };
	chooseMarka(marka, massive, dimension);
	maxMonth = COUNTmonth(dataUp[0], dataUp[1]);
	minMonth = COUNTmonth(dataDown[0], dataDown[1]);
	for (int i = 0; i < dimension; i++) {
		matrixMonth = COUNTmonth(massive[i].data[1], massive[i].data[2]);
		if (matrixMonth >= minMonth && matrixMonth <= maxMonth && strcmp(massive[i].marka, marka) == 0){
			if (check == 0) {
				check = 1;
				TIRE;
				TABLE;
				TIRE;
			}
			displayTV(massive[i], num++);
		}
	}
}
//выбор диагонали для поиска
int writeDiagonal() {
	int diag = 0;
	do {
		printf("Уведiть дiагональ для пошуку: ");
		scanf_s("%d", &diag);
		if (diag > 0)
			break;
		else puts("Уведiть корректнi данi!");
	} while (1);
	return diag;
}
//линейный поиск
void lineChoise(TV* massive, int dimension, int diagonalFind) {
	int first = 0;
	for (int i = 0, nomer = 0; i < dimension; i++) {
		if (massive[i].sizeDiagonal == diagonalFind) {
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
//бинарный поиск от центра вверх
void BinareToUp(TV* massive, int dimension, int diagonalFind, int center, int nomer) {
	for (int i = center; i < dimension; i++)
		if (massive[i].sizeDiagonal == diagonalFind) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayTV(massive[i], nomer++);
		}
}		
//бинарный поиск от центра вниз
void BinareToDown(TV* massive, int dimension, int diagonalFind, int center, int nomer) {
	for (int i = center; i >= 0; i--)
		if (massive[i].sizeDiagonal == diagonalFind) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayTV(massive[i], nomer++);
		}
}
//бинарный поиск главная функция
void Binare(TV* massive, int dimension, int diagonalFind) {
	int center = round(dimension / 2);
	static nomer = 0;
	sortDiagonal(massive, dimension);
	if (massive[center].sizeDiagonal < diagonalFind)
		BinareToUp(massive, dimension, diagonalFind, center, nomer);
	else if (massive[center].sizeDiagonal > diagonalFind)
		BinareToDown(massive, dimension, diagonalFind, center, nomer);
	else if (massive[center].sizeDiagonal == diagonalFind) {
		if (dimension == 1) {
			TIRE;
			TABLE;
			TIRE;
			displayTV(massive[0], nomer++);
		}	
		else if (dimension == 2) {
			nomer++;
			lineChoise(massive, dimension, diagonalFind);
		}
		else if (dimension >= 3) { 
			if ((massive[center].sizeDiagonal == diagonalFind) && massive[center - 1].sizeDiagonal != diagonalFind && massive[center + 1].sizeDiagonal != diagonalFind) {
				TIRE;
				TABLE;
				TIRE;
				displayTV(massive[0], nomer++);
			}
			else if (massive[center].sizeDiagonal == diagonalFind && massive[center - 1].sizeDiagonal == diagonalFind && massive[center + 1].sizeDiagonal != diagonalFind)
				BinareToDown(massive, dimension, diagonalFind, center, nomer);
			else if (massive[center].sizeDiagonal == diagonalFind && massive[center - 1].sizeDiagonal != diagonalFind && massive[center + 1].sizeDiagonal == diagonalFind)
				BinareToUp(massive, dimension, diagonalFind, center, nomer);
			else if (massive[center].sizeDiagonal == diagonalFind && massive[center - 1].sizeDiagonal == diagonalFind && massive[center + 1].sizeDiagonal == diagonalFind) {
				nomer++;
				lineChoise(massive, dimension, diagonalFind);
			}
			
		}
	}
	//if (nomer <= 0) puts("Нiчого не знайдено!");
}
//запись массива
void writingToFileTV(TV tv, FILE* data) {
	fprintf(data, "%s ", tv.virobnik);
	fprintf(data, "%d ", tv.sizeDiagonal);
	fprintf(data, "%d ", tv.data[0]);
	fprintf(data, "%d ", tv.data[1]);
	fprintf(data, "%d ", tv.data[2]);
	fprintf(data, "%d ", tv.price);
	fprintf(data, "%s ", tv.marka);
}
void writingToFileMassive(TV* massive, int dimension, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	if (!data) {
		puts("Не відкрився.\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		writingToFileTV(massive[i], data);
	fprintf(data, "- 0 0 0 0 0 -\n");
	fclose(data);
}
//функция выбора поиска
void choise(TV* massive, int dimension) {
	int choose = 0, diagonalFind = writeDiagonal();
	do {
		printf("Меню\n1.Лiнiйний пошук за дiагоналi;\n2.Бiнарний пошук за дiагоналi;\n0.Exit;\nВаш вибiр: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			lineChoise(massive, dimension, diagonalFind);
		else if (choose == 2)
			Binare(massive, dimension, diagonalFind);
	} while (choose != 0);
}
//главная функция
void main(int argc, char* argv[]) {
	setlocale(LC_ALL, ""); //Локализация
	char dataName[N] = { 0 };
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
	system("pause");
	system("cls");
	int dimension = foundHowMuchStructInFile(dataName), choose = 0;
	TV* massiveStruct = initArr(dimension, dataName);
	do {
		puts("\tМ Е Н Ю\
		 \n1.Всi операцiї;\
		 \n2.Помiняти розмiр масиву;\
		 \n3.Сортування за датою;\
		 \n4.Кiлькiсть проданих телевiзорiв обраної марки в обраний перiод;\
		 \n5.Пошук за дiагоналлю телевiзора;\
		 \n0.Exit;\
		 \nВаш вибiр: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			displayAll(massiveStruct, dimension);
		else if (choose == 2) {
			dimension = changeSizeStruct(foundHowMuchStructInFile(dataName));
			massiveStruct = initArr(dimension, dataName);
		}
		else if (choose == 3)
			sortCoctailByDate(massiveStruct, dimension);
		else if (choose == 4)
			foundTVforMonth(massiveStruct, dimension);
		else if (choose == 5)
			choise(massiveStruct, dimension);
	} while (choose != 0);
	writingToFileMassive(massiveStruct, dimension, dataName);//запись в файл
	free(massiveStruct); //Освобождение памяти
}
/*
+1.	Ім’я файлу задається в командному рядку. Якщо воно там не було задано, то після відповідного запиту вводиться користувачем.
+2.	Використовувати динамічне виділення пам’яті (розмір масиву задається користувачем після відповідного запиту). 
+Після використання масиву слід обов’язково звільнити пам’ять.
+3.	Пошук інформації здійснювати двома методами — лінійним та бінарним.
+4.	Вихідну інформацію виводити у вигляді таблиці і записувати до файлу.
+5.	Інформацію для пошуку слід вводити з клавіатури.
24 variant
+Є інформація щодо продажу телевізорів: країна-виробник, марка, розмір діагоналі, ціна за одиницю товару, дата продажу.
+Визначити кількість проданих телевізорів марки LG за останні три місяці.
+Впорядкувати інформацію за датою продажу телевізору методом шейкерного сортування (Cocktail sort).
+Організувати пошук телевізорів за розміром діагоналі.
*/