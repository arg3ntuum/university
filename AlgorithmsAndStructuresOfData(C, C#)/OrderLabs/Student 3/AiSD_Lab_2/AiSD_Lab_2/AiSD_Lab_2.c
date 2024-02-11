#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>
#define N 50
typedef struct {
	char Name[N];
	char* SecondName;

	float NumerFloat;//Переменная плавающего типа; 
	int Size;// Переменная целого типа;
	float* Massive;//Указатель на плавающего тип; 
} List;
void writeTo(char a[], char b[]) {
	for (int i = 0; i < strlen(b) + 1; i++)
		a[i] = b[i];
}
void scanf_my(int* a) {
	char temp[N];
	int error = 0;
	do {
		error = 0;
		scanf_s("%s", &temp, N - 1);
		for (int a = 0; a < strlen(temp); a++)
			if (atoi(temp) == 0 && !(('0' <= temp[a]) && (temp[a] <= '9')))
				error = 1;
		if (error == 1)
			printf("Вводмти лише числа!\n");
		else {
			*a = atoi(temp);
			break;
		}
	} while (1);
}
List TakeElement() {
	List list;

	printf("\nIм'я: ");
	scanf_s("%s", &list.Name, N);

	char SName[N];
	printf("\nПрiзвище: ");
	scanf_s("%s", &SName, N - 1);

	list.SecondName = (char*)malloc((strlen(SName) + 1) * sizeof(char));
	writeTo(list.SecondName, SName);

	printf("\nНомер: ");
	scanf_s("%f", &list.NumerFloat);

	list.Size = 0;
	return list;
}
List* initArray(int dimension) {
	List* massive = (List*)malloc(dimension * sizeof(List));

	if (massive == NULL)
		return NULL;

	for (int i = 0; i < dimension; i++)
		massive[i] = TakeElement();

	return massive;
}
void ViewInfoElement(int i, List list) {
	printf("%d | %s - %s - %f\n", i, list.Name, list.SecondName, list.NumerFloat);
}
void ViewInfo(List* lists, int dimension) {
	for (int i = 0; i < dimension; i++)
		ViewInfoElement(i, lists[i]);
}
List Change(List struct_) {
	int choose = 0;
	do {
		printf("Уведiть кiлькiсть чисел, що ви хочете записати до масиву: ");
		scanf_my(&choose);
		if (choose >= 1)
			break;
	} while (1);

	struct_.Size = (float)choose;
	struct_.Massive = (float*)malloc(struct_.Size * sizeof(float));
	float num = 0;
	for (int i = 0; i < struct_.Size; i++) {
		scanf_s("%f", &num);
		struct_.Massive[i] = num;
	}
	return struct_;
}
void ChooseChangeMassiveInLists(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nОберiть номер елементу для змiн: ");
		scanf_my(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = Change(lists[choosed]);
}
void MassiveOutPut(List list) {
	puts("Масив чисел: ");
	for (int i = 0; i < list.Size; i++)
		printf("%f ", list.Massive[i]);
}
void ChooseMassiveOutPut(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nОберiть номер елементу для показу: ");
		scanf_my(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	if (lists[choosed].Size > 0)
		MassiveOutPut(lists[choosed]);
	else puts("Massive is empty.");
}
void ChooseElementToChange(List* lists, int dimension) {
	int choosed = 0;
	do {
		printf("\nОберiть номер елементу для змiн: ");
		scanf_my(&choosed);
		if (choosed >= 0 && choosed < dimension)
			break;
	} while (1);
	lists[choosed] = TakeElement();
}
int TakeDimension() {
	int chooseNum = 0;
	do {
		printf("Уведiть кiлькiсть структур: ");
		scanf_my(&chooseNum);
		if (chooseNum > 0 && chooseNum < 10)
			break;
		else if (chooseNum >= 10)
			printf("\nНе можна бiльше нiж 10, бо я так хочу!");
	} while (1);
	return chooseNum;
}
void main()
{
	setlocale(LC_ALL, "Rus");
	List* massiveStruct = NULL;
	int choose = 0;
	int dimension = TakeDimension();
	do {
		puts("\nМеню: \
			\n1. Iнiцiалiзацiя структур;\
			\n2. Заповнити масив чисел;\
			\n3. Показати масив чисел;\
			\n4. Змiнити елемент;\
			\n5. Показати iнформацiю про поля структури;\
			\n6. Функцiя визволення пам'ятi;\
			\n0. Exit");
		scanf_my(&choose);

		if (choose == 1) {
			if (massiveStruct == NULL)
				massiveStruct = initArray(dimension);
			else puts("Масив не дорiвнює NULL!");
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
		
		if (massiveStruct == NULL)
			printf("!!!!!!massiveStruct == NULL!!!!!!");
	} while (choose != 0);
}