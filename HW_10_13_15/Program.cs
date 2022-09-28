using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha10()
            {
                // Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
                //и на выходе показывает вторую цифру этого числа.
                // 456 -> 5
                // 782 -> 8
                // 918 -> 1
                Random random = new Random();
                int number = random.Next(99, 1000);
                Console.WriteLine(number);
                int second = number / 10 % 10;
                Console.WriteLine("вторая цифра числа: " + second);
            } 
            Console.WriteLine("Задача 10");
            Zadacha10(); 
            Console.WriteLine();



            void Zadacha13()
            {
                // // Задача 13: Напишите программу, которая с помощью деления 
                //выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
                // // 645 -> 5
                // // 78 -> третьей цифры нет
                // // 3267432979 -> 6                
                int number = Convert.ToInt32(Console.ReadLine());               
                number = Math.Abs(number);                
                if (99 < number)
                {
                    while (999 < number)
                    {
                       number /=10;
                    }
                    Console.WriteLine("третья цифра числа: " + number%10);

                }                          
                               
                else 
                {
                  Console.WriteLine("третьей цифры нет");
                }
                
            } 
            Console.WriteLine("Задача 13");
            Zadacha13();
            Console.WriteLine(); 
            


            void Zadacha15()
            {
                // // Задача 15: Напишите программу, которая принимает на вход цифру, 
                //обозначающую день недели, и проверяет, является ли этот день выходным.
                // // 6 -> да
                // // 7 -> да
                // // 1 -> нет
                Console.WriteLine("Введите номер дня недели (от 1 до 7): ");                        
                int number = Convert.ToInt32(Console.ReadLine());
                         
                if (number == 6)
                {
                    Console.WriteLine("да, это выходной день");
                }
                else if (number == 7)
                {
                    Console.WriteLine("да, это выходной день");
                }
                else
                {
                  Console.WriteLine("нет, это будний день");  
                }

            }
            Console.WriteLine("Задача 15");
            Zadacha15();

        }  
    }
    #region Fill & Print
        
}
#endregion

