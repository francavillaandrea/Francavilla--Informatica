#define PIN_TX 2
#define Tb 1000
#define Nb 8
const int data = 0b101010; //0xAA

void setup() {
    pinMode(PIN_TX, OUTPUT);
    Serial.begin(9600);
    Serial.print("init\n");
    digitalWrite(PIN_TX, HIGH);
}


void loop() {
    transmitChar();
    Serial.print("\n");
    delay(1000);
}
void transmitChar()
{
    handleStart();
    handleData();
    handleParity(); //Controllo dell'errore
    handleStop();
}
void transmitBit(int bit)
{
    if(bit == 1)
    {
        digitalWrite(PIN_TX, HIGH);

    }
    else
    {
        digitalWrite(PIN_TX, LOW);
    }
    Serial.print(bit);
    delay(Tb);
}

void handleStart()
{
    transmitBit(0);
}

void handleData()
{

}

void handleParity()
{

}

void handleStop()
{

}