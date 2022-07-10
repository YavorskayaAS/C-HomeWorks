// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateNewDoubleArray(int a, int b)
{
   double[,] newMatrix = new double [a,b];

    for( int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next();
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateNewDoubleArray(m, n);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomMatrix(int a, int b, int min, int max)
{
    int[,] newMatrix = new int [a,b];

    for( int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min,max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] array = CreateRandomMatrix(m, n, minimum ,maximum);

Console.WriteLine();

void ElementIndexFinder (int c, int d, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ( i == c && j == d) Console.WriteLine(matrix[i, j]);
        }
        
    }
    
}

Console.WriteLine("Введите номер строки искомого элемента: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца искомого элемента: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

ElementIndexFinder(m1, n1, array);

if (m1 > array.GetLength(0) || n1 > array.GetLength(1)) Console.WriteLine("такого числа в массиве нет");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomMatrix(int a, int b, int min, int max)
{
    int[,] newMatrix = new int [a,b];

    for( int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min,max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число массива: ");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число массива: ");
int maximum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] myMatrix = CreateRandomMatrix(m, n, minimum ,maximum);

Console.WriteLine();

void AverageSumColumnNumbersFinder(int[,] matrix)
{
    
    int j = 0;
    while (j < matrix.GetLength(1))
    {
        double Sum = 0;

        for( int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum += matrix[i, j];
        }

        Sum /= matrix.GetLength(0);
        Console.Write(Sum + "; ");
        j++;
    }
}

Console.Write("Среднее арифметическое каждого столбца: ");
AverageSumColumnNumbersFinder(myMatrix);