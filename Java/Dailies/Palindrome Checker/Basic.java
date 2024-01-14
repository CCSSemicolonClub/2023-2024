/*
    Write a program that checks if a given string is a palindrome (reads the same forwards and backward).
*/

import java.util.Scanner;

public class Basic {

    public static boolean isPalindrome(String input) {
        // Convert the input string to lowercase for case-insensitive comparison
        input = input.toLowerCase();

        // Initialize two pointers, one at the beginning and one at the end of the string
        int start = 0;
        int end = input.length() - 1;

        // Loop through the string from both ends towards the middle
        while (start < end) {
            // If characters at the start and end pointers don't match, it's not a palindrome
            if (input.charAt(start) != input.charAt(end)) {
                return false;
            }
            // Move the pointers closer to the middle
            start++;
            end--;
        }

        // If the loop completes without finding a mismatch, it's a palindrome
        return true;
    }

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter a string: ");
        String userInput = scanner.nextLine();

        // Check if the input string is a palindrome
        boolean isPal = isPalindrome(userInput);

        // Display the result
        if (isPal) {
            System.out.println("The entered string is a palindrome.");
        } else {
            System.out.println("The entered string is NOT a palindrome.");
        }
    }
}
