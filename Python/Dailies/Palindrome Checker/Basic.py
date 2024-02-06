"""
    Write a program that checks if a given string is a palindrome (reads the same forwards and backward).
"""

def is_palindrome(input_str):
    # Convert the input string to lowercase and remove spaces for simplicity
    cleaned_str = ''.join(input_str.lower().split())

    # Check if the cleaned string is equal to its reverse
    return cleaned_str == cleaned_str[::-1]

user_input = input("Enter a string: ")

# Check if the input string is a palindrome
if is_palindrome(user_input):
    print("The entered string is a palindrome.")
else:
    print("The entered string is NOT a palindrome.")
