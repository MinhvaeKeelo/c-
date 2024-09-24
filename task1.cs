using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        
        string[] input = Console.ReadLine().Split(' ');
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

       
        var result = new List<int>();

        
        for (int i = 1; i < n; i++)
        {
            if (array[i] > array[i - 1])
            {
                result.Add(array[i]);
            }
        }

      
        Console.WriteLine(string.Join(" ", result));
    }
}