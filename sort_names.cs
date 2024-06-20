using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an empty list to store names
        List<string> names = new List<string>();

        // Prompt the user to enter names
        Console.WriteLine("Enter names (one per line). Press Enter twice to finish:");
        
        // Read names from the user until they press Enter twice
        string input;
        while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()))
        {
            names.Add(input);
        }

        // Sort the list of names
        names.Sort();

        // Print the sorted names
        Console.WriteLine("\nSorted names:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
