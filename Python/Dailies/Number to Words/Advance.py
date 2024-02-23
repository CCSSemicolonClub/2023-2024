# Define a map to store the word representations of numbers.
# It maps integers to their corresponding words.
number_to_word = {
    1: "One", 2: "Two", 3: "Three", 4: "Four", 5: "Five", 6: "Six",
    7: "Seven", 8: "Eight", 9: "Nine", 10: "Ten", 11: "Eleven",
    12: "Twelve", 13: "Thirteen", 15: "Fifteen", 18: "Eighteen",
    20: "Twenty", 30: "Thirty", 40: "Forty", 50: "Fifty",
    80: "Eighty"
}

# Define a map to specify the position names for groups of digits.
# It maps the position to its corresponding word.
group_words = {
    2: "Thousand", 3: "Million", 4: "Billion", 5: "Trillion",
    6: "Quadrillion", 7: "Quintillion"
}

# Constants to improve code readability
HUNDRED = 100
HUNDRED_TEXT = " Hundred"
TEEN_TEXT = "teen"
TY_TEXT = "ty"
ZERO = 0
TWENTY = 20
TEN = 10

def convert_num_to_words(formatted_string):
    # Split the formatted number into groups (e.g., thousands, millions).
    split_groups = formatted_string.split(",")
    group_position = len(split_groups)
    res = []

    for group in split_groups:
        value = int(group)
        if value == 0:
            group_position -= 1
            continue  # Skip if the group is zero.
        res.append(extract_values(value, group_position))
        group_position -= 1

    return ' '.join(res).strip()

def get_value(dictionary, key, default_value):
    return dictionary.get(key, default_value)

def extract_values(value, position):
    res = []

    # Get the value of hundreds.
    hundreds = value // HUNDRED

    # Get the value of tens or the remainder of hundreds.
    remainder = value % HUNDRED

    # If not 0 or if the number is 100 and up, get the number and add "Hundred".
    if hundreds > ZERO:
        res.append(get_value(number_to_word, hundreds, "") + HUNDRED_TEXT)

    # If there is a remainder.
    if remainder > ZERO:
        # Check if it is already in the word list.
        if remainder in number_to_word:
            res.append(get_value(number_to_word, remainder, ""))
        else:
            # If the remainder or tens or the remainder from hundreds is less than 20,
            # it contains "teen".
            if remainder < TWENTY:
                res.append(get_value(number_to_word, remainder - TEN, "") + TEEN_TEXT)
            else:
                # If higher than 20, get the number of tens and ones.
                tens = remainder // TEN
                ones = remainder % TEN

                # Set the default value to numbers multiple by 10, e.g., sixty, seventy,
                # followed by ones number if there is any.
                default_value = get_value(number_to_word, tens, "") + TY_TEXT + " "
                res.append(get_value(number_to_word, tens * TEN, default_value))
                res.append(get_value(number_to_word, ones, ""))

    # Return the words for each specific group.
    return ' '.join(res) + " " + get_value(group_words, position, "")

# Input number
num = input("Input number: ")
# Format the number with commas (e.g., 1,000,000)
formatted_number = "{:,}".format(int(num))

# Convert number to words
words = convert_num_to_words(formatted_number)
print("In words:", words)
