using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha19()
            {
                //Напишите программу, которая принимает на вход пятизначное число и проверяет, 
                //является ли оно палиндромом.
                // 14212 -> нет
                // 12821 -> да
                // 23432 -> да
                Console.WriteLine("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int current = number;
                int result = 0;

                while (current > 0)
                {
                    int digit = current % 10;
                    result = result * 10 + digit;
                    current /= 10;
                    Console.WriteLine(result);
                }
               
                if (number == result)
                {
                    Console.WriteLine($"Число {number} - палиндром.");
                }
                
                else if (number > 9999 && number > 100000 )
                {
                    Console.WriteLine($"Число {number} - не соответствует условию.");
                }
                
                else 
                {
                    Console.WriteLine($"Число {number} - не палинром");
                }
            } 
            Console.WriteLine("Задача 19");
            Zadacha19(); 
            Console.WriteLine();


            void Zadacha21()
            {
                //Напишите программу, которая принимает на вход координаты двух точек 
                //и находит расстояние между ними в 3D пространстве.
                // A (3,6,8); B (2,1,-7), -> 15.84
                // A (7,-5, 0); B (1,-1,9) -> 11.53
                Random random = new Random();
                int ax = random.Next(-10, 10);
                Random random2 = new Random();
                int ay = random2.Next(-10, 10);  
                Random random3 = new Random();
                int az = random3.Next(-10, 10);

                Random random4 = new Random();
                int bx = random4.Next(-10, 10);
                Random random5 = new Random();
                int by = random5.Next(-10, 10);
                Random random6 = new Random();
                int bz = random6.Next(-10, 10);

                Console.WriteLine($"Координаты точки A: ({ax}, {ay}, {az},);");
                Console.WriteLine($"Координаты точки B: ({bx}, {by}, {bz},).");

                int k = bx - ax;
                int m = by - ay;
                int l = bz - az;

                double length = Math.Sqrt(k * k + m * m + l * l);
                Console.WriteLine(length);
                length = Math.Round(length, 2);
                Console.WriteLine($"Длинна отрезка в 3D пространстве: {length}");    
            } 
            Console.WriteLine("Задача 21");
            Zadacha21();
            Console.WriteLine(); 
            


            void Zadacha23()
            {
                //Напишите программу, которая принимает на вход число (N) 
                //и выдаёт таблицу кубов чисел от 1 до N.
                // 3 -> 1, 8, 27
                // 5 -> 1, 8, 27, 64, 125
                Random random = new Random();
                int number = random.Next(1, 10);
                Console.WriteLine("Число: " + number);
               

                for (int i = 1; i<= number; i++)
                    {              
                        Console.WriteLine($"{i} * {i} * {i} = {i * i * i}");                  
                    }
            }
            Console.WriteLine("Задача 23");
            Zadacha23();

        }  
    }
    #region Fill & Print
        
}
#endregion


