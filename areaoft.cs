using System;
public class AreaOfTriangle
{
    static void Main(string[] args)
    {
        float area;
        int h,b;
        Console.WriteLine("Enter height: ");
        h=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter breadth: ");
        b=Convert.ToInt32(Console.ReadLine());
        area=0.5f*b*h;
        Console.WriteLine("Area:"+area);
    }
} 