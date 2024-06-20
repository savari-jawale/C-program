using System;
 
class Program {
 
    // Main Method
    public static void Main()
    {
 
        // original string
        string str1;
        Console.WriteLine("Enter a string: ");
        str1=Console.ReadLine();
 
        // string converted to lower case
        string lowerstr1 = str1.ToLower();
 
        Console.WriteLine(lowerstr1);
    }
}