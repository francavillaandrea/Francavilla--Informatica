from time import time 
from numpy import number
import phonenumbers
from phonenumbers import timezone, geocoder, carrier
number = input ("Metti il tuo numero di telefono")
phone = phonenumbers.parse(number)
time = timezone.time_zones_for_number(phone)
car = carrier.name_for_number(phone, "it")
