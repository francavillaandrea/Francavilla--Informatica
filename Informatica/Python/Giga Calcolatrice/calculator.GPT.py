import tkinter as tk

# Function to evaluate the expression
def evaluate_expression():
    try:
        result = eval(expression.get())
        expression.set(result)
    except:
        expression.set("Error")

# Function to add the button press to the expression
def add_to_expression(char):
    current_expression = expression.get()
    expression.set(current_expression + str(char))

# Function to clear the expression
def clear_expression():
    expression.set("")

# Create the main window
root = tk.Tk()
root.title("Calculator")

# Create the expression variable
expression = tk.StringVar()

# Create the entry box for the expression
expression_entry = tk.Entry(root, textvariable=expression, font=("Arial", 20), bd=5, justify=tk.RIGHT)
expression_entry.grid(row=0, column=0, columnspan=4, padx=10, pady=10)

# Create the number buttons
for i in range(1, 10):
    button = tk.Button(root, text=str(i), font=("Arial", 20), bd=5, command=lambda i=i: add_to_expression(i))
    button.grid(row=3 - (i - 1) // 3, column=(i - 1) % 3, padx=10, pady=10)
    
# Create the zero button
zero_button = tk.Button(root, text="0", font=("Arial", 20), bd=5, command=lambda: add_to_expression(0))
zero_button.grid(row=4, column=0, padx=10, pady=10)

# Create the operator buttons
plus_button = tk.Button(root, text="+", font=("Arial", 20), bd=5, command=lambda: add_to_expression("+"))
plus_button.grid(row=1, column=3, padx=10, pady=10)

minus_button = tk.Button(root, text="-", font=("Arial", 20), bd=5, command=lambda: add_to_expression("-"))
minus_button.grid(row=2, column=3, padx=10, pady=10)

multiply_button = tk.Button(root, text="*", font=("Arial", 20), bd=5, command=lambda: add_to_expression("*"))
multiply_button.grid(row=3, column=3, padx=10, pady=10)

divide_button = tk.Button(root, text="/", font=("Arial", 20), bd=5, command=lambda: add_to_expression("/"))
divide_button.grid(row=4, column=3, padx=10, pady=10)

# Create the equals button
equals_button = tk.Button(root, text="=", font=("Arial", 20), bd=5, command=evaluate_expression)
equals_button.grid(row=4, column=2, padx=10, pady=10)

# Create the clear button
clear_button = tk.Button(root, text="C", font=("Arial", 20), bd=5, command=clear_expression)
clear_button.grid(row=4, column=1, padx=10, pady=10)

# Start the main loop
root.mainloop()