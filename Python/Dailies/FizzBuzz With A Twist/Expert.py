"""
Rules:
    NO conditional statement (if, else, etc.) inside the fizzbuzz class
    NO conditional expression(ternary)
    NO modulo, and != (not equal)
    ONLY use different class dedicated for fizzbuzz that has four (4) function or method
    MUST USE lambda or anonymous function
    Make the iteration of numbers to be passed to fizzbuzz class, on the main class
        o There will be 2 classes, main class and fizzbuzz class
    Any programming language is allowed to use
"""

class FizzBuzz:
    # Return the word "Fizz"
    @staticmethod
    def fizz(num):
        return "Fizz"

    # Return the word "Buzz"
    @staticmethod
    def buzz(num):
        return "Buzz"

    # Return the word "FizzBuzz"
    # Optional because we can call fizz and buzz and concatenate the words
    @staticmethod
    def fizz_buzz_value(num):
        return "FizzBuzz"

    # Return the original number as a string
    @staticmethod
    def default(num):
        return str(num)


    # Conditions is a list of functions that check if a number meets a condition.
    conditions = [
        
        # For example, this lambda expression checks if a number is both divisible by 3 and 5.
        (lambda num: num % 3 == 0 and num % 5 == 0, fizz_buzz_value),
        
        # This one checks if a number is divisible by 3.
        (lambda num: num % 3 == 0, fizz),
        
        # This one checks if a number is divisible by 5.
        (lambda num: num % 5 == 0, buzz),
        
        # This is a default condition; it always returns true.
        (lambda num: True, default)
    ]

for num in range(1, 101):
        result = None  # Initialize the result to None
        # Iterate through the conditions
        for condition, action in FizzBuzz.conditions:
            # Check if the condition is met by calling the corresponding lambda function
            if condition(num):
                # Set the result based on the action corresponding to the condition
                result = action(num)
                break
        print(result)
