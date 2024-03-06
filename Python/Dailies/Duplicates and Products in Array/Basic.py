def remove_duplicates(array):
    # Use a set to store unique elements
    unique_set = set()
    # Iterate through the array and add unique elements to the set
    for num in array:
        unique_set.add(num)
    # Return the set converted back to a list
    return list(unique_set)


# Input array
array = [4, 2, 5, 2, 3, 4, 1, 6, 5]

# Call the function to remove duplicates
unique_array = remove_duplicates(array)

# Display the resulting array
print("Array after removing duplicates:")

for num in unique_array:
    print(num, end=" ")
