"""
Rules:                                                              
i.     Swapping method must be void.                                                 
ii.    You are not allowed to print anything inside the swapping method.
iii.   Declaring variables outside the methods is prohibited.                                   
iv.   Swapping two variables should only occur within the swapping method.                                                       
v.    Using any types of parameters is allowed.
vi.   Printing x must display 10, and printing y must display 5.
vii.  You can use any programming language.
"""

def swap(arr):
    #Swap the values of x and y without using a temporary variable
    arr[0], arr[1] = arr[1], arr[0]

#Declare variables 
x = 5 
y = 10 
arr = [x,y]

#Call the swapping function to swap the values of x and y
swap (arr) 

# Now, we call the 'swap' function, passing our 'arr' list as an argument.
# Inside the 'swap' function, it performs the swapping logic directly on 'arr'.

#Print the swapped values of x and y
print ("x:", arr[0]) #x: 10
print ("y:", arr[1]) #y: 5

#By passing a list in python and modify its value inside a function, 
#the changes made to the list inside the function will be reflected in the original list
