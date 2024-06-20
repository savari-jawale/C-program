using System;
namespace Assignment {
    
class Program {
    
    // Main Function
    static void Main(string[] args)
    {
        
            
            int x = 15; 
            
            // x = x + 10
            x += 10; 
            Console.WriteLine("Add Assignment Operator: " + x);
            
             // initialize variable x again
            x = 20;
            
            // x = x - 5
            x -= 5; 
            Console.WriteLine("Subtract Assignment Operator: " + x);
            
            // initialize variable x again
            x = 15;
            
            // x = x * 5
            x *= 5; 
            Console.WriteLine("Multiply Assignment Operator: " + x);
            
            // initialize variable x again
            x = 25;
            
            // x = x / 5
            x /= 5; 
            Console.WriteLine("Division Assignment Operator: " + x);
            
            // initialize variable x again
            x = 25;
            
            // x = x % 5
            x %= 5; 
            Console.WriteLine("Modulo Assignment Operator: " + x);
            
            // initialize variable x again
            x = 8;
            
            // x = x << 2
            x <<= 2; 
            Console.WriteLine("Left Shift Assignment Operator: " + x);
            
            // initialize variable x again
            x = 8;
            
            // x = x >> 2
            x >>= 2; 
            Console.WriteLine("Right Shift Assignment Operator: " + x);
            
            // initialize variable x again
            x = 12;
            
            // x = x >> 4
            x &= 4; 
            Console.WriteLine("Bitwise AND Assignment Operator: " + x);
            
            // initialize variable x again
            x = 12;
            
            // x = x >> 4
            x ^= 4; 
            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);
            
             // initialize variable x again
            x = 12;
            
            // x = x >> 4
            x |= 4; 
            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);

            //initialize value of x
            x = 5;
            int new_item_quantity;
            // Quantity of a new item added to the cart
            new_item_quantity = 3;

            // Update the number of items in the cart by adding the quantity of the new item
            x += new_item_quantity; //x= x + new_item_quantity

            Console.WriteLine("Total items in the cart:"+x);
        
    }
}
}

