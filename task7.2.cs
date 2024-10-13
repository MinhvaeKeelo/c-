class Program
{
    static int Num(int a)
    {
        if (a % 2 == 0)
            return 1;
        else return 0;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (Num(a) == 1)
            Console.WriteLine("Число четное");
        else
            Console.WriteLine("Число нечетное");
    }
}