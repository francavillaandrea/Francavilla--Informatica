import pyautogui, time
mess= input("Che messaggio vuoi spammare?")
qv= int(input("Quante volte vuoi che ripeta il messaggio?"))
time.sleep(3)
for cici in range (qv):
    pyautogui.typewrite(mess)
    pyautogui.press("enter")
