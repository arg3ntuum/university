#include <stdio.h>
#include <locale.h>
#include <windows.h>
#define N 30
int strlenMy(char massive[]) {
	for (int i = 0; ; i++)
		if (massive[i] == '\0')
			return i;
}
int latin(char s[]) {
	int counter = 0, check = 0;
	if ((s[0] >= 'A' && s[0] <= 'Z' )|| (s[0] >= 'a' && s[0] <= 'z')) {
		counter++;
		check = 0;
	}
		
	for (int i = 0;i < strlenMy(s);i++) {
		if (s[i - 1] == ' ' && check == 0 && ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z'))) {
			check = 1;
			counter++;
		}
		
		if (s[i] >= 'A' && s[i] <= 'Z' || s[i] >= 'a' && s[i] <= 'z'){
			check = 0;
		}
	}	
	return counter;
}
int main() {
	setlocale(LC_ALL, "Rus"); //Language

	char str[N];
	int error = 0;

	printf("Уведiть рядок для обробки: ");
	gets_s(str, N - 1);

	//Check for error
	for (int i = 0; str[i] != '\0'; i++) {
		if (!((str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z') || str[i] == ' ')) {
			error = 1;
			break;
		}
	}
	system("cls");

	if (error == 1)
		printf("У вашому рядку не тiльки латинськi лiтери.\n");
	else printf("В рядку %d слiв.\n", latin(str));
}
/*
1.	Рядки для тестування функції вводити в головній програмі з клавіатури.
2.	Передбачити обробку помилок в завданні параметрів та особливі випадки.
3.	Розробити два варіанти заданої функції з використанням:
а) індексованих масивів;
б) вказівників.
18.	 Функція latin(s)
Призначення: обчислює кількість слів в заданому рядку символів, що складаються тільки з латинських букв.
*/