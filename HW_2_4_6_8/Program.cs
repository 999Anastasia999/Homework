void Zadacha2()
{
    //Напишите программу, которая на вход принимает два числа и выдает,
    //какое число больше, а какое меньше.
    
    Random random1 = new Random();
    int number1 = random1.Next(-10, 10);
    Console.WriteLine("Первое число: " + number1);    
    Random random2 = new Random();
    int number2 = random2.Next(-10, 10);
    Console.WriteLine("Второе число: " + number2);

    if (number2 < number1)
    {
        Console.WriteLine($"{number1} > {number2}");
    }

    else if (number1 < number2)
    {
        Console.WriteLine($"{number2} > {number1}");
    }

    else
    {
        Console.WriteLine($"{number1} = {number2}");
    }

}
Console.WriteLine("Задача 2:");
Zadacha2();
Console.WriteLine();


void Zadacha4()
{
    //Напишите программу, котрая принимает на вход три числа,
    //и выдает максимальное из этих чисел.

    Random random1 = new Random();
    int number1 = random1.Next(-10, 10);
    Console.WriteLine("Первое число: " + number1);
    Random random2 = new Random();
    int number2 = random2.Next(-10, 10);
    Console.WriteLine("Второе число: " + number2);
    Random random3 = new Random();
    int number3 = random3.Next(-10, 10);
    Console.WriteLine("Третье число: " + number3);
    int numberMax = number1;

    if (numberMax < number2)
    {
        numberMax = number2;
    }

    if (numberMax < number3)
    {
        numberMax = number3;
    } 

    Console.WriteLine("Максимальное чисело: " + numberMax);
}
Console.WriteLine("Задача 4:");
Zadacha4();
Console.WriteLine();


void Zadacha6()
{
    //Напишите программу, которая на входе принимает число и выдает,
    //является ли число четным(делится ли оно на 2 без остатка).
    Random random = new Random();
    int number = random.Next(-10, 10);
    Console.Write("Число: " + number);

    if (number % 2 == 0)
    {
        Console.Write(" - является четным.");
    }

    else
    {
        Console.Write(" - является нечетным.");
    }

}
Console.WriteLine("Задача 6:");
Zadacha6();
Console.WriteLine();
Console.WriteLine();


void Zadacha8()
{
    //Напишите программу, которая на вход принимает число (N > 0),
    //а на выходе показывает все четные числа от 1 до N.
    Random random = new Random();
    int number = random.Next(2, 10);
    Console.WriteLine("Число: " + number);
    string Answer = "";
    string Sep = "";
    int number2 = 1;
    
    if (number >= 0) 
    { 
        while (number2 <= number)         
        {            
            if (number2 % 2 == 0)
            {
                if (number2 == number) {Sep = ".";} else {Sep = ", ";}
                Answer = Answer + number2 + Sep;  
                
            }         
            number2 = number2 + 1; 
        }
        
        Console.WriteLine("Все четные числа от 1 до " + number + ": " + Answer);
        Console.WriteLine();
    }  
   
}
Console.WriteLine("Задача 8:");
Zadacha8();
Console.WriteLine();