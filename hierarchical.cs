using System;
public class Subject
{
    public string sub1="C#";
    public string sub2="Java";
    public void fun1()
    {
        
        //Console.WriteLine("Subject: "+sub1+"\t"+sub2);
    }
}
public class Class1:Subject
{
    public string class1="B.Tech(A)";
    public void fun2()
    {
        Console.WriteLine(class1+"\t"+sub1);
        //Console.WriteLine("Subject:"+sub1);
    }
}
public class Class2:Subject
{
    public string class2="B.Tech(B)";
    public void fun3()
    {
        Console.WriteLine(class2+"\t"+sub2);
        
    }
}
public class Inheritance
{
    public static void Main(string[] args)
    {
    Class1 c1=new Class1();
    Class2 c2=new Class2();
    Console.WriteLine("Class\t\tSubject");
    c1.fun1();
    c1.fun2();
    c2.fun3();
    }
}