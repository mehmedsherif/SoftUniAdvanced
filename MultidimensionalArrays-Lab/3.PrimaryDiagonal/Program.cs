using System;

namespace PrimaryDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                int[] rowValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            int diagonalSum = 0;
            for (int i = 0; i < N; i++)
            {
                diagonalSum += matrix[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
