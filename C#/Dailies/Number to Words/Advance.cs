using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

class Program
{
    // Define a dictionary to map numbers to their word representations.
    // especially those which can be words template or no pattern for other example fifty, it is not five(ty)
    // eighteen instead of eight(teen)
    static Dictionary<int, string> numberToWord = new Dictionary<int, string>()
        {
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},
            {10, "Ten"},
            {11, "Eleven"},
            {12, "Twelve"},
            {13, "Thirteen"},
            {15, "Fifteen"},
            {18, "Eighteen"},
            {20, "Twenty "},
            {30, "Thirty "},
            {40, "Forty "},
            {50, "Fifty "},
            {80, "Eighty "}
        };
    
    // Define a dictionary to specify the position names for groups of digits
    // add larger group here example {8, "Sextillion"}.. etc for handling larger numbers
    static Dictionary<int, string> groupWords = new Dictionary<int, string>()
        {
            {2, "Thousand"},
            {3, "Million"},
            {4, "Billion"},
            {5, "Trillion"},
            {6, "Quadrillion"},
            {7, "Quintillion"}
        };
        
    // Constants to improve code readability    
    private const int HUNDRED = 100;
    private const string HUNDRED_TEXT = " Hundred ";
    private const string TEEN_TEXT = "teen";
    private const string TY_TEXT = "ty";
    private const int ZERO = 0;
    private const int TWENTY = 20;
    private const int TEN = 10;
    
    public static void Main(string[] args)
    {
        string formattedNumber;
        while (true)
        {
            try
            {
                Console.Write("Input number: ");
                BigInteger num = BigInteger.Parse(Console.ReadLine());
                // Format the number with commas (e.g., 1,000,000)
                formattedNumber = num.ToString("#,###");
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        string words = ConvertNumToWords(formattedNumber);
        Console.WriteLine($"In words: {words}");
    }

    private static string ConvertNumToWords(string formattedString)
    {
        // Split the formatted number into groups (e.g., thousands, millions).
        string[] splitGroups = formattedString.Split(',');
        int groupPosition = splitGroups.Length;
        StringBuilder res = new StringBuilder();

        foreach (string group in splitGroups)
        {
            int value = int.Parse(group);
            if (value == 0)
            {
                groupPosition--;
                continue; // Skip if the group is zero.
            }
                res.Append(extractValues(value, groupPosition) + " ");
                groupPosition--;

        }

        return res.ToString().Trim();
    }

    // Helper function to get a value from a dictionary or use a default value if not found
    private static string getValue(Dictionary<int, string> dictionary, int key, string defaultValue)
    {
        return dictionary.ContainsKey(key) ? dictionary[key] : defaultValue;
    }
    
    private static string extractValues(int value, int position)
    {
        StringBuilder res = new StringBuilder();
    
        // get the value of hundreds
        int hundreds = value / HUNDRED;
        
        // get the value of tens or the remainder of hundreds
        int remainder = value % HUNDRED;
        
        // if not 0 or if the number is 100 and up, get the number and add "Hundred"
        if (hundreds > ZERO)
        {
            res.Append(getValue(numberToWord, hundreds, "") + HUNDRED_TEXT);
        }
        
        // if there is a remainder
        if (remainder > ZERO)
        {
            // check if it is already in wordlist
            if (numberToWord.ContainsKey(remainder))
            {
                res.Append(getValue(numberToWord, remainder, ""));
            }
            // if not..
            else
            {
                // if the remainder or tens or the remainder from hundreds is less than 20
                // it contains "teen"
                if(remainder < TWENTY){
                    res.Append(getValue(numberToWord, remainder - TEN, "") + TEEN_TEXT);
                }
                // if higher than 20, get the number of tens and ones
                else{
                    int tens = remainder / TEN;
                    int ones = remainder % TEN;
                    
                    // set the default value to numbers multiple by 10, eg. sixty, seventy
                    // followed by ones number if there is any
                    String def = getValue(numberToWord, tens, "") + TY_TEXT + " ";
                    
                    res.Append(getValue(numberToWord, tens * TEN, def));
                    res.Append(getValue(numberToWord, ones, ""));
                }
            }
        }
        // return the words for each specific group
        return res + " " + getValue(groupWords, position, "");
    }

}
