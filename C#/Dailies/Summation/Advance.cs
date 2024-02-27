/*
Optimize it (without using any loops)
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = SumArray(numbers, numbers.Length, 0);

        Console.WriteLine("Sum of array: " + sum);
    }

    // Function to calculate the sum of an array
    // Parameters:
    //   arr: The array of integers
    //   n: The number of elements to consider
    //   accumulator: The current sum
    // Returns:
    //   The sum of the array elements
    static int SumArray(int[] arr, int n, int accumulator)
    {
        // Base case: if no elements to consider, return the sum
        if (n == 0)
            return accumulator;

        // Recursive case: add the current element to the sum
        // and continue with the next element
        return SumArray(arr, n - 1, accumulator + arr[n - 1]);
    }
}
