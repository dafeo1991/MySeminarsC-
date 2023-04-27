//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.

// void Triangle (int num1, int num2, int num3)
// {
//     if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
//     Console.WriteLine("Такой треугольник существует");
//     else
//     Console.WriteLine("Такого треугольника нет");
// }

// Console.WriteLine("Введите первую сторону");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите вторую сторону");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третью сторону");
// int n3 = Convert.ToInt32(Console.ReadLine());

// Triangle(n1, n2, n3);


void Num (int n) 
{   
    int res = 0;
    while (n > 0)
    {
        res = n % 2;
        n = n / 2;
        
        Console.Write(res);
    }
   
}

Num (2);