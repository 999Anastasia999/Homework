void Zadacha54()
{
    //Задайте двумерный массив. 
    //Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    //Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // В итоге получается вот такой массив:
    // 7 4 2 1
    // 9 5 3 2
    // 8 4 4 2
    int[,] numbers = new int[3, 4];
    FillArray(numbers);
    PrintArray(numbers);
    SortArray(numbers);
    Console.WriteLine();
    PrintArray(numbers);
}
void FillArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}

void Zadacha56()
{
    //Задайте прямоугольный двумерный массив. 
    //Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    //Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    //Программа считает сумму элементов в каждой строке 
    //и выдаёт номер строки с наименьшей суммой элементов: 1 строка
    int[,] numbers = new int[4, 4];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    SumMinElements(numbers);
    Console.WriteLine();
}
void SumMinElements(int[,] numbers)
{
    int minElement = 0;
    int sumMinElements = 0;
    int sumElements = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        minElement += numbers[0, i];
    }
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++) sumElements += numbers[i, j];
        if (sumElements < minElement)
        {
            minElement = sumElements;
            sumMinElements = i;
        }
        sumElements = 0;
    }
    Console.Write($"{sumMinElements + 1} строка");
}

void Zadacha58()
{
    //Напишите программу, которая заполнит спирально массив 4 на 4.
    //Например, на выходе получается вот такой массив:
    //01 02 03 04
    //12 13 14 05
    //11 16 15 06
    //10 09 08 07
    int len = 4;
    int[,] numbers = new int[len, len];
    FillArraySpiral(numbers, len);
    PrintArraySpiral(numbers);
}
void FillArraySpiral(int[,] numbers, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { numbers[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) numbers[i++, j] = value++;
        for (k = 0; k < n - 1; k++) numbers[i, j--] = value++;
        for (k = 0; k < n - 1; k++) numbers[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArraySpiral(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] < 10)
            {
                Console.Write("0" + numbers[i, j]);
                Console.Write(" ");
            }
            else Console.Write(numbers[i, j] + " ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Задача 54: ");
Zadacha54();
Console.WriteLine();

Console.WriteLine("Задача 56: ");
Zadacha56();
Console.WriteLine();

Console.WriteLine("Задача 58: ");
Zadacha58();
Console.WriteLine();