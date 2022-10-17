void Zadacha9()
{
    //Напишите программу, которая выводит случайное число из отрезка[10, 99]
    //и показывает наибольшую цифру числа.
    
    Random random = new Random();
    int number = random.Next(10, 100);
    Console.WriteLine("Число: " + number);
    int tens = number / 10;
    int ones = number % 10;

    if (tens > ones)
    {
        Console.WriteLine("Наибольшая цифра: " + tens);
        Console.WriteLine("Наименьшая цифра: " + ones);
    }
    else if (ones > tens)
    {
        Console.WriteLine("Наибольшая цифра: " + ones);
        Console.WriteLine("Наименьшая цифра: " + tens);
    }
    else
    {
        Console.WriteLine("Числа равны.");
    }

}
Console.WriteLine("Задача 9:");
Zadacha9();
Console.WriteLine();

void Zadacha11()
{
    //Напишите программу, которая выводит случайное трехзначное число 
    //и удаляет вторую цифру этого числа.
//Мой ввриант:    
    Random random = new Random();
    int number = random.Next(100, 1000);
    int hundredths = number / 100;
    int tens = number / 10;
    int ones = number % 10;
    Console.WriteLine($"Первая и третья цифра числа {number}: {hundredths}, {ones}.");
//Второй:
    //Console.WriteLine(hundredths * 10 + ones); //Применили формулу.

//Третий:
    // int number = new Random().Next(100, 1000);
    // int hundredths = number / 100;
    // int ones = number % 10;
    // string tens = Convert.ToString(hundredths) + Convert.ToString(ones);
    // Console.WriteLine(number);
    // Console.WriteLine(tens);
}
Console.WriteLine("Задача 11:");
Zadacha11();
Console.WriteLine(); 

void Zadacha12()
{
//     //Напишите программу, которая будет принимать на вход два числа и выводить,
//     //является ли второе число кратным первому. 
//     //Если число 2 не кратно числу 1, 
//     //то программа выводит остаток от деления.

    Console.WriteLine("Первое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Второе число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = number1 % number;

    if (number1 % number == 0)
    {
        Console.WriteLine("Число кратно.");
    }

    else 
    {
        Console.WriteLine($"Число НЕ кратно, остаток = {number2}.");
    }

}
Console.WriteLine("Задача 12:");
Zadacha12();
Console.WriteLine(); 

void Zadacha14()
{
    //Напишите программу, которая принимает на вход число и проверяет,
    //кратно ли оно одновременно 7 и 23.
    
// ♥ Мое решение:    
    // int number = 7;
    // int number2 = 23;
    // Console.WriteLine("Введите число: ");
    // int number3 = Convert.ToInt32(Console.ReadLine());
    // if (number3 % number == 0 && number3 % number == 0)
    // {
    //     Console.WriteLine($"Число {number3} одновременно кратно числам {number} и {number2}");
    // }
    // else
    // {
    //     Console.WriteLine($"Число {number3} одновременно НЕ кратно числам {number} и {number2}");
    // }
    
// ♥ Второй вариант:

    Console.WriteLine("Введите число: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    if (Num % 7 == 0 && Num % 23 == 0)
    {
        Console.WriteLine($"Число {Num} одновременно кратно числам 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {Num} одновременно НЕ кратно числам 7 и 23");
    }
//Третий вариант:
//     Console.WriteLine("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     //161 - это 7*23=161
//     if (number % 161 != 0) Console.WriteLine($"Число {number} одновременно НЕ кратно 7 и 23."); 
//     else Console.WriteLine($"Число {number} одновременно кратно 7 и 23."); 

}
Console.WriteLine("Задача 14:");
Zadacha14();
Console.WriteLine(); 

void Zadacha16()
{
    //Напишите программу, которая принимает на вход два числа и проверяет,
    //является ли одно число квадратом другого.
    int Input()
    {
        Console.WriteLine("Введите число: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    int number1 = Input();
    int number2 = Input();
    
    // if (number2 == number1 * number1    - МОЕ РЕШЕНИЕ
    //     || number1 == number2 * number2)- МОЕ РЕШЕНИЕ
    if (number2 == Math.Pow(number1, 2) //number2 == Math.Pow(number1, 2)-//Через функцию(Math.Pow)...
        || number1 == Math.Pow(number2, 2))                              //...что возводим(number1,),в квадрат(2).
    {
      Console.WriteLine($"Да");  
    }
    else
    {
        Console.WriteLine($"Нет");  
    }


}
Console.WriteLine("Задача 16:");
Zadacha16();
Console.WriteLine(); 