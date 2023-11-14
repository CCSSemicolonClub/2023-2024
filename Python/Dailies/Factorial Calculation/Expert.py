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
def factorial(n, mod=None):
    if n < 0:
        return "Invalid input (negative number)"
    if n == 0:
        return 1
    result = 1
    for i in range(1, n + 1):
        result *= i
        if mod is not None:
            result %= mod
    return result

# Test cases for all levels
result_set1 = factorial(100)
result_set2 = factorial(200)
result_set3 = factorial(1000, 1)
result_set4 = factorial(1000, 10**9 + 7)
result_set5 = factorial(1000, 100)

print("Expert - Factorial of 100:", result_set1)
print("Expert - Factorial of 200:", result_set2)
print("Expert - Factorial of 1000:", result_set3)
print("Expert - Factorial of 1000 (mod 10^9 + 7):", result_set4)
print("Expert - Factorial of 1000 (mod 100):", result_set5)

