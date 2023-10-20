"""
 Rules:
    No conditional statement (if, else, etc.)
    Any programming language is allowed to use
"""

for x in range(1,101):
    print("FizzBuzz" if x % 3 == 0 and x % 5 == 0
    else "Fizz" if x % 3 == 0
    else "Buzz" if x % 5 == 0
    else x)
