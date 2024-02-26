"""
Make a program that will calculate the summation of an array or list without using built-in mathematical functions or libraries.
"""

# Define a function to calculate the sum of elements in a list
def calculate_sum(arr):
    # Initialize sum to 0
    sum = 0
    
    # Iterate through each element of the list
    for num in arr:
        # Add the current element to the sum
        sum += num
    
    # Return the final sum
    return sum

# Define a list of numbers
numbers = [1, 2, 3, 4, 5]

# Call the function to calculate the sum of the list elements
sum_result = calculate_sum(numbers)

# Print the result
print("The sum of the list elements is:", sum_result)
