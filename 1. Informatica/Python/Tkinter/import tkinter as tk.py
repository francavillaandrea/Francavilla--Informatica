import tkinter as tk
import requests

window = tk.Tk()
window.geometry("900x550")
window.title("ASCII ART DOWNLOADER")
window.grid_columnconfigure(0, weight = 1)

window_label = tk.Label(window,
                        text = "Benvenuto! Inserisci una parola o frase: ",
                        pady = 10, font=("Helvetica", 15))
window_label.grid(row = 0, column = 0, sticky = "N", padx = 20, pady = 20 )

text_input= tk.Entry()
text_input.grid(row = 1, column=0, sticky = "WE",padx = 10)

def download_ascii():
    if text_input.get():
        text_label= tk.Label(window, text=text_input.get())
        text_label.grid(row = 3, column= 0, padx = 10, pady= 10)
    else:
        text = "Agiiungi una parola o una frase in input"
download_button = tk.Button(text = "Download ASCII art", command = download_ascii)
download_button.grid(row = 2, column= 0, sticky="WE", padx = 10, pady = 10)
