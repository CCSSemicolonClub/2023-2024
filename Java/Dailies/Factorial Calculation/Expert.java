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
import java.math.BigInteger;

public class Expert {
    /*
    In Java, to represent nullable types, you can use the class type and allow it to be null.
    Here, BigInteger is used to handle arbitrarily large integers that other numeric types cannot accommodate.
    It allows working with very large numbers like factorials of large integers.
    Function to calculate factorial modulo a given integer
    */

    // Function to calculate factorial modulo a given integer
    static BigInteger factorial(int n, BigInteger mod) {
        if (n < 0) {
            System.out.println("Invalid input (negative number)");
            return BigInteger.valueOf(-1); // Returning -1 for invalid input
        }

        BigInteger result = BigInteger.ONE;

        // Calculate factorial without considering modulo
        for (int i = 1; i <= n; i++) {
            result = result.multiply(BigInteger.valueOf(i));

            // If modulo is specified, take the remainder at each step
            if (mod != null) {
                result = result.remainder(mod); // Using remainder to get the modulo
            }
        }

        return result;
    }

    public static void main(String[] args) {
        // Test cases for the factorial function

        // Calculating factorials
        BigInteger resultSet1 = factorial(100, null);
        BigInteger resultSet2 = factorial(200, null);
        BigInteger resultSet3 = factorial(1000, BigInteger.ONE);
        BigInteger resultSet4 = factorial(1000, BigInteger.TEN.pow(9).add(BigInteger.valueOf(7)));
        BigInteger resultSet5 = factorial(1000, BigInteger.valueOf(100));

        // Displaying the results
        System.out.println("Factorial of 100: " + resultSet1);
        System.out.println("Factorial of 200: " + resultSet2);
        System.out.println("Factorial of 1000: " + resultSet3);
        System.out.println("Factorial of 1000 (mod 10^9 + 7): " + resultSet4);
        System.out.println("Factorial of 1000 (mod 100): " + resultSet5);
    }
}
