﻿//1. Запросить число и вывести его квадрат

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int quad = num * num;
// Console.Write("Квадрат числа " + num + " -> " + quad);
// Console.Write($"Квадрат числа {num} -> {quad}");

//2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad = num2 * num2;

// if (quad == num1)
// {
//     Console.WriteLine($"Число {num1} является квадратом {num2}");
// }

// else
// {
//     Console.WriteLine($"Число {num1} не квадрат числа {num2}");
// }

//3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num * -1;

// if (num > 0)
// {
//     while (num >= num2)
//     {
//         Console.Write($"{num2}, ");
//         num2 = num2 + 1;
//     }
// }

// else if (num < 0)
// {
//     while (num <= num2)
//     {
//         Console.Write($"{num2 * -1}, ");
//         num2 = num2 - 1;
//     }

// }

// else 
// {
//     Console.WriteLine("Это ноль");
// }


//4. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// способ 1
// int n = num % 10;
// Console.WriteLine($"У числа {num} последняя цифра {n}");

// способ 2
// Console.WriteLine(Math.Abs(num)%10);
