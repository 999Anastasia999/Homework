void Zadacha41()
{
//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввел пользователь.
//Пример: 0,7,8,-2,-2 -> 2;  -1,-7,567,89,223 -> 3.
Console.Clear();
Console.WriteLine("Сколько чисел требуется ввести?");
int numbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < numbers; i++)
{
    Console.WriteLine($"Введите {i} число: ");
    int enteredNumber = Convert.ToInt32(Console.ReadLine());
    if(enteredNumber > 0)
    {
        count++;
    } 
    Console.WriteLine("Положительных чисел введено: " + count);
}
}

void Zadacha43()
{
//Напишите программу, которая найдет точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1,k1,b2 и k2 задаются пользователем.
//Пример:b1= 2, k1 = 5, b2 = 4,  k2 = 9 -> (-0,5; -0,5).

double k1 = 5;
double b1 = 2;
double k2 = 9;
double b2 = 4;
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка перечсечения A ({x}, {y})");
}

Console.WriteLine("Задача 41: ");
Zadacha41();
Console.WriteLine();

Console.WriteLine("Задача 43: ");
Zadacha43();
Console.WriteLine();