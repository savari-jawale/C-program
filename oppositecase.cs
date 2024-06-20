using System;
using System.Text;

class GFG
{
    // Method to convert characters 
    // of a string to opposite case
    static void ConvertOpposite(StringBuilder str)
    {
        int length = str.Length;
             
        // Conversion according to ASCII values
        for (int i = 0; i < length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                // Convert lowercase to uppercase
                str[i] = (char)(str[i] - 32);
            }
            else if (str[i] >= 'A' && str[i] <= 'Z')
            {
                // Convert uppercase to lowercase
                str[i] = (char)(str[i] + 32);
            }
        }
    }
     
    // Driver code
    public static void Main() 
    {
        // Prompt the user for input
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        // Convert the input string to StringBuilder
        StringBuilder str = new StringBuilder(input);
        
        // Calling the method to convert characters
        ConvertOpposite(str);
        
        // Output the modified string
        Console.WriteLine("String after case conversion:");
        Console.WriteLine(str);
    }
}
