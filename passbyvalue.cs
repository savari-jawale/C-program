using System;

class Program
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling ModifyValue method: " + number);

        // Call the method and pass 'number' by value
        ModifyValue(number);

        // 'number' remains unchanged after the method call
        Console.WriteLine("After calling ModifyValue method: " + number);
    }

    // Method that modifies its parameter (passed by value)
    static void ModifyValue(int num)
    {
        num = 20; // Modifying the parameter 'num' inside the method
        Console.WriteLine("Inside ModifyValue method: " + num);
    }
}
