using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        List<List<double>> numbers = new List<List<double>>();
        double sum = 0;
        int count = rows * cols;

       
        for (int i = 0; i < rows; i++)
        {
            numbers.Add(new List<double>()); 

            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                double value = double.Parse(Console.ReadLine());

                numbers[i].Add(value); 
                sum += value;
            }
        }

        // Display elements
        Console.WriteLine("\nList elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(numbers[i][j] + "\t");
            }
            Console.WriteLine();
        }

              double average = sum / count;

        Console.WriteLine("\nSum of all elements = " + sum);
        Console.WriteLine("Average of all elements = " + average);

        Console.ReadKey();
    }
}

