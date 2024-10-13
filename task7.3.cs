class Program
{
    static int F(int a, int f)
    {
        for (int i = 1; i < a + 1; i++)
        {
            f *= i;
        }
        return f;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Факториал числа: {F(a, 1)}");
    }
}