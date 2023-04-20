// Семинар с Архипом

// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int FindSum (int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = FindSum(num);

// Console.WriteLine($"Сумма всех чисел от 1 до {num} -> {result}");

// Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int CountDigit (int num)
// {
//     int count = 1;
//     while (num > 9)
//     {
//         num = num / 10;
//         count ++;
//     }
//     return count;
// }

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// int result = CountDigit(a);

// Console.WriteLine($"Количество цифр в числе {a} -> {result}");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int Fak (int num)
// {
//     int pr = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         pr = pr * i;
//     }
//     return pr;
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = Fak(num);

// Console.WriteLine($"Произведение чисел от 1 до {num} -> {result}");

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.


// Способ 1

// void NewArray (int size)
// {
//     int[] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]} ");
//     }
// }

// Console.Write("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NewArray(num);

// Способ 2

// int [] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int [] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray (int[] array) 
// {
//   Console.Write("Получившийся массив -> ");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write(array[i] + " ");
//   }
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное число: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = CreateRandomArray(size, minValue, maxValue);

// PrintArray(array);

// Семинар с Кириллом

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SumNumbers(int number)
// {
// int result = 0;
// for (int y = 1; y <= number; y++)
// result += y;
// return result;
// }
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Результат суммы цифр: " + SumNumbers(number));

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// Способ 1

// Console.Write("Введите число:\t");
// string s = Console.ReadLine();
// int result = s.Length;
// Console.WriteLine("Количество цифр в числе: " + result);

// Способ 2

// int Input ()
// {
//     Console.Write("Введите число: ");
//     string s = Console.ReadLine();
//     return s.Length;
// }
// int str = Input();
// Console.WriteLine("Количество цифр в числе: " + str);


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Способ 1

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);

    }
    return array;
}

void PrintArray (int [] array)
{   
    Console.WriteLine($"[{string.Join(", ", array)}]");
    // for (int i = 0; i < array.Length; i++)
    // {
    //     Console.Write(array[i] + " ");
    // }
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(size, minValue, maxValue);
PrintArray(arr);

// Способ 2

int[] Random(int number)
{
int[] result = new int[number];
for (int y = 0; y < number; y++)
result[y] = (new Random().Next(0, 2));
return result;
}
Console.Write("Введите количество цифр: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(", ", Random(number)));













































