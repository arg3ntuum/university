//#define _CRT_SECURE_NO_WARNINGS
#include <locale.h>
#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#define N 50
#define S 3
//записать в а из b
void toAfromB(char a[], char b[]) {
	for (int i = 0; i < S; i++)
		a[i] = b[i];
}
//Вывод в двоичном коде
void putsBinaryCode(int number)
{
	int i, mask = 1 << 15;

	for (i = 1; i <= 16; i++) {
		putchar(number & mask ? '1' : '0');
		number <<= 1;
		if (i % 4 == 0)
			putchar(' ');
	}
	puts("");
}
void pack_Char(char char1, char char2, char outName[])
{
	unsigned short int result;
	result = char1;
	printf("Результат у двiйковому видi символа %c: ", char1);
	putsBinaryCode(result);
	result <<= 8;
	printf("Результат у двiйковому видi символа %c: ", char2);
	putsBinaryCode(result);
	result |= char2;

	printf("Результат у двiйковому видi: ");
	putsBinaryCode(result);
	printf("Результат у десятковому видi: %d\n", result);
	

	putchar('\n');
	FILE* data;
	fopen_s(&data, outName, "w");
	if (!data) {
		puts("Failed to open file \n");
		exit(1);
	}
	fprintf(data, "%d ", &result);
	fclose(data);
}

void initArr(char inName[], char arr[]) {
	char str[S] = { 0 };
	FILE* data;
	fopen_s(&data, inName, "r");
	if (!data) {
		puts("Failed to open file \n");
		exit(1);
	}
	//Отримання строк у динамічний масив
	fscanf_s(data, "%s", str, S);//cчитать с файла
	toAfromB(arr, str);//str записать в arr
	fclose(data);//закрыть файл
}
int checkFile(char fileName[]) {
	FILE* data;
	char temp[3] = { 0 };
	fopen_s(&data, fileName, "rb+");
	if (!data) {
		printf("Файл не вiдкрився!\n");
		return 1;//ошибка
	}
	else {
		if (fgets(temp, 2, data) == NULL) {//если ничего не считало
			fclose(data);
			printf("Файл не вдалося зчитати.\nМожливо у файлi не має даних!\n");
			return 1;//ошибка
		}
		fclose(data);
	}
	return 0;//все хорошо
}
//функция кодировки
void code(char inName[], char outName[]) {
	char arr[S] = {0};
	
	initArr(inName, arr);//запись в arr
	
	pack_Char(arr[0], arr[1], outName);//кодировка + запись
	
	free(arr); //Звільнення пам'яті
}
//Главная функция
void main(int argc, char* argv[]) {
		setlocale(LC_ALL, "Rus"); //Локалізація
		//Kur_24_3.exe data.txt out.txt
		int error = 0;
		char in[N] = "data.txt", out[N] = "out.txt";
		//if (argc == 2 || argc == 3) {//смотрим скок аргументов
		//	if (argc == 2) {//1 аргумент = ошибка
		//		printf("Файл не был передан через аргументы при запуске!\n");
		//		error = 1;
		//	}
		//	if (argc == 3 && error == 0) {//если 2 аргумента, (data.txt and out.txt)
		//		error = checkFile(argv[1]);//проверить файл на открытие
		//		memcpy(in, argv[1], N);//переписать с argv[1] в in
		//		if (error == 0) {
		//			error = checkFile(argv[2]);//проверить файл на открытие
		//			memcpy(out, argv[2], N);//переписать с argv[2] в out
		//		}
		//	}
		//}
		//else {
		//	printf("Входной и выходной файлы не были переданы через аргументы при запуске!\n");
		//	error = 1;
		//}
		if (error == 0)
			code(in, out);
		system("pause"); //Стоп консоль
	
}
/*
* Рекомендації для виконання 3-го завдання:
1.	При відкритті чи створенні будь-яких файлів необхідно перевіряти наявність помилок введення-виведення.
2.	Результат виконання завдання на моніторі повинен бути представлений в наочній формі. 
Наприклад, виконання побітової операції «І» між числами 57894 і 2 можна представити наступним чином:
	    57894 = 11100010 00100110
&			2 = 00000000 00000010
Результат:  2 = 00000000 00000010
24.	
Скласти програму, що одержує два символи з клавіатури та передає їх функції pack_char(),
яка упаковує їх в одну змінну типу unsigned int. 
Програма повинна виводити початкові символи та результат в десятковому та двійковому представленні.
*/