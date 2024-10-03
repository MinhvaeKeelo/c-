using System;

class Program
{
    static int F(int x)
    {
        return x % 2 == 0 ? x / 2 : 0;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Измененное число: {F(a)}");
    }
}