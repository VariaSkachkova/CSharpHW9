void Task64()
{
    Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.");
    Console.WriteLine("Введите начальное число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    PrintNumsInRangeRecursion(num1, num2);
    void PrintNumsInRangeRecursion(int num1, int num2)
    {
        if (num1 > num2) return;

        if (num1 % 3 == 0)
        {
            Console.Write(num1 + "  ");
            num1 = num1 + 3;

        }
        else
        {
            num1 += 1;
        }

        PrintNumsInRangeRecursion(num1, num2);
    }
    
}


void Task66()
{
    Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("Введите начальное число:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите конечное число:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
    SumUpNumsInRangeRecursion(num1, num2);
}
void SumUpNumsInRangeRecursion(int num1, int num2, int sum = 0)
{
    if (num1 > num2)
    {
        Console.WriteLine($"Сумма элементов: {sum}");
        return;
    }
    sum += num1;
    num1++;
    SumUpNumsInRangeRecursion(num1, num2, sum);

}

void Task68()
{
    Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.WriteLine("Введите первое целое число в промежутке между 0 и 3:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число в промежутке между 0 и 3:");
    int n = Convert.ToInt32(Console.ReadLine());
    int acker = FindAckerman(m, n);
    Console.WriteLine($"A({m},{n}) = {acker}");
}
int FindAckerman(int m, int n)
{
    int acker;
    if (m == 0)
    {
        acker = n + 1;
    }
    else if (m > 0 && n == 0)
    {
        acker = FindAckerman(m - 1, 1);
    }
    else
    {
        acker = FindAckerman(m - 1, FindAckerman(m, n - 1));
    }
    return acker;

}
Task64();
Console.WriteLine();
Task66();
Console.WriteLine();
Task68();
