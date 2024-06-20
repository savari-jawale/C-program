using System;
public class JaggedArray
{
    public static void Main(string[] args)
    {
        int[][] jagged_arr = 
        {
            new int[] {1, 2, 3, 4},
            new int[] {11, 34, 67},
            new int[] {89, 23},
            new int[] {0, 45, 78, 53, 99}
        };
        //Display jagged array
        for (int n = 0; n < jagged_arr.Length; n++) {

            // Print the row number
            System.Console.Write("Row({0}): ", n);

            for (int k = 0; k < jagged_arr[n].Length; k++) {

                // Print the elements in the row
                System.Console.Write("{0} ",jagged_arr[n][k]);
            }
            System.Console.WriteLine();
    }
}
}