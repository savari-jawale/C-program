using System;
public class House
    {
        public string house="3bhk";
    }
public class Rent:House
    {
        public float rent=30000;
    }
public class Deposit:Rent
    {
        public float deposit=10000;
    }
public class Inheritance
    {
    public static void Main(string[] args)
        {
        Deposit d=new Deposit();
        Console.WriteLine("House: "+d.house);
        Console.WriteLine("Rent: "+d.rent);
        Console.WriteLine("Deposit: "+d.deposit);
        }
    }
