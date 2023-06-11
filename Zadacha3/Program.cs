/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;
using static System.Console;
int[,] numbers = new int[,]
       {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
       };


int columns = numbers.GetLength(0);

for (int i = 0; i < columns; i++)
{
    double sum = 0;

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[j, i];
    }

    double average = sum / numbers.GetLength(0);

    WriteLine("Cреднее значение по столбцу {0} равно {1}", i + 1, average);
} 
