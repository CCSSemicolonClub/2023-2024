import re

# Function to check if a string is a palindrome
def is_palindrome_string(input_string):
    # Clean the input string by removing spaces, punctuation, and converting to lowercase
    cleaned_string = clean_string(input_string)

    # Check if the cleaned string is equal to its reverse
    return cleaned_string == cleaned_string[::-1]

# Function to clean the input string by removing spaces, punctuation, and converting to lowercase
def clean_string(input_string):
    # Remove anything that's not a letter or a number and convert to lowercase
    return re.sub(r'[^a-zA-Z0-9]', '', input_string.lower())


input_string = "A man, a plan, a canal, Panama!"

# Check if the input string is a palindrome
is_palindrome = is_palindrome_string(input_string)

# Display the result based on whether the input string is a palindrome or not
if is_palindrome:
    print("The input string is a palindrome.")
else:
    print("The input string is not a palindrome.")
    
