using System;
public class AreaOfPolygon
{
    static void Main(string[] args)
    {
        float area,r,l;
        int n;//number of sides
        Console.WriteLine("Enter number of sides: ");
        n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the length of side: ");
        l=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the radius: ");
        r=Convert.ToInt32(Console.ReadLine());
        area=(n/2)*l*r;
        Console.WriteLine("Area is: "+area);
    }
}