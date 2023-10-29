/*
[Basic]
    I. Create a program that selects the smallest and largest elements from the array. Any approach is allowed.
*/

import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        // Create an array of integers
        int[] arr = { 4, 2, 6, 7, 10, 44, 62, 1, 3, 5, -33 };

        // Finding the smallest and largest elements using Arrays, streams, and min/max methods

        // Use the Arrays class to work with arrays. Here, we're converting the array 'arr' into a stream.
        // Think of a stream as a sequence of elements that you can process in a series of steps.

        // Find the smallest element in the 'arr' array using the 'min' method.
        // 'getAsInt' is used to extract the actual integer value

        int smallest = Arrays.stream(arr).min().getAsInt();

        // Then, find the largest element in the 'arr' array using the 'max' method.

        int largest = Arrays.stream(arr).max().getAsInt();

        System.out.println("Smallest: " + smallest + ", Largest: " + largest);
    }
}
