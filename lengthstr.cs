using System;

// Define the Exercise2 class
public class Exercise2
{
    // Main method - entry point of the program
    public static void Main()
    {
        string str; // Declare a string variable
        int l = 0; // Initialize a variable to store the length of the string

        // Prompt the user to find the length of a string
        Console.Write("\n\nFind the length of a string:\n");
        Console.Write("---------------------------------\n");

        // Request user input for a string
        Console.Write("Input the string: ");
        str = Console.ReadLine(); // Read the user input

        // Loop through each character in the string to calculate its length
        foreach (char chr in str)
        {
            l += 1; // Increment the length counter for each character encountered
        }

        // Display the length of the entered string
        Console.Write("Length of the string is: {0}\n\n", l);
    }
}