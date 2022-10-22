void Zadacha39()
{
    //Напишите программу, которая перевернет одномерный массив
    //(последний элемент будет на первом месте, а первый - на последнем и т.д.)
    //Пример: [1 2 3 4 5 ] -> [5 4 3 2 1]
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    PrintArray(numbers);
    ReverseArray(numbers);
    PrintArray(numbers);
}

void ReverseArray(int[] numbers)
{
    int size = numbers.Length;
    int maxIndex = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
        //Решение через КОРТЕЖ - (,) = (,);
    }
}

void FillArray(int[] numbers,
                int minValue = 0,
                int maxValue = 9)
{
    maxValue++;
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
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}


void Zadacha40()
{
    //Напишите программу, которая принимает на вход три числа и проверяет, 
    //может ли существовать треугольник со сторонами такой длинны.
    //*Теореме о неравнстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

    //ПЕРВОЕ решение:
    Console.Clear();
    Random random1 = new Random();
    int number1 = random1.Next(1, 5);
    Random random2 = new Random();
    int number2 = random2.Next(1, 5);
    Random random3 = new Random();
    int number3 = random3.Next(1, 5);
    Console.WriteLine($"Даны три числа: {number1}, {number2}, {number3}.");

    if (number1 + number2 > number3 && number2 + number3 > number1 && number3 + number1 > number2)
    {
        Console.WriteLine("Треугольник существует.");
    }
    else
    {
        Console.WriteLine("Треугольник НЕ существует.");
    }
    // //ВТОРОЕ решение:
    //     Console.Clear();
    //     int one = InputMessage("Введите первое число: ");
    //     int two = InputMessage("Введите второе число: ");
    //     int three = InputMessage("Введите третье число: ");
    //     if (one + two > three && two + three > one && three + one > two)
    //      {
    //         Console.WriteLine("Треугольник существует.");
    //      }
    //      else
    //      {
    //         Console.WriteLine("Треугольник НЕ существует.");
    //      }
}
// Zadacha40();
// int InputMessage(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


void Zadacha42()
{
    //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    //Пример: 45->101101, 3->11, 2->10.
    //ПЕРВОЕ решение: 
    // Random random = new Random();
    // int number = random.Next(10, 50); 
    // Console.WriteLine("Дано число: " + number);
    // string result = "";

    // while (number > 0)
    // {
    //     result = number%2 + result;
    //     number /= 2;
    // }

    // Console.WriteLine("Преобразование в двоичное число: " + result);

    //ВТОРОЕ решение: 
    // int number = 43;
    // string result = Convert.ToString(number, 2);
    // Console.WriteLine(result);  

    //ТРЕТЬЕ решение:
    Random random = new Random();
    int number = random.Next(10, 50);
    Console.WriteLine("Дано число: " + number);
    int number1 = number;
    double result = 0;
    double i = 0;

    while (number1 > 0)
    {
        result = (number1 % 2) * Math.Pow(10, i) + result;
        number1 /= 2;
        i += 1;
    }
    Console.WriteLine($"В двоичном коде: {result}");
    Console.WriteLine("- - - - - - Задача успешно выполнена! - - - - -\n");
}


void Zadacha44()
{
    //Не используя рекурсию, выведите первые N числ Фибоначчи. 
    //Первые два числа Фибоначчи: 0 и 1.
    //Пример: 
    //Если N = 5 -> 01123
    //Если N = 3 -> 011
    //Если N = 57 -> 0112358.
    Console.Clear();
    Console.WriteLine("Введите число: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int a = 0;
    int b = 1;
    double[] numbers = new double[size];
    numbers[0] = a;
    numbers[1] = b;
    for (int i = 2; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i - 2] + numbers[i - 1];
    }
    PrintArray2(numbers);
}

void PrintArray2(double[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine("Число Фибоначчи: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
}

void Zadacha45()
{
    //Напишите программу, которая будет создавать корпию заданного массива 
    //с помощью поэлементного копирования.
    int size = 10;
    int[] numbers = new int[size];
    int[] other = new int[size];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);

    for (int i = 0; i < numbers.Length; i++)
    {
        other[i] = numbers[i];
        Console.Write(other[i] + "  ");
    }  
}


// Console.WriteLine("Задача 39:");
// Zadacha39();  
// Console.WriteLine("");  

// Console.WriteLine("Задача 40:");
// Zadacha40();
// Console.WriteLine("");

// Console.WriteLine("Задача 42:");
// Zadacha42();  
// Console.WriteLine("");

// Console.WriteLine("Задача 44:");
// Zadacha44();
// Console.WriteLine("");

Console.WriteLine("Задача 45:");
Zadacha45();  
Console.WriteLine("");