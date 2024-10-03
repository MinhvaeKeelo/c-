using System;

class Program
{
    static double F(double x, double y)
    {
        return Math.Round(Math.Sqrt(x * x + y * y), 2);
    }

    static void Main()
    {
        Console.Write("Введите первый катет: ");
        double k1 = double.Parse(Console.ReadLine());
        Console.Write("Введите второй катет: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Гипотенуза равна: {F(k1, k2)}");
    }
}