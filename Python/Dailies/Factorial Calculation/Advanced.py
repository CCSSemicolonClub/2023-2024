"""     
Rules:
You are ALLOWED to use recursion to calculate the factorial.
Implement error handling to handle invalid input (e.g., negative numbers).
"""

def factorial_advanced(n):
    # Step 1: Check if the input (n) is a negative number
    if n < 0:
        return "Invalid input (negative number)"

    # Step 2: Check if the input (n) is 0
    if n == 0:
        return 1

    """ Step 3: If n is neither negative nor 0, calculate the factorial using recursion
    if n is neither negative nor 0, it calculates the factorial using recursion.
    It calls the factorial_advanced function again with the argument n - 1.
    The result is multiplied by n and returned.
    This process continues until it reaches the base case (n equals 0), at which point it starts returning values and unwinding the recursion.
    """
    return n * factorial_advanced(n - 1)
