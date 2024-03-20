using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Define the array of integers
        int[] numbers = { 5, 2, 7, 4, 3, 6};

        // Sort the array in ascending order
        Array.Sort(numbers);

        // Get the length of the array
        int n = numbers.Length;

        // Calculate the maximum product of two distinct integers
        int maxProduct = Math.Max(numbers[0] * numbers[1], numbers[n - 1] * numbers[n - 2]);

        // Output the maximum product
        Console.WriteLine($"The maximum product of two distinct integers from the array is: {maxProduct}");

        // Output the two integers that yield the maximum product
        Console.WriteLine($"These two integers are: {numbers[n - 1]} and {numbers[n - 2]}");
    }
}
