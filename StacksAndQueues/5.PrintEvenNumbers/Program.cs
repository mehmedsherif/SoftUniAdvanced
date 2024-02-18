namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> numberQueue = new Queue<int>(numbers);
            List<int> evenNumbers = new List<int>();

            foreach (int num in numberQueue)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            string result = string.Join(", ", evenNumbers);
            Console.WriteLine(result);


        }
    }
}
