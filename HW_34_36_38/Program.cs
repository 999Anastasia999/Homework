void Zadacha34()
    {   //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        //Напишите программу, которая покажет количество чётных чисел в массиве.
        //[345, 897, 568, 234] -> 2
        Console.Clear();
        Random random = new Random();
        int size = 4;
        int[] numbers = new int[size]; 
        //Console.WriteLine(size);
        FillArray(numbers, 100, 500);
        PrintArray(numbers);
        EvenCheck(numbers);
       
    }
     
void EvenCheck(int[] numbers)
    { 
        int size = numbers.Length;
        int even = 0;
        for (int i = 0; i < size; i++)
        {
            if (numbers[i] % 2 == 0) 
            {
                even++;  
            }   
        }
        Console.WriteLine("Количество чётных элементов в массиве: " + even);  
    }

void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 10)
    {
        int size = numbers.Length; 
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(minValue, maxValue);
        }
    }
void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Массив: "); 
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine(); 
}   


void Zadacha36()
    {   //Задача 36. Задайте одномерный массив, заполненный случайными числами. 
        //Найдите сумму элементов с нечётными индексами.
        //[3, 7, 23, 12] -> 19
        //[-4, -6, 89, 6] -> 0
        Random random = new Random();
        int size = 4;
        int[] numbers = new int[size];    
        FillArray(numbers, -10, 100);
        PrintArray(numbers);
        SumOddCheck(numbers);
    } 

void SumOddCheck(int[] numbers)
    {       
        int size = numbers.Length;
        int sumOdd = 0;
        for (int i = 1; i < size; i+= 2)
        {
            if (i % 2 ==1) 
            {
                sumOdd += numbers[i];
            }
        }
        Console.WriteLine("Сумма элементов с нечётными индексами: " + sumOdd);
    }

void Zadacha38()
{

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3,21 7,04 22,93 -2,71 78,24] -> max = 78,24, min = - 2,71, difference = 80,95
    Console.Clear();
    Random random = new Random();
    int size = 5;
    double[] numbers = new double[size]; 
    FillArrayDouble(numbers, -10, 10);
    PrintArrayDouble(numbers);
    CheckDifferenceMaxMin(numbers);    
}

void CheckDifferenceMaxMin(double[] numbers)
{
    int size = numbers.Length;
    double maxValue = numbers[0];
    double minValue = numbers[0];
    double difference = maxValue - minValue;
    for (int i = 0; i < size; i++) 
    {
        if(maxValue < numbers[i]) maxValue = numbers[i];
        if(minValue > numbers[i]) minValue = numbers[i]; 
    }
    Console.WriteLine($"\nМаксимальный элемент: {maxValue}\nМинимальный элемент: {minValue}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом: {maxValue-minValue}"); 
}

void FillArrayDouble(double[] numbers, 
                    int minValue = 0,
                    int maxValue = 9)                   
{
    maxValue++;
    int saiz = numbers.Length;
    Random random = new Random();
    for (int i = 0; i < saiz; i++)
    {
        double number = random.NextDouble() * 20 - 10;
        numbers[i] = Math.Round(number, 2);
    }
}
void PrintArrayDouble(double[] numbers)
{   
    int size = numbers.Length;
    Console.Write("Массив: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}   


// Console.WriteLine("Задача 34:");
// Zadacha34();  
// Console.WriteLine(""); 

// Console.WriteLine("Задача 36:");
// Zadacha36();  
// Console.WriteLine(""); 

Console.WriteLine("Задача 38:");
Zadacha38();  
Console.WriteLine(""); 