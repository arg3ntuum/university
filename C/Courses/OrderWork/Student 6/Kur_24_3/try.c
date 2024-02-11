#define _CRT_SECURE_NO_WARNINGS
#include <locale.h>
#include <stdio.h>
#include <windows.h>
#define N 50

//Перевірка файлів
int checkFile(char fileName[]) {
	FILE* data;
	char temp[3] = {0};
	fopen_s(&data,fileName, "rb+");
	if (!data) {
		printf("Файл не вiдкрився!\n");
		return 1;
	}
	else {
		if (fgets(temp, 2, data) == NULL) {
			fclose(data);
			printf("Файл не вдалося зчитати.\nМожливо у файлi не має даних!\n");
			return 1;
		}
		fclose(data);
	}
	return 0;
}

//Кількість даних
int fileSize(char fileName[]) {
	int counter = 0;
	FILE* data;
	fopen_s(&data, fileName, "r");
	while (!feof(data)) {
		if (fgetc(data) == '\n')
			counter++;
	}
	counter++;
	fclose(data);
	return counter;
}

//Запис масиву у файл
void writeToFile(char** arr, int size, char fileName[]) {
	FILE* data;
	fopen_s(&data, fileName, "w");
	for (int i = 0; i < size; i++)
		if (size - i == 1) 
			fprintf(data, "%s", arr[i]);
		else fprintf(data, "%s\n", arr[i]);
	fclose(data);
}

//Ініціалізація масиву
void initArr(char inName[], int size, char **arr) {
	char str[N] = {0};
	FILE* data;
	fopen_s(&data, inName, "r");

	//Отримання строк у динамічний масив
	for (int i = 0; i < size; i++) {
		fgets(str, N, data);
		if (strstr(str, "\n")) {
			str[strlen(str) - 1] = '\0';
		}
		strcpy(arr[i], str);
	}
	fclose(data);
}

//Функція кодування
void codeOrDecode(char inName[], char outName[], int choose) {
	int size = fileSize(inName);

	char** arr = (char**)malloc(size * sizeof(char*));
	for (int i = 0; i < size; i++)
		arr[i] = (char*)malloc(N * sizeof(char));

	//initArr(inName, size, arr);

	//Цикл кодування/декодування символів
	for (int i = 0; i < size; i++) {
		printf("%s ->", arr[i]);
		for (int j = 0; j < strlen(arr[i]); j++) {
			unsigned char x;
			x = arr[i][j];
			x = (x << 7) | (x >> 7) | (x & 0x7E);
			arr[i][j] = x;
		}
		printf(" %s\n", arr[i]);
	}

	writeToFile(arr, size, outName); //Запис у файл
	free(arr); //Звільнення пам'яті
}

//Головна функція програми
void main(int argc, char* argv[]) {
	//Kur_18_3.exe data.txt out.txt
	setlocale(LC_ALL, ""); //Локалізація
	int choice, error = 0;
	char in[N] = { 0 }, out[N] = { 0 };
	if (argc == 2 || argc == 3) {
		if (argc == 2) {
		printf("Файл не был передан через аргументы при запуске!\n");
		error = 1;
		}
		if (argc == 3 && error == 0) {
			error = checkFile(argv[1]);
			memcpy(in, argv[1], N);
			if (error == 0) {
				error = checkFile(argv[2]);
				memcpy(out, argv[2], N);
			}	
		}
	}
	else {
		printf("Входной и выходной файлы не были переданы через аргументы при запуске!\n");
		error = 1;
	}
	//Вибір кодування/декодування
	if (error == 0) {
		do {
			printf("З файлу '%s' до '%s'\nВиберiть дiю:\n1-Кодування\n2-Декодування\nВиберiть дiю: ", in, out);
			scanf_s("%d", &choice);
		} while (choice != 1 && choice != 2);
		codeOrDecode(in, out, choice);
	}
	system("pause"); //Стоп консоль
}
/*
* Рекомендації для виконання 3-го завдання:
1.	При відкритті чи створенні будь-яких файлів необхідно перевіряти наявність помилок введення-виведення.
2.	Результат виконання завдання на моніторі повинен бути представлений в наочній формі. Наприклад, виконання побітової операції «І» між числами 57894 і 2 можна представити наступним чином:
	57894 = 11100010 00100110
&		2 = 00000000 00000010
Результат:       	2 = 00000000 00000010

18.	Скласти програму,
що кодує текстовий файлшляхом перестановки першого та останнього бітів у байті. 
Передбачити можливість декодування. Для кодування символу скласти функцію.
*/