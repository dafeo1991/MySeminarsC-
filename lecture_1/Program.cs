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

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}