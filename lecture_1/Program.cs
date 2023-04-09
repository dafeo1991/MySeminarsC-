// Приветствие пользователя

// Console.Write("Введите ваше имя");
// string username = Console.ReadLine();
// Console.Write("Hello, ");
// Console.Write(username);

// Сложение двух чисел

// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);


// деление двух чисел

// double numberA = 15;
// double numberB = 2;
// Console.WriteLine(numberA / numberB);

// Случайное целое число в диапазоне от min до max-1
// Сложение рандомных чисел

// int numberA = new Random().Next(1, 10);
// Console.WriteLine(numberA);
// int numberB = new Random().Next(1, 10);
// Console.WriteLine(numberB);
// Console.WriteLine(numberA + numberB);

// Поприветствовать любимого пользователя

// Console.WriteLine("Введите имя пользователя: ");
// string username = Console.ReadLine();

// if (username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

// Поиск самой большой гири

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("Самая большая гиря весит ");
// Console.WriteLine(max);


// Рисуем треугольник

// Console.Clear();
// Console.SetCursorPosition(10, 4);
// Console.WriteLine("+");

// int xa = 40, ya = 1,
//     xb = 1, yb = 30,
//     xc = 80, yc = 30;

// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;

// while (count < 10000)
// {
//     int what = new Random().Next(0, 3);
//     if (what == 0)
//     {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }
//     if (what == 1)
//     {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }
//     if (what == 2)
//     {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count = count + 1;
// }




