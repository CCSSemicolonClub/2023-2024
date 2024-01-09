/*
Rules:
You are ALLOWED to use recursion to calculate the factorial.
Implement error handling to handle invalid input (e.g., negative numbers).
*/

public class Advance {
    // Function to calculate factorial using recursion
    static Object calculateFactorial(int n) {
        // Step 1: Check if the input (n) is a negative number
        if (n < 0) {
            // Return error message for invalid input
            return "Invalid input (negative number)";
            // Alternatively, you can throw an exception here
            // throw new IllegalArgumentException("Invalid input (negative number)");
        }

        // Step 2: Check if the input (n) is 0
        if (n == 0) {
            return 1; // Factorial of 0 is 1
        }

        /* Step 3: If n is neither negative nor 0, calculate the factorial using recursion
         * It calculates the factorial using recursion.
         * It calls the calculateFactorial function again with the argument n - 1.
         * The result is multiplied by n and returned.
         * This process continues until it reaches the base case (n equals 0), at which point it starts returning values and unwinding the recursion.
         */
        return n * (int) calculateFactorial(n - 1);
    }

    public static void main(String[] args) {
        // Test cases
        int input1 = 5;
        int input2 = -3;

        // Retrieve the result from calculateFactorial function
        Object result1 = calculateFactorial(input1);
        Object result2 = calculateFactorial(input2);

        // Check if the result is an integer or an error message, and then print accordingly
        if (result1 instanceof Integer) {
            System.out.println("Factorial of " + input1 + " is: " + result1);
        } else {
            System.out.println(result1); // Print error message
        }

        if (result2 instanceof Integer) {
            System.out.println("Factorial of " + input2 + " is: " + result2);
        } else {
            System.out.println(result2); // Print error message
        }
    }
}
