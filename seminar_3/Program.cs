// Семинар с Архипом

// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (double x, double y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
    
//     return 0;
// }

// Console.WriteLine("ВВедите координату Х");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("ВВедите координату Y");
// double y = Convert.ToDouble(Console.ReadLine());

// int coord = FindQuart(x, y);

// Console.WriteLine($"Номер четверти где находится данная точка {coord}");

// 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void FindCoordinats (int quard)
// {
//     if(quard > 4 || quard < 1)
//     Console.WriteLine("Такого номера четверти нет!");
//     if(quard == 1)
//     Console.WriteLine("Диапазон координат в I четверти (х > 0; y > 0)");
//     if(quard == 2)
//     Console.WriteLine("Диапазон координат в II четверти (х < 0; y > 0)");
//     if(quard == 3)
//     Console.WriteLine("Диапазон координат в III четверти (х < 0; y < 0)");
//     if(quard == 4)
//     Console.WriteLine("Диапазон координат в IV четверти (х > 0; y < 0)");
// }

// Console.Write("ВВедите номер четверти : ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindCoordinats(num);

 // 3.  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 // √ (x 2 - x 1) 2 + (y 2 - y 1) 2                 квадрат гипотенузы равен сумме квадратов его катетов
 //A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

//  double GetLenght (double x1, double y1, double x2, double y2)
//  {
//     double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//     return len;
//  }

 
// Console.WriteLine("ВВедите координату первой точки Х1");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("ВВедите координату первой точки Y1");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("ВВедите координату второй точки Х2");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("ВВедите координату второй точки Y2");
// double y2 = Convert.ToDouble(Console.ReadLine());


// double num = GetLenght(x1, y1, x2, y2);

// Console.WriteLine(num);

// 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// с циклом while

// void SqrOll (int num)
// {
//     int count = 1;
//     Console.Write($"Квадраты чисел от 1 до {num}:  ");

//     while (count <= num)
//     {
//         int count2 = count * count;
//         Console.Write($"{count} -> {count2}, ");
//         count++;       
//     }
// }

// с циклом for

// void SqrOll (int num)
// {   
//     Console.Write($"Квадраты чисел от 1 до {num}:  ");
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write($"{i} -> {i * i}, ");
//     }
// }

// Console.Write("ВВедите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// SqrOll(num);


// Семинар с Кириллом

// выводим массив

// int[] GetArrayFromString(string arrayAsString)
// {
// string[] strings = arrayAsString.Split(", ");
// int[] array = new int[strings.Length];

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = int.Parse(strings[i]);
// }

// return array;
// }


// void PrintArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " - ");
// }
// }

// void UpdateArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = array[i] + 1;
// }
// }

// int[] array = GetArrayFromString(Console.ReadLine());

// PrintArray(array);
// UpdateArray(array);
// Console.WriteLine();
// PrintArray(array);

// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// string CheckXY (double x, double y)
// { 
//     if (x > 0 && y > 0)
//     {
//         return "1 четверть";
//     }
//     else if (x < 0 && y > 0)
//     {
//         return "2 четверть";
//     }
//     else if (x < 0 && y < 0)
//     {
//         return "3 четверть";
//     }
//     else if (x > 0 && y < 0)
//     {
//         return "4 четверть";
//     }
//     else
//     {
//         return "Вне четвертей";
//     }
// }

// Console.Write("Введите х: ");
// double x = double.Parse(Console.ReadLine());
// Console.Write("Введите y: ");
// double y = double.Parse(Console.ReadLine()); 

// Console.WriteLine(CheckXY(x,y));


// 2.  Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// System.Console.WriteLine("Укажите четверть");
// int x = int.Parse(System.Console.ReadLine());

// void WichSquare(int a)
// {
// switch (a)
// {
// case 1: System.Console.WriteLine("x > 0, y > 0"); break;
// case 2: System.Console.WriteLine("x > 0, y < 0"); break;
// case 3: System.Console.WriteLine("x < 0, y > 0"); break;
// case 4: System.Console.WriteLine("x < 0, y < 0"); break;
// default: System.Console.WriteLine("x = 0, и/или y = 0"); break;
// }
// }

// WichSquare(x);

// 3.  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Dist ()
{
Console.Write("ВВедите координату первой точки Х1: \t");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВедите координату первой точки Y1: \t");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВедите координату второй точки Х2: \t");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("ВВедите координату второй точки Y2: \t");
double y2 = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
return res;
}

Console.Write($"Расстояние между точками: \t {Dist()}");