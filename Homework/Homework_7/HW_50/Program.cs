﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
System.Console.WriteLine();

int[,] CreateArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

int[] FindNumberPosition(int[,] arr, int number)
{
    int[] position = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                position[0] = i + 1;
                position[1] = j + 1;
                return position;
            }
        }
    }
    position[0] = -1;
    position[1] = -1;
    return position;
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 1000 > 0) System.Console.Write($"{array[i, j]}   ");
            else if (array[i, j] / 100 > 0) System.Console.Write($" {array[i, j]}   ");
            else if (array[i, j] / 10 > 0) System.Console.Write($"  {array[i, j]}   ");
            else System.Console.Write($"   {array[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}

void PrintPosition(int[] pos, int num)
{
    System.Console.WriteLine();
    if (pos[0] > 0 && pos[1] > 0) System.Console.WriteLine($"Число {num} находится в {pos[0]}-й строке, {pos[1]}-м столбце");
    else System.Console.WriteLine($"Число {num} отсутствует в заданном массиве");
    System.Console.WriteLine();
}

int GetNumerToFind()
{
    System.Console.WriteLine();
    System.Console.Write("Введите число:   ");
    string writeNumber = Console.ReadLine();
    int number = Convert.ToInt32(writeNumber);
    return number;
}

int row = 4;
int col = 3;
int min = 1;
int max = 10;

int[,] array1 = CreateArray(row, col, min, max);
PrintArray(array1);
int number = GetNumerToFind();
int[] position = FindNumberPosition(array1, number);
PrintPosition(position, number);