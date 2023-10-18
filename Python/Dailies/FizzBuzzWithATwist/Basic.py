# Iterate through numbers from 1 to 100
for x in range(1, 101):
    # Initialize an empty string to store the result
    res = ""

    # Check if the current number is divisible by 3
    if x % 3 == 0:
        # If true, add "Fizz" to the result
        res += "Fizz"

    # Check if the current number is divisible by 5
    if x % 5 == 0:
        # If true, add "Buzz" to the result
        res += "Buzz"
        
    # Ternary : If it's not empty, print the result (either "Fizz," "Buzz," or "FizzBuzz")
    # else, the original number
    print(res if res else x)
