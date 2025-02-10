import pyautogui
import time
time.sleep(5)
f =open("Spam","r")
for word in f:
    pyautogui.typewrite(word)