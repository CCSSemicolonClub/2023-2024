'''
Create a program that will translate number to words (0 - 999)
'''

# Function to convert a number to words
def convert_number_to_words(number):
    # Arrays to store words for units and tens places
    units = ["Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
             "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"]
    tens = ["", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"]

    # If the number is less than 20, return the corresponding word from the 'units' array
    if number < 20:
        return units[number]

    # If the number is less than 100, combine the word for tens place and units place
    if number < 100:
        return tens[number // 10] + (" " + units[number % 10] if number % 10 != 0 else "")

    # If the number is less than 1000, combine the word for hundreds place with the words for tens and units places
    return units[number // 100] + " Hundred" + (" and " + convert_number_to_words(number % 100) if number % 100 != 0 else "")



number = int(input("Enter a number (0 - 999): "))  # Prompting the user to enter a number

# Checking if the entered number is within the valid range
if number < 0 or number > 999:
    print("Number out of range.")  # Displaying a message if the number is out of range
else:
    # If the number is within the valid range, converting it to words and displaying the result
    print("The number", number, "in words is:", convert_number_to_words(number))


