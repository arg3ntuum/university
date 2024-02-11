#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#define N 50
typedef struct {
	char Name[N];
	char* SecondName;

	int SizeOfMassive;
	int* Massive;
	float GroupAverageScore;
}Struct;
void ReSafer(char a[], char b[]) {
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
			printf("You can write only numbers!\n");
		else {
			*a = atoi(temp);
			break;
		}
	} while (1);
}
Struct CreateNewElement() {
	Struct struct_;

	printf("\nУведiть iм'я: ");
	scanf_s("%s", &struct_.Name, N);

	char SName[N];
	printf("\nУведiть прiзвище: ");
	scanf_s("%s", &SName, N - 1);

	struct_.SecondName = (char*)malloc((strlen(SName) + 1) * sizeof(char));
	ReSafer(struct_.SecondName, SName);

	struct_.SizeOfMassive = 0;

	printf("\nУведiть середню кiлькiсть баллiв класу: ");
	scanf_s("%f", &struct_.GroupAverageScore);

	return struct_;
}
Struct* CreateArray(int dimension) {
	Struct* massive = (Struct*)malloc(dimension * sizeof(Struct));

	if (massive == NULL)
		return NULL;

	for (int i = 0; i < dimension; i++)
		massive[i] = CreateNewElement();

	return massive;
}
void InfoElement(int i, Struct Struct) {
	printf("%d | %s - %s - %f\n",
		i, Struct.Name, Struct.SecondName, Struct.GroupAverageScore);
}
void InfoMassive(Struct* Structs, int dimension) {
	for (int i = 0; i < dimension; i++)
		InfoElement(i, Structs[i]);
}
int SetDimension() {
	int chooseNum = 0;
	printf("Уведiть dimension: ");
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

	struct_.SizeOfMassive = choose;
	struct_.Massive = (int*)malloc(struct_.SizeOfMassive * sizeof(int));
	int num = 0;
	for (int i = 0; i < struct_.SizeOfMassive; i++) {
		scanf_s("%d", &num);
		struct_.Massive[i] = num;
	}
	return struct_;
}
void ChooseMassiveToChange(Struct* Structs, int dimension) {
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
		printf("%d ", Struct.Massive[i]);
}
void ChooseMassiveToOut(Struct* Structs, int dimension) {
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
	Structs[choosed] = CreateNewElement();
}
void main()
{
	setlocale(LC_ALL, "Rus");
	Struct* massiveStruct = NULL;
	int choose = 0;
	int dimension = SetDimension();
	do {
		puts("\nМеню: \
			\n1. Створити структуру;\
			\n2. Змiнити масив чисел в обранiй структурi;\
			\n3. Вивести вмiст масиву обраної структури;\
			\n4. Обрати елемент для змiн;\
			\n5. Вивести iнформацiю всiх елементiв, окрiм чисел;\
			\n6. Звiльнити пам'ять;\
			\n0. Exit");
		scanf_(&choose);

		if (choose == 1) {
			if (massiveStruct == NULL)
				massiveStruct = CreateArray(dimension);
			else puts("Масив не NULL!");
		}
		else if (choose == 2 && massiveStruct != NULL)
			ChooseMassiveToChange(massiveStruct, dimension);
		else if (choose == 3 && massiveStruct != NULL)
			ChooseMassiveToOut(massiveStruct, dimension);
		else if (choose == 4 && massiveStruct != NULL)
			ChooseElementToChange(massiveStruct, dimension);
		else if (choose == 5 && massiveStruct != NULL)
			InfoMassive(massiveStruct, dimension);
		else if (choose == 6)
		{
			free(massiveStruct);//очищення пам'яті
			puts("Було виконано очищення пам'ятi!");
			massiveStruct = NULL;
		}
	} while (choose != 0);
}
