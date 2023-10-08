public class Main {
    public static void main(String[] args) {
        // Declare and initialize two integer variables, x and y.
        int x = 5;
        int y = 10;

        // Create an array 'arr' to hold the values of x and y.
        int[] arr = { x, y };

        // Call the swap method to swap the values of x and y.
        swap(arr);

        // Print the swapped values of x and y.
        System.out.println("x: " + arr[0]); // x: 10
        System.out.println("y: " + arr[1]); // y: 5

        // In Java, we achieve the swap by modifying the array elements within the swap method.
        // The changes made to the array inside the method are reflected in the original array.
    }

    // Swapping method that takes an integer array as a parameter.
    static void swap(int[] arr) {
        // Swap the values of x and y without using a temporary variable.
        int holder = arr[0];
        arr[0] = arr[1];
        arr[1] = holder;

        // Inside the swap method, we directly modify the elements of the 'arr' array.
        // The changes made here affect the original array that was passed as an argument.
    }
}

// We can't directly pass primitive types like int by reference as you can in C#. However, 
// we can achieve a similar result by using an array or an object to encapsulate the values we want to swap, 
// or modify the original array.
