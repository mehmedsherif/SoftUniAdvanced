using System;

class Program
{
    static void Main()
    {
        int[] numbers=Console.ReadLine()
            .Split(' ',StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Array.Sort(numbers, CompareNumbers);

        PrintArray(numbers);
    }

    static int CompareNumbers(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
        {
            return -1; 
        }
        else if (x % 2 != 0 && y % 2 == 0)
        {
            return 1; 
        }
        else
        {
            return x.CompareTo(y); 
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
