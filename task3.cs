using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        
        string[] input = Console.ReadLine().Split();
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        
        if (n > 1) 
        {
            int lastElement = array[n - 1];

            for (int i = n - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastElement;
        }

      
        Console.WriteLine(string.Join(" ", array));
    }
}
