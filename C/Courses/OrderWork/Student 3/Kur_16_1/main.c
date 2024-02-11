#include <stdio.h>
#include <locale.h>
#include <windows.h>
#include <math.h>
#define N 30
void save_index(char a[], char b[]) { 
	for (int i = 0; i < N; i++)
		a[i] = b[i];
}
void save_vkaz(char* a, char* b) { 
	for (int i = 0; i < N; i++)
		*(a + i) = *(b + i);
}
int strlen_index(char s[]) {
	for (int i = 0; i < N; i++)
		if (s[i] == '\0') 
			return i; 
}
int strlen_vkaz(char *s) {
	for (int i = 0; i < N; i++)  
		if (*(s + i) == '\0')  
			return i; 
}
char* rotateSimbolIndex(char s[]) {
	char str[N] = {0}, newstr[N];
	save_index(str, s);
	save_index(newstr, s);
	for (int i = 0, j = strlen_index(s) - 1; i < strlen_index(s); i++, j--)
		str[i] = newstr[j];
	return str;
}
char* rotateSimbolVkaz(char *s) {
	char str[N] = { 0 }, newstr[N];
	save_vkaz(str, s);
	save_vkaz(newstr, s);
	for (int i = 0, j = strlen_vkaz(s) - 1; i < strlen_vkaz(s); i++, j--)
		*(str + i) = *(newstr + j);
	return str;
}
char* rotationIndex(char s[], int n, int l) {
	char s_rot[N] = { 0 }, str[N] = {0};
	save_index(str, s);
	for (int i = 0, j = 0; i < strlen_index(str); i++) {
		if (n <= i && l > j) {
			s_rot[j] = str[i];
			j++;
		}
	}
	save_index(s_rot, rotateSimbolIndex(s_rot));
	for (int i = 0, j = 0; i < strlen_index(str); i++) {
		if (n <= i && l > j) {
			str[i] = s_rot[j];
			j++;
		}
	}
	return str;
}
char* rotationVkaz(char *s, int n, int l) {
	char s_rot[N] = { 0 }, str[N] = { 0 };
	save_vkaz(str, s);
	for (int i = 0, j = 0; i < strlen_vkaz(str); i++) {
		if (n <= i && l > j) {
			*(s_rot + j) = *(str+i);
			j++;
		}
	}
	save_vkaz(s_rot, rotateSimbolVkaz(s_rot));
	for (int i = 0, j = 0; i < strlen_vkaz(str); i++) {
		if (n <= i && l > j) {
			*(str + i) = *(s_rot + j);
			j++;
		}
	}
	return str;
}
void main() {
	setlocale(LC_ALL, "Rus"); //Язык
	int n = 0, l = 0, sposob = 0;
	char str[N] = { 0 };
	do {
		printf("Виберiть спосiб виконання завдання: \n1.Iндекси;\n2.Вказiвники;\nВаш вибiр: ");
		scanf_s("%d", &sposob);
	} while (sposob != 1 && sposob != 2);
	getchar();
	if (sposob == 1) {
		do {
			printf("Рядок: ");
			gets_s(str, N - 1);
		} while (strlen_index(str) < 2);
	
		do {
			printf("Виберiть позiцiю: ");
			scanf_s("%d", &n);
		} while (n > 0 && strlen_index(str) < n - 1);

		do {
			printf("Довжина l: ");
			scanf_s("%d", &l);
		} while (l > 0 && strlen_index(str) <= l);

		printf("Новий рядок: %s", rotationIndex(str, n, l));
	}
	else {
		do {
			printf("Рядок: ");
			gets_s(str, N - 1);
		} while (strlen_index(str) < 2);

		do {
			printf("Виберiть позiцiю: ");
			scanf_s("%d", &n);
		} while (n > 0 && strlen_index(str) < n - 1);

		do {
			printf("Довжина l: ");
			scanf_s("%d", &l);
		} while (l > 0 && strlen_index(str) <= l);

		printf("Новий рядок: %s", rotationIndex(str, n, l));
	}
}
/*
1.	Рядки для тестування функції вводити в головній програмі з клавіатури.
2.	Передбачити обробку помилок в завданні параметрів та особливі випадки.
3.	Розробити два варіанти заданої функції з використанням:
а) індексованих масивів;
б) вказівників.
16.	 Функція rotation(s, n, l)
Призначення: у рядку s, починаючи з позиції n виділити підрядок s1 (довжи-ною l) та обернути його.
Наприклад, рядок s – qwerty. Починаючи з позиції n=2 виділяємо підрядок s1 довжиною l=3 (ert).
При обертанні підрядка s1 отрима-ємо рядок qwtrey.
*/