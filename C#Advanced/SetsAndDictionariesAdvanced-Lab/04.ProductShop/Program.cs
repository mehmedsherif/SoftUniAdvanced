﻿namespace _04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string, double>> stores=new Dictionary<string,Dictionary<string,double>>();
            string command=Console.ReadLine();

            while(command != "Revision")
            {
                string[] input = command.Split(", ");
                string store = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if(!stores.ContainsKey(store))
                {
                    stores.Add(store, new Dictionary<string,double>());
                }
                if (!stores[store].ContainsKey(product)) 
                {
                    stores[store].Add(product, 0);
                }
                stores[store][product]=price;

                command=Console.ReadLine();
            }
            stores=stores.OrderBy(s=>s.Key).ToDictionary(s=>s.Key, s=>s.Value);
            foreach(var (store,products) in stores)
            {
                Console.WriteLine($"{store}->");

                foreach (var (product,price) in products)
                {
                    Console.WriteLine($"Product: {product}, Price: {price} ");
                }
            }
        }
    }
}
