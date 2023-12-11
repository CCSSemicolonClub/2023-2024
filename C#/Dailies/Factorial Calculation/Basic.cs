/*
Create a program that calculates the factorial of a given number.
*/

using System;

class Basic
{
    // Define a function named 'FactorialBasic' that takes one argument 'n'.
    /*
      Handling Different Return Types: Using object allows the method to return different types of data.
      In this specific case, the function returns an integer result in case the input n is a non-negative number 
      or a string message for an invalid (negative) input. By using object, it can return either an integer or a string.
      
      Error Handling: Returning an object type allows for the possibility of returning an error message (a string) 
      when the input is negative. This way, the function can communicate different types of information back to the caller.
      
      Dynamic Typing and Flexibility: The object type in C# is the base type for all other types. 
      By using object as the return type, the method gains flexibility in returning different types of values, 
      making it versatile for various scenarios.
    */
    static object FactorialBasic(int n)
    {
        if (n < 0)
        {
            return "Invalid input (negative number)"; // Return an error message if 'n' is negative.
        }
        if (n == 0)
        {
            return 1; // Return 1 if 'n' is zero because the factorial of 0 is defined as 1.
        }
        int result = 1; // Initialize a variable 'result' to 1.
        for (int i = 1; i <= n; i++) // Start a for loop that iterates from 1 to 'n' (inclusive).
        {
            result *= i; // Multiply the current value of 'result' by the loop variable 'i'.
        }
        return result; // Return the final value of 'result' as the factorial of 'n'.
    }

    static void Main(string[] args)
    {
        // Add values below for calling the function and displaying the result
        int valueToCalculateFactorial = 5; // Change the value to calculate different factorials

        // Call the function and display the result
        Console.WriteLine($"Factorial of {valueToCalculateFactorial} is: {FactorialBasic(valueToCalculateFactorial)}");
    }
}
