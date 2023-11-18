using System;

class Program
{
    // Function to calculate factorial using recursion
    static object FactorialAdvanced(int n)
    {
        // Step 1: Check if the input (n) is a negative number
        if (n < 0)
        {
            // Return error message for invalid input
            return "Invalid input (negative number)";
            // Alternatively, you can throw an exception here
            // throw new ArgumentException("Invalid input (negative number)");
        }

        // Step 2: Check if the input (n) is 0
        if (n == 0)
        {
            return 1; // Factorial of 0 is 1
        }

        /* Step 3: If n is neither negative nor 0, calculate the factorial using recursion
        * if n is neither negative nor 0, it calculates the factorial using recursion.
        * It calls the FactorialAdvanced function again with the argument n - 1.
        * The result is multiplied by n and returned.
        * This process continues until it reaches the base case (n equals 0), at which point it starts returning values and unwinding the recursion.
        */
        return n * (int) FactorialAdvanced(n - 1);
    }

    static void Main(string[] args)
    {
        // Test cases
        int input1 = 5;
        int input2 = -3;

        // Retrieve the result from FactorialAdvanced function
        object result1 = FactorialAdvanced(input1);
        object result2 = FactorialAdvanced(input2);

        // Check if the result is an integer or an error message, and then print accordingly
        if (result1 is int)
        {
            Console.WriteLine("Factorial of " + input1 + " is: " + result1);
        }
        else
        {
            Console.WriteLine(result1); // Print error message
        }

        if (result2 is int)
        {
            Console.WriteLine("Factorial of " + input2 + " is: " + result2);
        }
        else
        {
            Console.WriteLine(result2); // Print error message
        }
    }
}

/*
Using object as a return type allows for flexibility in returning different types of values. 
In the context of the provided code, the requirement was to return an error message for invalid inputs 
(such as negative numbers) and not return any number in those cases. Using object as the return type 
accommodates returning different types of values, including integers for valid inputs and strings for error messages.
*/
