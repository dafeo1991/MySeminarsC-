// Семинар с Архипом

// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int [] MyArray ()
// {
//     int [] array = new int [12];
//     for (int i = 0; i < 12; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// void PrintArray(int [] array) 
// {   
//     Console.Write("Наш массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
// }

// void Sum (int [] array)
// {   
//     int sumPositive = 0;
//     int sumNegative = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sumPositive = sumPositive + array[i];

//         else sumNegative = sumNegative + array[i]; 

//     }
//     Console.WriteLine();
//     Console.WriteLine($"Сумма положительных чисел в массиве -> {sumPositive}");
//     Console.WriteLine($"Сумма отрицательных чисел в массиве -> {sumNegative}");
// }

// int[] array = MyArray();
// PrintArray(array);
// Sum(array);

// // PrintArray(MyArray());
// // Sum(MyArray());

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] MyArray ()
// {
//     int [] array = new int [12];
//     for (int i = 0; i < 12; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// void PrintArray(int [] array) 
// {   
//     Console.Write("Наш массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// int [] ConvertArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * -1; 
//     }
//     return array;
// }

// int[] newArray = MyArray();
// PrintArray(newArray);
// PrintArray(ConvertArray(newArray));

//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// создание метода запроса элементов массива у пользователя
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

// int [] MyArray (int size)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.Write($"Введите элемент {i+1} -> ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int [] array) 
// {   
//     Console.Write("Наш массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// void Num (int [] array, int n)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//        if (array[i] == n) Console.WriteLine($"Это то число которое мы ищем -> {n}");
//        else Console.WriteLine($"Это не то число -> {n}");

//     }
// }

// bool Number (int[] array, int n)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == n) return true;
//     }
//     return false;
// }
// Console.WriteLine("Введите количество элементов");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число которое нужно найти");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = MyArray(size);
// PrintArray(array);
// Num(array, n);
// Console.Write(Number(array, n));

///Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].


// int [] MyArray ()
// {
//     int [] array = new int [123];
//     for (int i = 0; i < 123; i++)
//     {   
//        array[i] = new Random().Next(0, 1000);
//     }
//     return array;
// }

// void PrintArray(int [] array) 
// {   
//     Console.Write("Наш массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
//     Console.WriteLine();
// }

// int CountNumber(int [] array) 
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         count++;
//     }
//     return count;
// }

// int[] array = MyArray();
// PrintArray(array);
// int count = CountNumber(array);

// Console.WriteLine($"Количество элементов массива значения которых от 10 до 99 -> {count}");

// Семинар с Денисом

// Задача 1.  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.


void FillArray(int[] numbers, int minValue = -9, int maxValue = 9) // на вход даем массив, в этом методе только заполняем его
{   
    maxValue++;
    Random rnd = new Random();                            // создали переменную с типом "Рандом" 
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(minValue, maxValue);                    // обращаемся к переменной для создания числа
    }

}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.WriteLine();
}

int GetPositiveSum(int [] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}

int GetNegativeSum(int [] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sum += numbers[i];
    }
    return sum;
}

void ChangeSing(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

void Element (int[] numbers, int num)
{   
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num)
        {
            // Console.WriteLine("Число имеется");
            flag = true;
        }
    }
    if (flag) Console.WriteLine($"Число {num} найдено в массиве");
    else Console.WriteLine($"Числа {num} в массиве нет");
}

int CountElement (int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

void Task1()
{
    int size = 10;
    int[] numbers = new int[size];

    FillArray(numbers); // вызвали метод и на вход дали массив созданный выше
    PrintArray(numbers); // вызываем метод который печатает массив
    int sum1 = GetPositiveSum(numbers);
    Console.WriteLine($"Сумма положительных элементов в массиве -> {sum1}");
    int sum2 = GetNegativeSum(numbers);
    Console.WriteLine($"Сумма отрицательных элементов в массиве -> {sum2}");
}

//Task1();

// Задача 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

void Task2 ()
{
    int size = 10;
    int[] numbers = new int[size];

    FillArray(numbers); 
    PrintArray(numbers); 
    ChangeSing(numbers);
    PrintArray(numbers); 
}

// Task2();

// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void Task3 ()
{
    int size = 10;
    int[] numbers = new int[size];

    FillArray(numbers); 
    PrintArray(numbers);

    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Element(numbers, num);
}

// Task3 ();

// Задача 4. Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


void Task4 ()
{
    int size = 10;
    int[] numbers = new int[size];

    FillArray(numbers, -30, 99); 
    PrintArray(numbers);

    int count = CountElement(numbers);
    Console.WriteLine($"Количество элементов в массиве от 10 до 99 -> {count}");
}

Task4();