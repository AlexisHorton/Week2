using System;

namespace LabPractice_StudentDatabase
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
            string[] names = new string[] { "Jeff", "Antonio", "Hanna", "Tommy" };
            string[] hometowns = new string[] { "GR", "Det", "Seat", "Rale" };
            string[] food = new string[] { "Pizza", "FB", "Shrimp", "ChickDum" };

            do
            {
                string entry = "";
                int num = 0;
                bool validEntry = false;
                do
                {

                    Console.Write("Which student would you like information on?");
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

                //      We'll let the user start with 1 as the first, rather than the actual index 0 as the first

                num--;

                Console.WriteLine(names[num]);

                validEntry = false;
                do
                {
                    Console.Write("Which category? Please enter hometown or favorite food: ");
                    entry = Console.ReadLine().ToLower();
                    if (entry == "hometown")
                    {
                        Console.WriteLine($"{names[num]} is from {hometowns[num]}");
                        validEntry = true;
                    }
                    else if (entry == "favorite food")
                    {
                        Console.WriteLine($"{names[num]}'s favorite food is {food[num]} ");
                        validEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter hometown or favorite food.");
                    }
                } while (validEntry == false);

            } while (GoAgain("Would you like to learn about another student? (y/n)"));
        }
    }
}
