using System;
using System.Collections.Generic;

namespace ListMemoryDem2
{
    class Program
    {
        static void Modify(List<string> mylist)
        {
            mylist.Add("Frank");
        }

        static void TestInt(int n)
        {
            n++;
            Console.WriteLine(n);
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Fred");
            names.Add("Sally");

            Modify(names);

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            int x = 10;
            TestInt(x);
            Console.WriteLine(x);
        }

        
    }
}
