namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double coffeeMilliliters = 50;
        private const decimal coffeePrice = 3.5m;
        public double Caffeine { get; set; }

        public Coffee(string name, double caffeine) : base(name, coffeePrice, coffeeMilliliters)
        {
            Caffeine = caffeine;
        }
    }
}