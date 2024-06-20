using System;
public class ArrayReverse
{
    public static void Main(string[] args)
    {
        int n;
        //const int j=0;
        Console.WriteLine("How many numbers you want to have have in array: ");
        n=Convert.ToInt32(Console.ReadLine());
        int[] array=new int[n];
        for(int i=0;i<n;i++)
        {
            array[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Before Reversing:");
        for(int i=0;i<n;i++)
        {
            Console.WriteLine(array[i]);

        }

        Console.WriteLine("After Reversing:");
        for(int i=n-1;i>=0;i--)
        {
            Console.WriteLine(array[i]);
        }
    }
}