import requests

# URL del tuo Google Apps Script o altro endpoint
url = "https://script.google.com/macros/s/AKfycbypRiRD2FdBqnvTYX3Pmt0wrQnwWKuJ-n2x1qYgSa-EqJcEZwD7HSPT0OK55BaU4zIXZg/exec"

# Apri il file JSON e invialo con una richiesta POST
with open("data.json", "r") as file:
    json_data = file.read()

headers = {"Content-Type": "application/json"}

response = requests.post(url, data=json_data, headers=headers)

# Stampa la risposta del server
print("Status Code:", response.status_code)
print("Response:", response.text)
