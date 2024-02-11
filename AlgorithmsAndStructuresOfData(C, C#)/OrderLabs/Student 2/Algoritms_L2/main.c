#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#define N 50
typedef struct {
	char Name[N];
	char* SecondName;

	float SizeOfMassive;//nomer//Переменная плаваю- щего типа. 
	float* Massive;
	char GroupSymbol;
}Struct;
void writeToFrom(char a[], char b[]) {
	for (int i = 0; i < strlen(b) + 1; i++)
		a[i] = b[i];
}
void scanf_(int* a) {
	char temp[N];
	int error = 0;
	do {
		error = 0;
		scanf_s("%s", &temp, N - 1);
		for (int a = 0; a < strlen(temp); a++)
			if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
				error = 1;
		if (error == 1)
			printf("Увести можна лише числа!\n");
		else {
			*a = atoi(temp);
			break;
		}
	} while (1);
}
Struct TakeElement() {
	Struct struct_;

	printf("\nУведiть iм'я: ");
	scanf_s("%s", &struct_.Name, N);

	char SName[N];
	printf("\nУведiть прiзвище: ");
	scanf_s("%s", &SName, N - 1);

	struct_.SecondName = (char*)malloc((strlen(SName) + 1) * sizeof(char));
	writeToFrom(struct_.SecondName, SName);

	struct_.SizeOfMassive = 0;

	char symbol[3];
	printf("\nУведiть символ, що вiдповiдає iм'ю класа: ");
	scanf_s("%s", &symbol, 2);
	struct_.GroupSymbol = symbol[0];
	return struct_;
}
Struct* initArray(int dimension) {
	Struct* massive = (Struct*)malloc(dimension * sizeof(Struct));

	if (massive == NULL)
		return NULL;

	for (int i = 0; i < dimension; i++)
		massive[i] = TakeElement();

	return massive;
}
void ViewInfoElement(int i, Struct Struct) {
	printf("%d | %s - %s - %c\n", 
		i, Struct.Name, Struct.SecondName, Struct.GroupSymbol);
}
void ViewInfo(Struct* Structs, int dimension) {
	for (int i = 0; i < dimension; i++)
		ViewInfoElement(i, Structs[i]);
}
int TakeDimension() {
	int chooseNum = 0;
	printf("Уведіть dimension: ");
	do {
		scanf_(&chooseNum);
		if (chooseNum > 0 && chooseNum < 10)
			break;
		else if (chooseNum >= 10)
			printf("\nНе потрiбно число нам бiльше 10)!\n");
	} while (1);
	return chooseNum;
}
Struct Change(Struct struct_) {
	int choose = 0;
	do {
		printf("Уведiть кiлькiсть чисел, що ви хочете записати до масиву: ");
		scanf_(&choose);
		if (choose >= 1)
			break;
	} while (1);

	struct_.SizeOfMassive = (float)choose;
	struct_.Massive = (float*)malloc(struct_.SizeOfMassive * sizeof(float));
	float num = 0;
	for (int i = 0; i < struct_.SizeOfMassive; i++) {
		scanf_s("%f", &num);
		struct_.Massive[i] = num;
	}
	return struct_;
}
void ChooseChangeMassiveInStruct(Struct* Structs, int dimension) {
	int choosed = 0;
	do {
		printf("\nУведiть номер елемента для змiн: ");
		scanf_(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	Structs[choosed] = Change(Structs[choosed]);
}
void MassiveOutPut(Struct Struct) {
	puts("Масив чисел: ");
	for (int i = 0; i < Struct.SizeOfMassive; i++)
		printf("%f ", Struct.Massive[i]);
}
void ChooseMassiveOutPut(Struct* Structs, int dimension) {
	int choosed = 0;
	do {
		printf("\nУведiть номер елемента для показу: ");
		scanf_(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	if (Structs[choosed].SizeOfMassive > 0)
		MassiveOutPut(Structs[choosed]);
	else puts("Масив еmpty.");
}
void ChooseElementToChange(Struct* Structs, int dimension) {
	int choosed = 0;
	do {
		printf("\nУведiть номер елементу для змiн: ");
		scanf_(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	Structs[choosed] = TakeElement();
}
void main()
{
	setlocale(LC_ALL, "Rus");
	Struct* massiveStruct = NULL;
	int choose = 0;
	int dimension = 4;
	do {
		puts("\nМеню: \
			\n1. Створити структуру;\
			\n2. Змiнити в елементi масив чисел;\
			\n3. Вивести iнформацiю масиву;\
			\n4. Змiнити елемент;\
			\n5. Вивести iнформацiю всiх елементiв, окрiм чисел;\
			\n6. Звiльнити пам'ять;\
			\n0. Exit");
		scanf_(&choose);

		if (choose == 1) {
			if (massiveStruct == NULL)
				massiveStruct = initArray(dimension);
			else puts("Масив не NULL!");
		}
		else if (choose == 2 && massiveStruct != NULL)
			ChooseChangeMassiveInStruct(massiveStruct, dimension);
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
	} while (choose != 0);
}
