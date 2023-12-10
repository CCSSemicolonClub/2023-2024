/*
[Expert]
result_set1 = factorial(100)
result_set2 = factorial(200)
result_set3 = factorial(1000, 1)
result_set4 = factorial(1000, 10**9 + 7)
result_set5 = factorial(1000, 100)
     Rules:
    Implement a program to calculate the factorial WITHOUT using built-in libraries like math.
    Optimize the program to handle large factorials efficiently, taking into account performance and memory constraints.
    Ensure the program works for calculating factorials of very large numbers, e.g., 200.
    Implement the factorial calculation in a way that allows you to calculate the factorial of a number modulo a given integer.
*/

using System;
using System.Numerics;

class HelloWorld
{
  /*
    The question mark ? in BigInteger? mod indicates that the parameter mod is nullable, 
    meaning it can accept a value of BigInteger or be null.

    In C#, adding ? after a type declaration makes that type nullable. 
    This allows a variable of that type to either hold a valid value of the specified type or a null value.

   BigInteger is used to handle arbitrarily large integers that other numeric types cannot accommodate.
   It allows working with very large numbers like factorials of large integers.
     Function to calculate factorial modulo a given integer
  */
    static BigInteger Factorial(int n, BigInteger? mod = null)
    {
        if (n < 0)
        {
            Console.WriteLine("Invalid input (negative number)");
            return -1; // Returning -1 for invalid input
        }

        BigInteger result = 1;

        // Calculate factorial without considering modulo
        for (int i = 1; i <= n; i++)
        {
            result *= i;

            // If modulo is specified, take the remainder at each step
            if (mod != null)
            {
                result %= mod.Value; // Using Value to access the non-nullable BigInteger
            }
        }

        return result;
    }

    static void Main()
    {
        // Test cases for the factorial function
        BigInteger resultSet1 = Factorial(100);
        BigInteger resultSet2 = Factorial(200);
        BigInteger resultSet3 = Factorial(1000, 1);
        BigInteger resultSet4 = Factorial(1000, (BigInteger)(Math.Pow(10, 9)) + 7);
        BigInteger resultSet5 = Factorial(1000, 100);

        // Displaying the results
        Console.WriteLine("Factorial of 100: " + resultSet1);
        Console.WriteLine("Factorial of 200: " + resultSet2);
        Console.WriteLine("Factorial of 1000: " + resultSet3);
        Console.WriteLine("Factorial of 1000 (mod 10^9 + 7): " + resultSet4);
        Console.WriteLine("Factorial of 1000 (mod 100): " + resultSet5);
    }
}
