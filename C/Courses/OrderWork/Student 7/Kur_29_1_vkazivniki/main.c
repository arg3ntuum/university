#include <stdio.h>
#include <locale.h>
#include <windows.h>
#include <math.h>
#define N 100
int strlen_my(char *massive) {
	for (int i = 0; ; i++)
		if (*(massive + i) == '\0')
			return i;
}
void rewrite(char *x, char *y, int k) {
    for (int i = 0; i < k; i++)
        *(x +i) = *(y + i);
}
char* strstr_my(const char* str1, const char* str2) {
    char* str1_ptr, *str2_ptr;
    for (int check; *str1; str1++) {
        if (*str1 == *str2) {
            check = 1;
            str1_ptr = str1;
            str2_ptr = str2;
            for (; *str1_ptr && *str2_ptr; str1_ptr++, str2_ptr++)
                check &= (*str1_ptr == *str2_ptr);

            if (check && !(*str1_ptr) && *str2_ptr)
                return NULL;
            if (check) 
                return str1;
        }
    }
    return NULL;
}
void replace_pc(char str[]) {
    char computer[] = "computer", pc[] = "PC";
    char* p;
    int lenth = 0;
    p = strstr(str, computer);
    while (p) {
        lenth = strlen_my(str);
        rewrite(p + strlen_my(pc), p + strlen_my(computer), strlen_my(str) - strlen_my(computer));
        rewrite(p, pc, strlen_my(pc));
        str[lenth - (strlen_my(pc) - strlen_my(computer))] = 0;
        p = strstr_my(p, computer);
    }
}
void main() {
	setlocale(LC_ALL, "Rus"); //Язык

	char str[N] = {0};
	int error = 1;

	printf("Введите предложение, для замены computer: ");
    gets_s(str, N - 1);

    for (int i = 0; i < strlen_my(str); i++)
        if (*(str +i ) == 'c' && *(str + i + 1) == 'o' && *(str + i + 2) == 'm' && *(str + i + 3) == 'p' && *(str + i + 4) == 'u' && *(str + i + 5) == 't' && *(str + i + 6) == 'e' && *(str + i + 7) == 'r')
            error = 0;

	if (error != 1) {
        replace_pc(str);
		printf("После замены: "); 
		puts(str);
	}
	else printf("В вашей строке не имеется 'computer'.\n");
}
/*
1.	Рядки для тестування функції вводити в головній програмі з клавіатури.
2.	Передбачити обробку помилок в завданні параметрів та особливі випадки.
3.	Розробити два варіанти заданої функції з використанням:
а) індексованих масивів;
б) вказівників.
Функція replace_pc(s)
Призначення: заміна у рядку s окремо розташованих слів computer на PC.
Наприклад, є рядок:
Protects your computer as you are working, surfing and playing.
Після заміни одержимо:
Protects your PC as you are working, surfing and playing.

*/