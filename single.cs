using System;
public class Employee
{
    public float salary=40000;
}
public class Developer:Employee
{
    public float bonus=2000;
}
public class Inheritance
{
public static void Main(string[] args)
{
    Developer d= new Developer();
    Console.WriteLine("Salary: "+d.salary);
    Console.WriteLine("Salary with bonus: "+d.bonus);
}
}