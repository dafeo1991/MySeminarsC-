
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2DRandomArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.NextDouble() * (max - min) + min; // формула для того чтобы задать диапазон для вывода рандомных чисел
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}

void Print2DRandomArray(double[,] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}

void Task1()
{
    Console.WriteLine();
    Console.Write("Введите количество строк: ");
    int r = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное число: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число: ");
    int max = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    double[,] myArray = Create2DRandomArray(r, c, min, max);
    Print2DRandomArray(myArray);
}

Task1();

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] Create2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array, int rowsPosition, int columnsPosition)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowsPosition == i && columnsPosition == j)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

void NumberPosition(int[,] array, int rowsPosition, int columnsPosition)
{
    bool flag = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowsPosition == i && columnsPosition == j)
            {
                flag = true;
            }
        }
    }
    Console.WriteLine();
    if (flag) Console.WriteLine($"Элемент на позиции строки {rowsPosition} и столбца {columnsPosition} -> {array[rowsPosition, columnsPosition]} ");
    else Console.WriteLine("Такого элемента нет");
}

void Task2()
{
    Console.WriteLine();
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию строки элемента: ");
    int rowsPosition = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите позицию столбца элемента: ");
    int columnsPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] myArray = Create2DArray(rows, columns);

    Print2DArray(myArray, rowsPosition, columnsPosition);
    NumberPosition(myArray, rowsPosition, columnsPosition);
}

Task2();

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2DNewArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DNewArray(int[,] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (j == 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (j == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (j == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (j == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (j == 5)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (j == 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
             else if (j == 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (j == 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (j == 9)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (j == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

void SumColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        double result = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {

            sum = sum + array[i, j];
            count++;

        }
        if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (j == 1)
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (j == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (j == 3)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (j == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (j == 5)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (j == 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
             else if (j == 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (j == 8)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else if (j == 9)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (j == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

        result = sum / count;
        result = Math.Round(result, 2);
        Console.WriteLine($"Среднее арифмитическое в {j + 1} столбце {result}");
    }
    Console.ForegroundColor = ConsoleColor.White;
}

void Task3()
{
    Console.WriteLine();
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] myArray = Create2DNewArray(rows, columns);

    Print2DNewArray(myArray);
    SumColumns(myArray);
}

Task3();