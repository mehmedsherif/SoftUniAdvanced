﻿namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers=Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if(numbers.Any()==false) 
            {
                return;
            }
            Func<int[], int> CustomMin = (int[] input) =>
            {
                int smallest = input[0];
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < smallest)
                    {
                        smallest = input[i];
                    }
                }
                return smallest;
            };
            Console.WriteLine(CustomMin(numbers));
        }
    }
}
