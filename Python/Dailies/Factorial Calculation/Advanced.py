"""     
Rules:
You are ALLOWED to use recursion to calculate the factorial.
Implement error handling to handle invalid input (e.g., negative numbers).
"""

def factorial_advanced(n: int) -> [int, str]:
    # Step 1: Check if the input (n) is an integer or a float
    if not isinstance(n, int): 
        raise TypeError(f"\nn = {n} : Input numbers only\n")

    # Step 2: Check if the input (n) is a negative number
    if n < 0:
        return "Invalid input (negative number)"
        
    # Step 3: Check if the input (n) is 0
    if n == 0:
        return 1

    """ Step 4: Calculate the factorial using recursion
    If n is a non-negative integer, it calculates the factorial using recursion.
    It calls the factorial_advanced function again with the argument n - 1.
    The result is multiplied by n and returned.
    This process continues until it reaches the base case (n equals 0), at which point it starts returning values and unwinding the recursion.
    """
    return n * factorial_advanced(n - 1)
    
try:
    print(factorial_advanced(1))
    print(factorial_advanced("a")) # Comment this line to check if the input is negative
    print(factorial_advanced(-1))
except TypeError as e:
    print(e)

