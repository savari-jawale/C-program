using System;
public class AreaOfRectangle
{
    static void Main(string[] args)
    {
    float area,l,b;
    Console.WriteLine("Enter length: ");
    l=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter breadth: ");
    b=Convert.ToInt32(Console.ReadLine());
    area=l*b;
    Console.WriteLine("Area: "+area);
    }
}