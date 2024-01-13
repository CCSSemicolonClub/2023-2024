/*
Rules:                                                              
i.     Swapping method must be void.                                                 
ii.    You are not allowed to print anything inside the swapping method.
iii.   Declaring variables outside the methods is prohibited.                                   
iv.   Swapping two variables should only occur within the swapping method.                                                       
v.    Using any types of parameters is allowed.
vi.   Printing x must display 10, and printing y must display 5.
vii.  You can use any programming language.
*/

using System;

class HelloWorld
{
    static void Main() 
    {
        // Initialize two integer variables, x and y, with values 5 and 10.
        int x = 5;
        int y = 10;
        
        // Call the Swapping method to swap the values of x and y.
        Swapping(ref x, ref y);
        
        // Print the swapped values of x and y.
        Console.WriteLine("x: " + x); // x: 10
        Console.WriteLine("y: " + y); // y: 5
    }
  
    // Swapping method that takes two integer references, x and y.
    // The 'ref' keyword allows us to pass variables by reference,
    // meaning the method can modify the original variables directly.
    static void Swapping(ref int x, ref int y)
    {
        // Create a temporary variable 'holder' to store the value of x.
        int holder = x;
        // Update the value of x with the value of y.
        x = y;
        // Update the value of y with the stored value in 'holder', effectively swapping them.
        y = holder;
    }
}
