// Семинар с Архипом

// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] Create2DRandomArray(int rows, int columns)
// {
//     Random rnd = new Random();
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rnd.Next(1, 10);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

// Console.Write("Введите количество строк: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(r, c);
// Print2DArray(array);

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.

// int[,] New2DArray()
// {
//     int[,] array = new int[5, 5];

//     for (int i = 0; i < 5; i++)
//     {
//         for (int j = 0; j < 5; j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DNewArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Print2DNewArray(New2DArray()); 

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] NewArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = rnd.Next(2, 10);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     Console.WriteLine();
//     Console.WriteLine("Наш массив -> ");
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 Console.ForegroundColor = ConsoleColor.Blue;
//             }
//             else
//             {
//                 Console.ForegroundColor = ConsoleColor.Yellow;
//             }

//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();

//     }
//     Console.ForegroundColor = ConsoleColor.White;
// }

// int[,] SquaresOfNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i += 2)
//     {
//         for (int j = 0; j < array.GetLength(1); j += 2)
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }

//     }
//     return array;
// }

// Console.Write("Введите количество строк: ");
// int r = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int c = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = NewArray(r, c);
// PrintArray(myArray);
// PrintArray(SquaresOfNumbers(myArray));




// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int[,] NewArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(2, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Наш массив -> ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintColorArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Наш массив -> ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

int Sum(int[,] array)
{
    int s = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {

                s = s + array[i, j];

            }
        }

    }
    return s;
}

int Sum2(int[,] array)
{
    int s2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        s2 = array[i, i] + s2;

    }
    return s2;
}


Console.WriteLine();
Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] myArray = NewArray(r, c);
//PrintArray(myArray);
PrintColorArray(myArray);
int num = Sum(myArray);
//int num2 = Sum2(myArray);

Console.WriteLine($"Сумма элементов на главной диагонали -> {num}");
Console.WriteLine();

// Семинар с Кириллом

// PrintArray(CreateTwoDimensionArray(4, 4));

// int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
// {
//     int[,] array = new int[firstLength, secondLength];

//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(0, 10);

//     return array;
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i, j]} ");
//         Console.WriteLine();
//     }
// }