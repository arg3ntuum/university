#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#define N 50
FILE* data2;
typedef struct {
	char Name[N];
	char* SecondName;
	float Number;//nomer//Переменная плаваю- щего типа. 

	unsigned long SizeOfMassive;//Переменная беззнакового длинного целого типа; 
	long* Massive;//Указатель на длинный целый тип; 
} List;
void writeToFrom_L2(char a[], char b[]) {
	for (int i = 0; i < strlen(b) + 1; i++)
		a[i] = b[i];
}
void safeScanf_L2(int* a) {
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
List TakeElement_L2() {
	List list;

	printf("\nВведите название: ");
	scanf_s("%s", &list.Name, N);

	char SName[N];
	printf("\nВведите фамилию: ");
	scanf_s("%s", &SName, N - 1);

	list.SecondName = (char*)malloc((strlen(SName) + 1) * sizeof(char));
	writeToFrom_L2(list.SecondName, SName);

	printf("\nВведите номер: ");
	scanf_s("%f", &list.Number);

	list.SizeOfMassive = 0;
	return list;
}
List* initArray_L2(int dimension) {
	List* massive = (List*)malloc(dimension * sizeof(List));

	if (massive == NULL)
		return NULL;

	for (int i = 0; i < dimension; i++)
		massive[i] = TakeElement_L2();

	return massive;
}
void ViewInfoElement_L2(int i, List list) {
	printf("%d | %s - %s - %f\n", i, list.Name, list.SecondName, list.Number);
}
void ViewInfo_L2(List* lists, int dimension) {
	for (int i = 0; i < dimension; i++)
		ViewInfoElement_L2(i, lists[i]);
}
List Change_L2(List list_) {
	List list;
	int choose = 0;
	do {
		printf("Ввведите количество цифр, что хотите записать в массив: ");
		safeScanf_L2(&choose);
		if (choose >= 1)
			break;
	} while (1);

	list.SizeOfMassive = (long)choose;
	list.Massive = (long*)malloc(list.SizeOfMassive * sizeof(long));
	for (int i = 0, num = 0; i < list.SizeOfMassive; i++) {
		safeScanf_L2(&num);
		list.Massive[i] = num;
	}
	return list;
}
void ChooseChangeMassiveInLists_L2(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для изменений: ");
		safeScanf_L2(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = Change_L2(lists[choosed]);
}
void MassiveOutPut_L2(List list) {
	puts("Массив чисел: ");
	for (int i = 0; i < list.SizeOfMassive; i++)
		printf("%ld ", list.Massive[i]);
}
void ChooseMassiveOutPut_L2(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для вывода: ");
		safeScanf_L2(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	if (lists[choosed].SizeOfMassive > 0)
		MassiveOutPut_L2(lists[choosed]);
	else puts("Пустой массив чисел.");
}
void ChooseElementToChange_L2(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nВведите номер елемента для изменений: ");
		safeScanf_L2(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = TakeElement_L2();
}
int TakeDimension_L2() {
	int chooseNum = 0;
	do {
		printf("\nВведите размер dimension: ");
		safeScanf_L2(&chooseNum);
		if (chooseNum > 0 && chooseNum < 10)
			break;
		else if (chooseNum >= 10)
			printf("\nНе нужно делать больше 10, неудобно потом будет)");
	} while (1);
	return chooseNum;
}
List initKnigaFileR(FILE* data) {
	List list;

	fscanf_s(data, "%s ", list.Name, N);
	char SecondName[N];
	fscanf_s(data, "%s ", SecondName, N - 1);
	list.SecondName = (char*)malloc((strlen(SecondName) + 1) * sizeof(char));
	writeToFrom_L2(list.SecondName, SecondName);
	list.SecondName[(strlen(SecondName))] = '\0';
	fscanf_s(data, "%f ", &list.Number);
	fscanf_s(data, "%ld ", &list.SizeOfMassive);
	long* Massive = (long*)malloc(list.SizeOfMassive * sizeof(long));
	for(int i = 0; i < list.SizeOfMassive; i++)
		fscanf_s(data, "%ld ", &Massive[i]);
	list.Massive = Massive;
	return list;
}

List* initArrayFile(char fileName[], int dimension) {
	List* massive = (List*)malloc(dimension * sizeof(List));
	if (massive == NULL)
		return NULL;
	FILE* data;
	fopen_s(&data, fileName, "r");
	if (!data) {
		printf("Error");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		massive[i] = initKnigaFileR(data);
	fclose(data);
	return massive;
}

List* ChooseOfInitMassiveStruct(List* massiveStruct, int dimension) {
	int choosed = 0;
	do {
		printf("\nВыберите способ создания массива структур: \
				\n1. Обычная инициализация;\
				\n2. Сканирование из файла;");
		safeScanf_L2(&choosed);
	} while (choosed != 1 && choosed != 2);

	if (choosed == 1)
		massiveStruct = initArray_L2(dimension); 
	else massiveStruct = initArrayFile("data.txt", dimension);
	return massiveStruct;
}

void write(List list, FILE* data) {
	fprintf(data, "%s ", list.Name);
	fprintf(data, "%s ", list.SecondName);
	fprintf(data, "%f ", list.Number);
	fprintf(data, "%ld ", list.SizeOfMassive);
	for(int i = 0; i < list.SizeOfMassive; i++)
		fprintf(data, "%ld ", list.Massive[i]);
	fprintf(data, "\n");
}
void initWrite(char fileName[], List* massive, int dimension) {
	FILE* data;
	fopen_s(&data, fileName, "w");//запись в новый файл
	if (!data) {
		printf("Error");
		exit(1);
	}
	for (int i = 0; i < dimension; i++)
		write(massive[i], data);
	fprintf(data, "- - - 0 0 -\n");
	fclose(data);
	printf("Запись окончена!");
}
void main()
{
	setlocale(LC_ALL, "Rus");
	List* massiveStruct = NULL;
	int choose = 0;
	int dimension = TakeDimension_L2();
	do {
		puts("\nМеню: \
			\n1. Инициализация структуры;\
			\n2. Заполнение массива чисел;\
			\n3. Вывода на экран массива чисел;\
			\n4. Ввода информации в строки имени и фамилии и другие поля;\
			\n5. Bывода на экран всех полей структуры, кроме массива чиcел;\
			\n6. Функцию освобождения динамической памяти;\
			\n7. Сохранить массив структур;\
			\n0. Exit");
		safeScanf_L2(&choose);

		if (choose == 1)
			massiveStruct = ChooseOfInitMassiveStruct(massiveStruct, dimension);
		else if (choose == 2 && massiveStruct != NULL)
			ChooseChangeMassiveInLists_L2(massiveStruct, dimension);
		else if (choose == 3 && massiveStruct != NULL)
			ChooseMassiveOutPut_L2(massiveStruct, dimension);
		else if (choose == 4 && massiveStruct != NULL)
			ChooseElementToChange_L2(massiveStruct, dimension);
		else if (choose == 5 && massiveStruct != NULL)
			ViewInfo_L2(massiveStruct, dimension);
		else if (choose == 6 && massiveStruct != NULL)
		{
			free(massiveStruct);//очищення пам'яті
			puts("Память очищена!");
			massiveStruct = NULL;
		}
		else if (choose == 7 && massiveStruct != NULL)
			initWrite("data.txt", massiveStruct, dimension);
	} while (choose != 0);
}