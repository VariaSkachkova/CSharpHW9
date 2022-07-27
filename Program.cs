void Task64()
{
Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.");
Console.WriteLine("Введите начальное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число:");
int num2 = Convert.ToInt32(Console.ReadLine());
PrintNumsInRangeRecursion(num1, num2);
void PrintNumsInRangeRecursion( int num1, int num2)
{
    if (num1 > num2) return; 
    
    if (num1 % 3 == 0)
    {
        Console.Write(num1 + "  ");
        num1 = num1 + 3;
        
    }
    else 
    {
        num1+= 1;
    }

    PrintNumsInRangeRecursion(num1, num2);
}
Console.WriteLine();
}
//Task64();

void Task66()
{
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Введите начальное число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число:");
int num2 = Convert.ToInt32(Console.ReadLine());
SumUpNumsInRangeRecursion(num1, num2);
}
void SumUpNumsInRangeRecursion( int num1, int num2, int sum = 0)
{
    if (num1 > num2) 
    {
        Console.WriteLine($"Сумма элементов: {sum}");
        return; 
    }
    sum+=num1;
    num1++;
    SumUpNumsInRangeRecursion(num1, num2, sum);
    
}
//Task66();

void Task68()
{
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int akker = FindAkkerman (m, n);
Console.WriteLine($"A({m},{n}) = {akker}");
}
int FindAkkerman ( int m, int n)
{
    int akker;
    if (m == 0) 
    {
        akker = n + 1;
         
    }
    else if (m > 0 && n == 0) 
    {
        akker = FindAkkerman(m - 1, 1);
    }
    else 
    {
        akker = FindAkkerman(m - 1, FindAkkerman(m, n - 1));
    }
    return akker;     
       
}
Task68();
