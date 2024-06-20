using System;

namespace TypeCastingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing: Converting a value type (int) to an object type
            int value = 123;
            object boxedValue = value; // Boxing
            Console.WriteLine($"Boxed value: {boxedValue}");

            // Unboxing: Converting the object back to the value type with typecasting
            int unboxedValue = (int)boxedValue; // Unboxing with typecasting
            Console.WriteLine($"Unboxed value: {unboxedValue}");

            // Verify that the values are the same
            if (value == unboxedValue)
            {
                Console.WriteLine("Boxing and unboxing with typecasting are successful and values are equal.");
            }
            else
            {
                Console.WriteLine("Boxing and unboxing with typecasting failed or values are not equal.");
            }
        }
    }
}