//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNumberFinder(int num)
{
    int sot, des, ed;

    if(num > 99 && num < 1000)
    {
        sot = num / 100;
        des = num / 10;
        des = des % 10;
        ed = num % 10;
        return des;
    }
    else
    {
        return -1;
    }
}

Console.Write("Input a three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SecondNumberFinder(a);

if(result == -1)
{
    Console.WriteLine("Error! Your number is not three-digit!");
}
else
{
    Console.WriteLine($"Second number is {result}");
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int raz = 1; //переменная будет менять разрядность в цикле
int ThirdNumFinder(int num)
{
    if(num >= 100)
    {
        while(num >= 100)
        {
            if(num >= 100*raz && num < 1000*raz)
            {
                int third = (num / raz) % 10;
                return third;
            }
            raz = raz*10;
        }
    }
    else
    {
        return -1;
    }
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumFinder(a);

if(result == -1)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(result);
}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
int WeekendFinder(int num)
{
    if(num <= 7)
    {
        return num;
    }
    else
    {
        return -1;
    }
}


Console.Write("Input number of the day of the week: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = WeekendFinder(a);

if(result == -1)
{
    Console.WriteLine("Error! Your number doesn't match to the day of the week!");
}
else
{
    if(result >= 6 && result <= 7)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
*/