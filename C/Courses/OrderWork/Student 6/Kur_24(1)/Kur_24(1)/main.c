#include <stdio.h>
#include <locale.h>
#define N 30
int strlenIndex(char massive[]){
	for (int i = 0; ; i++)
		if (massive[i] == '\0')
			return i;
}
int quantityIndex(char s[], char p[]) {
	int counter = 0, counter_P = strlenIndex(p);
	for (int i = 0; i < strlenIndex(s); i++) {
		if (s[i] == p[0])
			for (int j = 0, k = i;; j++, k++) {
				if (j == strlenIndex(p))
					counter++;
				if (s[k] != p[j])
					break;
			}
	}
	return counter;
}
int strlenVkazivnik(char *massive) {
	for (int i = 0; ; i++)
		if (*(massive + i ) == '\0')
			return i;
}
int quantityVkazivnik(char *s, char *p) {
	int counter = 0, counter_P = strlenVkazivnik(p);
	for (int i = 0; i < strlenVkazivnik(s); i++) {
		if (*(s + i) == *p)
			for (int j = 0, k = i;; j++, k++) {
				if (j == strlenVkazivnik(p))
					counter++;
				if (*(s + k) != *(p + j))
					break;
			}
	}
	return counter;
}
void main() {
	setlocale(LC_ALL, "Rus");
	int choose_function = 0;
	char s[N] = {0}, p[N] = { 0 };
	printf("Уведiть рядок для аналiзу: ");
	scanf_s("%s", s, N - 1);
	printf("Уведiть пiдрядок для аналiзу: ");
	scanf_s("%s", p, N - 1);
	system("cls");
	do {
		printf("Виберiть варiант функцiї:\n1.З iндексом\n2.З вказiвниками\n");
		scanf_s("%d", &choose_function);
		if (choose_function == 1 || choose_function == 2)
			break;
		else puts("Зробiть правильний вибiр!");
	} while (1);
	system("cls");
	if (quantityIndex(s, p) != 0) {
		if (choose_function == 1)
			printf("Кiлькiсть входжень у рядок '%s' пiдрядка '%s': %d", s, p, quantityIndex(s, p));
		else printf("Кiлькiсть входжень у рядок '%s' пiдрядка '%s': %d", s, p, quantityVkazivnik(s, p));
	}
	else printf("Пiдрядок в рядку не знайдено.");
}

/*
* При виконанні 1-го завдання необхідно:
1.	Рядки для тестування функції вводити в головній програмі з клавіатури.
2.	Передбачити обробку помилок в завданні параметрів та особливі випадки.
3.	Розробити два варіанти заданої функції з використанням:
а) індексованих масивів;
б) вказівників.
24.	 Функція quantity(s, p)
Призначення: підраховує кількість входжень підрядку p у рядок s.
*/