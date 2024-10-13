class Program
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма чисел: {Sum(a, b)}");
    }
}