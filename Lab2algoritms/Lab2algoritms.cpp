#include <stdio.h>
#include <stdlib.h>
#include <math.h>
unsigned char period(unsigned int array[], int a, int k);
int main() {
	unsigned long long a = 69069, c = 1, m = pow(2, 32), k = 10000;
	unsigned int* array;
	unsigned int* array1;
	array = (unsigned int*)malloc(sizeof(unsigned int) * k);
	array1 = (unsigned int*)malloc(sizeof(unsigned int) * k);
	if (array == NULL || array1 == NULL) {
		printf("Помилка виділення пам'яті\n");
		return -1;
	}
	unsigned arrays[300];
	float arrays2[300], S = 0, bm = 0;
	array[0] = 1;
	for (int i = 0; i < k - 1; i++) {
		array[i + 1] = (a * array[i] - c) % m;
	}
	for (int i = 0; i < k; i++) {
		array1[i] = array[i] % 300;
		printf("%d\t", array1[i]);
	}
	printf("\nЧастота інтервалів появи:\n");
	for (int i = 0; i < 300; i++) {
		arrays[i] = period(array1, i, k);
		printf("%d - %d\n", i, arrays[i]);
	}
	printf("\nСтатистична ймовірність появи :\n");
	for (int i = 0; i < 300; i++) {
		arrays2[i] = (float)arrays[i] / k;
		printf("%d - %.4f\n", i, arrays2[i]);
	}
	for (int i = 0; i < 300; i++)
		S += i * arrays2[i];
	printf("\nМатематичне сподівання: %f\n", S);
	for (int i = 0; i < 300; i++)
		bm += pow((i - S), 2) * arrays2[i];
	printf("Дисперсія: %f\n", bm);
	printf("Середньоквадратичне відхилення: %f\n", sqrt(bm));
	free(array);
	free(array1);
	return 0;
}
unsigned char period(unsigned int array[], int a, int k) {
	int d = 0;
	for (int i = 0; i < k; i++) {
		if (array[i] == a)
			d++;
	}
	return d;
}