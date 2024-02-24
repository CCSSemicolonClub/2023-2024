/*
 Make a program that will calculate the summation of an array or list without using built-in mathematical functions or libraries.
*/

using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = CalculateSum(numbers);
        Console.WriteLine("The sum of the array elements is: " + sum);
    }

    static int CalculateSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
