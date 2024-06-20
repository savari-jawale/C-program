using System;  
  public class Swap  
   {  
     public static void Main(string[] args)  
      {  
       int  a=5;
       int b=10;            
       Console.WriteLine("Before swap a= "+a+" b= "+b);    
       a=a*b; //a=50 (5*10)      
       b=a/b; //b=5 (50/10)      
       a=a/b; //a=10 (50/5)    
       Console.Write("After swap a= "+a+" b= "+b);       
     }  
  } 