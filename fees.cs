using System;

namespace FeeReceiptGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collect student information
            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter PRN Number: ");
            string prnNumber = Console.ReadLine();

            Console.Write("Enter Semester: ");
            string semester = Console.ReadLine();

            // Collect fee details
            double examFee = GetFeeFromUser("Exam Fee");
            double libraryFee = GetFeeFromUser("Library Fee");
            double hostelFee = GetFeeFromUser("Hostel Fee");
            double tnpFee = GetFeeFromUser("TnP Fee");

            // Calculate total fee
            double totalFee = examFee + libraryFee + hostelFee + tnpFee;

            // Generate the fee receipt
            Console.WriteLine("\n------------------- Fee Receipt -------------------");
            Console.WriteLine("Student Name :" + studentName);
            Console.WriteLine("Department   :" + department);
            Console.WriteLine("PRN Number   :" + prnNumber);
            Console.WriteLine("Semester     :" + semester);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Exam Fee     :" + examFee+:N2);
            Console.WriteLine("Library Fee  :" + libraryFee+:N2);
            Console.WriteLine("Hostel Fee   :" + hostelFee+:N2);
            Console.WriteLine("TnP Fee      :" + tnpFee+:N2);
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Total Fee    :" + totalFee+:N2);
            Console.WriteLine("---------------------------------------------------");
        }

        static double GetFeeFromUser(string feeType)
        {
            double fee;
            while (true)
            {
                Console.Write("Enter "+ feeType +":" );
                if (double.TryParse(Console.ReadLine(), out fee) && fee >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number.");
                }
            }
            return fee;
        }
    }
}
