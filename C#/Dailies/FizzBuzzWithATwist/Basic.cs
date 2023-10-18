using System;
class HelloWorld {
    static void Main() {
        // Iterate through numbers from 1 to 100
        for(int x=1; x <= 100; x++){
            // Initialize an empty string to store the result
            string res = "";
            
            // Check if the current number is divisible by 3
            if(x % 3 == 0){
                // If true, add "Fizz" to the result
                res += "Fizz";
            }
            
            // Check if the current number is divisible by 5
            if(x % 5 == 0){
                // If true, add "Buzz" to the result
                res += "Buzz";
            }
            
            // Ternary : If it's not empty, print the result (either "Fizz," "Buzz," or "FizzBuzz")
            // else, the original number
            Console.WriteLine(
                !string.IsNullOrEmpty(res) ? res : 
                x.ToString());
        }
    }
}
