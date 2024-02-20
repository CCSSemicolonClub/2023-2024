import java.math.BigInteger;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Advance {

    // Define a map to store the word representations of numbers.
    // It maps integers to their corresponding words.
    static Map<Integer, String> numberToWord = new HashMap<>();
    
    // Define a map to specify the position names for groups of digits.
    // It maps the position to its corresponding word.
    static Map<Integer, String> groupWords = new HashMap<>();
    
    // Constants to improve code readability
    private static final int HUNDRED = 100;
    private static final String HUNDRED_TEXT = " Hundred ";
    private static final String TEEN_TEXT = "teen";
    private static final String TY_TEXT = "ty";
    private static final int ZERO = 0;
    private static final int TWENTY = 20;
    private static final int TEN = 10;
    
    public static void main(String[] args) {
        // Initialize the numberToWord map with integer to word mappings.
        initializeNumberToWordMap();
        
        // Initialize the groupWords map with position names for groups of digits.
        initializeGroupWordsMap();
        
        String formattedNumber;
        Scanner scanner = new Scanner(System.in);
        
        while (true) {
            try {
                System.out.print("Input number: ");
                BigInteger num = new BigInteger(scanner.nextLine());
                // Format the number with commas (e.g., 1,000,000)
                formattedNumber = String.format("%,d", num);
                break;
            } catch (Exception e) {
                System.out.println("Error: " + e);
            }
        }
        
        String words = convertNumToWords(formattedNumber);
        System.out.println("In words: " + words);
        scanner.close();
    }
    
    // Initialize the numberToWord map with integer to word mappings.
    private static void initializeNumberToWordMap() {
        numberToWord.put(1, "One");
        numberToWord.put(2, "Two");
        numberToWord.put(3, "Three");
        numberToWord.put(4, "Four");
        numberToWord.put(5, "Five");
        numberToWord.put(6, "Six");
        numberToWord.put(7, "Seven");
        numberToWord.put(8, "Eight");
        numberToWord.put(9, "Nine");
        numberToWord.put(10, "Ten");
        numberToWord.put(11, "Eleven");
        numberToWord.put(12, "Twelve");
        numberToWord.put(13, "Thirteen");
        numberToWord.put(15, "Fifteen");
        numberToWord.put(18, "Eighteen");
        numberToWord.put(20, "Twenty ");
        numberToWord.put(30, "Thirty ");
        numberToWord.put(40, "Forty ");
        numberToWord.put(50, "Fifty ");
        numberToWord.put(80, "Eighty ");
    }
    
    // Initialize the groupWords map with position names for groups of digits.
    private static void initializeGroupWordsMap() {
        groupWords.put(2, "Thousand");
        groupWords.put(3, "Million");
        groupWords.put(4, "Billion");
        groupWords.put(5, "Trillion");
        groupWords.put(6, "Quadrillion");
        groupWords.put(7, "Quintillion");
    }

    // Convert the formatted number string into words.
    private static String convertNumToWords(String formattedString) {
        // Split the formatted number into groups (e.g., thousands, millions).
        String[] splitGroups = formattedString.split(",");
        int groupPosition = splitGroups.length;
        StringBuilder res = new StringBuilder();

        for (String group : splitGroups) {
            int value = Integer.parseInt(group);
            if (value == 0) {
                groupPosition--;
                continue; // Skip if the group is zero.
            }
            res.append(extractValues(value, groupPosition)).append(" ");
            groupPosition--;
        }

        return res.toString().trim();
    }

    // Helper function to get a value from a map or use a default value if not found.
    private static String getValue(Map<Integer, String> map, int key, String defaultValue) {
        return map.containsKey(key) ? map.get(key) : defaultValue;
    }

    // Extract the words for the given value and position.
    private static String extractValues(int value, int position) {
        StringBuilder res = new StringBuilder();

        // Get the value of hundreds.
        int hundreds = value / HUNDRED;

        // Get the value of tens or the remainder of hundreds.
        int remainder = value % HUNDRED;

        // If not 0 or if the number is 100 and up, get the number and add "Hundred".
        if (hundreds > ZERO) {
            res.append(getValue(numberToWord, hundreds, "")).append(HUNDRED_TEXT);
        }

        // If there is a remainder.
        if (remainder > ZERO) {
            // Check if it is already in the word list.
            if (numberToWord.containsKey(remainder)) {
                res.append(getValue(numberToWord, remainder, ""));
            } else {
                // If the remainder or tens or the remainder from hundreds is less than 20,
                // it contains "teen".
                if (remainder < TWENTY) {
                    res.append(getValue(numberToWord, remainder - TEN, "")).append(TEEN_TEXT);
                } else {
                    // If higher than 20, get the number of tens and ones.
                    int tens = remainder / TEN;
                    int ones = remainder % TEN;

                    // Set the default value to numbers multiple by 10, e.g., sixty, seventy,
                    // followed by ones number if there is any.
                    String def = getValue(numberToWord, tens, "") + TY_TEXT + " ";
                    res.append(getValue(numberToWord, tens * TEN, def));
                    res.append(getValue(numberToWord, ones, ""));
                }
            }
        }
        // Return the words for each specific group.
        return res + " " + getValue(groupWords, position, "");
    }
}
