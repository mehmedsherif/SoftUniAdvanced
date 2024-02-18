namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", ArrayCreator.Create(5, "Pesho")));  
        }
    }
}
