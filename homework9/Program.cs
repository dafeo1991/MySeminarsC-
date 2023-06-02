// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNum(int n)
{
    if (n >= 1)
    {
        Console.Write(n + " ");
        ShowNum(n - 1);
    }
}

void Task1()
{
    Console.WriteLine();
    Console.Write("Введите число N ");
    int n = Convert.ToInt32(Console.ReadLine());
    ShowNum(n);
    Console.WriteLine();
    Console.WriteLine();

}

Task1();

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNum(int m, int n)
{

    if (m < n)
    {
        return m + SumNum(m + 1, n);

    }
    return m;
}

void Task2()
{
    Console.Write("Введите число M ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumNum(m, n));
    Console.WriteLine();
}
Task2();

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int FAkk(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return FAkk(m - 1, 1);
    else
        return FAkk(m - 1, FAkk(m, n - 1));
}

void Task3()
{
    Console.Write("Введите число M ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N ");
    int n = Convert.ToInt32(Console.ReadLine());
    int num = FAkk(m, n);
    Console.Write($"Вычисление функции Аккермана = {num} ");
}
Task3();

