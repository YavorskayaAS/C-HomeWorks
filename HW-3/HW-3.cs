// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
int Palindrom(int num)
{
    int stotis, destis, tis, des, ed;
    stotis = num / 10000; 
    destis = (num / 1000) % 10;
    tis = (num / 100) % 10;
    des = (num /10) % 10;
    ed = num % 10;
    if(stotis == ed)
    {
        if(destis == des)
        {
            return 1;
        }
        else return -1;
    }
    else return -1;
}

Console.Write("Input a five-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = Palindrom(a);

if(result == 1)
{
    Console.WriteLine("да");
}    
else
{
    Console.WriteLine("нет");
}
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

/*
double DotLength(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x2 - x1;
    x = x*x;
    int y = y2 - y1;
    y = y*y;
    int z = z2 - z1;
    z = z*z;

    double dist = x + y + z;
    dist = Math.Sqrt(dist);
    return dist;
}

Console.WriteLine("Input integer coordinates of the first dot in series: X1, Y1, Z1 (using Enter button): ");
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input integer coordinates of the second dot in series: X2, Y2, Z2 (using Enter button): ");
int a2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int c2 = Convert.ToInt32(Console.ReadLine());

double result = DotLength(a1, b1, c1, a2, b2, c2);
Console.WriteLine($"Distance between dots is: {result}");
*/

// Задача 23. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

/*void CubeTable(int num)
{
    for(int current=1; current<=num; current++)
    {
        int cube = current*current*current;
        Console.Write(cube + ", ");
    } 
}

Console.WriteLine("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

CubeTable(a);
*/
