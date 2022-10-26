void Zadacha47()
{
    //Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
    //округлёнными до одного знака.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9
    Console.WriteLine("введите количество строк");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[lines, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
}
void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void Zadacha50()
{
    // Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет
    Console.WriteLine("введите номер строки");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[10, 10];
    FillArrayInt(numbers);
    PrintArrayInt(numbers);
    if (lines > numbers.GetLength(0) || columns > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Значение элемента {lines} строки и {columns} столбца равно {numbers[lines - 1, columns - 1]}");
    }

}
void FillArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}
void PrintArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

void Zadacha52()
{
    // Задайте двумерный массив из целых чисел. 
    // Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
    Console.WriteLine("введите количество строк");
    int lines = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] numbers = new int[lines, columns];
    FillArrayInt(numbers);
    PrintArrayInt(numbers);
    Console.WriteLine("Среднее арифметическое каждого столбца: ");

    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            arithmeticMean = (arithmeticMean + numbers[i, j]);
        }
        arithmeticMean  = arithmeticMean / lines;
        
        Console.Write(arithmeticMean + "; ");
    }
    Console.WriteLine();
}


Console.WriteLine("Задача 47: ");
Zadacha47();
Console.WriteLine();

Console.WriteLine("Задача 50: ");
Zadacha50();
Console.WriteLine();

Console.WriteLine("Задача 52: ");
Zadacha52();
Console.WriteLine();
