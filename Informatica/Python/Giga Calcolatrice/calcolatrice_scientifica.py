import math

while True:
    print("Seleziona l'operazione:")
    print("1. Somma")
    print("2. Differenza")
    print("3. Prodotto")
    print("4. Divisione")
    print("5. Radice quadrata")
    print("6. Logaritmo naturale")
    print("7. Logaritmo in base 10")
    print("8. Potenza")
    print("0. Esci")

    scelta = int(input("Inserisci la tua scelta: "))

    if scelta == 0:
        print("Arrivederci!")
        break

    elif scelta == 1:
        num1 = float(input("Inserisci il primo numero: "))
        num2 = float(input("Inserisci il secondo numero: "))
        print("Il risultato è", num1 + num2)

    elif scelta == 2:
        num1 = float(input("Inserisci il primo numero: "))
        num2 = float(input("Inserisci il secondo numero: "))
        print("Il risultato è", num1 - num2)

    elif scelta == 3:
        num1 = float(input("Inserisci il primo numero: "))
        num2 = float(input("Inserisci il secondo numero: "))
        print("Il risultato è", num1 * num2)

    elif scelta == 4:
        num1 = float(input("Inserisci il primo numero: "))
        num2 = float(input("Inserisci il secondo numero: "))
        if num2 == 0:
            print("Impossibile dividere per zero!")
        else:
            print("Il risultato è", num1 / num2)

    elif scelta == 5:
        num = float(input("Inserisci il numero: "))
        print("Il risultato è", math.sqrt(num))

    elif scelta == 6:
        num = float(input("Inserisci il numero: "))
        print("Il risultato è", math.log(num))

    elif scelta == 7:
        num = float(input("Inserisci il numero: "))
        print("Il risultato è", math.log10(num))

    elif scelta == 8:
        num1 = float(input("Inserisci il primo numero: "))
        num2 = float(input("Inserisci il secondo numero: "))
        print("Il risultato è", num1 ** num2)

    else:
        print("Scelta non valida. Riprova.")
