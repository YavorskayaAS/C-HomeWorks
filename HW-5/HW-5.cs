// Задача 34. Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    
    return newArray;
}
Console.Write("Input the number of massive elements: ");
int mySize = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(mySize, 100, 999);


int NumberOfEvenNumbers(int[] newArray)
{
    int sum = 0;
    for(int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] % 2 == 0) sum += 1;
    }
    return sum;
}

Console.WriteLine("The number of even numbers is: " + NumberOfEvenNumbers(myArray));
*/

// Задача 36. Задайте одномерный массив, заполненный случайнымичислами. Найдите сумму элементов, стоящих на нечетных позициях

/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    
    return newArray;
}

Console.Write("Input the number of massive elements: ");
int mySize = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the minimal number of massive element: ");
int minEl = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the maximal number of massive element: ");
int maxEl = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(mySize, minEl, maxEl);

int SumOfElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) sum += array[i];
    }
    return sum;
}

Console.WriteLine("The sum of odd index elements is: " + SumOfElements(myArray));
*/

// Задача 38. Задайте массив вещественных (дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArray(int size)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    
    return newArray;
}

Console.Write("Input the number of massive elements: ");
int mySize = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(mySize);

double MaxFinder(double[] array)
{
    double max = array[0];
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double MinFinder(double[] array)
{
    double min = array[0];
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}

double diffence = MaxFinder(myArray) - MinFinder(myArray);

Console.WriteLine("The diffence between max and min is: " + diffence);
*/