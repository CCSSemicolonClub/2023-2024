/*
Create a program that calculates the factorial of a given number.
*/
public class Basic {
    // Define a method named 'calculateFactorial' that takes an integer 'n' as input.
    public static int calculateFactorial(int n) {
        // Check if the input 'n' is negative.
        if (n < 0) {
            return -1; // Return -1 to indicate an error for negative input.
        }
        // Check if 'n' is equal to 0, factorial of 0 is 1.
        if (n == 0 || n == 1) {
            return 1; // Return 1 if 'n' is 0 or 1.
        }
        int result = 1; // Initialize a variable 'result' to store the factorial value.
        // Iterate from 1 to 'n' (inclusive) using a for loop.
        for (int i = 2; i <= n; i++) {
            result *= i; // Multiply 'result' by the current value of 'i'.
        }
        return result; // Return the final value of 'result' as the factorial of 'n'.
    }

    // Main method to test the factorial calculation.
    public static void main(String[] args) {
        int number = 5; // Define the number for which factorial needs to be calculated.
        int factorial = calculateFactorial(number); // Calculate factorial using the method.
        // Display the result.
        System.out.println("Factorial of " + number + " is: " + factorial);
    }
}
