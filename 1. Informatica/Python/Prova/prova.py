import requests
import json

# URL del tuo script Google Apps pubblicato come web app
url = 'https://script.google.com/macros/s/ID_DEL_TUO_SCRIPT/exec'

# I dati che desideri inviare in formato JSON
data = {
    "nome": "Luca",
    "cognome": "Bianchi",
    "eta": 25
}

# Invia la richiesta POST con i dati JSON
response = requests.post(url, json=data)

# Stampa la risposta
print(response.json())