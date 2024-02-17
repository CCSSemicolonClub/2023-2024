/*
Create a program that will translate number to words (0 - 999)
*/

using System;

class HelloWorld
{
    // Arrays to store words for units and tens places
    static string[] units = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                             "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
    static string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

    // Method to convert a number to words
    static string ConvertNumberToWords(int number)
    {
        // If the number is less than 20, return the corresponding word from the 'units' array
        if (number < 20)
            return units[number];

        // If the number is less than 100, combine the word for tens place and units place
        if (number < 100)
            return tens[number / 10] + ((number % 10 != 0) ? " " + units[number % 10] : "");

        // If the number is less than 1000, combine the word for hundreds place with the words for tens and units places
        return units[number / 100] + " Hundred" + ((number % 100 != 0) ? " and " + ConvertNumberToWords(number % 100) : "");
    }

    // Main method where the program execution starts
    static void Main(string[] args)
    {
        Console.Write("Enter a number (0 - 999): "); // Prompting the user to enter a number
        int number = Convert.ToInt32(Console.ReadLine()); // Reading the input from the user and converting it to an integer

        // Checking if the entered number is within the valid range
        if (number < 0 || number > 999)
        {
            Console.WriteLine("Number out of range."); // Displaying a message if the number is out of range
        }
        else
        {
            // If the number is within the valid range, converting it to words and displaying the result
            Console.WriteLine($"The number {number} in words is: {ConvertNumberToWords(number)}");
        }
    }
}
