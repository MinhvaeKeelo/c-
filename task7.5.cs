class Program
{
    static string R(string a, string b)
    {
        for (int i = a.Length - 1; i >= 0; i--)
        {
            b += a[i];
        }

        if (a == b)
            return "Слово является полиндромом";
        else
            return "Слово не является полиндромом";
    }
    static void Main(string[] args)
    {
        Console.Write("Введите слово: ");
        string a = Console.ReadLine();
        string rev = "";

        Console.WriteLine(R(a, rev));
    }
}