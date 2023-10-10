using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 4, 2, 6, 7, 10, 44, 62, 1, 3, 5, -33 };

        // Finding the smallest and largest elements using Minimum and Maximum methods of array
        int smallest = arr.Min();
        int largest = arr.Max();

        Console.WriteLine($"Smallest: {smallest}, Largest: {largest}");
    }
}
