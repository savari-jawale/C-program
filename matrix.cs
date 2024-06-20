using System;
public class Matrix
{
    public static void Main()
    {
        int rows=2;
        int cols=2;
        int[,] arr1=new int[rows,cols];
        int[,] arr2=new int[rows,cols];
        //Console.WriteLine("Enter number of rows: ");
        //rows=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter number of columns: ");
        //cols=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of array1:");
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                arr1[rows,cols]=int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine("Enter elements of array2:");
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                arr2[rows,cols]=int.Parse(Console.ReadLine());

            }
        }

    }
}