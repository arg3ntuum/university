#include <stdio.h>
#include <locale.h>
#include <windows.h>
#include <math.h>
#define N 30
int strlen_my_vkazivniki(char* massive) {
	for (int i = 0; ; i++)
		if (*(massive + i) == '\0')
			return i;
}
void save_to_vkazivniki(char* x, char* y) {
	for (int i = 0; i < N; i++)
		*(x + i) = *(y + i);
}
int check(int num) {
	int number = num;
	for (int i = 0;; i++) {
		number -= 16;
		if (number <= 0)
			return i;
	}
}
void out_num_16_vkazivniki(char* str) {
	for (int i = 0; i < strlen_my_vkazivniki(str); i++)
		printf("%c", *(str + strlen_my_vkazivniki(str) - i - 1));
}
void out_10_to_16_vkazivniki(int num_10, char* s) {
	char str_16_func[N] = { 0 };
	int num_in_10 = num_10;
	for (int num_ostatok = 0, i = 0; num_in_10 > 0; i++) {
		num_ostatok = num_in_10 % 16;
		switch (num_ostatok) {
		case 0: *(str_16_func + i) = '0'; break;
		case 1: *(str_16_func + i) = '1'; break;
		case 2: *(str_16_func + i) = '2'; break;
		case 3: *(str_16_func + i) = '3'; break;
		case 4: *(str_16_func + i) = '4'; break;
		case 5: *(str_16_func + i) = '5'; break;
		case 6: *(str_16_func + i) = '6'; break;
		case 7: *(str_16_func + i) = '7'; break;
		case 8: *(str_16_func + i) = '8'; break;
		case 9: *(str_16_func + i) = '9'; break;
		case 10: *(str_16_func + i) = 'A'; break;
		case 11: *(str_16_func + i) = 'B'; break;
		case 12: *(str_16_func + i) = 'C'; break;
		case 13: *(str_16_func + i) = 'D'; break;
		case 14: *(str_16_func + i) = 'E'; break;
		case 15: *(str_16_func + i) = 'F'; break;
		}
		*(str_16_func + i + 1) = '\0';
		num_in_10 = check(num_in_10);
	}
	save_to_vkazivniki(s, str_16_func);
}
int convert_from_2_to_10_vkazivniki(long long int str_2) {
	int num_in_10 = 0;
	for (int i = 0, temp = 0; str_2 != 0; ++i) {
		temp = str_2 % 10;
		str_2 /= 10;
		num_in_10 += temp * pow(2, i);
	}
	return num_in_10;
}
void convert_2_to_16_vkazivniki(char s[]) {
	long long int str_2 = atoi(s);
	int num_in_10 = convert_from_2_to_10_vkazivniki(str_2);
	out_10_to_16_vkazivniki(num_in_10, s);
}
int strlen_my(char massive[]) {
	for (int i = 0; ; i++)
		if (massive[i] == '\0')
			return i;
}
void save_to(char x[], char y[]) {
	for (int i = 0; i < N; i++)
		x[i] = y[i];
}
void out_num_16(char str[]) {
	for (int i = 0; i < strlen_my(str); i++)
		printf("%c", str[strlen_my(str) - i - 1]);
}
void out_10_to_16(int num_10, char s[]) {
	char str_16_func[N] = { 0 };
	int num_in_10 = num_10;
	for (int num_ostatok = 0, i = 0; num_in_10 > 0;i++) {
		num_ostatok = num_in_10 % 16;
		switch (num_ostatok) {
		case 0: str_16_func[i] = '0'; break;
		case 1: str_16_func[i] = '1'; break;
		case 2: str_16_func[i] = '2'; break;
		case 3: str_16_func[i] = '3'; break;
		case 4: str_16_func[i] = '4'; break;
		case 5: str_16_func[i] = '5'; break;
		case 6: str_16_func[i] = '6'; break;
		case 7: str_16_func[i] = '7'; break;
		case 8: str_16_func[i] = '8'; break;
		case 9: str_16_func[i] = '9'; break;
		case 10: str_16_func[i] = 'A'; break;
		case 11: str_16_func[i] = 'B'; break;
		case 12: str_16_func[i] = 'C'; break;
		case 13: str_16_func[i] = 'D'; break;
		case 14: str_16_func[i] = 'E'; break;
		case 15: str_16_func[i] = 'F'; break;
		}
		str_16_func[i + 1] = '\0';
		num_in_10 = check(num_in_10);
	}
	save_to(s, str_16_func);
}
int convert_from_2_to_10(long long int str_2) {
	int num_in_10 = 0;
	for (int i = 0, temp = 0; str_2 != 0; ++i) {
		temp = str_2 % 10;
		str_2 /= 10;
		num_in_10 += temp * pow(2, i);
	}
	return num_in_10;
}
void convert_2_to_16(char s[]) {
	long long int str_2 = atoi(s);
	int num_in_10 = convert_from_2_to_10(str_2);
	out_10_to_16(num_in_10, s);
}
void main() {
	setlocale(LC_ALL, "Rus"); //Язык

	char str[N] = {0};
	int error = 0, sposob = 0;

	printf("Введите число в двоичной системе счисления: ");
	gets_s(str, N - 1);

	do {
		puts("Выберите способ выполнения задачи: \n1.Индексы;\n2.Указатели;\nВаш выбор: ");
		scanf_s("%d", &sposob);
	} while (sposob != 1 && sposob != 2);

	if (sposob == 1) {
		//Проверка на ошибки
		for (int i = 0; str[i] != '\0'; i++) 
			if (!(str[i] >= '0' && str[i] <= '1')) {
				error = 1;
				break;
			}

		if (error != 1) {
			convert_2_to_16(str);
			printf("Ваше число: "); 
			out_num_16(str);
		}
	}
	else if (sposob == 2) {
		//Проверка на ошибки
		for (int i = 0; *(str + i) != '\0'; i++)
			if (!(*(str + i) >= '0' && *(str + i) <= '1')) {
				error = 1;
				break;
			}

		if (error != 1) {
			convert_2_to_16_vkazivniki(str);
			printf("Ваше число: ");
			out_num_16_vkazivniki(str);
		}
	}
	else printf("В вашей строке не только 0 и 1.\n");
}
/*
1.	Рядки для тестування функції вводити в головній програмі з клавіатури.
2.	Передбачити обробку помилок в завданні параметрів та особливі випадки.
3.	Розробити два варіанти заданої функції з використанням:
а) індексованих масивів;
б) вказівників.
6.	Функція conversion_2_to_16(s)
Призначення: обчислює шістнадцяткове значення цілого числа за заданим рядком символів s, 
який є записом цього числа в двійковій системі числення.
*/