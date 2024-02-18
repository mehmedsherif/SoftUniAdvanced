namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines=int.Parse(Console.ReadLine());
            HashSet<string> uniqueUserNames = new();

            for (int i = 0; i < lines; i++) 
            {
                uniqueUserNames.Add(Console.ReadLine());
            }
            foreach(string userName  in uniqueUserNames) 
            {
                Console.WriteLine(userName);
            }
        }
    }
}
