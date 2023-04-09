// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Первый способ

// int num = new Random().Next(10, 100);
// Console.WriteLine(num);

// int first = num / 10;
// Console.WriteLine(first);

// int second = num % 10;
// Console.WriteLine(second);

// if (first > second)
// {
//     Console.WriteLine($"Наибольшая цифра из числа {num} это {first}");
// } 
// else if (first < second)
// {
//     Console.WriteLine($"Наибольшая цифра из числа {num} это {second}");
// } 

// else
// {
//     Console.WriteLine($"Цифры {num} и {first} равны");
// } 

// Второй способ

// System.Console.WriteLine("min");
// int min = ReadInt();

// System.Console.WriteLine("max");
// int max = ReadInt();

// int number = GetRandomNumber(min, max);

// System.Console.WriteLine(number);

// if (GetFirstDigit(number) > GetSecondDigit(number))
// {
//       Console.WriteLine($"Наибольшая цифра из числа {number} первая");
// }else
// {
//     Console.WriteLine($"Наибольшая цифра из числа {number} это вторая");
// }

// int GetRandomNumber(int min, int max)
// {
//     return new Random().Next(min, max + 1);
// }

// int GetFirstDigit(int number)
// {
//     return number / 10;
// }

// int GetSecondDigit(int number)
// {
//     return number % 10;
// }

// int ReadInt()
// {
//     return int.Parse(Console.ReadLine());
// }

// 2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int num = new Random().Next(100, 1000);
// Console.WriteLine(num);

// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 % num2 == 0)
// {
//     Console.WriteLine($"Первое число {num1} кратно второму {num2}");
// }
// else
// {
//     int x = num1 % num2;
//     Console.WriteLine($"Первое число {num1} не кратно второму {num2}, остаток от деления {x}");
// }


// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 7 == 0 & num % 23 == 0 )
// {
//     Console.WriteLine($"Число {num} кратно 7 и 23");
// }
// else
// {
//       int x = num % 7;
//       int y = num % 23;
//       Console.WriteLine($"Число {num} кратно не 7 и 23, остаток от деления на 7 -> {x}, на 23 -> {y}");
// }

//5. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad1 = num2 * num2;
int quad2 = num1 * num1;

if (quad1 == num1 || quad2 == num2 )
{
    Console.WriteLine("Одно число является квадратом другого.");
}
else 
{
    Console.WriteLine("Одно число не является квадратом другого.");
}

Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());



bool OutputKratnoLi(int a);
{
    return a  == Math.Pow(b, 2) || b  == Math.Pow(a, 2);
}
Console.WriteLine(OutputKratnoLi(a));