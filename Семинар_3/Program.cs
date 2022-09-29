using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha17()
            {
            //     // Задача 17: Напишите программу, которая принимает на вход координаты точки (X и Y),
            //     //причем X не равен 0 и Y не равен 0 и выдает номер четверти плоскости,
            //     //в которой находится эта точка
             
                Random random = new Random();
                int x = random.Next(-10, 11);
                int y = random.Next(-10, 11);
                Console.WriteLine($"точка A: {x}, {y}"); //точка А у которой будут координаты: x, y.
                CoorCheck(x, y);
            } 
            void CoorCheck(int x, int y)
            {   
                if (x > 0 && y > 0)
                {
                   Console.WriteLine("лежит в первой четверти"); 
                }
                else if (x < 0 && y > 0)
                {
                   Console.WriteLine("лежит во второй четверти"); 
                }
                else if (x < 0 && y < 0)
                {
                   Console.WriteLine("лежит в третьей четверти"); 
                }
                else if (x > 0 && y < 0)
                {
                   Console.WriteLine("лежит в четвертой четверти"); 
                }
                else
                {
                    Console.WriteLine("лежит на одной из осей"); 
                }
            } 
        
            Console.WriteLine("Задача 17");
            Zadacha17(); 
            Console.WriteLine();


            void Zadacha18()
            {
                //Напишите программу, которая по заданному номеру четверти,
                //показывает диапазон возможных координат точек в этой чеиверти (x и y).                
                Console.WriteLine("Введите номер четверти: "); 
                int number = Convert.ToInt32(Console.ReadLine());                
                Check(number); 
                           
            } 
            void Check(int number)
            {
                if (number == 1)
                {
                    Console.WriteLine("Ответ: в первой четверти x в диапазоне (0, +∞), y - (0, +∞)."); 
                }
                else if (number == 2)
                {
                    Console.WriteLine("Ответ: во второй четверти x в диапазоне (-∞, 0), y - (0, +∞).");  
                }
                else if (number == 3)
                {
                    Console.WriteLine("Ответ: в третьей четверти x в диапазоне (-∞, 0), y - (-∞, 0).");  
                }
                else if (number == 4)
                {
                    Console.WriteLine("Ответ: в четвертой четверти x в диапазоне (0, ∞), y - (-∞, 0)."); 
                }
                else
                {
                    Console.WriteLine("Неверный ввод"); 
                }   
            }
            
            Console.WriteLine("Задача 18");
            Zadacha18();
            Console.WriteLine(); 
            


            void Zadacha21()
            {
                //Напишите программу, 
                //которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
                //А(3, 6); В(2, 1) -> 5,09
                //А(7, -5); В(1, -1) -> 7,21

// //Мой вариант решения:
                Console.WriteLine("Введите координаты точки А: "); 
                Console.Write("x: ");
                int ax = Convert.ToInt32(Console.ReadLine());
                Console.Write("y: ");
                int ay = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Введите координаты точки B: "); 
                Console.Write("x: ");
                int bx = Convert.ToInt32(Console.ReadLine());
                Console.Write("y: ");
                int by = Convert.ToInt32(Console.ReadLine()); 

                double d = Math.Sqrt((ax - bx)*(ax - bx) + (ay - by) *(ay - by));
                Console.WriteLine(d);
                d = Math.Round(d, 2);
                Console.WriteLine("Длинна отрезка: " + d); 


// //второй вариант решения:
                // Console.WriteLine("Введите координаты точки А: "); 
                // Console.Write("x: ");
                // int ax = Convert.ToInt32(Console.ReadLine());
                // Console.Write("y: ");
                // int ay = Convert.ToInt32(Console.ReadLine()); 
                // Console.WriteLine("Введите координаты точки B: "); 
                // Console.Write("x: ");
                // int bx = Convert.ToInt32(Console.ReadLine());
                // Console.Write("y: ");
                // int by = Convert.ToInt32(Console.ReadLine()); 
                // int k = bx - ax;
                // int m = by - ay;

                // double length = Math.Sqrt(k * k + m * m);
                // Console.WriteLine(length);
                // length = Math.Round(length, 2);
                // Console.WriteLine($"Длинна отрезка: {length}"); 


// //третий вариант решения:
                // Random random = new Random();
                // int ax = random.Next(-10, 11);
                // int ay = random.Next(-10, 11);
                // int bx = random.Next(-10, 11);
                // int by = random.Next(-10, 11);
                // Console.WriteLine($"точки: A {ax}, {ay}, B {bx}, {by}"); 
                // Console.WriteLine($"Расстояние между точками A и B: {Math.Sqrt(Math.Pow((bx - ax), 2)+Math.Pow((by - ay), 2))}");
            

// //четвертый вариант решения, методом:
                // Random random = new Random();
                // int x1 = random.Next(-10, 11);
                // int y1 = random.Next(-10, 11);
                // int x2 = random.Next(-10, 11);
                // int y2 = random.Next(-10, 11);
                // Console.WriteLine($"Точка А: {x1}, {y1}");
                // Console.WriteLine($"Точка B: {x2}, {y2}");
                // Dist(x1, y1, x2, y2);
                // Console.WriteLine($"Расстояние между точками A и B: {Dist(x1,  y1,  x2,  y2)}"); 

                // double Dist(int x1, int y1, int x2, int y2)
                // {
                //     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));                    
                // }
                
            }
            Console.WriteLine("Задача 21");
            Zadacha21();


            void Zadacha22()
            {
                //Напишите программу, которая принимает на вход число (N) 
                //и выдает таблицу квадратов чисел от 1 до N.            
               
//МОЁ РЕШЕНИЕ:
            //    Console.WriteLine("Введите число: "); 
            //    int number = Convert.ToInt32(Console.ReadLine());
               

            //    for (int i = 1; i<= number; i++)
            //     {
            //         Console.WriteLine($"{i} * {i} = {i * i}");                  
            //     }
              
//♥♥ ВТОРОЕ РЕШЕНИЕ: ♥♥ 
                // Console.WriteLine("Введите число:  ");
                // int number = Convert.ToInt32(Console.ReadLine());

                // Console.WriteLine("Число\tКвадрат");
                // for (int i = 1; i <= number; i++)
                //     {
                //         Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,2 ));                       
                //     }
//♥ ТРЕТЬЕ РЕШЕНИЕ через while: ♥
                // Console.WriteLine("Введите число: ");
                // int N = Convert.ToInt32(Console.ReadLine());
                // int i = 1;
                // double Sqw;
                // while (i <= N)
                // {
                //     Sqw = Math.Pow(i,2);
                //     Console.WriteLine($"|{i}|{Sqw}|");
                //     i++;
                // }
 //♥♥♥ ЧЕТВЕРТОЕ РЕШЕНИЕ через while: ♥♥♥ 
                Random RandNum = new Random();
                int Num = RandNum.Next(1, 1000);
                string ResultStr = "";
                int i = 1;
                Console.WriteLine($"Квадраты чисел от 1 до {Num}:");
                while (i <= Num)
                {
                    if (ResultStr.Length > 0) ResultStr = ResultStr.Insert(ResultStr.Length, ", ");
                    ResultStr = ResultStr.Insert(ResultStr.Length, Convert.ToString(Math.Pow(i,2)));
                    i++;
                }              
                Console.WriteLine(ResultStr);
            }
            Console.WriteLine("Задача 22");
            Zadacha22();
        }  
    }
    #region Fill & Print
        
}
#endregion



