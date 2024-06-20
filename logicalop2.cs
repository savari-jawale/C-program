using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = true, y = false;
            bool a = true, result;
            // AND operator
            result = (x <= y) && (x > 10);
            Console.WriteLine("AND Operator: " + result);
            // OR operator
            result = (x >= y) || (x < 5);
            Console.WriteLine("OR Operator: " + result);
            //NOT operator
            result = !x;
            Console.WriteLine("NOT Operator: " + result);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}