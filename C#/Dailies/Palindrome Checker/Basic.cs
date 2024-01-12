/*
    Write a program that checks if a given string is a palindrome (reads the same forwards and backward).
*/

using System;

class Palindrome {
    static bool IsPalindrome(string input)
    {
        // Convert the input string to lowercase for case-insensitive comparison
        input = input.ToLower();

        // Initialize two pointers, one at the beginning and one at the end of the string
        int start = 0;
        int end = input.Length - 1;

        // Loop through the string from both ends towards the middle
        while (start < end)
        {
            // If characters at the start and end pointers don't match, it's not a palindrome
            if (input[start] != input[end])
            {
                return false;
            }
            // Move the pointers closer to the middle
            start++;
            end--;
        }

        // If the loop completes without finding a mismatch, it's a palindrome
        return true;
    }
    
    static void Main() {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        // Check if the input string is a palindrome
        bool isPal = IsPalindrome(userInput);

        // Display the result
        if (isPal)
        {
            Console.WriteLine("The entered string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The entered string is NOT a palindrome.");
        }
        
    }
}
