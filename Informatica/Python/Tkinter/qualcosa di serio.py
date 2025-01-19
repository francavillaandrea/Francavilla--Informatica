import tkinter as tk 
import requests
window = tk.Tk()
window.geometry("600x600") 
window.title("Famiglia Nifrochi al rogo")
window.resizable(False, False)
window.configure(background="white")


def first_print():
    text = "Kleiton morto!!"
    text_output = tk.Label(window, text=text, fg="red", font=("Arial", 16))
    text_output.grid(row=0, column=1)

def second_function():
    text = "Cici morta!!"
    text_output = tk.Label(window, text=text, fg="green", font=("Arial", 16))
    text_output.grid(row=1, column=1, padx=100)

first_button = tk.Button(text="Sidat Esploso", command=first_print)
first_button.grid(row=0, column=0)

second_button= tk.Button(text="Krashna morta!!", command=second_function)
second_button.grid(row=1, column=0, pady=20)

if __name__ == "__main__":
    window.mainloop()  