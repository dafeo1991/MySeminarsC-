// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 & num < 1000)
// {
//     int num1 = num / 10;
//     int x = num1 % 10;
//     Console.WriteLine($"Вторая цифра числа {num} -> {x}");
// }

// else
// {
//     Console.WriteLine("Это не трехзначное число");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Способ 1

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num / 100 > 0)
// {
//     string num2 = num.ToString();       // создали переменную и приравняли ее к числу которое ввел пользователь в типе строки
//     int[] array = new int[num2.Length]; // создали массив у которого длинна как у переменной num2
//     for( int i = 0; i < num2.Length; i++)  // заполняем наш массив
//     {
//      array[i] = Convert.ToInt32(num2[i].ToString()); // переводим num2 обратно в число и ложим в элемент массива элемент num2 
//                                                      // который является строкой 
//     }
//     Console.WriteLine($"Третья цифра у числа {num} -> {array[2]}");   // выводим третий элемент массива
// }
// else
// {
//     Console.WriteLine($"Третьей цифры у числа {num} нет");
// }

// Способ 2

int GetDigitFromNumber (int number, int digitPosition)
{   
    number = Math.Abs(number);
    
    if (number < Math.Pow(10, digitPosition))
    {
        return -1;
    }
    while (number > Math.Pow(10, digitPosition))
    {
        number/=10;
    }
    return number % 10;
}

int ReadInt()
{
    Console.Write("Введите число: \t");
    return int.Parse(Console.ReadLine());
}

int digit = GetDigitFromNumber(ReadInt(), ReadInt());

if (digit != -1)
{
    Console.Write(digit);
}
else
{
    Console.Write("OOps");
}


// Console.WriteLine(125%)

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >0 & num <8)
// {
//     if (num == 1)
//     {
//         Console.WriteLine("Понедельник рабочий день");
//     }
//     if (num == 2)
//     {
//         Console.WriteLine("Вторник рабочий день");
//     }
//     if (num == 3)
//     {
//         Console.WriteLine("Среда рабочий день");
//     }
//     if (num == 4)
//     {
//         Console.WriteLine("Четверг рабочий день");
//     }
//     if (num == 5)
//     {
//         Console.WriteLine("Пятница рабочий день");
//     }
//     if (num == 6)
//     {
//         Console.WriteLine("Ура! Суббота выходной день");
//     }
//     if (num == 7)
//     {
//         Console.WriteLine("Ура! Воскресенье выходной день");
//     }
// }
// else
// {     
//     Console.WriteLine("Вы ввели не верное чиcло");
// }