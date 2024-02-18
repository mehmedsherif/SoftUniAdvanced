namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input=Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string[] secondLine = Console.ReadLine().Split(' ');
            Stack<int> integerStack = new Stack<int>();
            foreach(var s  in secondLine) 
            {
                int temp=int.Parse(s);
                integerStack.Push(temp);
            }
            for (int i = 0; i < input[1]; i++)
            {
                integerStack.Pop();
            }
            if (integerStack.Contains(input[2]))
            {
                Console.WriteLine("true");
            }
            else if(integerStack.Any())
            {
                Console.WriteLine(integerStack.Min());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
