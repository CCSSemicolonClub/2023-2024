/*
Required variables for Basic and Advance Categories:

-   int x = 5;
-   int y = 10;

[Basic]
           1. Create a program that swaps the values of two integers. 
           Using any approach is allowed, as long as when you print x, 
           it will display 10, and for y, it will display 5.
*/

public class Basic {
    public static void main(String[] args) {
        int a = 5;
        int b = 10;

        System.out.println("Before swapping: a = " + a + ", b = " + b);

        // Swap the variables using temporary value handler
        int temp = a;
        a = b;
        b = temp;

        System.out.println("After swapping: a = " + a + ", b = " + b);
    }
}
