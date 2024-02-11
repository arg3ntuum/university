#include "source.h"
#define K 5
int summa(int chislo)
{
	static int summa = 0;
	return summa += chislo;
}
void zavdannya1()
{
	SLASH;
	
	int chislo = 0, sum;

	puts("");
	for (int i = 0;i < K;i++) 
	{
		chislo = -10 + rand() % 20;
		printf("%d ", chislo);
		sum = summa(chislo);
	}
	printf("\nСреднее арифметическое: %g\n\n", (double)sum/K);
}
