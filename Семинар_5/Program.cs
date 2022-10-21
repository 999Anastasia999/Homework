// void Zadacha25()
// {
// // Используя определение степени числа напишите цикл,
// //который принимает на вход два натуральных числа(A & B) и возводит число A в степень B.
// }

// void Zadacha27() 
// {
//     //Напишите программу, которая принимает на вход число
//     //и выдает сумму цифр в числе.
// }

// void Zadacha29()
// {
// //Напишите программу, которая задает массив из 8 случайных целых чисел
// //и выводит отсортированный по модулю массив.
// }

// Console.WriteLine("Задача 25.");
// Zadacha25();
// Console.WriteLine();

// Console.WriteLine("Задача 27.");
// Zadacha27();
// Console.WriteLine();

// Console.WriteLine("Задача 29.");
// Zadacha29();
// Console.WriteLine();

void Zadacha31()
{
    //Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
    //Найдите сумму отрицательных и положительных элементов массива.
    //Например, в массиве [3,9,-8,1,0,-7,2,-1,8-3,-1,6] сумма положительных чисел равна 29,
    //сумма отрицательных равна -20.
    Random random = new Random();
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    Console.WriteLine("Сумма положительных элементов: " + SummPositiv(numbers));
    Console.WriteLine("Сумма отрицательных элементов: " + SummNegative(numbers));
}

int SummPositiv(int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0) sum += numbers[i];
    }
    return sum;
}
int SummNegative(int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < 0) sum += numbers[i];
    }
    return sum;
}


void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 100)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(minValue, maxValue);
    }
}
void PrintArray(int[] numbers)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}



void Zadacha32()
{
    //Напишите программу замены элементов массива:  
    //положительные элементв замените на соответствующие отрицательные, и наоборот.
    //Пример: [-4,8,-8,2] -> [4,-8,8,-2].
    Random random = new Random();
    int size = 4;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    ChangeValue(numbers);
    PrintArray(numbers);

}
void ChangeValue(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1; // numbers[i] = numbers[i] * -1;
    }
}


//Задача 33 НЕ решена по условию:
void Zadacha33() //TODO
{
    //Задайте массив. Напишите программу, которая определяет,
    //присутствует ли заданное число в массиве.
    //Пример: 4; массив[6,7,19,345,3] -> нет
    //        3; массив[6,7,19,345,3] -> да
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, 1, 10);
    PrintArray(numbers);
    ChackArray(numbers); //-Данное решение только не работает на десятичные и сотые числа, 
    //только с еденичными числами.

}
void ChackArray(int[] numbers) //-Данное метод только не работает на десятичные и сотые числа.
{
    Random random = new Random();
    int num = random.Next(0, 10);
    Console.WriteLine("Число: " + num);
    bool flag = false;
    //int i = 0;
    // int tens = numbers[i] / 10;
    // int ones = numbers[i] % 10;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (num == numbers[i]) flag = true;

    }
    // while (!flag || i < numbers.Length) // "!" - Читается как не - пока число не найденно. 
    // {
    //     if (num == numbers[i])
    //     {
    //         flag = true;

    //     }
    //     i++;
    // }
    if (flag)
    {
        Console.WriteLine($"Заданное число в массиве присутствует: {num}");
    }
    else
    {
        Console.WriteLine($"Заданное число в массиве отсутствует.");
    }
}

void Zadacha35()
{
    //Задайте одномерный массив, состоящий из случайных чиселю
    //Надите количество элементов массива, значения которых лежат в отрезке [10,99]/
    //Пример: [5,18,123,6,2,] -> 1.
    //        [1,2,3,6,2] -> 0.
    //        [10,11,12,13,14] -> 5.
    int size = 5;
    int[] numbres = new int[size];
    FillArray(numbres, -10, 100);
    PrintArray(numbres);
    FindArray(numbres);
}
void FindArray(int[] numbres)
{
    int num = 0;
    for (int i = 0; i < numbres.Length; i++)
    {
        if (numbres[i] < 100 && numbres[i] > 9)
        {
            num++;
        }
    }
    Console.WriteLine(num);
}

void Zadacha37()
{
    //Найдите произведение пар чисел в одномерном массиве.
    //Парой считаем первый и последний элемент, второй и предпоследний и т.д.
    //Результат запишем в новом массиве.
    //Пример: [1 2 3 4 5] -> 5 8 3,
    //        [10,11,12,13,14] -> 12 10.

    int size = 5;
    int[] numbres = new int[size];
    FillArray(numbres, -10, 99);
    PrintArray(numbres);

    int maxIndax = size - 1; // ( int maxIndax = size - 1) в любом массиве
    for (int i = 0; i < size  / 2; i++) //(size  / 2) - Половина массива.
    {
        Console.WriteLine($"{numbres[i]}*{numbres[maxIndax - i]} = {numbres[i]*numbres[maxIndax - i]}");
    }
    if (size % 2 == 1)
    {
        Console.WriteLine("Средний элемент массива: " + numbres[size / 2]);
    }
    Console.WriteLine();
}


// Console.WriteLine("Задача 31.");
// Zadacha31();
// Console.WriteLine();

// Console.WriteLine("Задача 32.");
// Zadacha32();
// Console.WriteLine();

// Console.WriteLine("Задача 33.");
// Zadacha33();
// Console.WriteLine();


// Console.WriteLine("Задача 35.");
// Zadacha35();
// Console.WriteLine();

Console.WriteLine("Задача 37.");
Zadacha37();
Console.WriteLine();

