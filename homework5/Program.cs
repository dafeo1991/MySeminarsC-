
int[] Array(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
        
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double[] MyArray(int size, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * max;
        array[i] = Math.Round(array[i], 2); 
    }
    return array;
}

void MyPrintArray(double[] array, int max)
{
    Console.Write($"Получившийся массив от 0 до {max} -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ";  ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int Non_EvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void DifferenceOfNumbers(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = Math.Round(max - min, 2);
    Console.WriteLine($"Максимальный элемент -> {max}, минимальный элемент -> {min}, разница между ними -> {diff}");
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void Task1()
{
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());


    Array(size, min, max);
    int[] numbers = Array(size, min, max);

    PrintArray(numbers);
    int countNum = CountEvenNumbers(numbers);
    Console.WriteLine($"Количество четных числел в массиве -> {countNum}");
}
// Task1();

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void Task2()
{
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());


    Array(size, min, max);
    int[] numbers = Array(size, min, max);

    PrintArray(numbers);
    int summa = Non_EvenIndex(numbers);
    Console.WriteLine($"Сумма элементов с не четными индексами -> {summa}");
}

//Task2();

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

void Task3()
{
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());

    MyArray(size, max);
    double[] numbers = MyArray(size, max);

    MyPrintArray(numbers, max);
    DifferenceOfNumbers(numbers);
}
// Task3();

