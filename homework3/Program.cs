Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 14212 -> нет, 12821 -> да, 23432 -> да");
Console.WriteLine();

void Palindrome (double num)
{
    if (num <= 9999 || num > 99999)
    {   
        Console.WriteLine("Это не пятизначное число, введите другое число");
    }
    else 
    {
        if (num % 10 == num / 10000 && num % 100 / 10 == num / 1000 % 10)
        {
            Console.WriteLine($"Число {num} является палиндромом.");
        }
        else
        {
             Console.WriteLine($"Число {num} не палиндром.");
        }
    }
}

Console.Write("Введите пятизначное число: ");
double n = Convert.ToInt32(Console.ReadLine());

Palindrome(n);

Console.WriteLine();
Console.WriteLine("Задача завершена, нажмите что-нибудь для перехода к следующей задаче");
Console.ReadKey();
Console.WriteLine();


Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53; формула l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2");
Console.WriteLine();

double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 -z1) * (z2 -z1));
    return result;
}

Console.Write("Введите координаты точки x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double res1 = Distance(x1, y1, z1, x2, y2, z2);

double res2 = Math.Round(res1, 2);

Console.WriteLine($"Расстояние между точками в 3D пространстве -> {res2}");


Console.WriteLine();
Console.WriteLine("Задача завершена, нажмите что-нибудь для перехода к следующей задаче");
Console.ReadKey();
Console.WriteLine();

Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27;  5 -> 1, 8, 27, 64, 125");
Console.WriteLine();

void Kub (double num)
{
    Console.Write($"Таблица кубов чисел от 1 до {num} -> ");
    double k = 0;
    for (double i = 1; i <= num; i++)
    {
        
        k = Math.Pow(i, 3);
        Console.Write(k + ", ");
    }
    
}

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

Kub(num);

