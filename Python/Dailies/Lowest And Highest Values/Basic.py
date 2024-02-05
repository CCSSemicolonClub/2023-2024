arr = [4, 2, 6, 7, 10, 44, 62, 1, 3, 5, -33]

# Initialize variables to store the smallest and largest elements
smallest = arr[0]
largest = arr[0]

# Loop through the array to find the smallest and largest elements
for num in arr:
    # If the current number is smaller than current value of "smallest"
    # replace the value
    if num < smallest:
        smallest = num
        
    # If the current number is larger than current value of "largest"
    # replace the value
    if num > largest:
        largest = num

# Print the smallest and largest elements
print("Smallest element:", smallest)
print("Largest element:", largest)


