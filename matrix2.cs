using System;

class Program
{
    static void Main()
    {
        // Define the size of the matrices
        const int rows = 2;
        const int cols = 2;

        // Initialize two matrices
        int[,] matrixA = new int[rows, cols];
        int[,] matrixB = new int[rows, cols];

        // Input elements for the first matrix
        Console.WriteLine("Enter elements of the first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [{i},{j}]: ");
                matrixA[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Input elements for the second matrix
        Console.WriteLine("Enter elements of the second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [{i},{j}]: ");
                matrixB[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Perform operations and print results
        Console.WriteLine("Addition Result:");
        PerformAndPrintOperation(matrixA, matrixB, (a, b) => a + b);

        Console.WriteLine("Subtraction Result:");
        PerformAndPrintOperation(matrixA, matrixB, (a, b) => a - b);

        Console.WriteLine("Multiplication (element-wise) Result:");
        PerformAndPrintOperation(matrixA, matrixB, (a, b) => a * b);

        Console.WriteLine("Division (element-wise) Result:");
        PerformAndPrintOperation(matrixA, matrixB, (a, b) => b != 0 ? a / b : 0);

        Console.WriteLine("Modulus (element-wise) Result:");
        PerformAndPrintOperation(matrixA, matrixB, (a, b) => b != 0 ? a % b : 0);
    }

    static void PerformAndPrintOperation(int[,] matrixA, int[,] matrixB, Func<int, int, int> operation)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(operation(matrixA[i, j], matrixB[i, j]) + "\t");
            }
            Console.WriteLine();
        }
    }
}