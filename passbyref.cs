using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling ModifyValue method: " + number);

        // Call the method and pass 'number' by reference
        ModifyValue(ref number);

        // 'number' is modified after the method call
        Console.WriteLine("After calling ModifyValue method: " + number);
    }

    // Method that modifies its parameter (passed by reference)
    static void ModifyValue(ref int num)
    {
        num = 20; // Modifying the parameter 'num' directly affects the original variable
        Console.WriteLine("Inside ModifyValue method: " + num);
    }
}
