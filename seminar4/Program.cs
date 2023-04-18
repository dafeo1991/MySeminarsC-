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
//     int count = 0;
//     while (num > 0)
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
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
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











































