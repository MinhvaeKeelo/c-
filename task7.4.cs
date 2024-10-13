class Program
{
    static string R(string a, string b)
    {
        for (int i = a.Length - 1; i >= 0; i--)
        {
            b += a[i];
        }
        return b;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите слово: ");
        string a = Console.ReadLine();
        string rev = "";

        Console.WriteLine($"В обратном порядке: {R(a, rev)}");
    }
}
