#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <windows.h>
#include <ctype.h>
#include <math.h>
#define	N 50
#define TIRE puts("---------------------------------------------------------")
#define TABLE puts("|  #  | Размер кубика | Цвет  кубика | Материал  кубика |")
#define TIRE_AMOUNT puts("-----------------------------------------")
typedef struct {//cтруктура
	int size;//размер
	int color;//цвет
	int material;//материал
} Cub;
void writeTo(char a[], char b[]) {
	for (int i = 0; i < N; i++)
		a[i] = b[i];
}
void openFile(char fileName[]) {
	setlocale(LC_ALL, "Russian");
	FILE* data;
	fopen_s(&data, fileName, "rb+");
	if (!data) {
		printf("Файл %s не открыт!\n", fileName);
		exit(0);
	}
	else {
		printf("Файл %s был открыт!\n", fileName);
		fclose(data);
	}
}
int check(char file[]) {
	int i;
	Cub cub;
	FILE* data;
	fopen_s(&data, file, "r");
	if (!data) {
		puts("Файл не был открыт.\n");
		exit(1);
	}
	for (i = 0; ; i++) {
		fscanf_s(data, "%d ", &cub.size);
		fscanf_s(data, "%d ", &cub.color);
		fscanf_s(data, "%d ", &cub.material);
		if (cub.size == 0 && cub.color == 0 && cub.material == 0)
			break;
	}
	fclose(data);
	return i;
}
Cub initTovar(FILE* data) {
	Cub cub;
	fscanf_s(data, "%d ", &cub.size);
	fscanf_s(data, "%d ", &cub.color);
	fscanf_s(data, "%d ", &cub.material);
	return cub;
}
Cub* initArr(int dimension, char dataName[]) {
	Cub* massive = (Cub*)malloc(dimension * sizeof(Cub));
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
		massive[i] = initTovar(data);
	fclose(data);
	return massive;
}
void displayCub(Cub cub, int i) {
	printf("|%4d.|  %12d | ", i + 1, cub.size);
	switch (cub.color) {
	case 1: printf("Красный цвет"); break;
	case 2: printf("Желтый  цвет"); break;
	case 3: printf("Зеленый цвет"); break;
	case 4: printf(" Синий цвет "); break;
	}
	printf(" | ");
	switch (cub.material) {
	case 1: printf("     Дерево     "); break;
	case 2: printf("     Картон     "); break;
	case 3: printf("     Железо     "); break;
	}
	printf(" |\n");
	TIRE;
}
void display(Cub* massive, int dimension) {
	TIRE;
	TABLE;
	TIRE;
	for (int i = 0; i < dimension; i++)
		displayCub(massive[i], i);
}
void writeCub(Cub kniga, FILE* data) {
	fprintf(data, "%d ", kniga.size);
	fprintf(data, "%d ", kniga.color);
	fprintf(data, "%d\n", kniga.material);
}
void write(Cub* massive, int dimension, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	if (!data) {
		puts("Файл не был открыт.\n");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		writeCub(massive[i], data);
	fprintf(data, "0 0 0\n");
	fclose(data);
}
int changeSize(int dimension) {
	int sizeOfMassive = 0;
	do {
		printf("Введите новый размер массива: ");
		scanf_s("%d", &sizeOfMassive);
		if (sizeOfMassive > dimension)
			printf("Размер не должен превышать '%d'!\n", dimension);
		else if (sizeOfMassive <= 0)
			puts("Размер не должен быть ниже или приравниваться к 0!", dimension);
	} while (!(sizeOfMassive > 0 && sizeOfMassive <= dimension));
	return sizeOfMassive;
}
void SortMaterialQuick(Cub* massive, int first, int last) {
	Cub temp;
	int i, j, index;
	if (first < last) {
		index = first;
		i = first;
		j = last;
		while (i < j) {
			while (massive[i].material <= massive[index].material && i < last)
				i++;
			while (massive[j].material > massive[index].material)
				j--;
			if (i < j) {
				temp = massive[i];
				massive[i] = massive[j];
				massive[j] = temp;
			}
		}
		temp = massive[index];
		massive[index] = massive[j];
		massive[j] = temp;
		SortMaterialQuick(massive, first, j - 1);
		SortMaterialQuick(massive, j + 1, last);
	}
}
void sortSize(Cub* massive, int dimension) {
	Cub temp;
	for (int i = 0; i <= dimension; i++)
		for (int j = dimension - 1; j > i; j--)
			if (massive[j].size < massive[j - 1].size) {
				temp = massive[j - 1];
				massive[j - 1] = massive[j];
				massive[j] = temp;
			}
}
int writeSize() {
	int size = 0;
	do {
		printf("Введите размер: ");
		scanf_s("%d", &size);
		if (size > 0)
			break;
		else puts("Введите корректные данные!");
	} while (1);
	return size;
}
void lineChoise(Cub* massive, int dimension, int sizeFound) {
	int first = 0;
	for (int i = 0, nomer = 0; i < dimension; i++) {
		if (massive[i].size == sizeFound) {
			if (first == 0) {
				TIRE;
				TABLE;
				TIRE;
				first = 1;
			}
			displayCub(massive[i], nomer++);
		}
	}
	if (first == 0)
		puts("При поиске ничего не найдено!");
}
void BinareUp(Cub* massive, int dimension, int sizeFound, int center, int nomer) {
	for (int i = center; i < dimension; i++)
		if (massive[i].size == sizeFound) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayCub(massive[i], nomer++);
		}
}
void BinareDown(Cub* massive, int dimension, int sizeFound, int center, int nomer) {
	for (int i = center; i >= 0; i--)
		if (massive[i].size == sizeFound) {
			if (nomer == 0) {
				TIRE;
				TABLE;
				TIRE;
			}
			displayCub(massive[i], nomer++);
		}
}
void Binare(Cub* m, int dimension, int size) {
	int center = round(dimension / 2);
	static nomer = 0;
	sortSize(m, dimension);
	if (m[center].size < size)
		BinareUp(m, dimension, size, center, nomer);
	else if (m[center].size > size)
		BinareDown(m, dimension, size, center, nomer);
	else if (m[center].size == size) {
		if (dimension == 1) {
			TIRE;
			TABLE;
			TIRE;
			displayCub(m[0], nomer++);
		}
		else if (dimension == 2) {
			nomer++;
			lineChoise(m, dimension, size);
		}
		else if (dimension >= 3) {
			if ((m[center].size == size) && m[center - 1].size != size && m[center + 1].size != size) {
				TIRE;
				TABLE;
				TIRE;
				displayCub(m[0], nomer++);
			}
			else if (m[center].size == size && m[center - 1].size == size && m[center + 1].size != size)
				BinareDown(m, dimension, size, center, nomer);
			else if (m[center].size == size && m[center - 1].size != size && m[center + 1].size == size)
				BinareUp(m, dimension, size, center, nomer);
			else if (m[center].size == size && m[center - 1].size == size && m[center + 1].size == size) {
				nomer++;
				lineChoise(m, dimension, size);
			}

		}
	}
	
}
void choise(Cub* massive, int dimension) {
	int choose = 0, diagonalFind = writeSize();
	do {
		printf("Меню\n1.Линейный поиск;\n2.Бинарный поиск;\n0.Выход;\nВаш выбор: ");
		scanf_s("%d", &choose);
		if (choose == 1)
			lineChoise(massive, dimension, diagonalFind);
		else if (choose == 2)
			Binare(massive, dimension, diagonalFind);
	} while (choose != 0);
}
int found(Cub* massive, int dimension, int nomer) {
	int count = 0;
	for (int i = 0; i < dimension; i++)
		if (massive[i].color == nomer)
			count++;
	return count;
}
int vCub(Cub* massive, int dimension) {
	int v = 0;
	for (int i = 0; i < dimension; i++)
		v += pow(massive[i].size, 3);
	return v;
}
void foundAmount(Cub* massive, int dimension) {
	TIRE_AMOUNT;
	printf("| Количество красных кубиков : %5d шт |\n", found(massive, dimension, 1));
	TIRE_AMOUNT;
	printf("| Количество  желтых кубиков : %5d шт |\n", found(massive, dimension, 2));
	TIRE_AMOUNT;
	printf("| Количество зеленых кубиков : %5d шт |\n", found(massive, dimension, 3));
	TIRE_AMOUNT;
	printf("| Количество  синих  кубиков : %5d шт |\n", found(massive, dimension, 4));
	TIRE_AMOUNT;
	TIRE_AMOUNT;
	printf("| Объём : %26d м3 |\n", vCub(massive, dimension));
	TIRE_AMOUNT;
}
void main(int argc, char* argv[]) {
	setlocale(LC_ALL, ""); 
	char dataName[N] = "0";
	if (argc == 2) {
		printf("Файл подгружен через аргумент!\n");
		writeTo(dataName, argv[1]);
		openFile(dataName);
	}
	else {
		printf("Введите название файла для подгрузки данных: ");
		scanf_s("%s", dataName, N - 1);
		openFile(dataName);
	}
	system("pause");
	system("cls");
	int dimension = check(dataName), choose = 0;
	Cub* massiveStruct = initArr(dimension, dataName);
	do {
		puts("\tМ Е Н Ю\
		 \n1.Список кубиков в наборе;\
		 \n2.Изменить размер массива;\
		 \n3.Сортировка по материалу;\
		 \n4.Найти количество кубиков и их объем;\
		 \n5.Поиск;\
		 \n0.Выход;\
		 \nВаш выбор: ");
		scanf_s("%d", &choose);
		if (choose == 1)	  display(massiveStruct, dimension);
		else if (choose == 2)  {
			dimension = changeSize(check(dataName));
			massiveStruct = initArr(dimension, dataName);
		}
		else if (choose == 3) SortMaterialQuick(massiveStruct, 0, dimension - 1);
		else if (choose == 4) foundAmount(massiveStruct, dimension);
		else if (choose == 5) choise(massiveStruct, dimension);
	} while (choose != 0);
	write(massiveStruct, dimension, dataName);
	free(massiveStruct);
}
/*
		+1.	Ім’я файлу задається в командному рядку. Якщо воно там не було задано, то після відповідного запиту вводиться користувачем.
		+2.	Використовувати динамічне виділення пам’яті (розмір масиву задається користувачем після відповідного запиту). 
		+Після використання масиву слід обов’язково звільнити пам’ять.
		+3.	Пошук інформації здійснювати двома методами — лінійним та бінарним.
		+4.	Вихідну інформацію виводити у вигляді таблиці і записувати до файлу.
		+5.	Інформацію для пошуку слід вводити з клавіатури.

		+20.	Є набір кубиків, для кожного з яких задано розмір (довжина ребра у са-нтиметрах), колір (червоний, жовтий, зелений, синій),  матеріал (дерево, кар-тон, залізо). 
		+Знайти кількість кубиків кожного кольору, сумарний об’єм кубиків
		+та упорядкувати кубики за матеріалом методом швидкого сортування (Quick Sort). 
		+Організувати пошук кубиків за розміром.
*/