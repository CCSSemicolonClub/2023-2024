def factorial_basic(n):  # Define a function named 'factorial_basic' that takes one argument 'n'.
    if n < 0:  # Check if 'n' is a negative number.
        return "Invalid input (negative number)"  # Return an error message if 'n' is negative.
    if n == 0:  # Check if 'n' is equal to zero.
        return 1  # Return 1 if 'n' is zero because the factorial of 0 is defined as 1.
    result = 1  # Initialize a variable 'result' to 1.
    for i in range(1, n + 1):  # Start a for loop that iterates from 1 to 'n' (inclusive).
        result *= i  # Multiply the current value of 'result' by the loop variable 'i'.
    return result  # Return the final value of 'result' as the factorial of 'n'.
  
#Add values below for calling the function
