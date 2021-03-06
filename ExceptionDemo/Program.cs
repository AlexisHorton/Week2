using System;
using System.Collections.Generic;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Fred");
            names.Add("Julia");
            names.Add("Sally");

            //Console.WriteLine("Who's going next? Please enter a number: ");
            //string entry = Console.ReadLine();

            //int num = 0;
            //try
            //{
            //    num = int.Parse(entry);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Hey that isn't a number!!!");
            //}
            //try
            //{
            //    Console.WriteLine(names[num]);
            //}
            //catch (Exception ex)
            //{
            //    //The following commented out lines really aren't very user-friendly.
            //    //Console.WriteLine("An error occurred!!!");
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine($"Please enter a number between 0 and {names.Count -1}");
            //}

            int num = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Write($"Who's going next? Please enter a number between 0 and {names.Count -1}: ");
                string entry = Console.ReadLine();
                //int num;---> was moved up above the while loop to be used later.

                //this takes two parameters; returns a bool= true if it worked, false if not
                if (int.TryParse(entry, out num) == false)
                {
                    Console.WriteLine("That isn't a numer!");
                    Console.WriteLine("Please try again!");
                }
                else
                {
                    // We know it's a valid number, now let's make sure it's inside the correct range. 
                    if (num >= 0 && num < names.Count)
                    {
                        keepGoing = false;
                    }
                    else
                    {
                        Console.WriteLine($"Although that's a number, it's not in the correct range. Please enter between {0} and {names.Count -1}");
                    }
                }
            }
            Console.WriteLine($"Thank you! You entered {num}");
        }
    }
}
