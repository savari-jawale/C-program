using System;

class CenterAlignedDecreasingStars
{
    static void Main()
    {
        int n = 5; // Number of rows
        for (int i = n; i >= 1; i--)
        {
            // Print leading spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            // Print stars
            for (int k = 1; k <= i; k++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
