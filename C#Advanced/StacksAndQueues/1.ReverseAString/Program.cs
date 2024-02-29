namespace _1.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> text= new Stack<char>();

            foreach(var item in input)
            {
                text.Push(item);
            }
            while(text.Count != 0)
            {
                Console.Write(text.Pop());
            }
        }
    }
}
