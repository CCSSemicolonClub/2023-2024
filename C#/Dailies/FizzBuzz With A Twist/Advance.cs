/*
 Rules:
    No conditional statement (if, else, etc.)
    Any programming language is allowed to use
*/

using System;

class HelloWorld 
{
    static void Main() 
    {
     
        for(int x = 1; x <= 100; x++)
        {
          /*
            The use of the ternary operator here allows the program to make decisions 
            without using traditional if or else statements. 
            Instead, it determines what to print based on the result of each condition
          */
            Console.WriteLine(x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : 
            x % 3 == 0 ? "Fizz" :
            x % 5 == 0 ? "Buzz" :
            $"{x}");
        }
     
    }
}
