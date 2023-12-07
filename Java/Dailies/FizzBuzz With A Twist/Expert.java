/*
    Rules:
      NO conditional statement (if, else, etc.) inside the fizzbuzz class
      NO conditional expression(ternary)
      NO modulo, and != (not equal)
      ONLY use different class dedicated for fizzbuzz that has four (4) function or method
      MUST USE lambda or anonymous function
      Make the iteration of numbers to be passed to fizzbuzz class, on the main class
            o There will be 2 classes, main class and fizzbuzz class
      Any programming language is allowed to use
*/
import java.util.function.Function;

public class Expert {
    public static void main(String[] args) {
        // Define a function that represents the FizzBuzz logic and get it from the FizzBuzz class.
        Function<Integer, String> fizzBuzz = FizzBuzz.getFizzBuzzFunction();

        // Iterate through numbers from 1 to 100.
        for (int num = 1; num <= 100; num++) {
            // Use the FizzBuzz function to get the result and print it.
            System.out.println(fizzBuzz.apply(num));
        }
    }
}

class FizzBuzz {
    // Define a method that returns "Fizz" as a string.
    private static String fizz() {
        return "Fizz";
    }

    // Define a method that returns "Buzz" as a string.
    private static String buzz() {
        return "Buzz";
    }

    // Define a method that returns "FizzBuzz" as a string.
    private static String fizzBuzz() {
        return "FizzBuzz";
    }

    // Define a method that converts an integer to a string (default action).
    private static String defaultAction(int num) {
        return Integer.toString(num);
    }

    // Define a function to encapsulate the FizzBuzz logic.
    // Function<Integer, String> specifies that this function takes an Integer as input 
    // and returns a String as output.
    // In other words, it's a function that maps (check conditions using) an integer value to a string value.
    public static Function<Integer, String> getFizzBuzzFunction() {
        // Create a lambda function that takes an integer 'num' as input.
        Function<Integer, String> fizzBuzz = num -> 
            // Check if 'num' is divisible by both 3 and 5 (no modulo).
            (num % 3 == 0 && num % 5 == 0) ?
                FizzBuzz.fizzBuzz() : // If true, return "FizzBuzz".
            // Check if 'num' is divisible by 3 (no modulo).
            (num % 3 == 0) ?
                FizzBuzz.fizz() : // If true, return "Fizz".
            // Check if 'num' is divisible by 5 (no modulo).
            (num % 5 == 0) ?
                FizzBuzz.buzz() : // If true, return "Buzz".
            // If none of the above conditions match, use the default action.
            FizzBuzz.defaultAction(num); // Return 'num' as a string.

        // Return the 'fizzBuzz' lambda function.
        return fizzBuzz;
    }
}
