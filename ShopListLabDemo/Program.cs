using System;
using System.Collections.Generic;

namespace ShopListLabDemo
{
    class Program
    {
        //As a method:
        static void PrintMenu(Dictionary<string,decimal> menu)
        {
            Console.WriteLine("Welcome to the Store");
            foreach (var pair in menu)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }
        }
        static void PrintCart(List<string> cart, Dictionary<string,decimal>menu)
        {
            decimal sum = 0.00m;
            Console.WriteLine("Here are your items: ");
            foreach (string item in cart) 
            {
                Console.WriteLine($"{item} price {menu[item]}");
                sum += menu[item];
            }
            Console.WriteLine($"Your total is {sum}");
        }

        static void Main(string[] args)
        {

            /* Our data model:
             * 
             * 1. A dictionary mapping an item name (string) to a price (decimal)
             * 2. A list containing items (string) the shopper is going to purchase, i.e. the cart or basket
             * 
             */

            Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
            List<string> cart = new List<string>();

            // Add some items to the menu

            menu["Milk"] = 2.00m;
            menu["Bread"] = 3.00m;
            menu["Coffee"] = 7.00m;
            menu["Banana"] = 0.50m;
            menu["Apple"] = 0.75m;

            PrintMenu(menu);

            // Let's add one item to the cart
            cart.Add("Milk");
            cart.Add("Apple");
            cart.Add("Apple");

            PrintCart(cart, menu);
        }
    }
}
