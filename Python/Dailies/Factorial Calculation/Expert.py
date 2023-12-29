"""
result_set1 = factorial(100)
result_set2 = factorial(200)
result_set3 = factorial(1000, 1)
result_set4 = factorial(1000, 10**9 + 7)
result_set5 = factorial(1000, 100)
     Rules:
Implement a program to calculate the factorial WITHOUT using built-in libraries like math.
Optimize the program to handle large factorials efficiently, taking into account performance and memory constraints.
Ensure the program works for calculating factorials of very large numbers, e.g., 200.
Implement the factorial calculation in a way that allows you to calculate the factorial of a number modulo a given integer.
"""

# Define a function called factorial that takes two arguments: 'n' (number to find factorial of) 
# and 'mod' (optional modulo value)
# the return hint annotation (int, str) is used after the -> symbol 
# in the function definition to indicate on what possible types of return values 
# that the factorial function can produce
def factorial(n: int, mod: int = None) -> (int, str):
    # Check if 'n' is an integer and 'mod' is an integer, float, or None; 
    # raise a TypeError if they're not
    if not isinstance(n, int) or not isinstance(mod, (int, type(None))): 
        raise TypeError(f"\nn = {n}, mod = {mod} : Input numbers only\n")
    
    # Check if the number is negative; return a message if it is
    if n < 0:
        return "Invalid input (negative number)"
    
    # Initialize the result variable to 1
    result = 1
    
    # Iterate through numbers from 1 to 'n' (inclusive)
    for i in range(1, n + 1):
        # Multiply 'result' by 'i' (factorial calculation)
        result *= i
        
        # If 'mod' is provided, calculate the result modulo 'mod'
        if mod is not None:
            result %= mod
    
    # Return the final calculated result
    return result

# Test cases for all levels and demonstrating error handling
try:
    # Calculate factorials and handle the exception if TypeError is raised
    result_set1 = factorial(100)
    result_set2 = factorial(200)
    result_set3 = factorial(1000, 1)
    result_set4 = factorial(1000, 10**9 + 7)
    result_set5 = factorial(1000, 100)
    
    # Attempt to calculate factorials with invalid inputs to demonstrate error handling
    # Eemodify the first attempt correctly to check the second attempt
    result = factorial("a", 1)  # This line will raise a TypeError due to insufficient arguments
    result1 = factorial(1, "a")  # This line will raise a TypeError due to an invalid type for 'mod'
    
except TypeError as e:
    print(e)  # Print the error message if a TypeError occurs

# Displaying the results of factorial calculations
print("Expert - Factorial of 100:", result_set1)
print("Expert - Factorial of 200:", result_set2)
print("Expert - Factorial of 1000:", result_set3)
print("Expert - Factorial of 1000 (mod 10^9 + 7):", result_set4)
print("Expert - Factorial of 1000 (mod 100):", result_set5)
