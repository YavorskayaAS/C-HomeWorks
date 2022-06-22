//Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int NumberDegree(int num1, int num2)
{
    int current = 1;
    int degree = 1;
    while ( current <= num2)
    {
        degree = degree * num1;
        current++;
    }

    return degree;
}

Console.Write("Input an integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input an integer number of degree of the previous number: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int result = NumberDegree(a, b);
Console.WriteLine(result);
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int size = 8;

int[] array = {1, 2, 5, 7, 19, 3, 44, 3};

Console.Write("[");
for(int i = 0; i < size; i++)
{
    Console.Write(array[i] + ", ");
}
Console.Write("]");

