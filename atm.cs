using System;
public class ATMService
{
    static void Main(string[] args)
    {
        int amount=1000;
        int num=123;
        int deposit,withdraw,choice,pin;
        Console.WriteLine("Welcome TO ATM Service");
        Console.WriteLine("Enter your pin: ");
        pin=Convert.ToInt32(Console.ReadLine());
        if(pin==num)
        {
            do{
            Console.WriteLine("1.CHECK BALANCE");
            Console.WriteLine("2.CASH DEPOSIT");
            Console.WriteLine("3.CASH WITHDRAW");
            Console.WriteLine("4.QUIT");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Enter your choice: ");
            
            choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("Your balance is "+amount);
                break;

                case 2: 
                Console.WriteLine("Enter deposit:");
                deposit=int.Parse(Console.ReadLine());
                amount=amount+deposit;
                Console.WriteLine("Amount Successfully Deposited");
        
                break;

                case 3:
                Console.WriteLine("Enter the amount to withdraw");
                withdraw=int.Parse(Console.ReadLine());
                amount=amount-withdraw;
                Console.WriteLine("Amount Withdraw Successful");
                break;

                case 4:
                Console.WriteLine("Thank you");
                break;
                

            }
            }while(choice!=4);
        }

    }
}