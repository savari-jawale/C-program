using System;
public class MinMax
{
    public static void Main(string[] args)
    {
        int a=10;
        int b=20;
        int min,max;
        if (a>b)
        {
            max=a;
            min=b;
        }
        else{
            max=b;
            min=a;
        }
        Console.WriteLine("Minimum number:{0}",min);
        Console.WriteLine("Maximum number:{0}",max);
    }
}