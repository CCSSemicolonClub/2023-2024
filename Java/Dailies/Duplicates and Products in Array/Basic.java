import java.util.Arrays;

public class Basic {
    public static void main(String[] args) {
        // Input array
        int[] array = { 4, 2, 5, 2, 3, 4, 1, 6, 5 };

        // Call the function to remove duplicates
        int[] uniqueArray = removeDuplicates(array);

        // Display the resulting array
        System.out.println("Array after removing duplicates:");
        for (int num : uniqueArray) {
            System.out.print(num + " ");
        }
    }

    public static int[] removeDuplicates(int[] array) {
        // Create a boolean array to mark visited elements
        boolean[] visited = new boolean[array.length];

        // Initialize all elements as not visited
        for (int i = 0; i < array.length; i++) {
            visited[i] = false;
        }

        // Initialize variables to keep track of unique elements
        int uniqueCount = 0;
        int[] uniqueArray = new int[array.length];

        // Loop through each element in the input array
        for (int i = 0; i < array.length; i++) {
            // If the current element is not visited yet
            if (!visited[i]) {
                // Mark the current element as visited
                visited[i] = true;

                // Add the current element to the unique array
                uniqueArray[uniqueCount++] = array[i];

                // Check for duplicates and mark them as visited
                for (int j = i + 1; j < array.length; j++) {
                    if (array[i] == array[j]) {
                        visited[j] = true;
                    }
                }
            }
        }

        // Create a new array with the correct size containing only unique elements
        int[] resultArray = Arrays.copyOf(uniqueArray, uniqueCount);

        return resultArray;
    }
}
