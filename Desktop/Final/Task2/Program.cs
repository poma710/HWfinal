//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

class Program
{
    static void Main(string[] args)
    {
        int m = 4;
        int n = 8;
        int sum = GetSum(m, n);
        Console.WriteLine(sum);
    }

    static int GetSum(int m, int n)
    {
        if (m == n)
        {
            return n;
        }
        else
        {
            return m + GetSum(m+1, n);
        }
    }
}