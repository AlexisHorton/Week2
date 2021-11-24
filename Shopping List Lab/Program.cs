using System;
using System.Collections.Generic;

namespace Shopping_List_Lab
{
    class Program
    {
        static bool GoAgain(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string entry = Console.ReadLine();
                if (entry.ToLower() == "n")
                {
                    return false;
                }
                if (entry.ToLower() == "y")
                {
                    return true;
                }
                Console.WriteLine("I'm sorry, I don't know what that means.");
            }
        }

        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            Dictionary<string, decimal> cost = new Dictionary<string, decimal>();
            cost["mango"] = 0.79m;
            cost["carrot"] = 1.59m;
            cost["apple"] = 0.89m;
            cost["banana"] = 0.59m;
            cost["bread"] = 1.29m;
            cost["eggs"] = 2.29m;
            cost["water"] = 3.29m;
            cost["coffee"] = 5.69m;

            do
            {

                Console.WriteLine("Hello there! Welcome to the Market!");

                foreach (var pair in cost)
                {
                    Console.WriteLine($"{pair.Key,-6}{pair.Value,12}");
                }

                bool validEntry = false;
                do
                {
                    Console.Write("\nPick your grocery item: ");
                    string entry = Console.ReadLine().ToLower();
                    if (cost.ContainsKey(entry))
                    {
                        Console.WriteLine($"\nYou selected {entry} which costs ${cost[entry]}.");
                        Console.WriteLine($"Adding {entry} to cart at ${cost[entry]}");
                        shoppingList.Add(entry);
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Whoops, that item is MIA! Please try again.");
                    }
                } while (validEntry == false);

            } while (GoAgain("Would you like to add an item to your order? (y/n)"));

            Console.WriteLine("Thanks for your order!");
            Console.WriteLine("Here's what you got: ");

            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
                //for (int i=0; i<shoppingList.Count; i++)
                //{
                //    Console.WriteLine($"The total cost of your items is ${i}.");
                //}
            }
        }
    }
}
