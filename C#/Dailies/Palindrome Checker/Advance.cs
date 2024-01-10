/*
[Advanced]
     Rules:
Handles more complex cases and special characters.
Ignores spaces, punctuation, and letter casing while determining if the string is a palindrome.
*/

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Define the input string to check for palindrome
        string input = "A man, a plan, a canal, Panama!";

        // Check if the input string is a palindrome
        bool isPalindrome = IsPalindrome(input);

        // Display the result based on whether the input string is a palindrome or not
        if (isPalindrome)
        {
            Console.WriteLine("The input string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The input string is not a palindrome.");
        }
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        // Remove spaces, punctuation, and convert all characters to lowercase
        string cleanedString = CleanString(input);

        // Initialize pointers for checking palindrome
        int left = 0;
        int right = cleanedString.Length - 1;

        // Loop until the pointers meet or cross
        while (left < right)
        {
            // Compare characters at the left and right pointers
            if (cleanedString[left] != cleanedString[right])
            {
                // If characters don't match, the string is not a palindrome
                return false;
            }

            // Move the pointers towards the center
            left++;
            right--;
        }

        // If the loop completes without finding any mismatch, the string is a palindrome
        return true;
    }

    // Function to clean the input string by removing spaces, punctuation, and converting to lowercase
    static string CleanString(string input)
    {
        // Remove anything that's not a letter or a number and convert to lowercase
        return Regex.Replace(input, @"[^a-zA-Z0-9]", "").ToLower();
    }
}
