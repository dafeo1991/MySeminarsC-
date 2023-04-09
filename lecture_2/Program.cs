// Функции

// 1. Поиск максимального из 9 чичел

// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// Способ 1
// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
// Console.WriteLine(max);


// Способ 2
// int max = Max(Max(a1, b1, c1), 
//               Max(a2, b2, c2),
//               Max(a3, b3, c3));

// Console.WriteLine(max);

// 2. Та же задача только с массивом

// int Max (int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int[] array = {11, 21, 43, 4, 95, 66, 87, 58, 69 };

// int result = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
// );
// Console.WriteLine(result);

// 3. Ищем индекс числа

// int[] array = {11, 21, 43, 4, 95, 66, 87, 4, 69 };

// int n = array.Length;
// int find = 4;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break; // что бы показал только один эл если их несколько
//     }
//     index++;
// }

// Задача 3, решаем с помощью функций 

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 9);
        index ++;
    }
}

void PrintArray (int[] col) 
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find )
        {
            position = index;
            break;
        }
         index++;       
    }
    return position;
}
    

int[] array = new int[10];  

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Index(array, 2);
Console.WriteLine(pos);