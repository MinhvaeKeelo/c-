public class Programm
{
    static double F(double x)
    {
        return Math.Pow(x, 3) - Math.Sin(x);
    }
    public static void Main(string[] args)
    {
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double valueA = F(a);
        double valueB = F(b);

        if (valueA > valueB)
        {
            Console.WriteLine($"Наибольшее значение в точке a ({valueA})");
        }
        else if (valueA < valueB)
        {
            Console.WriteLine($"Наибольшее значение в точке b ({valueB})");
        }
        else
        {
            Console.WriteLine($"Значения одинаковы ({valueA})");
        }
    }
}