class Program
{
    static double Average(int[] a, double sum)
    {
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }

        return sum / a.Length;
    }
    static void Main(string[] args)
    {
        Console.Write("Укажите размер массива: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[a];

        for (int i = 0; i < a; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Среднее арифметическое в массиве: {Average(array, 0)}");
    }
}
