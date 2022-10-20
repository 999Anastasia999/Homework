
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha10()
            {
            //Напишите программу,которая на вход принимает трехзначное число
            //и на выходе выводит перевернутое число.
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1000 && 99 < number)
            {
            Console.WriteLine($"Перевернутое число: {number % 10}{number / 10 % 10}{number / 100 % 100}");
            }
            else
            {
                Console.WriteLine("Введено НЕ трехзначное число.");
            }

            }

            void Zadacha13()
            {
            //Напишите программу,которая выводит третью цифру заданного числа 
            //или сообщает, что третьей цифры нет.

            //ПЕРВЫЙ ВАРИАНТ РЕШЕНИЯ:
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            number = Math.Abs(number); //На отрицательные значения.

            if (number > 99)
            {
                while (number > 999)
                {
                    number /= 10; //сброс последней цифры, пока не дойдет до 3-х значного.
                    //Console.WriteLine(number); - ОТЛАДКА.
                }
                Console.WriteLine("Третья цифра числа: " + (number % 10));
            }
            else
            {
                Console.WriteLine("Введено не трехзначное число.");
            }

            //РЕШЕНИЕ В ОДНУ СТРОКУ (но это не рациональное решение): 
            // string number = "123456";
            // Console.WriteLine("Число: " + number);
            // Console.WriteLine("Третья цифра числа: " + number [2]);

            //♥♥♥ //СКОЛЬКО ВРЕМЕНИ займет решение в одну строку и через деление на остаток:
            // DateTime lastTime = DateTime.Now;
            // int number = 123;

            // for (int i = 0; i < 1000000000; i++)
            // {
            //     var n = number / 10 % 10; //заняло времени 00:00:03.5334586
            //     //var n = Convert.ToString(number)[1]; //заняло времени 00:00:11.0123815
            // }
            // Console.WriteLine(DateTime.Now - lastTime);

            }

            void Zadacha15()
            {
            //Напишите программу,которая принимает на вход цифру,
            //обозначающую день недели, и проверяет, является ли этот день выходным.
            //МОЙ ВАРИАНТ
                // Console.WriteLine("Введите число: ");
            //     int number = Convert.ToInt32(Console.ReadLine());

            //     if (number > 0 && number < 8)
            //     {    
            //         if (number == 1)
            //         {
            //             Console.WriteLine("День недели: понедельник, будний день.");
            //         }
            //         else if (number == 2)
            //         {
            //             Console.WriteLine("День недели: вторник, будний день.");
            //         }
            //         else if (number == 3)
            //         {
            //             Console.WriteLine("День недели: среда, будний день.");
            //         }
            //         else if (number == 4)
            //         {
            //             Console.WriteLine("День недели: четверг, будний день.");
            //         }
            //         else if (number == 5)
            //         {
            //             Console.WriteLine("День недели: пятница, будний день.");
            //         }
            //         else if (number == 6)
            //         {
            //             Console.WriteLine("День недели: суббота, выходной день.");
            //         }
            //         else if (number == 7)
            //         {
            //             Console.WriteLine("День недели: воскресенье, выходной день.");
            //         }
            //     }
            // else
            //     {
            //         Console.WriteLine("Число не соответствует условию.");
            //     }

            //Решение через МАССИВ:4
                Console.WriteLine("Введите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
                string[] week = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
                if (day > 0 && day < 8)
                {
                    Console.WriteLine(week[day - 1]); //week[0] - [day - 1] - это индекс, равен [0] - это понедельник.
                    if (day == 6 && day == 7)
                    {
                        Console.WriteLine("Выходной день.");
                    }
                    else
                    {
                        Console.WriteLine("Будний день.");
                    }
                }
                else
                {
                    Console.WriteLine("Число не соответствует условию.");
                }
            }

            // Console.WriteLine("Задача 10:");
            // Zadacha10();
            // Console.WriteLine("");  

            // Console.WriteLine("Задача 13:");
            // Zadacha13();
            // Console.WriteLine(""); 

            // Console.WriteLine("Задача 15:");
            // Zadacha15();
            // Console.WriteLine(""); 


            void Zadacha19()
            {
                //Напишите программу, которая принимает на вход пятизначное число и проверяет,
                //является ли оно палиндромом. 12821->да, 23432->да, 14212->нет.
                Console.WriteLine("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int thousandsTens = number/ 10000;
                int thousands = number / 1000;
                int hundreds = number / 100;
                int tens = number / 10;
                int ones = number % 10;
                Chack19(number, thousandsTens, thousands, hundreds, tens, ones);
            }
            void Chack19(int number, int thousandsTens, int thousands, int hundreds, int tens, int ones)
            {   
                if (100000 > number && number > 9999)
                {
                    if(thousandsTens == ones || thousands == tens)
                    {
                        Console.WriteLine("Это число палиндром.");
                    }
                    
                    else
                    {
                        Console.WriteLine("Это число НЕ палиндром.");
                    }
                }
            
                else
                {
                    Console.WriteLine("Введеное число не соотвветствует условию.");
                }
            }

            void Zadacha21()
            {
                //Напишите программу, которая принимает на вход координаты двух точек
                //и находит расстояние между ними в 3D пространстве.
                Random random = new Random();
                int coordinatesAx = random.Next(-10, 10);
                Random random2 = new Random();
                int coordinatesAy = random2.Next(-10, 10);
                Random random3 = new Random();
                int coordinatesAz = random3.Next(-10, 10);
                Console.WriteLine($"Координаты точки A: {coordinatesAx}, {coordinatesAy}, {coordinatesAz};");
                
                Random random4 = new Random();
                int coordinatesBx = random4.Next(-10, 10);
                Random random5 = new Random();
                int coordinatesBy = random5.Next(-10, 10);
                Random random6 = new Random();
                int coordinatesBz = random6.Next(-10, 10);
                Console.WriteLine($"Координаты точки B: {coordinatesBx}, {coordinatesBy}, {coordinatesBz};");

                int k = coordinatesBx - coordinatesAx;
                int m = coordinatesBy - coordinatesAy;
                int l = coordinatesBz - coordinatesAz;

                double distance = Math.Sqrt(Math.Pow(k, 2) + Math.Pow(m, 2) + Math.Pow(l, 2));
                Console.WriteLine($"Расстояние между точками A и B в 3D пространстве: {distance}"); 
                distance = Math.Round(distance, 2);
                Console.WriteLine("Ответ: " + distance);
            }

            void Zadacha23()
            {
                //Напишите программу, которая принимает на вход число (N) 
                //и выдает таблицу кубов чисел от 1 до N.
                Console.WriteLine("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                

                for(int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
                }
            }   
            
            // Console.WriteLine("Задача 19:");
            // Zadacha19();
            // Console.WriteLine("");   

            // Console.WriteLine("Задача 21:");
            // Zadacha21();
            // Console.WriteLine(""); 
       
            // Console.WriteLine("Задача 23:");
            // Zadacha23();
            // Console.WriteLine(""); 


            void Zadacha24()
            {
                //Напишите программу, которая принимает на вход число (A)
                //и выдает сумму чисел от1 до A.  7=>28, 4=>10, 8=>36.
                Random random = new Random();
                int number = random.Next(-10, 10);
                Console.WriteLine("Число: " + number);
                int sum = 0;
                number = Math.Abs(number);
                for (int i = 0; i <= number; i++)
                {
                    //Console.Write($" + {i}");
                    sum += i; // sum = sum + i
                }
                Console.Write($"{sum}");
                
            }
                

            void Zadacha26()
            {
                //Напишите программу, которая принимает на вход число
                //и выдает s.
//♥♥♥ МАТЕМЕТИЧЕСКОЕ РЕШЕНИЕ:
                Console.WriteLine("\n \t Task 24");
                Console.Write("Enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num} -> {Math.Ceiling(Math.Log10(num))}");

//МОЕ РЕШЕНИЕ:
                // Random random = new Random();
                // int number = random.Next(0, 100);
                // Console.WriteLine("Число: " + number);
                // int result = number;
                // int i = 0;
                // while (result > 0)
                // {
                //     result = result / 10;
                //     i++;
                // }
                // Console.WriteLine($"Количество цифр в числе: {i}");
            
                
//Решение через ЦИКЛ:
                // Random random = new Random();
                // int number = random.Next(0, 100);
                // Console.WriteLine("Число: " + number);
                // int current = number;
                // int count = 0;

                // while (current > 0)
                // {
                //     current = current / 10;
                //     count++;  
                // }
                // Console.WriteLine($"Количество цифр в числе: {count}");

//Решение через СТРОКУ 1:
                // Random random = new Random();
                // int number = random.Next(0, 100);
                // Console.WriteLine("Число: " + number);
                // string number2 = Convert.ToString(number);
                // Console.WriteLine($"Количество цифр в числе: {number2.Length}");

//Решение через СТРОКУ 2 более оптимальное:
                // Console.WriteLine("Введите число: ");
                // string number = Console.ReadLine();
                // Console.WriteLine($"Количество цифр в числе: {number.Length}");

            }


            void Zadacha28()
            {
                //ФАКТОРИАЛ числа N - произведение всех натуральных чисел от 1 до N включительно.
                //Напишите программу, которая принимает на вход число N
                //и выдает произведение чисел от 1 до N. 4=>24, 5=>120. 
                Random random = new Random();
                int number = random.Next(1, 6);
                Console.WriteLine("Число: " + number);
                int numberProduct = 1;
                //int number = 64;
                //double numberProduct = 1; на целочисленные (деление с остатком)

                for (int i = 1; i <= number; i++)
                {
                    //Console.WriteLine($" * {i}");
                    numberProduct *= i; // numberProduct = numberProduct * 1
                    Console.WriteLine(numberProduct);
                }
                Console.WriteLine($"Произведение чисел: {numberProduct}");
            }

            void Zadacha30()
            {
                //Напишите программу, которая выводит массив из 8 элементов,
                //заполненный нулями и еденицами в случайном порядке. [1,0,1,1,0,1,0,0]
                Random random = new Random();
                int size = random.Next(4, 10);
                int[] numbersАrray = new int[size]; 
                Console.WriteLine(size); 
                //new int[size] - рандомный массив,   
                //numbersАrray-имя массива,
                //int[] -выделенная память для массива.
//цикл на ЗАПОЛНЯЕМ МАССИВА:
                FillArray(numbersАrray);
//С консоли задавать массив:
                // for (int i = 0; i < numbersАrray.Length; i++)
                // {
                //     Console.WriteLine($"Введите {i + 1}-й элемент массива");
                //     numbersАrray[i] = Convert.ToInt32(Console.ReadLine());
                // }
//цикл на ВЫВОД массива:
                PrintArray(numbersАrray);
                // for (int i = 0; i < size; i++)
                // {
                //     Console.Write(numbersАrray[i] + " "); // "\t" - это большой пробел.
                // }
                Console.WriteLine();
            }
//Создадим пару МЕТОДОВ:

//Ссылочные типы:
            // void Test()
            // {
            //     int x = 6;
            //     Test2(x);
            //     Console.WriteLine(x);
            // }
            // void Test2(int y)
            // {
            //     y = 16;
            // }
            // Test();

    //1.метод будет заполнять массив:
            void FillArray(int[] num)
            {
                Random random = new Random();
                for (int i = 0; i < num.Length; i++)
                {
                    num[i] = random.Next(0, 2);
                }
            }
                
    //2.метод
            void PrintArray(int[] num)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    Console.Write(num[i] + "  ");
                }
                
                Console.WriteLine();
            }
            // Console.WriteLine("Задача 24:");
            // Zadacha24();
            // Console.WriteLine(""); 

            // Console.WriteLine("Задача 26:");
            // Zadacha26(); 
            // Console.WriteLine("");   

            // Console.WriteLine("Задача 28:");
            // Zadacha28();  
            // Console.WriteLine("");        

            Console.WriteLine("Задача 30:");
            Zadacha30();  
            Console.WriteLine("");  
            
        }  
    }
    #region Fill & Print
        
}
#endregion