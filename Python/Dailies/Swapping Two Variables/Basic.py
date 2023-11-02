"""
Required variables for Basic and Advance Categories:

-   int x = 5;
-   int y = 10;

[Basic]
           1. Create a program that swaps the values of two integers. 
           Using any approach is allowed, as long as when you print x, 
           it will display 10, and for y, it will display 5.
"""

x = 5
y = 10

# Swap the values of x and y using tuple unpacking
x, y = y, x

# Print the result after swapping
print(f"After swapping: x = {x}, y = {y}")
