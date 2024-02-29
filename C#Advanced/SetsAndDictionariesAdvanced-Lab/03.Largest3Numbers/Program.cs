namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> largestThreeNumbers=Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList();
            Console.WriteLine(String.Join(" ", largestThreeNumbers));
        }
    }
}
