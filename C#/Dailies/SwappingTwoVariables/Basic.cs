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
