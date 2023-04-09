﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Первое число {num1} больше второго {num2}");
}

else
{
    Console.WriteLine($"Первое число {num1} меньше второго {num2}");
}


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num5 = Convert.ToInt32(Console.ReadLine());

int max = num3;

if (num4 > num3)
{
    max = num4;
    if (num5 > num4)
    {
        max = num5;
    }
} 

else
{
    if (num5 > num3 )
    {
        max = num5;
    }
}

Console.WriteLine($"Максимальное число -> {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int num6 = Convert.ToInt32(Console.ReadLine());

if (num6 % 2 == 0)
{
    Console.WriteLine($"Число {num6} -> четное число");
}

else
{
    Console.WriteLine($"Число {num6} -> не четное число");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num7 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Четные числа от 1 до {num7} -> ");

for (int i = 2; i < num7; i+=2)
{
    Console.Write($"{i}, ");
}
