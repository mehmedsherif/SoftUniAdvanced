using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> amountOfMoney = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> prices = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int foodCount = 0;

            while (amountOfMoney.Count > 0 && prices.Count > 0)
            {
                int money = amountOfMoney.Peek();
                int price = prices.Peek();

                if (money == price)
                {
                    foodCount++;
                    continue;
                }
                else if (money > price)
                {
                    foodCount++;
                    int difference = money - price;
                    
                    if (amountOfMoney.Any())
                    {
                        money=amountOfMoney.Pop();
                        int next=money+difference;
                        amountOfMoney.Push(next);
                    }
                }
                else if(money>price)
                {
                    continue;
                }
            }

            if (foodCount >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodCount} foods.");
            }
            else if (foodCount >= 2)
            {
                Console.WriteLine($"Henry ate: {foodCount} foods.");
            }
            else if (foodCount == 1)
            {
                Console.WriteLine($"Henry ate: {foodCount} food.");
            }
            else
            {
                Console.WriteLine($"Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
