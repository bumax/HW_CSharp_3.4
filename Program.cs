﻿// Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу.
// Подсказка: если взять первое число в массиве, можно ли найти в оставшейся его части два числа равных по сумме первому.

int[] array = new int[] {0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29};

int number = 64;

for (int i = 0; i < array.Length - 2; i++)
	for (int k = i; k < array.Length - 1; k++)
		for (int j = k; j < array.Length; j++)
			if (array[i] + array[k] + array[j] == number)
                Console.WriteLine("Найдены числа: " + array[i] + " + "+ array[k] + " + " + array[j]);