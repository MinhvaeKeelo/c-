using System;

class Program
{
    static int F(int x)
    {
        if (x >= 10 && x <= 99)
        {
            return (x % 10) * 10 + (x / 10); 
        }
        return x;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Измененное число: {F(a)}");
    }
}