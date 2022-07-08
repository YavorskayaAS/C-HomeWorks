//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
/*
int[] InputArray()
{
    Console.WriteLine("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите число с индексом {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int[] myArray = InputArray();

int PositiveNumFinder(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += 1;
    }
    return sum;
}

int result = PositiveNumFinder(myArray);

Console.WriteLine($"Вы ввели {result} положительных чисел");
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
/*
int[] GivenArray = {1, 3, 8, -7, 16};

int[] ArrayDublicator(int[] array)
{
    int[] dublicArray = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        dublicArray[i] = array[i];
    }

    return dublicArray;
}

int[] copyArray = ArrayDublicator(GivenArray);

for (int i = 0; i < copyArray.Length; i++) Console.Write(copyArray[i] + " ");
*/