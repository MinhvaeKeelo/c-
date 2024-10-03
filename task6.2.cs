using System;

class Program
{
    static int F(int x)
    {
        return x % 5 == 0 ? x / 5 : x + 1;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Измененное число: {F(a)}");
    }
}
