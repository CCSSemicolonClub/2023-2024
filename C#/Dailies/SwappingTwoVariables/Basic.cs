/*
Required variables for Basic and Advance Categories:

-   int x = 5;
-   int y = 10;

[Basic]
           1. Create a program that swaps the values of two integers. 
           Using any approach is allowed, as long as when you print x, 
           it will display 10, and for y, it will display 5.
*/

using System;

class SwapTwoVariables {
    public static void Main(string[] args) {
        int a = 5;
        int b = 10;
        
        // Swap the variables by make a temporary value handler "temp"
        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
