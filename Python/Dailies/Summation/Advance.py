def sum_array(arr, n, accumulator):
    """
    Function to calculate the sum of an array recursively.

    Parameters:
        arr: The array of integers.
        n: The number of elements to consider.
        accumulator: The current sum.
    
    Returns:
        The sum of the array elements.
    """
    # Base case: if no elements to consider, return the sum
    if n == 0:
        return accumulator
    
    # Recursive case: add the current element to the sum
    # and continue with the next element
    return sum_array(arr, n - 1, accumulator + arr[n - 1])


numbers = [1, 2, 3, 4, 5]

# Call the function to calculate the sum
sum_result = sum_array(numbers, len(numbers), 0)

print("Sum of array:", sum_result)

