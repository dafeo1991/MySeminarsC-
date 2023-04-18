// Виды методов

// 1. Ничего не принимает ничего не возвращает void

// void Method1()
// {
//     Console.WriteLine("Любой текст...");
// }
// Method1();

// 2. Что то принимает, ничего не возвращает

// void Method2 (string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method2_1 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method2_1(msg: "Текст", count: 4);

// 3. Что то возвращают, ничего не принимают

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// 4. Что то принимают и что то возвращают

// string Method4 (int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + " " + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(4, "asdf");
// Console.WriteLine(res);

// то же самое с циклом for

// string Method4 (int count, string text)
// {   
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + " " + text;
//     }
//     return result;
// }
// string res = Method4(4, "z");
// Console.WriteLine(res);

// 5. Таблица умножения с циклом for

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

 // 6. Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", а большие "С" заменить 
// маленькими "с".

//  string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//  + "ежели бы вас послали вместо нашего милого Винценгероде,"
//  + "вы бы взяли приступом согласие прусского короля."
//  + "Вы так красноречивы. Вы дадите мне чаю?";

//  string Replace (string text, char oldValue, char newValue)
//  {
//     string result = String.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
//  }

//  string newText = Replace(text, ' ', '|');
//  Console.WriteLine(newText);
//  Console.WriteLine();

//  string newText2 = Replace(newText, 'к', 'К');
//  Console.WriteLine(newText2);
//  Console.WriteLine();

//  string newText3 = Replace(newText2, 'с', 'С');
//  Console.WriteLine(newText3);
//  Console.WriteLine();
 

// 7. Упорядочивание массива

// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные элементы

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray (int [] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}

void MinMaxArray (int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp; 
    }
}

PrintArray(arr);
MinMaxArray(arr);
PrintArray(arr);