using System;
using System.Collections.Generic;

namespace StudentDabLab
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
                Console.WriteLine("Oops! Please enter something valid.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Database!");
            string[] names = new string[] {"Alexis", "Briauna", "Sierra", "Andrew", "Carlos"};
            string[] hometowns = new string[] {"Chicago", "Detroit", "Atlanta", "Ferndale", "Jersey"};
            string[] food = new string[] {"Salad", "Pizza", "Subs", "Lobster", "Cookies" };

            List<string> students = new List<string>();
            students.Add("Alexis");
            students.Add("Briauna");
            students.Add("Sierra");
            students.Add("Andrew");
            students.Add("Carlos");

            do
            {
                string entry = "";
                int num;
                bool validEntry = false;
                do
                {
                    Console.Write("\nWhich student would you like more info about? Choose a number 1-5:");
                    entry = Console.ReadLine();
                    num = int.Parse(entry);

                    if (num >= 1 && num <= names.Length)
                    {
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number between 1 and {names.Length}.");
                    }
                } while (validEntry == false);

                num--;

                Console.WriteLine(names[num]);

                validEntry = false;
                do
                {
                    Console.Write("\nChoose a category to discover next: [1] for hometown or [2] for favorite food: ");
                    entry = Console.ReadLine().ToLower();
                    int selection = int.Parse(entry);
                    if (selection == 1)
                    {
                        Console.WriteLine($"{names[num]} is from {hometowns[num]}");
                        validEntry = true;
                    }
                    else if (selection == 2)
                    {
                        Console.WriteLine($"{names[num]}'s favorite food is {food[num]} ");
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter [1] or [2].");
                    }
                } while (validEntry == false);

            } while (GoAgain("Would you like to learn about another student? (y/n)"));

        }
    }
}
