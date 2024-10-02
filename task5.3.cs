public class Programm
{
    static double F(double x)
    {
        return Math.Cos(2 * x) + Math.Sin(x - 3);
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
            Console.WriteLine($"Наименьшее значение в точке b ({valueB})");
        }
        else if (valueA < valueB)
        {
            Console.WriteLine($"Наименьшее значение в точке a ({valueA})");
        }
        else
        {
            Console.WriteLine($"Значения одинаковы ({valueA})");
        }
    }
}
