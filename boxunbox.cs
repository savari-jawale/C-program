using System;

class Program
{
    static void Main()
    {
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 'savari';         // Boxed value
        string unboxedValue = (string)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        
    }
}