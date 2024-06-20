using System;

// Define the namespace
namespace CalculatorNamespace
{
    // Define a class within the namespace
    public class Calculator
    {
        // Method for addition
        public double Add(double a, double b)
        {
            return a + b;
        }

        // Method for subtraction
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Method for multiplication
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        // Method for division
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}

namespace SimpleCalculatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class from the CalculatorNamespace namespace
            CalculatorNamespace.Calculator calculator = new CalculatorNamespace.Calculator();

            Console.WriteLine("Simple Calculator:");
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();

            double result = 0;
            bool validOperation = true;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Subtract(num1, num2);
                        break;
                    case "*":
                        result = calculator.Multiply(num1, num2);
                        break;
                    case "/":
                        result = calculator.Divide(num1, num2);
                        break;
                    default:
                        validOperation = false;
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine("Result: "+result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input format.");
            }
        }
    }
}
