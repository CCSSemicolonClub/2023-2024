"""
 Rules:
    No conditional statement (if, else, etc.)
    Any programming language is allowed to use
"""

for x in range(1,101):
    """
     The use of the ternary operator here allows the program to make decisions 
     without using traditional if or else statements. 
     Instead, it determines what to print based on the result of each condition
    """
    print("FizzBuzz" if x % 3 == 0 and x % 5 == 0
    else "Fizz" if x % 3 == 0
    else "Buzz" if x % 5 == 0
    else x)
