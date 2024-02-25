/*
  Make a program that will calculate the summation of an array or list without using built-in mathematical functions or libraries.
 */

public class Basic {
    public static void main(String[] args) {
        // Define an array of numbers
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // Calculate the sum of the array elements
        int sum = calculateSum(numbers);
        
        // Print the result
        System.out.println("The sum of the array elements is: " + sum);
    }

    // Method to calculate the sum of elements in an array
    static int calculateSum(int[] arr) {
        // Initialize sum to 0
        int sum = 0;
        
        // Iterate through each element of the array
        for (int num : arr) {
            // Add the current element to the sum
            sum += num;
        }
        
        // Return the final sum
        return sum;
    }
}
