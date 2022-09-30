// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = 3;
int columns = 4;

double[,] GetArray(int m, int n)
{
    var result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j =0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

PrintArray(GetArray(rows, columns));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. 
// Если есть - выводим элемент по этим индексам.

int rows = 3;
int columns = 4;

int[,] GetArray(int m, int n)
{
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}

bool Contains(int[,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                return true;
            }
            
        }
    }
    return false;
}

void PrintArray(double[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

var arr = GetArray(rows, columns);
foreach (var item in arr)
{
    Console.WriteLine(item);
}
Console.WriteLine(Contains(arr, 15));

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = 3;
int columns = 4;

int[,] GetArray(int m, int n)
{
    var result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j =0; j < n; j++)
        {
            result[i, j] = new Random().Next(100);
        }
    }
    return result;
}

bool Contains(int[,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                return true;
            }
            
        }
    }
    return false;
}

double[] GetAveragePerColumn(int[,] arr)
{
    var result = new double[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[i] = Math.Round(sum / arr.GetLength(0), 2);
    }

    return result;
}

void PrintArray(double[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

foreach (var item in GetAveragePerColumn(GetArray(rows, columns)))
{
    Console.WriteLine(item);
}
