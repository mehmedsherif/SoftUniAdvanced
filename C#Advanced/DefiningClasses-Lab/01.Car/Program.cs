namespace CarManufacturer;

public class StartUp
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Make = "Mazda";
        car.Model = "6";
        car.Year = 2003;

        Console.WriteLine($"Make: {car.Make}, Model: {car.Model}, Year: {car.Year}");
    }
}
