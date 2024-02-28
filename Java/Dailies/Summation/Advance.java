/*
Optimize it (without using any loops)
*/

public class Advance {
    public static void main(String[] args) {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = sumArray(numbers, numbers.length, 0);

        System.out.println("Sum of array: " + sum);
    }

    // Function to calculate the sum of an array recursively
    // Parameters:
    //   arr: The array of integers
    //   n: The number of elements to consider
    //   accumulator: The current sum
    // Returns:
    //   The sum of the array elements
    static int sumArray(int[] arr, int n, int accumulator) {
        // Base case: if no elements to consider, return the sum
        if (n == 0)
            return accumulator;

        // Recursive case: add the current element to the sum
        // and continue with the next element
        return sumArray(arr, n - 1, accumulator + arr[n - 1]);
    }
}
