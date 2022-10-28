void Zadacha64()
{   //Задача 64: Задайте значения M и N. 
    //Напишите рекурсивный метод, 
    //который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Все натуральные числа кратные 3-ём в промежутке от M до N: ");
    NaturalToLow(numberN);

    void NaturalToLow(int numberN, int numberM = 0)
    {
        numberM++;

        if (numberM >= numberN)
        {
            return;
        }
        if (numberM % 3 == 0) //проверка на кратность 3 
            Console.Write(numberM + " ");
        NaturalToLow(numberN, numberM);
    }
}

void Zadacha66()
{
    //Задача 66: Задайте значения M и N. Напишите программу, 
    //которая найдёт сумму натуральных элементов в промежутке от M до N.
    //M = 1; N = 15 -> 120
    //M = 4; N = 8. -> 30

    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    int temp = numberM;

    if (numberM > numberN)
    {
        numberM = numberN;
        numberN = temp;
    }

    PrintSumm(numberM, numberN, temp = 0);
}
void PrintSumm(int numberM, int numberN, int sum)
{
    sum = sum + numberN;
    if (numberN <= numberM)
    {
        Console.Write($"Сумма элементов в промежутке от M до N равна: {sum} ");
        return;
    }
    PrintSumm(numberM, numberN - 1, sum);
}

void Zadacha68()
{
    //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    //Даны два неотрицательных числа m и n.
    //m = 2, n = 3 -> A(m,n) = 9
    //m = 3, n = 2 -> A(m,n) = 29

    Console.Write("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    int functionAkkerman = Ack(numberM, numberN);
    Console.Write($"Функция Аккермана = {functionAkkerman} ");

    int Ack(int numberM, int numberN)
    {
        if (numberM == 0) return numberN + 1;
        else if (numberN == 0) return Ack(numberM - 1, 1);
        else return Ack(numberM - 1, Ack(numberM, numberN - 1));
    }

}
Console.WriteLine("Задача 64: ");
Zadacha64();
Console.WriteLine();

Console.WriteLine("Задача 66: ");
Zadacha66();
Console.WriteLine();

Console.WriteLine("Задача 68: ");
Zadacha68();
Console.WriteLine();
