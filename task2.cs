using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        
        string[] input = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(input, int.Parse);

        
        HashSet<int> uniqueElements = new HashSet<int>();

        
        foreach (int number in array)
        {
            uniqueElements.Add(number);
        }

       
        Console.WriteLine(uniqueElements.Count);
    }
}