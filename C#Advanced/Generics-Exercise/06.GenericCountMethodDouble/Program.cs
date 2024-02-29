using GenericCountMethodDouble;
using System.Globalization;

namespace GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Box<double> myBox = new();
            for (int i = 0; i < lines; i++)
            {
                myBox.Add(double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            }
            double compareWith = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(myBox.Count(compareWith));

        }
    }
}
