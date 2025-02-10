from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC

def send_whatsapp_message(friend_name, message):
    # Set up the driver
    driver = webdriver.Chrome('/path/to/chromedriver')

    # Open WhatsApp Web
    driver.get('https://web.whatsapp.com/')

    # Wait for the QR code to be scanned and the page to load
    target = '"%s"' % friend_name
    WebDriverWait(driver, 60).until(EC.presence_of_element_located((By.XPATH, f"//span[contains(., '{target}')]")))

    # Click on the contact
    contact = driver.find_element_by_xpath(f"//span[contains(., '{target}')]")
    contact.click()

    # Wait for the chat window to load
    WebDriverWait(driver, 60).until(EC.presence_of_element_located((By.CSS_SELECTOR, "span[title='Type a message']")))

    # Send the message
    message_input = driver.find_element_by_class_name("_1Plpp")
    message_input.send_keys(message)
    message_input.send_keys(Keys.RETURN)

    # Close the driver
    driver.quit()

send_whatsapp_message('friend_name', 'your_message')