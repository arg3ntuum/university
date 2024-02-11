#include "source.h"
void zavdannya2()
{
	
	int chto = 0;
	do {
	SLASH;
	printf("Какую площадь вам нужно посчитать?\n\
	Для круга - введите 1\n\
	Для прямоугольника - введите 2\n\
	Для призмы - введите 3\n\
	Для выхода из программы - введите 0.\n");
	scanf_s("%d", &chto);

	if (chto == 0)
		break;
	else if (chto == 1)
		s_krug();
	else if (chto == 2)
		s_pryamougolnik();
	else if (chto == 3)
		v_prizm();
	else;

	} while (1);
}
int s_krug()
{
	SLASH;
	double s = 0, r = 0;

	printf("Введите радиус для вычисления площади круга\n");
	scanf_s("%lg", &r);

	printf("S = Pi x r ^ 2\nS = %lg x %lg ^ 2 = %lg\n", PI, r, KRUG(r));
	return 0;
}
int s_pryamougolnik()
{
	SLASH;
	int a = 0, b = 0;

	printf("Введите две строны для вычисления площади прямоугольника\n");
	printf("a = "); 
	scanf_s("%d", &a);
	printf("b = ");
	scanf_s("%d", &b);

	printf("S = a x b\nS = %d x %d = %d\n", a, b, PRYAMOUGOLNIK(a,b));
	return 0;
}
int v_prizm()
{
	SLASH;
	int a = 0, b = 0, h = 0;

	printf("Введите две строны и высоту для вычисления объёма прямоугольной призмы\n");
	printf("a = ");
	scanf_s("%d", &a);
	printf("b = ");
	scanf_s("%d", &b);
	printf("h = ");
	scanf_s("%d", &h);

	printf("V = S x h\nS = a x b\nV = a x b x h\nS = %d x %d x %d = %d\n", a, b, h, PRIZMA(a,b,h));
	return 0;
}