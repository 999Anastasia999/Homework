void Zadacha25()
{
// Используя определение степени числа напишите цикл,
//который принимает на вход два натуральных числа(A & B) и возводит число A в степень B.
    Random random = new Random();
    int A = random.Next(10, 20); 
    Console.WriteLine("Число A = " + A);
    Random random2 = new Random();
    int B = random2.Next(10, 20); 
    Console.WriteLine("Число B = " + B);
    int result = 1;

    for (int i = 1; i <= B; i++)
    {
        result *= A; 
    }
    Console.WriteLine($"Число {A} в степени {B} = {result}");
}
    
Console.WriteLine("Задача 25.");
Zadacha25();
Console.WriteLine();

void Zadacha27() 
{
    //Напишите программу, которая принимает на вход число
    //и выдает сумму цифр в числе.
    Random random = new Random();
    int number = random.Next(10, 200); 
    Console.WriteLine("Число: " + number);
    int sum = 0;

    while (number > 0)     
    {
        sum += number%10;
        number /= 10;
    }
    Console.WriteLine("Сумма цифр в числе равна: " + sum);
}
Console.WriteLine("Задача 27.");
Zadacha27();
Console.WriteLine();

void Zadacha29()
{
//Напишите программу, которая задает массив из 8 случайных целых чисел
//и выводит отсортированный по модулю массив.
 
    
    int size = 8;
    int[] numbers = new int[size];
    Console.WriteLine("Массив: ");
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Отсортированный по модулю массив: ");
    
    for (int i = 1; i < size; i++)
    {
        for (int j = 0; j < size - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
            
        }
        PrintArray(numbers);
    }
    
}
void FillArray(int[] num)
{
     Random random = new Random();
     for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(1, 9);
    }
}
void PrintArray(int[] num)
{
     for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Задача 29.");
Zadacha29();
Console.WriteLine();