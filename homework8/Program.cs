
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            array[i, k] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i, k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }

            }
        }
    }
}

void Task1()
{
    Console.WriteLine();
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();


    int[,] array = CreateRandom2DArray(rows, columns);

    Print2DArray(array);
    NewArray(array);
    Print2DArray(array);
}
Task1();

//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}
void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void MinSumString(int[,] array)
{
    int min = Int32.MaxValue;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            count++;
        }

    }
    Console.WriteLine("Cтрока с наименьшей суммой: " + (count));
}

void Task2()
{
    Console.WriteLine();
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] myArray = Create2DRandomArray(rows, columns, min, max);
    Show2DArray(myArray);
    Console.WriteLine();
    MinSumString(myArray);
    Console.WriteLine();
}
Task2();

//Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] CreateArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= rows * columns)
    {
        newArray[i, j] = num;
        if (i <= j + 1 && i + j < rows - 1)
            ++j;
        else if (i < j && i + j >= columns - 1)
            ++i;
        else if (i >= j && i + j > rows - 1)
            --j;
        else
            --i;
        ++num;
    }
    return newArray;
}
void ShowArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Task3()
{
Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowArray2D(CreateArray(rows, columns));
}

Task3();
