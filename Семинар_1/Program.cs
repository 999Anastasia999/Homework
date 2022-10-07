using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha0()
            {
                //Напишите программу, которая принимает на вход число и выдает его квадрат
                //(число умноженное на само себя). Пример: 4->16, -3->9, -7->49.
                
                Random random = new Random ();
                int n = random.Next(-10, 10);
                Console.WriteLine("Число: " + n);
                int b;
                b = n * n;
                Console.WriteLine("Квадрат числа: " + b);
                

            }
            Console.WriteLine("Задача 0:"); 
            Zadacha0();
            Console.WriteLine();

            // void Zadacha01()
            // {
            //     //Напишите программу, которая принимает на вход число и выдает его квадрат
            //     //(число умноженное на само себя). Пример: 4->16, -3->9, -7->49.
            //     Console.WriteLine("Введите число: ");
            //     int a = Convert.ToInt32(Console.ReadLine());
            //     int b = a * a;
            //     //Console.WriteLine("Квадрат числа: " +b); 
            //     Console.WriteLine($"{a} * {a} = {b}"); //Интерполяция
            // }
            // Console.WriteLine("Задача 01:"); 
            // Zadacha01();
            // Console.WriteLine();


            void Zadacha001()
            {
                //Если (идет дождь) // условие
                //(то возьми зонт)  //действие 1
                //Иначе 
                //(иди в сандалях)  //действие 2
                int rain = 1; //Где, 0 - не идет дождь, 1 - идет.
                if (rain == 1)
                {
                    Console.WriteLine("Возьми зонт.");
                }
                else
                {
                    Console.WriteLine("Можешь идти в сандалях.");
                }

            }
            Console.WriteLine("Задача 001:");
            Zadacha001();
            Console.WriteLine();

            // //Цикл:
            // //Пока время раннее, можно ссмотреть мультики.
            // void ZadachaTime()
            // {
            //     int time = 11;
            //     while(time < 22)
            // {
            //     time++;
            //     Console.WriteLine("Можно смотреть мультики: " + time);
            // }
            // Console.WriteLine("Пора спать.");
            // Console.WriteLine(time);
            // }
            // Console.WriteLine("Zadacha time:");
            // ZadachaTime();
            // Console.WriteLine();


            void Zadacha1()
            {
                //Напишите программу, которая на вход принимает два числа и повторяет,
                //является ли первое число квадратом второго.
                Random randomA = new Random();
                int A = randomA.Next(-10, 10);
                Console.WriteLine("Первое число: " + A);
                Random randomB = new Random();
                int B = randomB.Next(-10, 10);
                Console.WriteLine("Второе число: " + B);
                if (A == B * B)
                {                    
                    Console.WriteLine("Первое число - это  квадрат второго");
                }
                else
                {
                    Console.WriteLine("Первое число не является квадратом второго");
                }
            }
            Console.WriteLine("Задача 1:");
            Zadacha1();
            Console.WriteLine();

            void Zadacha3()
            {
                //Напишите программу, которая будет выдавать 
                //название дня недели по заданному номеру.
                Random random = new Random();
                int number = random.Next(1, 7);
                Console.WriteLine("Число: " + number);
                if (number == 1)
                {
                    Console.WriteLine("Понедельник.");
                }
                else if (number == 2)
                {
                    Console.WriteLine("Вторник.");
                }
                else if (number == 3)
                {
                    Console.WriteLine("Среда.");
                }
                else if (number == 4)
                {
                    Console.WriteLine("Четверг.");
                }
                else if (number == 5)
                {
                    Console.WriteLine("Пятница.");
                }
                else if (number == 6)
                {
                    Console.WriteLine("Суббота.");
                }
                else if (number == 7)
                {
                    Console.WriteLine("Воскресенье.");
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Задача 3:");
            Zadacha3();
            Console.WriteLine();


            int Power(int x) // int x - это параметр функции, которая будет существовать внутри функции Power.
            {
                // //Напишите программу вычисления значения _*функции*_ возведения числа в квадрат.
                // Random random = new Random();
                // int number = random.Next(-10, 10);
                // Console.WriteLine("Число: " + number);
                // int number2 = number * number;  
                // Console.WriteLine("Возведение числа в квадрат:");             
                // Console.WriteLine($"{number} * {number} = {number2}");
                 return x * x;                
            }  
            //Console.WriteLine("Введите число: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Power(number));
            Console.WriteLine("Задача 5:");
            Random random = new Random();
            int x = random.Next(-10, 10);
            Console.WriteLine("Число: " + x);          
            Console.WriteLine("Число в квадрате: " + Power(x));
            

            
            void Zadacha7()
            {
                //Напишите программу, которая на вход принимает одно число (N),
                //а на выходе показывает все целые числа в промежутке от - N  до N.
                Random random = new Random();
                int number = random.Next(-10, 10);
                Console.WriteLine("Число: " + number);
                number = Math.Abs(number);
                int number2 = -number;//number * -1;
                while (number2 <= number)
                {
                    
                    Console.Write(number2 + ",");                    
                    number2 = number2 + 1; 
                    
                }             
                //Console.Write("\b"); //Убирает один знак, /b/b - убирает 2 знака.
                
            }            
            Console.WriteLine("Задача 7:");            
            Zadacha7();
            Console.WriteLine();
            
            
        }  
    }
    #region Fill & Print
        
}
#endregion