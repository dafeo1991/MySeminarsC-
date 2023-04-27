// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double NumberInAPower (double a, double b)
// {
    
//     double res = 1;
//     for (int i = 0; i < b; i++)
//     {
//         res = res * a;
//     }
//     return res;
// }

// Console.Write("Введите первое число: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double y = Convert.ToDouble(Console.ReadLine());

// double number = NumberInAPower(x, y);

// Console.WriteLine(number);

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNum (int number)
// {   
//     int sum = 0;
//     while (number > 0)
//     {
//         sum = number % 10 + sum;
//         number = number / 10;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int summa = SumNum(n);

// Console.WriteLine($"Сумма всех цифр в числе {n} = {summa}");


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] Array (int size)
// {
//     int[]array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
//     return array;
// }

// void PrintArray (int [] array)
// {   
//     Console.WriteLine($"[{String.Join(" * ", array)}]");

//     // for (int i = 0; i < array.Length; i++)
//     // {
//     //     Console.Write(array[i] + " ");
       
//     // }
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] myArray = Array(size);

// PrintArray(myArray);


