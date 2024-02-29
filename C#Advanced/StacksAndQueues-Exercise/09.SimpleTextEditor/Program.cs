namespace _09.SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> undoStack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "1":
                        string someString = input[1];
                        undoStack.Push(text);
                        text += someString;
                        break;

                    case "2":
                        int count = int.Parse(input[1]);
                        undoStack.Push(text);
                        text = text.Substring(0, Math.Max(0, text.Length - count));
                        break;

                    case "3":
                        int index = int.Parse(input[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;

                    case "4":
                        if (undoStack.Count > 0)
                        {
                            text = undoStack.Pop();
                        }
                        break;
                }
            }
        }
    }
}
