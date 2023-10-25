/*
    Rules:
      NO conditional statement (if, else, etc.) inside the fizzbuzz class
      NO conditional expression(ternary)
      NO modulo, and != (not equal)
      ONLY use different class dedicated for fizzbuzz that has four (4) function or method
      MUST USE lambda or anonymous function
      Make the iteration of numbers to be passed to fizzbuzz class, on the main class
            o There will be 2 classes, main class and fizzbuzz class
      Any programming language is allowed to use
*/

using System;

class FizzBuzz
{
    // return the word Fizz
    public static string Fizz(int num) { return "Fizz"; }

    // return the word Buzz
    public static string Buzz(int num) { return "Buzz"; }
    
    // return the word FizzBuzz
    //optional because we can call Fizz and Buzz and concatenate the words
    public static string FizzBuzzValue(int num) { return "FizzBuzz"; }

    // return the original
    public static string Default(int num) { return num.ToString(); }

    // Here's what Func does:
    // - It's like a container for a piece of code (a function).
    // - We use Func to store and manage different functions.
    // - Conditions is an array of functions that check if a number meets a condition.
    // - Actions is an array of functions that decide what to do based on a condition.
    // - Lambda expressions are like tiny, inline functions we define on the spot.
    //   They make it easy to describe conditions and actions without writing full functions.
    public static Func<int, bool>[] Conditions = new Func<int, bool>[]
    {
        // For example, this lambda expression checks if a number is both divisible by 3 and 5.
        (num) => (num / 3) * 3 == num && (num / 5) * 5 == num,
        // This one checks if a number is divisible by 3.
        (num) => (num / 3) * 3 == num,
        // And this checks if a number is divisible by 5.
        (num) => (num / 5) * 5 == num,
        // This is a default condition; it always returns true.
        (num) => true
    };

    // Actions decide what to do based on conditions.
    // For example, FizzBuzzValue returns "FizzBuzz" if a condition is met.
    public static Func<int, string>[] Actions = new Func<int, string>[]
    {
        // this commented statement is a lambda expression that will call Fizz and Buzz function 
        // without creating new function for FizzBuzz
        // (num) => Fizz(num) + Buzz(num), or
        FizzBuzzValue,
        Fizz,
        Buzz,
        Default
    };
}

class Program
{
    static void Main()
    {
        // iterate numbers from 1 to 100
        for (int num = 1; num <= 100; num++)
        {
            // initial value of result to empty string or null
            string result = null;
            // iterate the Conditions (Func) array
            for (int i = 0; i < FizzBuzz.Conditions.Length; i++)
            {
                // passing the num value to Conditions array and check where will it become true
                if (FizzBuzz.Conditions[i](num))
                {
                    // base on what "index" the Conditions return true,
                    // the "result" variable name will have the value base on same "index" in Actions
                    
                    // example, if the number become true in divisible by 3 and 5
                    // index 0 in Conditions will return true
                    // and by executing thie line below, it will get the value of Actions[0], which is FizzBuzz
                    result = FizzBuzz.Actions[i](num);
                    break;
                }
            }
            Console.Write(result);
            Console.WriteLine();
        }
    }
}


