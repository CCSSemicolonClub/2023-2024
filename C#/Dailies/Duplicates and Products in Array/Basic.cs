using System;

class Program
{
    static void Main(string[] args)
    {
        // Input array
        int[] array = { 4, 2, 5, 2, 3, 4, 1, 6, 5 };

        // Call the function to remove duplicates
        int[] uniqueArray = RemoveDuplicates(array);

        // Display the resulting array
        Console.WriteLine("Array after removing duplicates:");
        
        foreach (int num in uniqueArray)
        {
            Console.Write(num + " ");
        }
        
    }

    static int[] RemoveDuplicates(int[] array)
    {
        
        // Create a boolean array to mark visited elements
        bool[] visited = new bool[array.Length];
        
        // Initialize all elements as not visited
        for (int i = 0; i < array.Length; i++)
        {
            visited[i] = false;
        }

        // Initialize variables to keep track of unique elements
        int uniqueCount = 0;
        int[] uniqueArray = new int[array.Length];

        // Loop through each element in the input array
        for (int i = 0; i < array.Length; i++)
        {
            
            // If the current element is not visited yet
            if (!visited[i])
            {
                // Mark the current element as visited
                visited[i] = true;

                // Add the current element to the unique array
                uniqueArray[uniqueCount++] = array[i];

                // Check for duplicates and mark them as visited
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        visited[j] = true;
                    }
                }
            }
        }

        // Create a new array with the CORRECT SIZE containing only unique elements
        int[] resultArray = new int[uniqueCount];
        Array.Copy(uniqueArray, resultArray, uniqueCount);

        return resultArray;
    }
}
