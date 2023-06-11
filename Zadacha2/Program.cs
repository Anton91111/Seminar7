/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
  что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;
int[,] array = new int[,]
        {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

Write("Введите номер строки: ");
int row = int.Parse(ReadLine());

Write("Введите номер столбца: ");
int column = int.Parse(ReadLine());

if (row >= array.GetLength(0) || column >= array.GetLength(1))
{
    WriteLine("Такого элемента нет");
}
else
{
    int element = array[row, column];
    WriteLine($"Значение элемента: {element}");
}