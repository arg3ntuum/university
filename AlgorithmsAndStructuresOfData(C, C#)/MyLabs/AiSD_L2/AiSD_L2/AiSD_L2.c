#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#define N 50
typedef struct {
	char Name[N];
	char* SecondName;
    float Number;//nomer//Переменная плаваю- щего типа. 

	unsigned long SizeOfMassive;//Переменная беззнакового длинного целого типа; 
	long* Massive;//Указатель на длинный целый тип; 
} List;
void writeToFrom(char a[], char b[]) {
	for (int i = 0; i < strlen(b) + 1; i++)
		a[i] = b[i];
}
void safeScanf(int* a) {
	char temp[N];
	int error = 0;
	do {
		error = 0;
		scanf_s("%s", &temp, N - 1);
		for (int a = 0; a < strlen(temp); a++)
			if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
				error = 1;
		if (error == 1)
			printf("Вводите только числа!\n");
		else {
			*a = atoi(temp);
			break;
		}
	} while (1);
}
List TakeElement() {
	List list;

	printf("\nВведите название: ");
	scanf_s("%s", &list.Name, N);

	char SName[N];
	printf("\nВведите фамилию: ");
	scanf_s("%s", &SName, N - 1);

	list.SecondName = (char*)malloc((strlen(SName) + 1)* sizeof(char));
	writeToFrom(list.SecondName, SName);

	printf("\nВведите номер: ");
	scanf_s("%f", &list.Number);

	list.SizeOfMassive = 0;
	return list;
}
List* initArray(int dimension) {
	List* massive = (List*)malloc(dimension * sizeof(List));

	if (massive == NULL)
		return NULL;

	for(int i = 0; i < dimension; i++)
		massive[i] = TakeElement();

	return massive;
}
void ViewInfoElement(int i, List list ) {
	printf("%d | %s - %s - %f\n", i, list.Name, list.SecondName, list.Number);
} 
void ViewInfo(List* lists, int dimension) {
	for(int i = 0; i < dimension; i++)
		ViewInfoElement(i, lists[i]);
}
List Change(List list_) {
	List list;
	int choose = 0;
	do {
		printf("Ввведите количество цифр, что хотите записать в массив: ");
		safeScanf(&choose);
		if (choose >= 1)
			break;
	} while (1);

	list.SizeOfMassive = (long)choose;
	list.Massive = (long*)malloc(list.SizeOfMassive * sizeof(long));
	for (int i = 0, num = 0; i < list.SizeOfMassive; i++) {
		safeScanf(&num);
		list.Massive[i] = num;
	}
	return list;
}
void ChooseChangeMassiveInLists(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для изменений: ");
		safeScanf(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = Change(lists[choosed]);
}
void MassiveOutPut(List list) {
	puts("Массив чисел: ");
	for (int i = 0; i < list.SizeOfMassive; i++)
		printf("%ld ", list.Massive[i]);
}
void ChooseMassiveOutPut(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для вывода: ");
		safeScanf(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	if (lists[choosed].SizeOfMassive > 0)
		MassiveOutPut(lists[choosed]);
	else puts("Пустой массив чисел.");
}
void ChooseElementToChange(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для изменений: ");
		safeScanf(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = TakeElement();
}
int TakeDimension() {
	int chooseNum = 0;
	do {
		safeScanf(&chooseNum);
		if (chooseNum > 0 && chooseNum < 10)
			break;
		else if (chooseNum >= 10)
			printf("\nНе нужно делать больше 10, неудобно потом будет)");
	} while (1);
	return chooseNum;
}
void main()
{
	setlocale(LC_ALL, "Rus");
	List* massiveStruct = NULL;
	int choose = 0;
	int dimension = 4;
	do {
		puts("\nМеню: \
			\n1. Инициализация структуры;\
			\n2. Заполнение массива чисел;\
			\n3. Вывода на экран массива чисел;\
			\n4. Ввода информации в строки имени и фамилии и другие поля;\
			\n5. Bывода на экран всех полей структуры, кроме массива чиcел;\
			\n6. Функцию освобождения динамической памяти;\
			\n0. Exit");
		safeScanf(&choose);
		
		if (choose == 1) {
			if (massiveStruct == NULL)
				massiveStruct = initArray(dimension);
			else puts("Массив не равен NULL!");
		}
		else if (choose == 2 && massiveStruct != NULL)
			ChooseChangeMassiveInLists(massiveStruct, dimension);
		else if (choose == 3 && massiveStruct != NULL)
			ChooseMassiveOutPut(massiveStruct, dimension);
		else if (choose == 4 && massiveStruct != NULL)
			ChooseElementToChange(massiveStruct, dimension);
		else if (choose == 5 && massiveStruct != NULL)
			ViewInfo(massiveStruct, dimension);
		else if (choose == 6)
		{
			free(massiveStruct);//очищення пам'яті
			puts("Память очищена!");
			massiveStruct = NULL;
		}
	} while (choose!= 0);
}
/*

*/