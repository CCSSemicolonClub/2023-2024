/*
[Advanced]
     Rules:
Handles more complex cases and special characters.
Ignores spaces, punctuation, and letter casing while determining if the string is a palindrome.
*/

import java.util.regex.Pattern;

public class Advance {
    public static void main(String[] args) {
        // Define the input string to check for palindrome
        String input = "racecar";

        // Check if the input string is a palindrome
        boolean isPalindrome = isPalindrome(input);

        // Display the result based on whether the input string is a palindrome or not
        if (isPalindrome) {
            System.out.println("The input string is a palindrome.");
        } else {
            System.out.println("The input string is not a palindrome.");
        }
    }

    // Function to check if a string is a palindrome
    static boolean isPalindrome(String input) {
        // Remove spaces, punctuation, and convert all characters to lowercase
        String cleanedString = cleanString(input);

        // Initialize pointers for checking palindrome
        int left = 0;
        int right = cleanedString.length() - 1;

        // Loop until the pointers meet or cross
        while (left < right) {
            // Compare characters at the left and right pointers
            if (cleanedString.charAt(left) != cleanedString.charAt(right)) {
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
    static String cleanString(String input) {
        // Remove anything that's not a letter or a number and convert to lowercase
        return input.replaceAll("[^a-zA-Z0-9]", "").toLowerCase();
    }
}
