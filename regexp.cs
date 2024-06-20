using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Hello, my email is abc12@gmail.com and my mobile number is 7655448932.";

        // Regular expression patterns
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        string mobilePattern = @"\b\d{10}\b";

        // Match email addresses
        MatchCollection emailMatches = Regex.Matches(input, emailPattern);
        Console.WriteLine("Email addresses found:");
        foreach (Match match in emailMatches)
        {
            Console.WriteLine(match.Value);
        }
        Console.WriteLine();

        // Match 10-digit mobile numbers
        MatchCollection mobileMatches = Regex.Matches(input, mobilePattern);
        Console.WriteLine("Mobile numbers found:");
        foreach (Match match in mobileMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
