public class Program
{
    static int F(int a)
    {
        if (a < 10)
        {
            return a;
        }
        else
        {
            a /= 10;
            return a % 10;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int z = F(a) + F(b) - F(c);

        Console.WriteLine($"Значение z: {z}");
    }
}