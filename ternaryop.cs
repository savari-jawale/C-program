using System;
namespace Conditional {
    
class GFG {
    
    // Main Function
    static void Main(string[] args)
    {
            int x = 10, y = 20, result;
            
            // To find which value is greater
            // Using Conditional Operator
            result = x > y ? x : y; 
            
            // To display the result 
            Console.WriteLine("Result: " + result);
            
            // To find which value is greater
            // Using Conditional Operator
            result = x < y ? x : y; 
            
            // To display the result
            Console.WriteLine("Result: " + result);
    }
}
}