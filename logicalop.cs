using System;
public class LogicalAND
{
    public static void Main(string[] args)
    {
        int age=21;
        if(age>=18 && age<=70)
        {
            Console.WriteLine("You can vote");
        }
        else{
            Console.WriteLine("You cannot vote");
        }
    }
} 