from tkinter import *
import  pyautogui, time

window =Tk()
window.geometry("900x500")
window.title("Trituratore di coglioni 3000")
window.grid_columnconfigure(0, weight=1)
window.configure(background="#7FFFD4")

mess="" 
cici=1
def download_ascii():
    time.sleep(3)
    for cici in range (int(text_input2.get())):
        pyautogui.typewrite(text_input.get())
        pyautogui.press("enter")

welcome_label =Label(window,
                           text="Ciao! Aggiungi una parola o una frase che vuoi spammare:",
                           fg="#6F00FF",
                           background="#7FFFD4",
                           font=("Helvetica", 15))
welcome_label.grid(row=0, column=0, sticky="N", padx=20, pady=10)


text_input=Entry()
text_input.grid(row=1, column=0,sticky="WE", pady=10, padx=10)


prossimo_button =Button(text="Salva", command=download_ascii)
prossimo_button.grid(row=6, column=0, padx=50, pady=50)
print(mess)

welcome_label =Label(window,
                           text="Ciao! Aggiungi il numero di volte che vuoi spammare il messaggio:",
                           fg="#6F00FF",
                           background="#7FFFD4",
                           font=("Helvetica", 15))
welcome_label.grid(row=4, column=0, sticky="N", padx=30, pady=20)

text_input2=Entry()
text_input2.grid(row=5, column=0,sticky="WE", pady=10, padx=10)

if __name__== "__main__":
    window.mainloop()
    
