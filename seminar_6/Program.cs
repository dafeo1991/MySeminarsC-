// семинар с Архипом

// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)

// int[] MyArray(int size)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.Next(1, 100);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("Получившийся массив -> ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] Revers(int[] array)
// {
//     Console.Write("Перевернутый массив -> ");
//     for (int i = 0, j = array.Length - 1; i < j; i++, j--) // ; отделяет блоки цикла: 1. создали переменные 2. указали условия завершения 3. что происходит 
//     {                                                      // в каждой итерации
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
//     return array;
// }

// Console.Write("Введите количество элементов: ");
// int size = Convert.ToInt32(Console.ReadLine());

// MyArray(size);
// int[] arr = MyArray(size);

// PrintArray(arr);

// PrintArray(Revers(arr));

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// треугольник существует если его сторона меньше суммы двух других

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a + b > c && b + c > a && a + c > b)
//     {
//         return true;
//     }
//     return false;
// }

// int CheckNumber()
// {
//     int x = Convert.ToInt32(Console.ReadLine());
//     if (x <= 0) return CheckNumber();
//     else return x;
// }

// Console.Write("Введите сторону А: ");
// int a = CheckNumber();
// Console.Write("Введите сторону B: ");
// int b = CheckNumber();
// Console.Write("Введите сторону C: ");
// int c = CheckNumber();

// Console.WriteLine(CheckTriangle(a, b, c));

// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// int[] Fibonachii()
// {
//     Console.Write("Введите первое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите второе число: ");
//     int b = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите последнее число: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[] array = new int[n];
//     array[0] = a;
//     array[1] = b;

//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// PrintArray(Fibonachii());

// Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// string TransformToBinary (int num)
// {
//     string result = String.Empty;
//     int bin = 0;
//     while (num > 0)
//     {
//         bin = num % 2;
//         result = bin + result;
//         num = num / 2;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Число {a} в двоичной системе -> {TransformToBinary(a)}");

// Семинар с Денисом


void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Reverse(int[] array)
{
    int halfSize = array.Length / 2;
    int lastIndex = array.Length - 1; // последний элемент в массиве

    for (int i = 0; i < halfSize; i++)
    {
        //(array[i], array[lastIndex - i]) = (array[lastIndex - i], array[i]); // то же самое с помощью кортежа
        // как было                         как стало
        int temp = array[i];
        array[i] = array[lastIndex - i];
        array[lastIndex - i] = temp;
    }

}

void PrintArrayReverse(int[] array)  // печатаем сразу перевернутый массив
{
    int lastIndex = array.Length - 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[lastIndex - i] + " ");
    }
    Console.WriteLine();
}

string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

bool SideCheck(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

(int, int) Test()  // кортеж
{
    int x = 6;
    int y = 8;
    return (x, y);
}

void TaskTest() // кортеж
{
    Console.WriteLine(Test());
    int num1;
    int num2;
    (num1, num2) = Test();
    Console.WriteLine(num1);
    Console.WriteLine(num2);

    Console.WriteLine(num1 + num2);
}
//TaskTest();

// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). Решите задачу без создания второго массива.


void Task1()
{
    int size = 6;
    int[] numbers = new int[size];

    FillArray(numbers);                        // создает
    Console.Write("Получившийся массив -> ");
    PrintArray(numbers);

    Reverse(numbers);                          // только переворачивает
    Console.Write("Перевернутый массив -> ");
    PrintArray(numbers);                       // только печатает  

    Console.Write("Печатаем сразу перевернутый массив -> ");
    PrintArrayReverse(numbers);                // переворачивает и сразу печатает                


}

//Task1();

// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

void Task2()
{
    int sideA = Convert.ToInt32(Input("Введите сторону А: "));
    int sideB = Convert.ToInt32(Input("Введите сторону B: "));
    int sideC = Convert.ToInt32(Input("Введите сторону C: "));

    if (SideCheck(sideA, sideB, sideC))
        Console.WriteLine("Треугольник с данными сторонами существует");
    else
        Console.WriteLine("Треугольник не существует");
}

// Task2();

// Задача 3. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Task3()
{
    int number = Convert.ToInt32(Input("Введите число: "));
    int value = number;
    int resultInt = 0;       // хранится результат в числе
    int shift = 1;           // переменная в которую заложен разряд
    string resultStr = "";   // хранится результат в виде строки

    while (value > 0)
    {
        resultInt = resultInt + value % 2 * shift; // для записи наоборот итоговое число + остаток от деления * на разряд
        resultStr = value % 2 + resultStr;         // сохраняем в строку, новое значение записывается слева
        shift = shift * 10;
        value = value / 2;
    }
    Console.WriteLine($"Число в двоичном представлении в формате числа {resultInt}");
    Console.WriteLine($"Число в двоичном представлении в формате строки {resultStr}");
}

//Task3();

// Задача 4. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Task4()
{
    int num_f = 0;
    int num_s = 1;
    int count = Convert.ToInt32(Input("Количество элементов последовательности: "));
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{num_f} ");
        (num_f, num_s) = (num_s, num_f + num_s);      // вывод кортежем
        // int temp = num_f;                          // обычный вывод
        // num_f = num_s; 
        // num_s = temp + num_f; 
    }
}

//Task4();

// Задача 5. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void Task5()
{
    int size = 6;
    int[] numbers = new int[size];

    FillArray(numbers);
    Console.Write("Первый массив -> ");
    PrintArray(numbers);

    int[] numbers_copy =  new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers_copy[i] = numbers[i];
    }

    numbers[0] = 10000;
    Console.Write("Копия массив -> ");
    PrintArray(numbers);
}

Task5();