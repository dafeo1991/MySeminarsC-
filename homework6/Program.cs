// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] MyArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}

int PositiveNumbers (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void Task1 ()
{
    Console.Write("Введите количество элементов в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());

    int [] numbers = MyArray(size);
    PrintArray(numbers);
    int countNumbers = PositiveNumbers(numbers);
    Console.WriteLine($"Количество положительных элементов в массиве -> {countNumbers}");
}

//Task1();

//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 void Coordinates(double k1, double b1, double k2, double b2)
{

    double x = (b2 - b1) / (k1 - k2);
    // double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых -> x {x}, y {y}");

}

void Task2 ()
{
Console.WriteLine("Введите координаты k1, b1, k2, b2");
double k1 = Convert.ToDouble(Console.ReadLine());
double b1 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
Coordinates(k1, b1, k2, b2);
}

Task2 ();

