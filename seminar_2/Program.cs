// Семинар 2 с Кириллом обучение

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


int GetRandomNumber(int min, int max)                  // создаем рандомное число
{
    return new Random().Next(min, max + 1);
}

int GetFirstDigit(int number)                          // получаем первую цифру числа 
{
    return number / 10;
}

int GetSecondDigit(int number)                         // получаем вторую цифру числа
{
    return number % 10;
}

int ReadInt()                                         // конвертируем строку которую получили в консоли в число
{
    return int.Parse(Console.ReadLine());
}

Console.WriteLine("min");
int min = ReadInt();

Console.WriteLine("max");
int max = ReadInt();

int number = GetRandomNumber(min, max);

if (GetFirstDigit(number) > GetSecondDigit(number))
{
      Console.WriteLine($"Наибольшая цифра из числа {number} первая");
}else
{
    Console.WriteLine($"Наибольшая цифра из числа {number} это вторая");
}

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

// Способ 1
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int quad1 = num2 * num2;
// int quad2 = num1 * num1;

// if (quad1 == num1 || quad2 == num2 )
// {
//     Console.WriteLine("Одно число является квадратом другого.");
// }
// else 
// {
//     Console.WriteLine("Одно число не является квадратом другого.");
// }


// Способ 2
// Console.WriteLine("Введите число 1: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = int.Parse(Console.ReadLine());



// bool OutputKratnoLi(int a);
// {
//     return a  == Math.Pow(b, 2) || b  == Math.Pow(a, 2);
// }
// Console.WriteLine(OutputKratnoLi(a));

// Семинар с Архипом

// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int FindBiggestDigit (int num)
// {
//     int ed = num / 10;
//     int dec = num % 10;
//     if ( ed > dec)
//     {
//         return ed;
//     }
//     else 
//     {
//         return dec;
//     }
    
// }

// int random = new Random().Next(10, 100);
// Console.WriteLine($"Мы сгенерировали число -> {random}");

// int result = FindBiggestDigit(random);
// Console.WriteLine($"Наибольшая цифра из числа {random} -> {result}");

// 2. Задача.Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber (int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int res = sot * 10 + ed;
//     return res;
// }

// int random = new Random().Next(100, 1000);
// Console.WriteLine($"Мы сгенерировали число -> {random}");

// int result = CutNumber(random);
// Console.WriteLine($"Если удалить вторую цифру из числа {random} то получится число -> {result}");

// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// void CheckTheMultiplicity (int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         Console.WriteLine($"Число {num2} кратно числу {num1} т.е. делится без остатака");
    
//     }
//     else
//     {
//         Console.WriteLine($"Число {num2} не кратно числу {num1}, будет остаток -> {num1 % num2}");
        
//     }
// }

// Console.WriteLine("Введите первое число");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int n2 = Convert.ToInt32(Console.ReadLine());

// CheckTheMultiplicity(n1, n2);

// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// void CheckTheMultiplicity (int num)
// {
//     if (num % 7 == 0 && num % 23 == 0)
//     {
//         Console.WriteLine($"Число {num} кратно числам 7 и 23 т.е. делится без остатака на оба числа");
    
//     }
//     else
//     {
//         Console.WriteLine($"Число {num} не кратно числам 7 и 23, будет остаток -> при делении на 7 -> {num % 7}, при делении на 23 -> {num % 23}");
        
//     }
// }

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());

// CheckTheMultiplicity(n);