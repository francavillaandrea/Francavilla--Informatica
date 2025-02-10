import pyautogui
import time

# Press the space key to start the game
pyautogui.press('space')

# Run the game loop
while True:
    # Check if the game is over by looking for the "Game Over" text
    game_over = pyautogui.locateOnScreen('game_over.png')
    if game_over is not None:
        break

    # Look for the dino and obstacles on the screen
    dino = pyautogui.locateOnScreen('T amagno.png')
    obstacle = pyautogui.locateOnScreen('Napoli.png')

    # If an obstacle is approaching, press the space key to jump
    if obstacle is not None:
        pyautogui.press('space')
        time.sleep(0.1)
 