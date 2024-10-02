public class Program
{
    public static int MinDigit(int x)
    {
        int maxDigit = 9;

        while (x > 0)
        {
            int digit = x % 10;
            if (digit < maxDigit)
            {
                maxDigit = digit;
            }
            x /= 10;
        }
        return maxDigit;
    }

    public static void Main()
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int z = MinDigit(a) + MinDigit(b);

        Console.WriteLine("Значение z: " + z);
    }
}